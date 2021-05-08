using System;
using System.Collections.Generic;
using System.Text;

namespace RefillMyGlass
{
    public class Glass
    {

        public int LiquidLevel = 200;

        public void Drink(int millileters)
        {
            LiquidLevel -= millileters;
        }

        public void Refill()
        {
            LiquidLevel = 200;
        }
    }
}
