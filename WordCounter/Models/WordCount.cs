using System;
using System.Collections.Generic;
using WordCounter;

namespace WordCounter.Models
{
  public class WordCount
  { 
    private string WordInput;
    private string SentenceInput;
    private int WordCount;

    public WordCount(string wordInput, string sentenceInput) // Constructor
    {
        WordInput = wordInput;
        SentenceInput = sentenceInput;
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

    // public int Count(string WordInput, string SentenceInput)
    // {
    //     string[] sentenceWordSplit = SentenceInput.Split(' ');
    //     int wordCount = 0;
    //     for (int i = 0; i < sentenceWordSplit.Length; i++)
    //     {
    //         if (sentenceWordSplit[i] == WordInput)
    //         {
    //             wordCount += 1;
    //         }
    //     }
    //     return wordCount;
    // }

  }
}
