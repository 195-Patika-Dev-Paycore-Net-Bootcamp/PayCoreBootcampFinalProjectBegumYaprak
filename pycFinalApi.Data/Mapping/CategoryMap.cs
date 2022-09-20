using NHibernate;
using NHibernate.Mapping.ByCode;
using NHibernate.Mapping.ByCode.Conformist;
using pycFinalApi.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pycFinalApi.Data.Mapping
{
    public class CategoryMap : ClassMapping<Category>
    {
        public CategoryMap()
        {
            Id(x => x.Id, x =>
            {
                x.Type(NHibernateUtil.Int32);
                x.Column("Id");
                x.UnsavedValue(0);
                x.Generator(Generators.Increment);
            });

            Property(b => b.CategoryName, x =>
            {
                x.Length(50);
                x.Type(NHibernateUtil.String);
                x.NotNullable(true);
            });

           Bag(category => category.Products, map => map.Key(k => k.Column("CategoryId")), rel => rel.OneToMany());

            Table("category");
        }

    }
}
