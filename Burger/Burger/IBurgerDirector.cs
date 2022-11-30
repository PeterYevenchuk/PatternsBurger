using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Burger
{
    internal interface IBurgerDirector
    {
        void Build();
        string nameBuger { get; }
        void SetNameBurger();
        void SetBurgerBuilder(IBurgerBuilder builder);
    }
}
