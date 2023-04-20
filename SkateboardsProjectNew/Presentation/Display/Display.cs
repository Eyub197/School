using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkateboardsProject.Presentation.Display
{
    class Display
    {
        BearingPresentaion bearingPresentaion = new BearingPresentaion();
        BrandPresentaion brandPresentaion = new BrandPresentaion();
        DeckPresentaion deckPresentaion = new DeckPresentaion();
        WheelPresentaion wheelPresentaion = new WheelPresentaion();
        private int closeOperationId = 6;
        public void Menu()
        {
            var operation = -1;
            do
            {
                
                operation = int.Parse(Console.ReadLine());
                switch (operation)
                {
                    case 1:
                        DeckInput();
                        break;
                    case 2:
                        Add();
                        break;
                    case 3:
                        Update();
                        break;
                    case 4:
                        Find();
                        break;
                    default:
                        break;
                }
            } while (operation != closeOperationId);
        }
        public void ChooseMenu() 
        {
            Console.WriteLine(new string('-', 40));
            Console.WriteLine(new string(' ', 18) + "MENU" + new string(' ', 18));
            Console.WriteLine(new string('-', 40));
            Console.WriteLine("1. Decks");
            Console.WriteLine("2 Bearing");
            Console.WriteLine("3. Brands ");
            Console.WriteLine("4. Wheels");
            Console.WriteLine("5. Exit");
            
        }
    }
}

