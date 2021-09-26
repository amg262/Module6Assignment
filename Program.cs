using System;
using System.Collections.Generic;

namespace Module6Assignment
{
    class Program
    {
        private List<Item> items;

        public Program(List<Item> items = null)
        {
            this.items = items;
        }


        public List<Item> Items
        {
            get => items;
            set => items = value;
        }


        static void Main(string[] args)
        {
            Program p = new Program();
            string stockItem = "";
            double quantity = 0;
            double price = 0;
            p.items = new List<Item>();

            do
            {
                Console.WriteLine("Item to stock (NA when done):");
                stockItem = Console.ReadLine();

                if (stockItem.ToUpper() != "NA")
                {
                    Item item = new Item();
                    item.Name = stockItem;

                    Console.WriteLine("Quantity");
                    Double.TryParse(Console.ReadLine(), out quantity);
                    item.Quantity = quantity;

                    Console.WriteLine("Price:");
                    Double.TryParse(Console.ReadLine(), out price);
                    item.Price = price;

                    p.items.Add(item);
                }
            } while (stockItem.ToUpper() != "NA");

            foreach (Item i in p.items)
            {
                Console.WriteLine(i.Name);
                Console.WriteLine(i.Quantity);
                Console.WriteLine(i.Price);
            }
        }
    }
}