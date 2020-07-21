using System;
using System.Collections;
using System.Collections.Generic;

namespace Lab_4.Mini_Project_Pig_Latin
{
    class Program
    {
        
        static void Main(string[] args)
        {

            Console.WriteLine($"Welcome to the Pig Latin Translator!");
           
            bool running = true;
            while (running)
            {
                Console.Write($"Enter a line to be translated: ");

                string entry = Console.ReadLine().ToLower();
                string pigLatin = PrintPigLatin(entry);

                Console.WriteLine(pigLatin);

                Console.Write($"Translate another line? (y/n): ");

                string cont = Console.ReadLine();
                if (cont == "yes" || cont == "Yes" || cont == "y" || cont == "Y")
                {
                    running = true;
                    {
                        Console.Clear();
                    }
                }
                else if (cont == "no" || cont == "No" || cont == "n" || cont == "N")
                {
                    running = false;
                    {
                        Console.WriteLine($"Goodbye!");
                    }

                }

            }
                                
        }
         
        static string PrintPigLatin(string entry)
        {

            string vowels = "aeiou";
            List<string> newWord = new List<string>();
            foreach (string word in entry.Split())
            {
                int eject = wheresVowel(word); //finding the ejection point to remove the consonants before the first vowel
                string firstLetter = word.Substring(0, eject);
                string remainingLetters = word[eject..];
                int currentLetter = vowels.IndexOf(firstLetter);
                
                switch (currentLetter)
                {
                    case -1:
                        newWord.Add($"{remainingLetters}{firstLetter}ay");
                        break;
                    default:
                        newWord.Add(word + "way");
                        break;
                }

            }
            return string.Join(" ", newWord);

        }

        static int wheresVowel(string word)
        {

            int vowelPosition = 0;

            for (int i = 0; i < word.Length; i++) //running the word through the loop to look for the first vowel position
            {
                if (word[i] == 'a' || word[i] == 'e' || word[i] == 'i' || word[i] == 'o' || word[i] == 'u')
                {
                    vowelPosition = i;
                    break;
                }
          
            }
            return vowelPosition;
        }

    }

 }

