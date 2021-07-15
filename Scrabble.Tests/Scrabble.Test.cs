using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Scrabble.Models;
using System;

namespace Scrabble.Tests
{
  [TestClass]
  public class ScrabbleTests
  {
    [TestMethod]
    public void Dictionary_InitializesValesCorrectly()
    {
      Dictionary<string, int> letters = new Dictionary<string, int>() {{"c", 3}, {"a", 1}, {"r", 1}};
      Assert.AreEqual( 3, letters["c"]); // first param = expected, second = "calling it" 
    }
  }
}