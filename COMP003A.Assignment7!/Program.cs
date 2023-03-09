/*
2    * Author: Robert Leftridge
3    * Course: COMP-003A
4    * Purpose: Array and List Activity Lecture
5    * 
6    */

using System;
using System.Reflection.Metadata.Ecma335;
using static System.Formats.Asn1.AsnWriter;

namespace COMP003A.Assignment7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SectionSeparator("Array - CharacterCounter Section");

            string letter;
            Console.WriteLine("Please enter a letter: ");
            letter = Console.ReadLine();
            char lett = Convert.ToChar(letter);

            string words;
            Console.WriteLine("Please enter a word: ");
            words = Console.ReadLine();



            int winner = CharacterCounter(lett, words);

            Console.WriteLine(winner);

            SectionSeparator("Array - IsPalindrome Section");

            string palin;
            Console.Write("Please enter a word to check if it is a palindrome:");
            palin = Console.ReadLine();

            if (IsPalindrome(palin) == true)
            {
                Console.WriteLine($"Is the word {palin} palindrome: True");
            }
            else
            {
                Console.WriteLine($"Is the word {palin} palindrome: False");
            }

            SectionSeparator("List - Add section");

            List<string> names = new List<string>();
            char userInput = default;
            do
            {
                Console.WriteLine("Please enter a name ");
                string name = Console.ReadLine();
                names.Add(name);


                Console.WriteLine("Press any key to add more or (e) to exit.");
                userInput = Console.ReadKey().KeyChar;
            } while (userInput != 'E' && userInput != 'e');
            

            SectionSeparator("List - Traversal Section");

            TraverseList(names);


            SectionSeparator("List - Reverse Traversal Section");

            TraverseListReverse(names);
        }

        static void SectionSeparator(string section)
        {
            Console.WriteLine("".PadRight(50, '*') + $"\n\t\t{section} Section\n" + "".
            PadRight(50, '*'));
        }
        static int CharacterCounter(char characterinput, string word)
        {
            int count = 0;
            for (int i = 0; i < word.Length; i++)
            {
                if (characterinput == word[i])
                {
                    count++;
                }
            }
            Console.WriteLine($"There are {count} letter {characterinput} in the word {word}");
            characterinput = char.ToLower(characterinput);
            word = word.ToLower();
            return count;
        }

        static bool IsPalindrome(string word)
        {
            if (word.Length <= 1)
                return true;
            else
            {
                if (word[0] != word[word.Length - 1])
                    return false;
                else
                    return IsPalindrome(word.Substring(1, word.Length - 2));
            }
        }

        static void TraverseList(List<string> list)
        {
            foreach (var name in list)
            {
                Console.WriteLine(name);
            }
        }

        static void TraverseListReverse(List<string> list)
        {
            for(var i = list.Count - 1; i >=0; i--) {
                Console.WriteLine(list[i]);
            }
            }
        }
    }
