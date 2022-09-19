using pycFinalApi.Data.Model;
using pycFinalApi.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pycFinalApi.Service
{
    public interface IProductService :IBaseService<ProductDto ,Product>
    {
    }
}
