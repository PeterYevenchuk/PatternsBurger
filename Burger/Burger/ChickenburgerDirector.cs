using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Burger
{
    internal class ChickenburgerDirector : IBurgerDirector
    {
        public string nameBuger => "Chicken Burger";
        public void SetNameBurger()
        {
            Console.WriteLine(nameBuger);
        }

        private IBurgerBuilder _builder;
        public void SetBurgerBuilder(IBurgerBuilder builder)
        {
            this._builder = builder;
        }

        public void Build()
        {
            _builder.BuildBun();
            _builder.BuildCutlet();
            _builder.BuildCheese();
            _builder.BuildSauce();
            _builder.BuildBacon();
            _builder.BuildCucumbers();
            _builder.BuildCabbage();
        }
    }
}
