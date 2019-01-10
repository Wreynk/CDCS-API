#region

using AutoMapper;

#endregion

namespace CDCS.Model.Profiles {

    public class AutoMapperConfig {
        public static MapperConfiguration RegisterMappings()
        {
            return new MapperConfiguration(cfg => { cfg.AddProfile(new CdcsDtoProfiles()); });
        }
    }

}