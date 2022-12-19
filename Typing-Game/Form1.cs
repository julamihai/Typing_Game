using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Typing_Game
{
    public partial class Form1 : Form
    {
        
        string[] words = {"programming", "coding", "interfaces", "objects", "internet", "wi-fi", "banana", 
            "orange", "bowling", "football", "jupiter" , "informatics"};
        Random rnd = new Random();
        int correct = 0;
        int incorrect = 0;
        int lifescore = 3;
        public Form1()
        {
            InitializeComponent();
            lblword.Text = words[rnd.Next(0, words.Length)]; 
        }

        private void checkGame(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (textBox1.Text == lblword.Text)
                {
                    correct++;
                    lblword.Text = words[rnd.Next(0, words.Length)];
                    textBox1.Text = null;
                }
                else 
                {
                    incorrect++;
                    lifescore--;
                    lblword.Text = words[rnd.Next(0, words.Length)];
                    textBox1.Text = null;
                }
               
                if (lifescore == 0)
                {
                    lbllifescore.Text = "LIFE SCORE:" + lifescore;
                    lblwrong.Text = "INCORRECT:" + incorrect;
                    MessageBox.Show("You lost the game. Try again!");
                }

                lblright.Text = "CORRECT:" + correct;
                lblwrong.Text = "INCORRECT:" + incorrect;
                lbllifescore.Text = "LIFE SCORE:" + lifescore;
            }   
        }

        //Restart from 0 all the components
        public void Restart()
        {
            lblword.Text = words[rnd.Next(0, words.Length)];
            textBox1.Text = null;
            correct = 0;
            incorrect = 0;
            lifescore = 3;
            lblright.Text = "CORRECT:" + correct;
            lblwrong.Text = "INCORRECT:" + incorrect;
            lbllifescore.Text = "LIFE SCORE:" + lifescore;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Restart();
        }
    }
}
