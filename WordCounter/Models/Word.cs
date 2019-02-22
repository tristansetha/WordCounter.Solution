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

    public int Count(string WordInput, string SentenceInput)
    {
        string[] sentenceWordSplit = SentenceInput.Split(' ');
        int wordCount = 0;
        for (int i = 0; i < sentenceWordSplit.Length; i++)
        {
            if (sentenceWordSplit[i] == WordInput)
            {
                wordCount += 1;
            }
        }
        return wordCount;
    }

  }
}

    // public bool IsWordAlpha(string WordInput)
    // {
    //     string myWordUpper = WordInput.ToUpper();
    //     char[] wordInputArray = myWordUpper.ToCharArray();
        
    //     for  (int i = 0; i < wordInputArray.Length; i++)
    //     {
    //         if (wordInputArray[i] < 'A' || wordInputArray[i] > 'Z') 
    //         {
    //             return false;
    //         } 
    //     }
    //     return true;
        
    // }

    // public bool IsSentenceAlpha(string SentenceInput)
    // {
    //     string mySentenceUpper = SentenceInput.ToUpper();
    //     string sentenceInputReplace = mySentenceUpper.Replace(" ", "");
    //     char[] sentenceInputArray = sentenceInputReplace.ToCharArray();

    //     for  (int i = 0; i < sentenceInputArray.Length; i++)
    //     {
    //         if (sentenceInputArray[i] < 'A' || sentenceInputArray[i] > 'Z') 
    //         {
    //             return false;
    //         }
    //     }
    //     return true;
       
    // }