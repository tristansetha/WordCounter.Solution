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
    public void IsWordAlpha_ChecksForAlphabeticCharactersInWordInput_True()
    {
      Word newWord = new Word();
      Assert.AreEqual(true, newWord.IsWordAlpha("Apples"));
    }

    [TestMethod]
    public void IsSentenceAlpha_ChecksForAlphabeticCharactersInSentenceInput_True()
    {
      Word newWord = new Word();
      Assert.AreEqual(true, newWord.IsSentenceAlpha("Apples are good"));
    }

    [TestMethod]
    public void CountWords_CountsWordsInSentence_1()
    {
      Word newWord = new Word();
      Assert.AreEqual(1, newWord.Count("Apples", "Apples are good"));
    }

  }
}