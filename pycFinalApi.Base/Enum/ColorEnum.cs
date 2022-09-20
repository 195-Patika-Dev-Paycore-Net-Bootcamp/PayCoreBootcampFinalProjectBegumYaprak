using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pycFinalApi.Base.Enum
{
    public class Color
    {

        public const string Red = "red";
        public const string Green = "green";
        public const string Blue = "blue";
        public const string Black = "black";
        public const string White = "white";
        public const string Yellow = "yellow";
        
    };

    public enum ColorEnum
    {
        [Description(Color.Red)]
        Red = 1,

        [Description(Color.Green)]
        Green = 2,

        [Description(Color.Blue)]
        Blue = 3,

        [Description(Color.Black)]
        Black = 4,

        [Description(Color.White)]
        White = 5,
        
        [Description(Color.Yellow)]
        Yellow = 6,




    };
}
