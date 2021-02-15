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
        string myChoice;

        // Dictionary<String, String> theWin = new Dictionary<String, String> {
        //     {"rock", "paper"},
        //     {"scissors", "rock"},
        //     {"paper", "scissors"}
        // };

        bool running = true; 
        while (running)
        {
            
            computerChoice = compChoices[rand.Next(compChoices.Count)];
            Console.WriteLine(computerChoice);
            Console.WriteLine(@"Welcome to Rock, Paper, Scissors! Type rock to play rock, Type scissors to play scissors, and paper to player paper");
        // ConsoleKeyInfo playerChoice = Console.ReadKey();        
            Console.ReadLine().ToLower(); 
        Console.Clear();


        if (playerChoice.Key == ConsoleKey.R)
        {
            myChoice = "rock";
        }
        Console.Write("player choice" + myChoice );
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
