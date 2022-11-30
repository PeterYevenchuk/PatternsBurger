using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Burger
{
    internal interface IBurgerBuilder
    {
        void BuildBun();
        void BuildCutlet();
        void BuildTomato();
        void BuildCucumbers();
        void BuildSauce();
        void BuildCabbage();
        void BuildBacon();
        void BuildCheese();

        Burger GetReport();
    }
}
