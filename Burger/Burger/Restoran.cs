using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Burger
{
    internal class Restoran : IRestoran
    {
        const string RESTORN_MENU = "===================== Restoran Menu ======================";

        private Kitchen _citchen;

        private List<IBurgerDirector> _menuList;

        public bool isElementFound = false;

        public Restoran()
        {
            _citchen = new();
            SetRestoranMenu();
        }

        private void SetRestoranMenu()
        {
            Console.WriteLine(RESTORN_MENU);
            
            //Searching for classes that implement the interface
            var iBurgerDerector = typeof(IBurgerDirector);
            var burgerDerectorsTypes = AppDomain.CurrentDomain.GetAssemblies()
                .SelectMany(assembly => assembly.GetTypes())
                .Where(type => iBurgerDerector.IsAssignableFrom(type) && type.IsClass);

            _menuList = new();

            //Add Class in List
            foreach (var burger in burgerDerectorsTypes)
            {
                _menuList.Add(Activator.CreateInstance(burger) as IBurgerDirector);
            }

            //Call the "SetNameBurger" method for each class
            _menuList.ForEach(burger => burger.SetNameBurger());
        }

        public void SetBurger(string nameBurger)
        {
            foreach (var item in _menuList)
            {
                if (item.nameBuger == nameBurger)
                {
                    _citchen.CookingBurger(item);
                    isElementFound = SetIsElement(true);
                }
            }
            if (!isElementFound) Console.WriteLine($"Burger with this name : {nameBurger}, was not found");
            //isElementFound = SetIsElement(false);;
        }

        public bool SetIsElement(bool isElementFound)
        {
            return isElementFound;
        }
    }
}
