using NHibernate.Mapping.ByCode;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate.Mapping.ByCode.Conformist;
using pycFinalApi.Data.Model;

namespace pycFinalApi.Data.Mapping
{
    public class OfferMap : ClassMapping<OfferEntity>
    {

        public OfferMap()
        {
            Id(x => x.Id, x =>
            {
                x.Type(NHibernateUtil.Int32);
                x.Column("Id");
                x.UnsavedValue(0);
                x.Generator(Generators.Increment);
            });

            Property(b => b.ProductId, x =>
            {
                x.Length(100);
                x.Type(NHibernateUtil.Int32);
                x.NotNullable(true);
            });

            Property(b => b.UserId, x =>
            {
                x.Length(500);
                x.Type(NHibernateUtil.Int32);
                x.NotNullable(true);
            });
            
            
            Property(b => b.OfferAmount, x =>
            {
                x.Length(500);
                x.Type(NHibernateUtil.Int32);
                x.NotNullable(true);
            });


        }

    }
}
