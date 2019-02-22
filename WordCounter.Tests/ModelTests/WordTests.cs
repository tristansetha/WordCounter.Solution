using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using WordCounter.Models;
using System;

namespace WordCounter.Tests
{
  [TestClass]
  public class WordTest : IDisposable
  {
    public void Dispose()
    {
      Word.ClearAll();
    }

    [TestMethod]
    public void WordConstructor_CreateInstance_Word()
    {
      Word newWord = new Word("Word", "Sentence");
      Assert.AreEqual(typeof(Word), newWord.GetType());
    }

    [TestMethod]
    public void GetWordCount_ReturnNumberOfWords_Int()
    {
      Word newWord = new Word("Word", "Sentence");
      int wordCount = newWord.GetWordCount();
      Assert.AreEqual(0, wordCount);
    }

  };
}