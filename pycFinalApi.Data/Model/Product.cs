using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pycFinalApi.Data.Model
{
  public class Product
    {
        public virtual int Id { get; set; }

        public virtual string ProductName { get; set; }

        public virtual string Description { get; set; }

        public virtual int Price { get; set; }  

        public virtual string Color { get; set; }   

        public virtual string Brand { get; set; }

        public virtual bool IsOfferable { get; set; }

        public virtual bool IsSold { get; set; }    
        public virtual Category Category { get; set; }
    }
}
