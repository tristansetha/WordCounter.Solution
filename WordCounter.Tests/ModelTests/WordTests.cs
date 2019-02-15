using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCounter.Models;
// using System.Collections.Generic;
// using System;

namespace WordCounter.Tests
{
  [TestClass]
  public class WordTest
  {
    // Test methods will go here.
    [TestMethod]
    public void IsAlpha_ChecksForAlphabeticCharacters_True()
    {
      Word newWord = new Word();
      Assert.AreEqual(true, newWord.IsAlpha("Apple"));
    }

  }
}