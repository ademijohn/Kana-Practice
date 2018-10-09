using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KanaPractice
{
    public partial class Form1 : Form
    {
        Boolean hiragana = true;
        string message = "";
        string answer = "";
        int right = 0;
        int wrong = 0;
        Kana kana = new Kana();

        public Form1()
        {
            InitializeComponent();
            AcceptButton = guessbutton;
            DialogResult result1 = MessageBox.Show("Would you like to study Hiragana or Katakana? " +
                "Press Yes for Hiragana and No for Katakana","", MessageBoxButtons.YesNo);
            if (result1 == DialogResult.Yes)
            {
                hiragana = true;
                hiraganaButton.Checked = true;
                katakanabutton.Checked = false;
            }
            else
            {
                hiragana = false;
                hiraganaButton.Checked = false;
                katakanabutton.Checked = true;
            }
            kana.randomNumber();
            maintextbox.Text = MainText();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        //public void guess()
        //{
        //    String[] kana = new string[46] {"a",  "i",   "u",   "e",  "o",
        //                                    "ka", "ki",  "ku",  "ke", "ko",
        //                                    "sa", "shi", "su",  "se", "so",
        //                                    "ta", "chi", "tsu", "te", "to",
        //                                    "na", "ni",  "nu",  "ne", "no",
        //                                    "ha", "hi",  "fu",  "he", "ho",
        //                                    "ma", "mi",  "mu",  "me", "mo",
        //                                    "ya",        "yu",        "yo",
        //                                    "ra", "ri",  "ru",  "re", "ro",
        //                                    "wa",                     "wo", "n"};
        //    String[] hira = new string[46] {"あ","い","う","え","お",
        //                                    "か","き","く","け","こ",
        //                                    "さ","し","す","せ","そ",
        //                                    "た","ち","つ","て","と",
        //                                    "な","に","ぬ","ね","の",
        //                                    "は","ひ","ふ","へ","ほ",
        //                                    "ま","み","む","め","も",
        //                                    "や",     "ゆ",     "よ",
        //                                    "ら","り","る","れ","ろ",
        //                                    "わ",               "を","ん"};
        //    String[] kata = new string[46] {"ア","イ","ウ","エ","オ",
        //                                    "カ","キ","ク","ケ","コ",
        //                                    "サ","シ","ス","セ","ソ",
        //                                    "タ","チ","ツ","テ","ト",
        //                                    "ナ","ニ","ヌ","ネ","ノ",
        //                                    "ハ","ヒ","フ","ヘ","ホ",
        //                                    "マ","ミ","ム","メ","モ",
        //                                    "ヤ",     "ユ",     "ヨ",
        //                                    "ラ","リ","ル","レ","ロ",
        //                                    "ワ",               "ヲ","ン"};
        //    Random random = new Random();
        //    int randomNumber = random.Next(0, 45);
        //    answer = kana[randomNumber];

        //    if (hiragana == true)
        //    { maintextbox.Text = ("What sound does " + hira[randomNumber] + " make?"); }

        //    if (hiragana == false)
        //    { maintextbox.Text = ("What sound does " + kata[randomNumber] + " make?"); }

        //}

        private string MainText()
        {
            string output = "";
            if (hiragana == true)
            { output = "What sound does " + kana.Hiragana() + " make?"; }

            if (hiragana == false)
            { output = "What sound does " + kana.Katakana() + " make?"; }

            return output;
        }

        private void exitbutton_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void guessbutton_Click(object sender, EventArgs e)
        {
            message = entrytextbox.Text.ToLower();
            entrytextbox.Text = "";

            if (kana.CheckAnswer(message) == true)
            {
                MessageBox.Show("Great Job!");
                right = right + 1;
            }
            else
            {
                MessageBox.Show("Sorry, that's not correct." + Environment.NewLine + "The correct answer is " + kana.Romanji().ToUpper());
                wrong = wrong + 1;
            }

            resultlabel.Text = ("Right Answers: " + right + "    Wrong Answers: " + wrong);

            //guess();

            kana.StepForward();
            kana.randomNumber();
            maintextbox.Text = MainText();
        }

        private void hiraganaButton_CheckedChanged(object sender, EventArgs e)
        {
            hiragana = true;
        }

        private void katakanabutton_CheckedChanged(object sender, EventArgs e)
        {
            hiragana = false;
        }
    }
}
