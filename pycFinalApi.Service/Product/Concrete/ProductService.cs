using AutoMapper;
using NHibernate;
using pycFinalApi.Data.Model;
using pycFinalApi.Data;
using pycFinalApi.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using pycFinalApi.Base;
using Serilog;

namespace pycFinalApi.Service
{
    public class ProductService : BaseService<ProductDto, Product>, IProductService
    {

        protected readonly ISession session;
        protected readonly IMapper mapper;
        protected readonly IHibernateRepository<Product> hibernateRepository;

        public ProductService (ISession session, IMapper mapper) : base(session, mapper)
        {
            this.session = session;
            this.mapper = mapper;

            hibernateRepository = new HibernateRepository<Product>(session);
        }



    }
}
