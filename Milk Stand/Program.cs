﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Milk_Stand
{
    class Program
    {
        static void Main(string[] args)
        {
            Game Game = new Game();
            Weather Weather = new Weather(2);
            Customer Customer = new Customer("hello", 4);
            
            Game.DisplayRules();
            Weather.DetermineForecast();
            Customer.CustomerGenerator();

            




        }
    }
}