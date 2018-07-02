using System;
using System.Collections.Generic;
using System.Collections;


namespace ZuulCS
{
	 public class Inventory
	 {

        private Dictionary<string, Item> items;

        internal Dictionary<string, Item> Items { get => items; }

        public Inventory()
        {
            items = new Dictionary<string, Item>();

            

           // Console.WriteLine("=========================");
           // Console.WriteLine("The Dictionary contains: ");
            foreach (KeyValuePair<string, Item> entry in items)
            {
                Console.WriteLine(entry.Key + ": " + entry.Value.Description);
            }

        }
        
        public bool addItem(Item item)
        {
            items.Add(item.Name, item);
            return true;
        }

        public void takeItem(Item item)
        {
            items.Add(item.Name, item);
        }

        public Item transportItem(Inventory other, string key)
        {

            Item i = items[key];

            if(other == null)
            {

                return null;

            }

            if (items[key] == null)
            {

                return null;

            }

            if (other.addItem(i))
            {

                items[key] = null;
                return i;

            }

            return null;
            
        }
    }
}


