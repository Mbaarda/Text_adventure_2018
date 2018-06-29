using System;

namespace ZuulCS { 

    public class Key : Item
    {
        public Key()
        {
            System.Console.WriteLine("Key Constructor");

            name = "key";
            description = "A rusty old key";

            
        }

        public override void use(Object o)
        {
            if (o.GetType() == typeof(Room))
            {
                Room r = (Room)o; // must cast
                //r.unlock();
            }
            else
            {
                // Object o is not a Room
                System.Console.WriteLine("Can't use a key on this Object");
            }

        }

        public override void use()
        {
            System.Console.WriteLine("Key::use()");
        }

    }
}
