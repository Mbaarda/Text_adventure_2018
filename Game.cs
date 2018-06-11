﻿using System;

namespace ZuulCS
{
	public class Game
	{
		private Parser parser;
        private Player player;
        private Item knife;
        private Item key;

		public Game ()
		{
            player = new Player();
			createRooms();
			parser = new Parser();
		}

		private void createRooms()
		{
            Room staircase, basement, livingroom, bathroom, winecellar, corridor, kitchen, backyard, shed;

            // create the rooms
            staircase = new Room("in a hallway with a giant staircase.");
            kitchen = new Room("in the kitchen, it's old and dirty.");
            basement = new Room("in a dark, cold room.");
            livingroom = new Room("in the livingroom, all furniture is covered in white blankets.");
            bathroom = new Room("in a bathroom, it reeks in here.");
            winecellar = new Room("in a huge wine cellar.");
            corridor = new Room("in a corridor, its a long and small hallway.");
            backyard = new Room("in the backyard, it't totally overgrown.");
            shed = new Room("in a shed in the backyard, its full of shit. It's a miracle its still standing.");

            // initialise room exits

            basement.setExit("south", winecellar);

            livingroom.setExit("south", kitchen);
            livingroom.setExit("west", backyard);

            shed.setExit("south", backyard);

            backyard.setExit("north", shed);
            backyard.setExit("west", livingroom);

            kitchen.setExit("north", livingroom);
            kitchen.setExit("west", staircase);

            bathroom.setExit("west", corridor);

            winecellar.setExit("up", staircase);
            winecellar.setExit("north", basement);

            staircase.setExit("down", winecellar);
            staircase.setExit("east", kitchen);
            staircase.setExit("up", corridor);

            
            corridor.setExit("east", bathroom);
            corridor.setExit("down", staircase);

            player.setCurrentRoom(basement);  // start game outside

            //staircase.ge
                                      
        }


		/**
	     *  Main play routine.  Loops until end of play.
	     */
		public void play()
		{
			printWelcome();

			// Enter the main command loop.  Here we repeatedly read commands and
			// execute them until the game is over.
			bool finished = false;
			while (! finished) {
				Command command = parser.getCommand();
				finished = processCommand(command);
			}
			Console.WriteLine("Thank you for playing.");
		}

        /**
	     * Print out the opening message for the player.
	     */
        private void printWelcome()
        {
            Console.WriteLine();
            Console.WriteLine("Welcome to this adventure");
            Console.WriteLine("You just woke up, you are all alone in a dark and cold room.");
            Console.WriteLine("You are suffering from blood loss,");
            Console.WriteLine("and you realize you need help, quick!");
            Console.WriteLine();
            Console.WriteLine("Type 'help' if you need help.");
            Console.WriteLine();
            Console.WriteLine(player.getCurrentRoom().getLongDescription());
        }

        /**
         * Given a command, process (that is: execute) the command.
         * If this command ends the game, true is returned, otherwise false is
         * returned.
         */
        private bool processCommand(Command command)
        {
            bool wantToQuit = false;

            if (player.isAlive() == false) {
                Console.ReadLine();
                return true;
                }

			    if(command.isUnknown()) {
				    Console.WriteLine("I don't know what you mean...");
				return false;
			    }

			string commandWord = command.getCommandWord();
			switch (commandWord) {
				case "help":
					printHelp();
					break;
                case "look":
                    Console.WriteLine(player.getCurrentRoom().getLongDescription());
                    break;
				case "go":
					player.goRoom(command);
					break;
               //case "heal" && command.hasSecondWord:
                //    player.heal(command.getSecondWord());
                //b     break;
				case "quit":
					wantToQuit = true;
					break;
			}

			return wantToQuit;
		}

        private void createItems()
        {
            key = new Item("Key", "Misterious rusty key");
            knife = new Item("Knife", "An old kitchen knife");
        }

		// implementations of user commands:

		/**
	     * Print out some help information.
	     * Here we print some stupid, cryptic message and a list of the
	     * command words.
	     */
		private void printHelp()
		{
			Console.WriteLine("You are lost. You are alone. Some of your toes are missing,");
			Console.WriteLine("you are suffering from blood loss, there is no time to waste!!");
			Console.WriteLine();
			Console.WriteLine("Your command words are:");
			parser.showCommands();
		}

		/**
	     * Try to go to one direction. If there is an exit, enter the new
	     * room, otherwise print an error message.
	     */
	}
}