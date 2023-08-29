using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PigLatinGame
{
    class Translate
    {
        List<char> vowels = new List<char>();

        public Translate()
        {
            vowels.Add('a');
            vowels.Add('e');
            vowels.Add('i');
            vowels.Add('o');
            vowels.Add('u');
        }

        public string GetResult(string word)
        {
            List<char> letters = new List<char>();
            letters.AddRange(word);
            bool flag = false;

            foreach(char v in vowels)
            {
                if(v == letters[0])
                {
                    flag = true;
                }
            }

            if (flag)
            {
                letters.AddRange("-way");
            }
            else
            {
                letters = BeginConstant(letters);
            }

            word = ConvertListToString(letters);

            return word;
        }

        private List<char> BeginConstant(List<char> letters)
        {
            letters.Add('-');
            bool flag = false;

            for(int i = 0; i < letters.Count; i++)
            {
                foreach (char v in vowels)
                {
                    if (v == letters[i])
                    {
                        flag = true;
                    }
                }

                if (!flag)
                {
                    char temp = letters[i];
                    letters.Remove(letters[i]);
                    letters.Add(temp);
                    i--;
                }
                else
                {
                    i = letters.Count;
                }
            }

            letters.AddRange("ay");

            return letters;
        }

        private string ConvertListToString(List<char> list)
        {
            string x = "";

            foreach(char l in list)
            {
                x += l;
            }

            return x;
        }
    }
}
