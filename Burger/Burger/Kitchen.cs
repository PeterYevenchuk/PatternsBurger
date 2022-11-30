using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Burger
{
    internal class Kitchen
    {
        const string INGREDIENTS = "Ingredients : ";
        public void CookingBurger(IBurgerDirector _derector)
        {
            var burgerBuilder = new BurgerBuilder();

            _derector.SetNameBurger();

            _derector.SetBurgerBuilder(burgerBuilder);

            _derector.Build();

            var report = burgerBuilder.GetReport();

            Console.WriteLine(INGREDIENTS);
            Console.WriteLine(report);
        }
    }
}
