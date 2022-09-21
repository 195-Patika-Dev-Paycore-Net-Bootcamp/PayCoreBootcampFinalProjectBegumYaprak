using AutoMapper;
using pycFinalApi.Data;
using pycFinalApi.Data.Model;
using pycFinalApi.Dto;

namespace pycFinalApi.Mapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {

            CreateMap<UserDto, User>().ReverseMap();

            CreateMap<CategoryDto, Category>().ReverseMap();

            CreateMap<ProductDto, Product>().ReverseMap();

            //  .ForMember(a => a.Category, source => source.MapFrom(src => src))
             // .ForMember(a => a.User, source => source.MapFrom(src => src));
            //CreateMap<ProductDto,Category>()
            //   // .ForMember(a => a.Id, source => source.MapFrom(src => src.CategoryId));
            //CreateMap<ProductDto,User>()
            //    .ForMember(a => a.Id, source => source.MapFrom(src => src.UserId));
           
           

            //CreateMap<OffersDto, User>()
            //   .ForMember(a => a.Id, source => source.MapFrom(src => src.UserId));
            //CreateMap<OffersDto, Product>()
            //    .ForMember(a => a.Id, source => source.MapFrom(src => src.ProductId));

            //CreateMap<OffersDto, Offers>().ReverseMap();

        }

    }
}
