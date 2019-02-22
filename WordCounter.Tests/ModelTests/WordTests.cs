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

    [TestMethod]
    public void GetWordInput_ReturnWordInput_String()
    {
      Word newWord = new Word("Word", "Sentence");
      Assert.AreEqual("Word", newWord.GetWordInput());
    }

    [TestMethod]
    public void GetSentenceInput_ReturnSentenceInput_String()
    {
      Word newWord = new Word("Word", "Sentence");
      Assert.AreEqual("Sentence", newWord.GetSentenceInput());
    }
    
    [TestMethod]
    public void CountWords_ReturnNumberOfWords_Int()
    {
      Word newWord = new Word("Word", "Word Sentence");
      Assert.AreEqual(1, newWord.CountWords("Word", "Word Sentence"));
    }

    [TestMethod]
    public void SetWordCount_ReturnWordCount_Int()
    {
      Word newWord = new Word("Word", "Word Sentence");
      int wordCount = newWord.CountWords("Word", "Word Sentence");
      newWord.SetWordCount(wordCount);
      Assert.AreEqual(1, newWord.GetWordCount());
    }
  };
}