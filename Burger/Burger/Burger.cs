using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Burger
{
    internal class Burger
    {
        public string Bun { get; set; }
        public string Cutlet { get; set; }
        public string Tomato { get; set; }
        public string Cucumbers { get; set; }
        public string Sauce { get; set; }
        public string Cabbage { get; set; }
        public string Bacon { get; set; }
        public string Cheese { get; set; }

        public override string ToString() =>
            new StringBuilder()
            .Append(Bun)
            .Append(Cutlet)
            .Append(Tomato)
            .Append(Cucumbers)
            .Append(Sauce)
            .Append(Cabbage)
            .Append(Bacon)
            .Append(Cheese)
            .ToString();
    }
}
