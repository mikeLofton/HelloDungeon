using System;
using System.Collections.Generic;
using System.Text;

namespace HelloDungeon
{
    class Game
    {
        public void Run()
        {
            ////Health Exercise

            //// Initailize default health values
            //int healthRegen = 50;
            //int health = 100;
            ////Increase health by regen amount 
            //health += healthRegen;
            ////Display health to user
            //Console.WriteLine(health);

            ////Name Exercise
            //string name = "Empty";
            //Console.WriteLine("Please enter your name.");
            //name = Console.ReadLine();
            //Console.WriteLine("Hello " + name);


            Console.WriteLine("Welcome to Tower Ascent");
            Console.WriteLine("Press Enter");
            Console.ReadLine();

            //Character Name
            string heroName = "";
            Console.WriteLine("What is thine name?");
            heroName = Console.ReadLine();
            Console.WriteLine("Your destiny awaits " + heroName);

            //Stats Display
            int health = 100;
            float strength = 10f;
            float defense = 10f;
            Console.WriteLine(heroName + "'s" + " Current Health " + health);
            Console.WriteLine(heroName + "'s" + " Current Stength " + strength);
            Console.WriteLine(heroName + "'s" + " Current Defense " + defense);

            //Floor
            int currentfloor = 1;
            Console.WriteLine("Floor " + currentfloor);
        }
    }
}
