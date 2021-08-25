using System;
using System.Collections.Generic;
using System.Text;

namespace HelloDungeon
{
    class Game
    {
        string heroName = "";
        int health = 100;
        float strength = 10f;
        float defense = 10f;       
        string weapon = "";       
        bool playerIsAlive = true;
        bool gameOver = false;
        int currentArea = 1;
        /// <summary>
        /// Function that reads three inputs and will either return an inputrecieved integer or
        /// label the as input invalid.
        /// </summary>
        /// <param name="description">The set up or scenerio</param>
        /// <param name="option1">The first option for the player</param>
        /// <param name="option2">The second option for the player</param>
        /// <param name="option3">The third option for the player</param>
        /// <returns></returns>
        int GetInput(string description, string option1, string option2, string option3)
        {
            string input = "";
            int inputRecieved = 0;

            while (!(inputRecieved == 1 || inputRecieved == 2 || inputRecieved == 3))
            {
                Console.WriteLine(description);
                Console.WriteLine("1. " + option1);
                Console.WriteLine("2. " + option2);
                Console.WriteLine("3. " + option3);
                Console.Write("> ");

                input = Console.ReadLine();

                if (input == "1" || input == option1)
                {
                    inputRecieved = 1;
                }
                else if (input == "2" || input == option2)
                {
                    inputRecieved = 2;
                }
                else if (input == "3" || input == option3)
                {
                    inputRecieved = 3;
                }
                else
                {
                    Console.WriteLine("Invalid Input");
                    Console.ReadLine();
                }

                Console.Clear();
            }
            return inputRecieved;
        }

        int GetTwoInputs(string description, string option1, string option2)
        {
            string input = "";
            int inputRecieved = 0;

            while (!(inputRecieved == 1 || inputRecieved == 2))
            {
                Console.WriteLine(description);
                Console.WriteLine("1. " + option1);
                Console.WriteLine("2. " + option2);            
                Console.Write("> ");

                input = Console.ReadLine();

                if (input == "1" || input == option1)
                {
                    inputRecieved = 1;
                }
                else if (input == "2" || input == option2)
                {
                    inputRecieved = 2;
                }
                else
                {
                    Console.WriteLine("Invalid Input");
                    Console.ReadLine();
                }

                Console.Clear();
            }
            return inputRecieved;
        }

        void titleScreen()
        {
            Console.WriteLine("Welcome to Tower Ascent");
            Console.WriteLine("Press Enter \n");
            Console.ReadKey();
        }
        void characterName()
        {
            Console.WriteLine("What is thine name?");
            Console.Write("> ");
            heroName = Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine("Your destiny awaits " + heroName + "\n");
            Console.ReadKey();
        }
        /// <summary>
        /// Displays players name, weapon, and stats
        /// </summary>
        void displayStats()
        {
            Console.WriteLine("Name " + heroName + "\n");
            Console.WriteLine("Weapon " + weapon + "\n");
            Console.WriteLine(heroName + "'s" + " Current Health " + health);
            Console.WriteLine(heroName + "'s" + " Current Stength " + strength);
            Console.WriteLine(heroName + "'s" + " Current Defense " + defense);
        }
        void weaponSelection()
        {
            int input = GetInput("Choose thine weapon \n", "1. Sword", "2. Sheild", "3. Bow");

            if (input == 1)
            {
                health = 100;
                strength = 15f;
                defense = 5f;
                weapon = "The Sword of Fate";
                Console.WriteLine("You have chosen " + weapon + "\n");
            }
            else if (input == 2)
            {
                health = 150;
                strength = 10f;
                defense = 15f;
                weapon = "The Sheild of Destiny";
                Console.WriteLine("You have chosen " + weapon + "\n");
            }
            else if (input == 3)
            {
                health = 70;
                strength = 20f;
                defense = 10f;
                weapon = "The Bow of Despair";
                Console.WriteLine("You have chosen " + weapon + "\n");
            }          
        }
        void firstEvent()
        {
            int input = GetTwoInputs("You stand at the entrance of Celestia Tower. Will you enter?",
                   "1. Yes", "2. No");
            if (input == 1)
            {
                Console.WriteLine("You feel cold. God has abandoned this place. \n");
                Console.ReadKey();
            }
            else if (input == 2)
            {
                Console.WriteLine("You have abandoned your journey. Run home cowardly traveler.");
                Console.ReadKey();
                playerIsAlive = false;
            }          
        }
        void secondEvent()
        {
            int numofAttempts = 2;
            Console.WriteLine("Upon entering the tower the door slams shut behind you. You are in a " +
                "hallway with three doors. The Devil's voice enters your mind. \n");
            Console.WriteLine("The Devil: Choose the correct path or the fires of hell shall consume you!" +
               "You have " + numofAttempts + " attempts. \n");
            Console.ReadKey();
            for (int i = 0; i < numofAttempts; i++)
            {
                int input = GetInput("A message is engraved on your weapon...3 souls free, 2 filled " +
                    "with hate, 1 consumed by power.\nChoose " +
                    "a door number", "1. Door 1", "2. Door 2", "3. Door 3");
                int remainingAttempts = numofAttempts - i;
                Console.WriteLine("Attempts Remaining: " + remainingAttempts);
                if (input == 1)
                {
                    Console.WriteLine("You have been sucked into the jaws of hell. Your suffering shall be eternal.");
                    Console.ReadKey();
                }
                else if (input == 2)
                {
                    Console.WriteLine("You have been sucked into the jaws of hell. Your suffering shall be eternal.");
                    Console.ReadKey();
                }
                else if (input == 3)
                {
                    Console.WriteLine("The Devil: You have chosen correctly foolish mortal.");
                    break;
                }

            }
        }

        void thirdEvent()
        {

        }

        void displayMenu()
        {
            int input = GetTwoInputs("Would you like to play again", "Yes", "No");
            if (input == 1)
            {
                currentArea = 1;
                gameOver = false;
            }
            if (input == 2)
            {
                gameOver = true;
            }
        }
        void DisplayCurrentRoom()
        {
            if (currentArea == 1)
            {
                Console.Clear();

                //Title Screen
                titleScreen();

                //Character Name
                characterName();

                //Weapon Selection
                weaponSelection();
                Console.ReadKey();

                //Stats Display 
                displayStats();
                Console.ReadKey();
                Console.Clear();

                //First Event
                Console.WriteLine("Floor 1 Start \n");
                Console.ReadKey();
                firstEvent();

            }
            else if (currentArea == 2)
            {
                secondEvent();
            }
        }

        public void Run()
        {
            while (!gameOver)
            {
               //Place the whole game in DisplayCurrentRoom function
               //Try working on this at home & fix errors.             
                Console.Clear();

                DisplayCurrentRoom();

                //Game End
                if (playerIsAlive == false || currentArea == 3)
                {                    
                    displayMenu();
                    //Console.Clear();
                    //Console.WriteLine("You have reach the end of your path. Farewell. \n");
                    //Console.ReadKey();
                    //Console.WriteLine("Do you want to play again?");
                }
                else
                {
                    currentArea++;
                }
               

            }
             

            


        }
    }
}
