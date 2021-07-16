using System.Collections.Generic;
using System;

namespace Scrabble.Models
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Welcome to our Scrabble Score Application");
      Console.WriteLine("Enter a word, and we'll tell you the scrabble score for it!");
      string userInput = Console.ReadLine();
      int score = Scrabble.ScrabbleScore(userInput);
      
      Console.WriteLine(score);
    }
  }
}


