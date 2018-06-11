using System;
using System.Collections.Generic;
using System.Collections;


namespace ZuulCS
{
	 public class Inventory
	 {

        private List <Item> itemList;

        public Inventory()
        {

            itemList = new List<Item>();

        }
/*
        public void addItem(Item item)
        {
            this.itemList.add(item);
        }

        public String getItemsDescription()
        {
            String str = "";
            for (Item item : itemList)
            {
                str += item.getName() + ", ";
            }
             return str;
            }

        public Item remove(Item item)
        {
            Item removedItem = null;
                if (itemList.contains(item))
                {
                    removedItem = item;
                    itemList.remove(item);
                }
            return removedItem;
         }*/
     }
}


