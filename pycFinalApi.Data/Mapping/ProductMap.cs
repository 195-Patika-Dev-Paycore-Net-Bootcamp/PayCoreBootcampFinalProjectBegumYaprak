using NHibernate.Mapping.ByCode.Conformist;
using NHibernate.Mapping.ByCode;
using NHibernate;
using pycFinalApi.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pycFinalApi.Data.Mapping
{
    public class ProductMap : ClassMapping<Product>
    {
        public ProductMap()
        {
            Id(x => x.Id, x =>
            {
                x.Type(NHibernateUtil.Int32);
                x.Column("Id");
                x.UnsavedValue(0);
                x.Generator(Generators.Increment);
            });

            Property(b => b.ProductName, x =>
            {
                x.Length(100);
                x.Type(NHibernateUtil.String);
                x.NotNullable(true);
            });

            Property(b => b.Description, x =>
            {
                x.Length(500);
                x.Type(NHibernateUtil.String);
                x.NotNullable(true);
            });
            
            
            Property(b => b.Price, x =>
            {
           
                x.Type(NHibernateUtil.Int32);
                x.NotNullable(true);
            });
            
            Property(b => b.Color, x =>
            {
               
                x.Type(NHibernateUtil.String);
                x.NotNullable(true);
            });   
            
            Property(b => b.Brand, x =>
            {
                
                x.Type(NHibernateUtil.String);
                x.NotNullable(true);
            });
            
            Property(b => b.IsOfferable, x =>
            {
               
                x.Type(NHibernateUtil.Boolean);
                x.NotNullable(true);
            });

            ManyToOne(product => product.Category, map => map.Column("CategoryId"));

            Table("product");
        }
    }

}
