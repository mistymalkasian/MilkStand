﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Milk_Stand
{
    class Shop
    {
        public Shop()
        {
            //Shop Shop = new Shop();
        }
        
        public void AskToShop(Player player)
        {
            Console.WriteLine("Type 'yes' if you'd like to go to the shop.");
           string answer = Console.ReadLine();

            switch(answer)
            {
                case "yes":
                    SellToPlayer(player);
                    break;
                default:
                    break;
            }
        }
        public void SellToPlayer(Player player)
        {
            
            Console.WriteLine("Welcome to Dairy King!");
            Console.WriteLine("We just so happen to only sell the exact items you need for your business...");
            Console.WriteLine("How convenient!");
            Console.WriteLine("Please type the corresponding number of the item you wish to buy.");
            Console.WriteLine("[1] 'Code Farms' Single-Serve Organic Milk Carton - $1.00");
            Console.WriteLine("[2] Vanilla Flavor Syrup - $0.25");
            Console.WriteLine("[3] Raw Cane Sugar Packet - $0.10");
            Console.WriteLine("[4] 'Silicon Spring' Ice Cube - $0.01");
            Console.WriteLine("[5] Classy Plastic Cup - $0.05");
        
            double CustomerChoice = Convert.ToInt32(Console.ReadLine());

            if (CustomerChoice == 1)
            {
                Console.WriteLine("Please enter (in numerals) how many milk cartons you would like to purchase.");
                Console.WriteLine("Hint: Ten cartons will fill a pitcher, and a pitcher serves 10 people.");
                double NumberofCartons = Convert.ToInt32(Console.ReadLine());
                for (int i = 0; i < NumberofCartons; i++)
                {
                    MilkCarton milkCarton = new MilkCarton();
                    player.PlayerInventory.Add(milkCarton);
                }
                
            }
                    

            else if (CustomerChoice == 2)
            {
                Console.WriteLine("Please enter how many flavor packets you would like to purchase.");
                Console.WriteLine("Hint: If you add too few or too many packets per pitcher, the customers won't like your product.");
                double NumberofPackets = Convert.ToInt32(Console.ReadLine());
                for (int i = 0; i < NumberofPackets; i++)
                {
                    FlavorSyrup flavorSyrup = new FlavorSyrup();
                    player.PlayerInventory.Add(flavorSyrup);
                }

            }   

            else if (CustomerChoice == 3)
            {
                Console.WriteLine("Please enter how many sugar packets you would like to purchase.");
                Console.WriteLine("Hint: If you add too few or too many packets per pitcher, the customers won't like your product.");
                double NumberofSugars = Convert.ToInt32(Console.ReadLine());
                for (int i = 0; i < NumberofSugars; i++)
                {
                    Sugar sugarPacket = new Sugar();
                    player.PlayerInventory.Add(sugarPacket);
                }
            }
              
            else if (CustomerChoice == 4)
            {
                Console.WriteLine("Please enter how many ice cubes you would like to purchase.");
                double NumberofCubes = Convert.ToInt32(Console.ReadLine());
                for (int i = 0; i < NumberofCubes; i++)
                {
                    Ice iceCube = new Ice();
                    player.PlayerInventory.Add(iceCube);
                }

            }     
            
            else if (CustomerChoice == 5)
            {
                Console.WriteLine("Please enter how many cups you would like to purchase.");
                Console.WriteLine("Hint: Buy as many cups as you can reasonably afford!");
                double NumberofCups = Convert.ToInt32(Console.ReadLine());
                for (int i = 0; i < NumberofCups; i++)
                {
                    Cup cup = new Cup();
                    player.PlayerInventory.Add(cup);
                }

            }
            else
            {
                Console.WriteLine("We literally don't sell anything else here. Please only enter 1, 2, 3, 4, or 5.");
                SellToPlayer(player);
            }    

        }
    }
}
