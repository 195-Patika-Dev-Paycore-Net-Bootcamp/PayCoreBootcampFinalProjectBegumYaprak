using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pycFinalApi.Data.Model
{
    public class OfferEntity
    {
        public virtual int Id { get; set; }

        public virtual int OfferAmount { get; set; }

        public virtual int ProductId { get; set; }

        public virtual int UserId { get; set; }

    }
}
