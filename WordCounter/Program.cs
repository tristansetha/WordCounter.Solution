using System;
using WordCounter.Models;
using System.Collections.Generic;

namespace WordCounter{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Enter a word (No numbers or symbols): ");
            string myWord = Console.ReadLine();
            Console.WriteLine("Type a sentence (No numbers or symbols): ");
            string mySentence = Console.ReadLine();

            Word newCount = new Word(myWord, mySentence);

            if (newCount.IsWordAlpha(myWord) && newCount.IsSentenceAlpha(mySentence))
            {
                int myCount = newCount.Count(myWord, mySentence);
                Console.WriteLine("Word count: " + myCount);
            } else
            {
                Console.WriteLine("Enter a valid input");
            }
            
        }
    }
}