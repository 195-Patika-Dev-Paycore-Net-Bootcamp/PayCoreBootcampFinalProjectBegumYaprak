using AutoMapper;
using pycFinalApi.Model;

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
