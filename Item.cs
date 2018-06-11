using System;

namespace ZuulCS
{
	class Item
	{
        private String itemName;
        private String description;

        public Item(String name, String description)
        {
            this.itemName = name;
            this.description = description;
        }

        public String getName()
        {
            return this.itemName;
        }
    }
}
