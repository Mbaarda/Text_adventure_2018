using System;

namespace ZuulCS
{
    public class Item
    {
        protected string description;
        protected string name;

        public Item()
        {

            name = "item";
            description = "A generic Item";
           // System.Console.WriteLine("Item Constructor");
        }

        public virtual void use(Object o)
        {
            System.Console.WriteLine("Item::use(Object o)");
        }

        public virtual void use()
        {
            System.Console.WriteLine("Item::use()");
        }

        public string Description
        {
            get { return this.description; }
            set { this.description = value; }
        }
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
    }
}
