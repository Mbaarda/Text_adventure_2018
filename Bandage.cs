using System;

namespace ZuulCS
{

    public class Bandage : Item
    {
        public Bandage()
        {


            name = "bandage";
            description = "an dusty old bandage";


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

