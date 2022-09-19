using AutoMapper;
using NHibernate;


using pycFinalApi.Data;
using pycFinalApi.Data.Model;
using pycFinalApi.Dto;

namespace pycFinalApi.Service
{
    public class CategoryService : BaseService<CategoryDto, Category>, ICategoryService
    {

        protected readonly ISession session;
        protected readonly IMapper mapper;
        protected readonly IHibernateRepository<Category> hibernateRepository;

        public CategoryService(ISession session, IMapper mapper) : base(session, mapper)
        {
            this.session = session;
            this.mapper = mapper;

            hibernateRepository = new HibernateRepository<Category>(session);
        }


      
    }
}
