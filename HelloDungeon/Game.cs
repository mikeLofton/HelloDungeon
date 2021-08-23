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
        string input;
        string weapon = "";
        bool validInput = false;
        bool playerIsAlive = true;

        int GetInput(string description, string option1, string option2)
        {

            return;
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
            while (validInput == false)
            {
                Console.WriteLine("Choose thine weapon \n");
                Console.WriteLine("#1 The sword, #2 The sheild, or #3 The bow?");
                Console.Write("> ");
                input = Console.ReadLine();
                if (input == "1" || input == "Sword")
                {
                    health = 100;
                    strength = 15f;
                    defense = 5f;
                    weapon = "The Sword of Fate";
                    Console.WriteLine("You have chosen " + weapon + "\n");
                    validInput = true;
                }
                else if (input == "2" || input == "Sheild")
                {
                    health = 150;
                    strength = 10f;
                    defense = 15f;
                    weapon = "The Sheild of Destiny";
                    Console.WriteLine("You have chosen " + weapon + "\n");
                    validInput = true;
                }
                else if (input == "3" || input == "Bow")
                {
                    health = 70;
                    strength = 20f;
                    defense = 10f;
                    weapon = "The Bow of Despair";
                    Console.WriteLine("You have chosen " + weapon + "\n");
                    validInput = true;
                }
                else
                {
                    Console.WriteLine("Invalid Input");
                    Console.ReadKey();
                    Console.Clear();
                }
            }
        }

        public void Run()
        {                   
                //Title Screen
                Console.WriteLine("Welcome to Tower Ascent");
                Console.WriteLine("Press Enter \n");
                Console.ReadKey();

                //Character Name

                Console.WriteLine("What is thine name?");
                Console.Write("> ");
                heroName = Console.ReadLine();
                Console.WriteLine("");
                Console.WriteLine("Your destiny awaits " + heroName + "\n");
                Console.ReadKey();

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
                validInput = false;
                while (validInput == false)
                {
                    Console.WriteLine("You stand at the entrance of Celestia Tower." +
                            "Will you enter?");
                    Console.WriteLine("#1 Yes  #2 No");
                    Console.Write("> ");
                    input = Console.ReadLine();
                    if (input == "1" || input == "Yes")
                    {
                        Console.WriteLine("You feel cold. God has abandoned this place. \n");
                        Console.ReadKey();
                        validInput = true;
                    }
                    else if (input == "2" || input == "No")
                    {
                        Console.WriteLine("You have abandoned your journey. Run home cowardly traveler.");
                        Console.ReadKey();
                        Console.Clear();
                        
                    }
                    else
                    {
                        Console.WriteLine("Invalid Input");
                        Console.ReadKey();
                        Console.Clear();
                    }
                }

                //Second Event
                int numofAttempts = 3;
                Console.WriteLine("Upon entering the tower the door slams shut behind you. You are in a " +
                    "hallway with seven doors. Three to your left, three to your right, and one directly " +
                    "in front of you. The Devil's voice enters your mind. \n");
                Console.WriteLine("The Devil: Choose the correct path or the fires of hell shall consume you!" +
                   "You have " + numofAttempts + " attempts. \n");
                Console.ReadKey();
                for (int i = 0; i < numofAttempts; i++)
                {
                    Console.Clear();
                    Console.WriteLine("A message is engraved on your weapon... 7 dead," +
                        "6 fallen, 5 burning, 4 changed, 3 free, 2 hated, 1 stood above all. \n");
                    Console.WriteLine("Choose a door number");
                    int remainingAttempts = numofAttempts - i;
                    Console.WriteLine("Attempts Remaining: " + remainingAttempts);
                    Console.Write("> ");
                    input = Console.ReadLine();

                    if (input == "3")
                    {
                        Console.WriteLine("The Devil: You have chosen correctly foolish mortal.");
                        break;
                    }

                    Console.WriteLine("You have been sucked into the jaws of hell. Your suffering shall be eternal.");
                    Console.ReadKey();
                }

            //Third Event
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Floor 2 Start \n");
            Console.WriteLine("You have reached a fork in the road. Do you go left or right?");

            //Fourth Event


        }
    }
}
