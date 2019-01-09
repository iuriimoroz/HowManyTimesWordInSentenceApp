using System;
using System.Collections.Generic;

namespace HowManyTimesWordInSentenceApp
{
    class Program
    {
        static void Main()
        {
            //main variables declaration:
            string sentence = "";
            string word = "";
            int wordPresence = 0;
            
            //User input dialoge implemented:
            Console.WriteLine("Write a sentense and click [Enter] button:");
            sentence = Console.ReadLine();
            Console.WriteLine("Write a word to count its occurrences in the sentence and click [Enter] button:");
            word = Console.ReadLine();

            //Logic for counting a word occurrence in a sentence implemented:
            string sentenceFormatted = sentence.TrimEnd('.','!','?').ToLower();
            List<string> listOfWords = new List<string>(sentenceFormatted.Split(' '));

            for (int i = 0; i < listOfWords.Count; i++)
            {
                if(listOfWords[i] == word)
                {
                    wordPresence = wordPresence + 1;
                }
            }

            //Code which help to print result of application and closes it
            Console.WriteLine($"The word {word} appears {wordPresence} times in the following sentence: {sentence}. Press any key to close the screen...");
            Console.ReadKey();
        }
    }
}
