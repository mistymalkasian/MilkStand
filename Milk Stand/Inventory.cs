﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Milk_Stand
{
    class Inventory
    {
       // double amount;

        public Inventory()
        {
            Cup Cup = new Cup();
            Ice Ice = new Ice();
            FlavorPacket FlavorPacket = new FlavorPacket();
            Milk_Carton Milk_Carton = new Milk_Carton();
        }
    }
}