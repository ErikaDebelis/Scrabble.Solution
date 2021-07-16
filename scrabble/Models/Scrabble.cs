using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
namespace Scrabble.Models
{
  public class Scrabble //scrabble class
  {
    public static Dictionary<char, int> letters = new Dictionary<char, int>()
    {
      {'A',1}, {'B',3}, {'C',3}, {'D',2}, {'E',1}, {'F',4}, {'G',2}, {'H',4}, {'I',1}, {'J',8}, {'K',5}, {'L',1}, {'M',3}, {'N',1}, {'O',1}, {'P',3}, {'Q',10}, {'R',1}, {'S',1}, {'T',1}, {'U',1}, {'V',4}, {'W',4}, {'X',8}, {'Y',4}, {'Z',10}
    };

    public static int ScrabbleScore(string userInput) //method
    {
      string pattern = @"^[a-zA-Z]*$";
        Regex rg = new Regex(pattern);
        MatchCollection matches = rg.Matches(userInput);
        
        if (matches.Count == 0){
            return 0;
        }
      int InputtedWordScore = 0;
      char[] SplitInputtedWord = userInput.ToUpper().ToCharArray();
      foreach (char character in SplitInputtedWord)
      {
        InputtedWordScore += letters[character];
      }
      return InputtedWordScore;
    }
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