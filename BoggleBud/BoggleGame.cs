using System;

using System.Text.RegularExpressions;

using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace BoggleBud
{
    public class BoggleGame
    {
        public string[] Board = new string[16];
        private string alpha = "abcdefghijklmnopqrstuvwxyz";
        public int Player1Score;

		private Dictionary<String, int> _dictionary = new Dictionary<String, int>();
		private static Regex _wordRegex = new Regex("[a-z]+", RegexOptions.Compiled);

		private void Spelling()
		{
			string fileContent = File.ReadAllText("big.txt");
			List<string> wordList = fileContent.Split(new string[] { "\n" }, StringSplitOptions.RemoveEmptyEntries).ToList();

			foreach (var word in wordList)
			{
				string trimmedWord = word.Trim().ToLower();
				if (_wordRegex.IsMatch(trimmedWord))
				{
					if (_dictionary.ContainsKey(trimmedWord))
						_dictionary[trimmedWord]++;
					else
						_dictionary.Add(trimmedWord, 1);
				}
			}
		}

		private bool WordCheck(string word)
		{
			if (_dictionary.ContainsKey(word))
				return true;
			else
			{
				return false;
			}
		}

        public BoggleGame()
        {
            Random rng = new Random();
            for (int i = 0; i < 16; i++)
            {
                int random = Math.Abs(rng.Next(alpha.Length)) % 25;
                Board[i] = alpha[random].ToString();   
            }
            Spelling();
            Player1Score = 0;
        }

        public int PlayWord(string word)
        {
            if(WordCheck(word))
            {
                Player1Score++;
                return Player1Score;
            }
            else
            {
                Player1Score--;
                return Player1Score;
            }
        }

    }
}
