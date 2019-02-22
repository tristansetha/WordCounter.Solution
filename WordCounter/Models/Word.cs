using System;
using System.Collections.Generic;
using WordCounter;

namespace WordCounter.Models
{
  public class Word
  { 
    private string WordInput;
    private string SentenceInput;
    private int WordCount;
    private static List<Word> Instances = new List<Word>{}; // test this

    public Word (string wordInput, string sentenceInput)
    {
      WordInput = wordInput;
      SentenceInput = sentenceInput;
      WordCount = 0;
      Instances.Add(this); // test this
    }

    public int GetWordCount()
    {
      return WordCount;
    }

    public string GetWordInput()
    {
      return WordInput;
    }

    public string GetSentenceInput()
    {
      return SentenceInput;
    }

    public static List<Word> GetAll()
    {
      return Instances;
    }

    public void SetWordCount(int wordCount)
    {
      WordCount = wordCount;
    }

    public static void ClearAll()
    {
      Instances.Clear();
    }

    public int CountWords(string WordInput, string SentenceInput)
    {
        string[] sentenceWordSplit = SentenceInput.Split(' ');
        int countWords = 0;
        for (int i = 0; i < sentenceWordSplit.Length; i++)
        {
            if (sentenceWordSplit[i] == WordInput)
            {
                countWords += 1;
            }
        }
        return countWords;
    }

  }
}

