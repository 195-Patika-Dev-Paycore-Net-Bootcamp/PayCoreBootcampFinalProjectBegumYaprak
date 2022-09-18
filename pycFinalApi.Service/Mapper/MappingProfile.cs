using AutoMapper;
using pycFinalApi.Data;
using pycFinalApi.Dto;

namespace pycFinalApi.Mapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
           
             CreateMap<AccountDto, Account>().ReverseMap();

           
        }

    }
}
