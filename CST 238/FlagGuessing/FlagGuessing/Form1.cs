using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlagGuessing
{
    public partial class Form1 : Form
    {
        private Image[] myFlags;
        private string[] countryNames;
        Random numbers = new Random();
        int[] randomnumbers2 = new int[3];
        int []choice_one = new int[3];
        int randomNumber;
        string Process1;
        int CurrentScores;
        int BestScores = 0;

        public Form1()
        {
            CurrentScores = 0;
            
            InitializeComponent();
            myFlags = new Image[10];
            countryNames = new string[10];

            choice_one[0] = 22;
            choice_one[1] = 22;
            choice_one[2] = 22;

            myFlags[0] = Properties.Resources.argentina;
            myFlags[1] = Properties.Resources.australia;
            myFlags[2] = Properties.Resources.brazil;
            myFlags[3] = Properties.Resources.canada;
            myFlags[4] = Properties.Resources.china;
            myFlags[5] = Properties.Resources.cuba;
            myFlags[6] = Properties.Resources.england;
            myFlags[7] = Properties.Resources.korea;
            myFlags[8] = Properties.Resources.nepal;
            myFlags[9] = Properties.Resources.usa;

            countryNames[0] = "Argentina";
            countryNames[1] = "Australia";
            countryNames[2] = "Brazil";
            countryNames[3] = "Canada";
            countryNames[4] = "China";
            countryNames[5] = "Cuba";
            countryNames[6] = "England";
            countryNames[7] = "Korea";
            countryNames[8] = "Nepal";
            countryNames[9] = "Usa";


            for (int i = 0; i < 3; i++)
            {
                randomnumbers2[i] = numbers.Next(0, 9);

                while (randomnumbers2[i] == choice_one[0] || randomnumbers2[i] == choice_one[1])
                {
                    randomnumbers2[i] = numbers.Next(0, 9);
                }

                choice_one[i] = randomnumbers2[i];
            }

            ChoiceOne.Text = countryNames[randomnumbers2[0]];
            ChoiceTwo.Text = countryNames[randomnumbers2[1]];
            ChoiceThree.Text = countryNames[randomnumbers2[2]];

            int[] numberz = new int[3] { randomnumbers2[0],randomnumbers2[1],randomnumbers2[2] };
            Random rd = new Random();
            int randomIndex = rd.Next(0, 3);
            randomNumber = numberz[randomIndex];

            pictureBox1.Image = myFlags[randomNumber];
            

            

        }


       

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void ChoiceTwo_Click(object sender, EventArgs e)
        {
            ShowResult.Text = "";
            Button b = (Button)sender;
            Process1 = b.Text;

            if (Process1 == countryNames[randomNumber])
            {
                CurrentScores++;
                CurrentScore.Text = CurrentScores.ToString();
                for (int i = 0; i < 3; i++)
                {
                    randomnumbers2[i] = numbers.Next(0, 9);

                    while (randomnumbers2[i] == choice_one[0] || randomnumbers2[i] == choice_one[1])
                    {
                        randomnumbers2[i] = numbers.Next(0, 9);
                    }
                    choice_one[i] = randomnumbers2[i];

                    ShowResult.Text += randomnumbers2[i];
                }

                ChoiceOne.Text = countryNames[randomnumbers2[0]];
                ChoiceTwo.Text = countryNames[randomnumbers2[1]];
                ChoiceThree.Text = countryNames[randomnumbers2[2]];

                int[] numberz = new int[3] { randomnumbers2[0], randomnumbers2[1], randomnumbers2[2] };
                Random rd = new Random();
                int randomIndex = rd.Next(0, 3);
                randomNumber = numberz[randomIndex];

                
                pictureBox1.Image = myFlags[randomNumber];

                ShowResult.ForeColor = System.Drawing.Color.Blue;
                ShowResult.Text = "Congratulation! You got it right";

                if (BestScores < CurrentScores)
                {
                    BestScores = CurrentScores;
                    BestScore.Text = CurrentScores.ToString ();
                    HighScore.ForeColor = System.Drawing.Color.Blue;
                    HighScore.Text = "New High Score!";
                }
            }
            else
            {
                HighScore.Text = "";
                if (BestScores < CurrentScores)
                {
                    BestScores = CurrentScores;
                    BestScore.Text = CurrentScores.ToString ();
                }

                if (Process1 != "Next Flag")
                {
                    ShowResult.ForeColor = System.Drawing.Color.Red;
                    ShowResult.Text = "Sorry! Try Again";
                }
                
                CurrentScores = 0;
                CurrentScore.Text = CurrentScores.ToString();

                for (int i = 0; i < 3; i++)
                {
                    randomnumbers2[i] = numbers.Next(0, 9);

                    while (randomnumbers2[i] == choice_one[0] || randomnumbers2[i] == choice_one[1])
                    {
                        randomnumbers2[i] = numbers.Next(0, 9);
                    }
                    choice_one[i] = randomnumbers2[i];
                    

                }

                ChoiceOne.Text = countryNames[randomnumbers2[0]];
                ChoiceTwo.Text = countryNames[randomnumbers2[1]];
                ChoiceThree.Text = countryNames[randomnumbers2[2]];

                int[] numberz = new int[3] { randomnumbers2[0], randomnumbers2[1], randomnumbers2[2] };
                Random rd = new Random();
                int randomIndex = rd.Next(0, 3);
                randomNumber = numberz[randomIndex];

                pictureBox1.Image = myFlags[randomNumber];
                


            }

        }

        private void CurrentScore_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
