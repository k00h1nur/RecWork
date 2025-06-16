using Application.Interfaces;
using DataAccess;
using DataAccess.Schemas.Auth;
using Domain.Enums;
using Domain.Models.API.Requests;
using Domain.Models.API.Results;
using Domain.Models.Common;
using Domain.Models.Infrastructure.Params;
using Infrastructure.Interfaces;
using Mapster;
using Microsoft.EntityFrameworkCore;

namespace Application.Services;

public class UserService(
    ITokenService tokenService,
    EntityContext context) : IUserService
{
    public async Task<Result<SignUpResult>> SignUp(SignUpRequest signUpRequest)
    {
        var isPhoneNotUnique = await context.Users.AnyAsync(x => x.Phone == signUpRequest.Phone);
        if (isPhoneNotUnique)
            return new ErrorModel(ErrorEnum.PhoneAlreadyExists);
        if (!string.IsNullOrEmpty(signUpRequest.Email))
        {
            var isEmailNotUnique = await context.Users.AnyAsync(x => x.Email == signUpRequest.Email);
            if (isEmailNotUnique)
                return new ErrorModel(ErrorEnum.EmailAlreadyExists);
        }

        var newUser = signUpRequest.Adapt<User>();
        await context.Users.AddAsync(newUser);
        await context.SaveChangesAsync();

        var newSession = newUser.Adapt<Session>();
        await context.Sessions.AddAsync(newSession);
        await context.SaveChangesAsync();

        return newSession.Adapt<SignUpResult>();
    }

    public async Task<Result<SignInResult>> SignIn(SignInRequest request)
    {
        var session = await context.Sessions.FirstOrDefaultAsync(x => x.Id == request.SessionId);
        if (session is null || session.ExpireDate < DateTime.UtcNow)
            return new ErrorModel(ErrorEnum.SessionNotFound);
        if (session.Code != request.Code)
            return new ErrorModel(ErrorEnum.InvalidCode);

        var user = await context.Users.FirstOrDefaultAsync(x => x.Id == session.UserId);
        var token = await tokenService.GenerateToken(user.Adapt<GenerateTokenParams>());
        return token.Payload.Adapt<SignInResult>();
    }
}