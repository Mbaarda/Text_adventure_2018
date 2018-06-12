using System;
using System.Collections.Generic;
using System.Collections;


namespace ZuulCS
{
	 public class Inventory
	 {
        private Item key;

        public Inventory()
        {
            Dictionary<string, Item> items = new Dictionary<string, Item>();

            items["key"] = key;

            Console.WriteLine("=========================");
            Console.WriteLine("The Dictionary contains: ");
            foreach (KeyValuePair<string, Item> entry in items)
            {
                Console.WriteLine(entry.Key + ": " + entry.Value.Description);
            }





        }
     }
}


