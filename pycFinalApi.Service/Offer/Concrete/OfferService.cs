using AutoMapper;
using NHibernate;
using pycFinalApi.Data;
using pycFinalApi.Data.Model;
using pycFinalApi.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pycFinalApi.Service.Offer.Concrete
{
    public class OfferService : BaseService<OfferDto, OfferEntity> ,IOfferService
    {

        protected readonly ISession session;
        protected readonly IMapper mapper;
        protected readonly IHibernateRepository<OfferEntity> hibernateRepository;

        public OfferService(ISession session, IMapper mapper) : base(session, mapper)
        {

            this.session = session;
            this.mapper = mapper;

            hibernateRepository = new HibernateRepository<OfferEntity>(session);
        }
    }
}
