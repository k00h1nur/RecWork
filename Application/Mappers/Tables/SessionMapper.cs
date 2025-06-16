using DataAccess.Schemas.Auth;
using Mapster;

namespace Application.Mappers.Tables;

public class SessionMapper : IRegister
{
    public void Register(TypeAdapterConfig config)
    {
        config.NewConfig<User, Session>().ConstructUsing(src => Map(src));
    }

    private static Session Map(User src)
    {
        return new Session
        {
            UserId = src.Id,
            Code = "112233",
            ExpireDate = DateTime.UtcNow.AddMinutes(3)
        };
    }
}