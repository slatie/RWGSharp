using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace RWG
{
    public class Generator
    {
        public char RandomCharacter(ref string options)
        {
            char character = (char) new Random().Next(0, 127);
            string charA = (character).ToString();
            while (!Regex.IsMatch(charA, options))
            {
                character = ((char) new Random().Next(0, 127));
                charA = (character).ToString();
            }

            return character;
        }
        public string RandomCharacters(int length, string options = @"[A-Z]")
        {
            List<char> characters = new List<char>();
            for (int i = 0; i < length; i++)
            {
                char character = RandomCharacter(ref options);
                characters.Add(character);
            }
            return new string(characters.ToArray());
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="wordArray"></param>
        /// <param name="times">IT is the amount of wordArray by default, not -1!!</param>
        /// <returns>The word </returns>
        public string RandomWords(string[] wordArray, string separator = ", ", int times = -1)
        {
            List<string> words = new List<string>();
            for (int i = 0; i < ((times == -1) ? wordArray.Length : times); i++)
            {
                int random = new Random().Next(0, wordArray.Length);
                words.Add(wordArray[random]);
            }
            return String.Join(separator, words.ToArray());
        }
    }
}