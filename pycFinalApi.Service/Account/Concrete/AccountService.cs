using AutoMapper;
using NHibernate;


using pycFinalApi.Data;
using pycFinalApi.Model;

namespace pycFinalApi.Service
{
    public class AccountService : BaseService<AccountDto, Account>, IAccountService
    {

        protected readonly ISession session;
        protected readonly IMapper mapper;
        protected readonly IHibernateRepository<Account> hibernateRepository;

        public AccountService(ISession session, IMapper mapper) : base(session, mapper)
        {
            this.session = session;
            this.mapper = mapper;

            hibernateRepository = new HibernateRepository<Account>(session);
        }


      
    }
}
