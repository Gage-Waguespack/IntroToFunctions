using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    class Game
    {
        bool _gameOver = false;
        string _playerName = "";
        void RequestName()
        {
            //if player already has a name, return from function
            if(_playerName != "")
            {
                return;
            }
            //Initialize input value
            char input = ' ';
            //Loop until valid input is given
            while (input != '1')
            {
                //Clear previous text
                Console.Clear();
                //Ask user for name
                Console.WriteLine("Welcome, Please enter your name!");
                _playerName = Console.ReadLine();
                //Display username
                Console.WriteLine("Hello " + _playerName);
                //Gives the user the option to change their name
                input = GetInput("Yes", "No", "Are you sure you want the name " + _playerName + "?");
                if (input == '2')
                {
                    Console.WriteLine("What were you thinking?! Try again!");
                }
            }

        }
        void ViewStats()
        {
            //Prints player stats to screen
            Console.WriteLine(_playerName);
            Console.WriteLine("Press any key to continue!");
            Console.Write("> ");
            Console.ReadKey();
        }

        void Explore()
        {
            char input = ' ';
            input = GetInput("Go left", "Go right" , "You came to a cross road");
            if(input == '1')
            {
                Console.WriteLine("You decided to go left and a trap is sprung. You become human fertilizer..");
                _gameOver = true;
            }
            else if(input == '2')
            {
                Console.WriteLine("You continue down the RIGHT path.. should be obvious!");
                Console.WriteLine("You head into the town of GoldenRowe.");
            }
        }

        char GetInput(string option1, string option2, string query)
        {
            //initialize input value
            char input = ' ';
            //Loop until a valid input is received
            while(input != '1' && input != '2')
            {
                Console.WriteLine(query);
                //display options
                Console.WriteLine("1. " + option1);
                Console.WriteLine("2. " + option2);
                Console.WriteLine("3. View Stats");
                Console.Write("> ");
                //Get input from user
                input = Console.ReadKey().KeyChar;
                Console.WriteLine();
                //If the player input 3, call the view stats function
                if(input == '3')
                {
                    ViewStats();
                }
            }
            //return input received from user
            return input;
        }
        void HeroicAct()
        {
            char input = ' ';
            input = GetInput("Save her", "Ignore her and walk away", "There are two thugs trying to rob this girl! What are you gonna do?!");
            if(input == '1')
            {
                Console.WriteLine("YOU JUMP IN WITHOUT HESITATING TO SAVE THE GIRL!");
                Console.WriteLine("Unfortunately she assumes you're with the thugs and she pepper sprays all three of you and you go to jail for assisted battery..");
                Console.WriteLine("You don't even know what a battery is but your life is now over and your stolen goods are now forfeit");
                _gameOver = true;
            }
            else if(input == '2')
            {
                Console.WriteLine("You chose to ignore it and alert the authorites instead..");
                Console.WriteLine("Because of this you are rewarded with a GOLDEN STAR?!");
                Console.WriteLine("Unfortunately the golden star is a sticker and you walk away with nothing but an inflated ego...");
            }
            void Wyoming()
            {
                char input = ' ';
                input = GetInput("Head off to Wyoming", "Stay in town for the night", "You head off and hear rumors of a place called Wyoming and pick up a map and see that its a two mile walk down the main road, Do you take it?");
                if(input == '1')
                {
                    Console.WriteLine("You head to Wyoming but end up in the town of RavenRock instead, you seem to have passed it up?!");
                    Console.WriteLine("You turn around to look for this Wyoming but you end up back in GoldenRowe..");
                    Console.WriteLine("You know you're following the right roads but you never see it...");
                    Console.WriteLine("You turn back around and end up in RavenRock again and this time you decide to go to the pub to ask people what they know about Wyoming.");
                    Console.WriteLine("After asking the first person, they tell you that they've heard of the place but they don't know anyone from there or what it looks like.");
                    Console.WriteLine("You decide to ask another person and this time they say they've never heard of the damn place...");
                    Console.WriteLine("Now you get fed up and ask one more person and they tell you that they once tried to go there but never made it.. where is this Wyoming?!");

                }
                if (input == '2')
                {
                    Console.WriteLine("You stay the night in a tavern and rest up.");
                    Console.WriteLine("However you ended up being stabbed in the middle of the night after being mugged.. ");
                    Console.WriteLine("Sucks to suck! Your fault for staying in the only free tavern in town...");
                    _gameOver = true;
                }
            }
        }
         //Run the game
        public void Run()
        {
            Start();
            while(_gameOver == false)
            {
                Update();
            }
            End();

        }

        //Performed once when the game begins
        //Used for initializing variables
        //Also used for performing start up tasks that should only be done once
        public void Start()
        {
            Console.WriteLine("Welcome to my game!!!");
        }

        //Repeated until the game ends
        //Used for all game logic that will repeat
        public void Update()
        {
            RequestName();
            Explore();
            HeroicAct();
        }

        //Performed once when the game ends
        public void End()
        {
            Console.WriteLine("\nSee you again soon <3");
        }
    }
}
