using System;
using System.Collections.Generic;
using System.Text;

namespace _03_BuilderPattern
{
    class BeefBurger : Burger
    {
        public override string name()
        {
            return "Beef Burger";
        }

        public override float price()
        {
            return 50.0f;
        }
    }
}
