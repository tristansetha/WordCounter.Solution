namespace WordCounter.Models
{
  public class Word
  { // properties, methods, etc. will go here.
    // public string WordInput;
    // public string SentenceInput;
    // public int WordCount;

    // public Word(string wordInput, string sentenceInput) // Constructor
    // {
    //     WordInput = wordInput;
    //     SentenceInput = sentenceInput;
    // }

    public bool IsWordAlpha(string WordInput)
    {
        char[] wordInputArray = WordInput.ToCharArray();
        
        for  (int i = 0; i < wordInputArray.Length; i++)
        {
            if ((wordInputArray[i] <'A' && wordInputArray[i] > 'Z') || (wordInputArray[i] < 'a' && wordInputArray[i] > 'z'))
            {
                return false;
            }
        }
        return true; 
    }

    public bool IsSentenceAlpha(string SentenceInput)
    {
        string sentenceInputReplace = SentenceInput.Replace(" ", "");
        char[] sentenceInputArray = sentenceInputReplace.ToCharArray();

        for  (int i = 0; i < sentenceInputArray.Length; i++)
        {
            if ((sentenceInputArray[i] <'A' && sentenceInputArray[i] > 'Z') || (sentenceInputArray[i] < 'a' && sentenceInputArray[i] > 'z'))
            {
                return false;
            }
        }
        return true;
    }




  }
}
