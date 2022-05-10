using System;
using System.Collections.Generic;
namespace CourseworkASD
{
    public class WordGenerator
    {
        private readonly int _wordLenght;
        private readonly string _chars = "abcdefghijklmnopqrstuvwxyzабвгдеёжзийклмнопрстуфхцчшщъыьэюя1234567890 ";
        private readonly string _upperChars = "ABCDEFGHIJKLMNOPQRSTUVWXYZАБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ";
        private readonly string _symbolChars = "!№;%:?*()#$@^&`/|~,.'\"";
        //private Dictionary<string, int> dictionaryChars = new Dictionary<string, int>();
        private readonly Dictionary<int, string> _dictionaryInt = new Dictionary<int, string>();
        private void GenerateDictionary()
        {
            foreach (char letter in _chars)
            {
                //dictionaryChars.Add(letter.ToString(), dictionaryChars.Count + 100);
                _dictionaryInt.Add(_dictionaryInt.Count + 100, letter.ToString());
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
            for (int counter = 0; counter < _wordLenght; counter++)
            {
                word += _dictionaryInt[rnd.Next(1, _dictionaryInt.Count) + 100];
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
            _wordLenght = lenght;
            if (uppered) _chars += _upperChars;
            if (symbols) _chars += _symbolChars;
            GenerateDictionary();
        }
    }
}