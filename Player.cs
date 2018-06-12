using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZuulCS
{
   public class Player { 

        private Room currentRoom;
        private int playerHealth = 100;
                        
    public Player()
    {
      //  inventory = new Inventory();
    }

        public void goRoom(Command command)
        {
            if (!command.hasSecondWord())
            {
                // if there is no second word, we don't know where to go...
                Console.WriteLine("Go where?");
                return;
            }

            String direction = command.getSecondWord();

            // Try to leave current room.
            
            Room nextRoom = this.getCurrentRoom().getExit(direction);

            

            if (nextRoom == null)
                Console.WriteLine("There is no door!");
            else {

                this.setCurrentRoom(nextRoom);
                Console.WriteLine(this.getCurrentRoom().getLongDescription());
                damage(20);
            
            }
        }

        public Room getCurrentRoom()
        {
            return currentRoom;
        }

        public void setCurrentRoom(Room currentRoom)
        {
            this.currentRoom = currentRoom;
        }

        public bool isAlive()
        {
            if (this.playerHealth == 0)
            {
                Console.WriteLine("You died, game over...");
                Console.WriteLine("Thank you for playing.");
                
                
                return false;
            }
            else
            {
                return true;

            }
        }

        public void heal(int amount)
        {
            this.playerHealth += amount;

            if (this.playerHealth > 100)
            {
                this.playerHealth = 100;
            }
            Console.WriteLine();
            Console.WriteLine("your are healed by " + amount);
            Console.WriteLine("your total health is " + playerHealth);
        }

        public void damage(int amount)
        {
            this.playerHealth -= amount;
            Console.WriteLine();
            Console.WriteLine("You are suffering from blood loss and take " + amount + " damage.");
            Console.WriteLine("Your total health is now " + playerHealth);

            if (this.playerHealth < 0)
            {
                this.playerHealth = 0;
            }
        }
    }
}
