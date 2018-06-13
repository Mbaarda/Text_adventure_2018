﻿using System;
using System.Collections.Generic;
using System.Collections;


namespace ZuulCS
{
	 public class Inventory
	 {

        private Dictionary<string, Item> items;

        public Inventory()
        {
            items = new Dictionary<string, Item>();

            

            Console.WriteLine("=========================");
            Console.WriteLine("The Dictionary contains: ");
            foreach (KeyValuePair<string, Item> entry in items)
            {
                Console.WriteLine(entry.Key + ": " + entry.Value.Description);
            }





        }

        public void addItem(Item item)
        {
            items.add(item.name, item);


        }
     }
}


