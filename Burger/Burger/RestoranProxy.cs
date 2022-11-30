using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Burger
{
    internal class RestoranProxy : IRestoran
    {
        public readonly Restoran restoran;
        public bool isElementFound = false;

        public RestoranProxy(Restoran restoran)
        {
            this.restoran = restoran;
        }

        public void SetBurger(string nameBurger)
        {
            if (nameBurger is null || nameBurger.Length == 0)
            {
                Console.WriteLine("You did not fill in the text field");
                isElementFound = SetIsElement(false);
                return;
            }
            //isElementFound= SetIsElement(true);
            restoran.SetBurger(nameBurger);
        }

        public bool SetIsElement(bool isElementFound)
        {
            return isElementFound;
        }
    }
}
