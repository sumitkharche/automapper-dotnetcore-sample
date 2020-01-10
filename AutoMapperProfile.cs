using AutoMapper;

namespace automapper_sample
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<StudentDTO, Student>()
                .ForMember(dest => dest.City, opt => opt.MapFrom(src => src.CurrentCity))
                .ForMember(dest => dest.IsAdult, opt => opt.MapFrom(src => src.Age > 18 ? true : false));
            CreateMap<AddressDTO, Address>();
        }
    }
}
