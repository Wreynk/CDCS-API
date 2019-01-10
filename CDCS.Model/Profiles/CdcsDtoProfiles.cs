#region

using AutoMapper;
using CDCS.Model.Domain;
using CDCS.Model.Dtos;
using TLT.BaseModel.Base;

#endregion

namespace CDCS.Model.Profiles
{

    public class CdcsDtoProfiles : Profile
    {
        public CdcsDtoProfiles()
        {
            // Accreditor
            CreateMap<Accreditor, AccreditorDto>()
                .ForMember(d => d.Id, m => m.MapFrom(src => src.Id))
                .ForMember(d => d.Name, m => m.MapFrom(src => src.Name.InLocal))
                ;

            // Accreditation
        }
    }

}