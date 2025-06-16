using DataAccess.Enums;
using DataAccess.Schemas.Public;
using Domain.Models.API.Requests;
using Domain.Models.Infrastructure.Params;
using Mapster;

namespace Application.Mappers;

public class SaveItemFileParamsMapper : IRegister
{
    public void Register(TypeAdapterConfig config)
    {
        /*
        config
            .NewConfig<(ChatMessage, MessageToChatRequest, ItemFileType), SaveItemFileParams>()
            .ConstructUsing(x => Map(x));
    */
    }

    /*
    private static SaveItemFileParams Map((ChatMessage, MessageToChatRequest, ItemFileType) saveItemFileParams)
    {
        return new SaveItemFileParams(
            ItemId: saveItemFileParams.Item1.Id,
            File: saveItemFileParams.Item2.File!,
            Type: saveItemFileParams.Item3); 
    }
*/
}