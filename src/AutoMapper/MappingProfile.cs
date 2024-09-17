using AutoMapper;

namespace Blvckout.MyMasternode.Setup.AutoMapper;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<Database.Entities.Setup, DataModels.Setup.V1.DTOs.Setups.SetupDto>().ReverseMap();
        CreateMap<Database.Entities.Setup, DataModels.Setup.V1.DTOs.Setups.SetupUpdateDto>().ReverseMap();
    }
}