using System;
using System.Collections.Generic;
namespace CourseworkASD
{
    public class WordGenerator
    {
        private int wordLenght;
        private string chars = "abcdefghijklmnopqrstuvwxyzабвгдеёжзийклмнопрстуфхцчшщъыьэюя1234567890 ";
        private string upperChars = "ABCDEFGHIJKLMNOPQRSTUVWXYZАБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ";
        private string symbolChars = "!№;%:?*()#$@^&`/|~,.'\"";
        //private Dictionary<string, int> dictionaryChars = new Dictionary<string, int>();
        private Dictionary<int, string> dictionaryInt = new Dictionary<int, string>();
        private void GenerateDictionary()
        {
            foreach (char letter in chars)
            {
                //dictionaryChars.Add(letter.ToString(), dictionaryChars.Count + 100);
                dictionaryInt.Add(dictionaryInt.Count + 100, letter.ToString());
            }
        }
        //private int GetCharCode(char letter) => dictionaryChars[letter.ToString()];
        /*public int GetWordCode(string word)
        {
            int wordCode = 0;
            foreach (char letter in word) wordCode += GetCharCode(letter);
            return wordCode;
        }*/
        private string GenerateWord(Random rnd)
        {
            string word = "";
            for (int counter = 0; counter < wordLenght; counter++)
            {
                word += dictionaryInt[rnd.Next(1, dictionaryInt.Count) + 100];
            }
            return word;
        }
        public (string word, int hash) GetWord(Random rnd)
        {
            string word = GenerateWord(rnd);
            return (word, Convert.ToInt32(word.GetHashCode()));
        }
        public WordGenerator(int lenght, bool symbols, bool uppered)
        {
            wordLenght = lenght;
            if (uppered) chars += upperChars;
            if (symbols) chars += symbolChars;
            GenerateDictionary();
        }
    }
}