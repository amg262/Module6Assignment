﻿using System;
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


        public void DisplayList(List<Item> list = null)
        {
            if (list == null)
            {
                list = this.items;
            }

            foreach (Item i in list)
            {
                i.Print();
            }
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

            // foreach (Item i in p.items)
            // {
            //     i.Print();
            // }

            p.DisplayList();

            string index = "";
            int ID = 0;

            do
            {
                Console.WriteLine("Item to buy (NA when done)");
                index = Console.ReadLine();

                if (index.ToUpper() != "NA")
                {
                    Int32.TryParse(index, out ID);

                    if (ID > 0)
                        ID--;

                    if (p.items[ID] != null)
                    {
                        //p.items[ID].PrintRemoval(ID);
                        //p.items.RemoveAt(ID);

                        if (p.items[ID].Quantity > 1)
                            Console.WriteLine(--p.items[ID].Quantity);
                        
                        else
                            //p.items[ID].PrintRemoval(ID);
                            p.items.RemoveAt(ID);

                        // Console.WriteLine(p.items[ID].Name);
                        // Console.WriteLine(p.items[ID].Quantity);
                        // Console.WriteLine(p.items[ID].Price);

                        //p.DisplayList(p.items);

                        foreach (Item i in p.items)
                        {
                            Console.WriteLine($"NEW: {i.Quantity} {i.Name} @ ${i.Price}");
                        }
                    }
                }
            } while (index.ToUpper() != "NA");
        }
    }
}