using System;
using System.Collections.Generic;

namespace rockpaperscissors
{
    class Program
    {
        static void Main(string[] args)
        {

        Dictionary<String, String> choices = new Dictionary<String, String> {
            {"r", "Rock"},
            {"s", "Scissors"},
            {"p", "Paper"}

        };
          
        Random rand = new Random();
        List<string> compChoices = new List<string>() {"rock", "paper", "scissors"};
        int playerWins = 0;
        int compWins = 0;
        string computerChoice = "";

        Dictionary<String, String> howToWin = new Dictionary<String, String> {
            {"paper", "rock"},
            {"rock", "scissors"},
            {"scissors", "paper"}
        };

        bool running = true; 
        while (running)
        {
            
            computerChoice = compChoices[rand.Next(compChoices.Count)];
            Console.WriteLine(computerChoice);
            Console.WriteLine("Computer Wins:" + "" + compWins);
            Console.WriteLine("Player Wins:" + "" + playerWins);
            Console.WriteLine(@"Welcome to Rock, Paper, Scissors! Type rock to play rock, Type scissors to play scissors, and paper to player paper");
        // ConsoleKeyInfo playerChoice = Console.ReadKey();        
           string myChoice = Console.ReadLine().ToLower(); 
        Console.Clear();


        if (howToWin.ContainsKey(myChoice))
        {
           if (myChoice == computerChoice)
           {
               Console.WriteLine("draw!");
           }
           else if (howToWin[myChoice].Contains(computerChoice))
           {
               Console.WriteLine("You win!");
               playerWins++;
           }
           else
           {
              Console.WriteLine("You chose...... poorly");
              compWins ++;
           }
        }





        // Console.Write("player choice" + myChoice );
        // else if (playerChoice.Key == ConsoleKey.S)
        // {
        //     Console.WriteLine("Scissors!");

        // }
        // else if (playerChoice.Key == ConsoleKey.P)
        // {
        //     Console.WriteLine("Paper!");
        // }
        
        // string playerChoice = Console.ReadLine();

        Console.WriteLine();
        }

        }
    }
}
