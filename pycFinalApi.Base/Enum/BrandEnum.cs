using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pycFinalApi.Base.Enum
{

    public class Brand
    {

        public const string Nike = "nike";
        public const string Adidas = "adidas";
        public const string Puma = "puma";
        public const string Zara = "zara";
        public const string HM = "HM";
    }
    public enum BrandEnum
    {
        [Description(Brand.Nike)]
        Nike = 1,
        
        [Description(Brand.Adidas)]
        Adidas = 2,

        [Description(Brand.Puma)]
        Puma = 3,

        [Description(Brand.Zara)]
        Zara = 4,

        [Description(Brand.HM)]
        HM = 5,




    };
}
