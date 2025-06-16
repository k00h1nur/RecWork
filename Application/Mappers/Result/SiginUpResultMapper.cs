using DataAccess.Schemas.Auth;
using Domain.Models.API.Results;
using Mapster;

namespace Application.Mappers.Result;

public class SiginUpResultMapper : IRegister
{
    public void Register(TypeAdapterConfig config)
    {
        config
            .NewConfig<Session, SignUpResult>()
            .ConstructUsing(src => Map(src));
    }

    private SignUpResult Map(Session src)
    {
        return new SignUpResult(src.Id);
    }
}