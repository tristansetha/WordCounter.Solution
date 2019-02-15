using System;
using WordCounter.Models;
using System.Collections.Generic;

namespace WordCounter{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Enter a word: ");
            string myWord = Console.ReadLine();
            Console.WriteLine("Type a sentence: ");
            string mySentence = Console.ReadLine();

            Word newCount = new Word(myWord, mySentence);

            if  (newCount.IsWordAlpha(myWord) && newCount.IsSentenceAlpha(mySentence))
            {
                int myCount = newCount.Count(mySentence, myWord);
                Console.WriteLine("Word count: " + myCount);
            }
        }
    }
}