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
      ScrabblePlay = new ScrabblePlay(userInput, wordScore, userInputLetters);
      // Scrabble result = new Scrabble("car");
      // Console.WriteLine("Split Array: " + result.SplitInputtedWord);
    }
  }
}