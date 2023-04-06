using SkateboardsProject.Business;
using SkateboardsProject.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkateboardsProject.Presentation
{
    class Display
    {
        private int closeOperationId = 6;

        private SkateboardBusiness skateboardBusiness = new SkateboardBusiness();

        /// <summary>
        ///  Constructor
        /// </summary>
        public Display()
        {
            Input();
        }

        /// <summary>
        /// Menu UI
        /// </summary>
        private void ShowMenu()
        {
            Console.WriteLine(new string('-', 40));
            Console.WriteLine(new string(' ', 18) + "MENU" + new string(' ', 18));
            Console.WriteLine(new string('-', 40));
            Console.WriteLine("1. List all entries");
            Console.WriteLine("2. Add new entry");
            Console.WriteLine("3. Update entry");
            Console.WriteLine("4. Fetch entry by ID");
            Console.WriteLine("5. Delete entry by ID");
            Console.WriteLine("6. Exit");
        }

        /// <summary>
        /// User Input
        /// </summary>
        private void Input()
        {
            var operation = -1;
            do
            {
                ShowMenu();
                operation = int.Parse(Console.ReadLine());
                switch (operation)
                {
                    case 1:
                        ListAll();
                        break;
                    case 2:
                        Add();
                        break;
                    case 3:
                        Update();
                        break;
                    case 4:
                        Fetch();
                        break;
                    case 5:
                        Delete();
                        break;
                    default:
                        break;
                }
            } while (operation != closeOperationId);
        }

        /// <summary>
        /// US for Deletion
        /// </summary>
        private void Delete()
        {
            Console.WriteLine("Enter ID to delete: ");
            int id = int.Parse(Console.ReadLine());
            skateboardBusiness.Delete(id);
            Console.WriteLine("Done.");
        }

        /// <summary>
        /// UI for getting a single product record from the database
        /// </summary>
        private void Fetch()
        {
            Console.WriteLine("Enter ID to fetch: ");
            int id = int.Parse(Console.ReadLine());
            Brand brand = skateboardBusiness.Get(id);
            if (brand != null)
            {
                Console.WriteLine(new string('-', 40));
                Console.WriteLine("ID: " + brand.Id);
                Console.WriteLine("Name: " + brand.Name);
                Console.WriteLine("Price: " + brand.Producer);
                Console.WriteLine("Stock: " + brand.Country);
                Console.WriteLine(new string('-', 40));
            }
        }

        /// <summary>
        /// UI dor updating a single product record in the database.
        /// </summary>
        private void Update()
        {
            Console.WriteLine("Enter ID to update: ");
            int id = int.Parse(Console.ReadLine());
            Brand brand = skateboardBusiness.Get(id);
            if (brand != null)
            {
                Console.WriteLine("Enter name: ");
                brand.Name = Console.ReadLine();
                Console.WriteLine("Enter price: ");
                brand.Producer = Console.ReadLine();
                Console.WriteLine("Enter producer: ");
                brand.Country = Console.ReadLine();
                skateboardBusiness.Update(brand);
            }
            else
            {
                Console.WriteLine("Brand not found!");
            }
        }

        /// <summary>
        /// UI for adding a single product record to the database.
        /// </summary>
        private void Add()
        {
            Brand brand = new Brand();
            Console.WriteLine("Enter name:");
            brand.Name = Console.ReadLine();
            Console.WriteLine("Enter producer:");
            brand.Producer = Console.ReadLine();
            Console.WriteLine("Enter country: ");
            brand.Country = Console.ReadLine();
            skateboardBusiness.Add(brand);
        }

        /// <summary>
        /// UI to list all the products.
        /// </summary>
        private void ListAll()
        {
            Console.WriteLine(new string('-', 40));
            Console.WriteLine(new string(' ', 16) + "BRANDS" + new string(' ', 16));
            Console.WriteLine(new string('-', 40));
            var brands = skateboardBusiness.GetAll();
            foreach (var item in brands)
            {
                Console.WriteLine("{0} {1} {2} {3}", item.Id, item.Name, item.Producer, item.Country);
            }
        }
    }
}
