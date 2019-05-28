using System;
using System.Collections.Generic;
using System.Text;

namespace _03_BuilderPattern
{
    class sprite : ColdDrink
    {
        public override string name()
        {
            return "Sprite";
        }

        public override float price()
        {
            return 15.0f;
        }
    }
}
