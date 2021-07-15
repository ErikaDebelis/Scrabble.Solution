using System;
using System.Collections.Generic;

namespace Scrabble.Models
{
  public class Scrabble //scrabble class
  {
    public string InputtedWord {get; set; }
    public int InputtedWordScore {get; set; }
    public char[] SplitInputtedWord {get; set; }
    public ScrabblePlay(string userInput, int wordScore, char[] userInputLetters) //constructor
    {
        InputtedWord = userInput;
        InputtedWordScore = wordScore;
        SplitInputtedWord = userInputLetters;
    }
    public char[] ScrabbleScore(string userInput) //method
    {
        InputtedWord = userInput;
        InputtedWordScore = 0;
      // We have a string that we convert into an array of characters
      SplitInputtedWord = userInput.ToCharArray();
      foreach (char character in SplitInputtedWord)
      {
        InputtedWordScore += letters[character]; // value
      }

    }
    public static Dictionary<char, int> letters = new Dictionary<char, int>() {{'c', 3}, {'a', 1}, {'r', 1}};
  }
}



// We want to check every character for its value within a Dictionary that contains characters and their values. 
// loop array <--- 
// 
// letters[""]
// We want to add all of the values from a word into a counter
// Return the counted value once we have finished looping. 

//foreach (string individualEntry in theEntireArray)
// {
//   Console.WriteLine(individualEntry);
// }