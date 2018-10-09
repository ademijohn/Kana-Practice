using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KanaPractice
{
    class Kana
    {
        //*************
        // Variables
        //*************
        private int number = 1;
        Random random = new Random();
        private String[] roma = new string[46] {"a",  "i",   "u",   "e",  "o",
                                            "ka", "ki",  "ku",  "ke", "ko",
                                            "sa", "shi", "su",  "se", "so",
                                            "ta", "chi", "tsu", "te", "to",
                                            "na", "ni",  "nu",  "ne", "no",
                                            "ha", "hi",  "fu",  "he", "ho",
                                            "ma", "mi",  "mu",  "me", "mo",
                                            "ya",        "yu",        "yo",
                                            "ra", "ri",  "ru",  "re", "ro",
                                            "wa",                     "wo", "n"};
        private String[] hira = new string[46] {"あ","い","う","え","お",
                                            "か","き","く","け","こ",
                                            "さ","し","す","せ","そ",
                                            "た","ち","つ","て","と",
                                            "な","に","ぬ","ね","の",
                                            "は","ひ","ふ","へ","ほ",
                                            "ま","み","む","め","も",
                                            "や",     "ゆ",     "よ",
                                            "ら","り","る","れ","ろ",
                                            "わ",               "を","ん"};
        private String[] kata = new string[46] {"ア","イ","ウ","エ","オ",
                                            "カ","キ","ク","ケ","コ",
                                            "サ","シ","ス","セ","ソ",
                                            "タ","チ","ツ","テ","ト",
                                            "ナ","ニ","ヌ","ネ","ノ",
                                            "ハ","ヒ","フ","ヘ","ホ",
                                            "マ","ミ","ム","メ","モ",
                                            "ヤ",     "ユ",     "ヨ",
                                            "ラ","リ","ル","レ","ロ",
                                            "ワ",               "ヲ","ン"};
        private bool[] tested = new bool[46];
        //*************
        // Methods
        //*************
        public void randomNumber()
        {
            number = random.Next(0, 45);
            if (tested[number] == true)
            {
                AllAnswers();
                randomNumber();
            }
        }
        public void StepForward() // Done with this one, continue
        { tested[number] = true; }
        public override string ToString() // Default ToString
        {
            return "Romanji: " + roma[number] + ", Hiragana: " + hira[number] + ", Katakana: " + kata[number];
        }
        public string Romanji() // Romanji String
        {
            return roma[number];
        }
        public string Hiragana() // Hiragana String
        {
            return hira[number];
        }
        public string Katakana() // Katakana String
        {
            return kata[number];
        }
        public bool CheckAnswer(string Input) // Checks is inputed answer is correct
        {
            if (Input.ToLower() == roma[number])
            {
                tested[number] = true;
                return true;
            }
            else
            {
                return false;
            }

        }
        private void AllAnswers() // Checks if all possible kana have been answered
        {
            // Test each number to see if it has been tried
            int done = 0;
            for(int n=0; n < 46; n++)
            {
                if (tested[n] == true)
                { done++; }
            }
            // If all numbers have been tried, reset them
            if (done == 0)
            {
                for (int n = 0; n < 46; n++)
                {
                    tested[n] = false;
                }
            }
            // Otherwise all numbers have not been tried
        }
    }
}
