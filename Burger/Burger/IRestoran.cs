using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Burger
{
    internal interface IRestoran
    {
        void SetBurger(string nameBurger);
        bool SetIsElement(bool isElementFound);
    }
}
