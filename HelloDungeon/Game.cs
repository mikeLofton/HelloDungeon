using System;
using System.Collections.Generic;
using System.Text;

namespace HelloDungeon
{
    class Game
    {
        public void Run()
        {    
                //Title Screen
                Console.WriteLine("Welcome to Tower Ascent");
                Console.WriteLine("Press Enter \n");
                Console.ReadKey();

                //Character Name
                string heroName = "";
                Console.WriteLine("What is thine name?");
                Console.Write("> ");
                heroName = Console.ReadLine();
                Console.WriteLine("");
                Console.WriteLine("Your destiny awaits " + heroName + "\n");
                Console.ReadKey();

                //Weapon Selection
                int health = 100;
                float strength = 10f;
                float defense = 10f;
                string input;
                string weapon = "";
                bool validInput = false;
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
                Console.ReadKey();

                //Stats Display 
                Console.WriteLine("Name " + heroName + "\n");
                Console.WriteLine("Weapon " + weapon + "\n");
                Console.WriteLine(heroName + "'s" + " Current Health " + health);
                Console.WriteLine(heroName + "'s" + " Current Stength " + strength);
                Console.WriteLine(heroName + "'s" + " Current Defense " + defense);
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
                    Console.WriteLine("You feel cold. God has abandoned this place.");                
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
                Console.Clear();

            }

            int numOfAttempts = 4;
            Console.WriteLine("A very old man will give you. " + numOfAttempts
                + " attempts");

            for (int i = 0; i < numOfAttempts; i++)
            {
                Console.Clear();
                Console.WriteLine("What has to be broken before you can use it?");
                int attempsRemaining = numOfAttempts - i;
                Console.WriteLine("Attemps Remaining: " + attempsRemaining);
                Console.Write("> ");
                input = Console.ReadLine();

                if (input == "egg")
                {
                    Console.WriteLine("Congrats");
                    break;
                }

                Console.WriteLine("Incorrect!");
            }



        }
    }
}
