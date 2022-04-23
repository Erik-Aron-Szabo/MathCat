using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MathCat
{
    public partial class Form1 : Form
    {

        // Create random object --> "randomizer"
        // to generate random numbers.
        Random randomizer = new Random();

        int leftNum1;
        int rigtNum1;

        int leftNum2;
        int rigtNum2;

        int leftNum3;
        int rigtNum3;

        int leftNum4;
        int rigtNum4;

        int leftNum5;
        int rigtNum5;

        int leftNum6;
        int rigtNum6;

        int leftNum7;
        int rigtNum7;

        int leftNum8;
        int rigtNum8;

        int leftNum9;
        int rigtNum9;

        int leftNum10;
        int rigtNum10;


        int timeLeft;



        public void StartQuiz()
        {
            leftNum1 = randomizer.Next(1, 10);
            rigtNum1 = randomizer.Next(1, 10);
            leftLabel1.Text = leftNum1.ToString();
            rightLabel1.Text = rigtNum1.ToString();
            answer1.Value = 0;


            leftNum2 = randomizer.Next(1, 10);
            rigtNum2 = randomizer.Next(1, 10);
            leftLabel2.Text = leftNum2.ToString();
            rightLabel2.Text = rigtNum2.ToString();
            answer2.Value = 0;


            leftNum3 = randomizer.Next(1, 10);
            rigtNum3 = randomizer.Next(1, 10);
            leftLabel3.Text = leftNum3.ToString();
            rightLabel3.Text = rigtNum3.ToString();
            answer3.Value = 0;


            leftNum4 = randomizer.Next(1, 10);
            rigtNum4 = randomizer.Next(1, 10);
            leftLabel4.Text = leftNum4.ToString();
            rightLabel4.Text = rigtNum4.ToString();
            answer4.Value = 0;


            leftNum5 = randomizer.Next(1, 10);
            rigtNum5 = randomizer.Next(1, 10);
            leftLabel5.Text = leftNum5.ToString();
            rightLabel5.Text = rigtNum5.ToString();
            answer5.Value = 0;


            leftNum6 = randomizer.Next(1, 10);
            rigtNum6 = randomizer.Next(1, 10);
            leftLabel6.Text = leftNum6.ToString();
            rightLabel6.Text = rigtNum6.ToString();
            answer6.Value = 0;


            leftNum7 = randomizer.Next(1, 10);
            rigtNum7 = randomizer.Next(1, 10);
            leftLabel7.Text = leftNum7.ToString();
            rightLabel7.Text = rigtNum7.ToString();
            answer7.Value = 0;


            leftNum8 = randomizer.Next(1, 10);
            rigtNum8 = randomizer.Next(1, 10);
            leftLabel8.Text = leftNum8.ToString();
            rightLabel8.Text = rigtNum8.ToString();
            answer8.Value = 0;


            leftNum9 = randomizer.Next(1, 10);
            rigtNum9 = randomizer.Next(1, 10);
            leftLabel9.Text = leftNum9.ToString();
            rightLabel9.Text = rigtNum9.ToString();
            answer9.Value = 0;


            leftNum10 = randomizer.Next(1, 10);
            rigtNum10 = randomizer.Next(1, 10);
            leftLabel10.Text = leftNum10.ToString();
            rightLabel10.Text = rigtNum10.ToString();
            answer10.Value = 0;

            // ====================================


            // ===========================

            timeLeft = 60;
            timeLabel.Text = "60 seconds";
            timer1.Start();

        }



        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Checks the answer 
        /// </summary>
        /// <returns>True if the answer's correct, else false.</returns>
        private bool CheckAnswer()
        {
            if (
                (leftNum1 * rigtNum1 == answer1.Value) &&
                (leftNum2 * rigtNum2 == answer2.Value) &&
                (leftNum3 * rigtNum3 == answer3.Value) &&
                (leftNum4 * rigtNum4 == answer4.Value) &&
                (leftNum5 * rigtNum5 == answer5.Value) &&
                (leftNum6 * rigtNum6 == answer6.Value) &&
                (leftNum7 * rigtNum7 == answer7.Value) &&
                (leftNum8 * rigtNum8 == answer8.Value) &&
                (leftNum9 * rigtNum9 == answer9.Value) &&
                (leftNum10 * rigtNum10 == answer10.Value)
                )
                return true;
            else
                return false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void startButton_Click(object sender, EventArgs e)
        {
            StartQuiz();
            startButton.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (CheckAnswer())
            {
                timer1.Stop();
                MessageBox.Show("Ügyes vagy Cat! Mindet eltaláltad!");
                startButton.Enabled = true;
            }
            else if (timeLeft > 0)
            {
                timeLeft = timeLeft - 1;
                timeLabel.Text = timeLeft + " seconds";
            } 
            else
            {
                timer1.Stop();
                timeLabel.Text = "Vége!";
                MessageBox.Show("Próbáld újra, kedves Cat!", "Sikerülni fog!! ^_^");
                answer1.Value = leftNum1 + rigtNum1;
                answer2.Value = leftNum2 + rigtNum2;
                answer3.Value = leftNum3 + rigtNum3;
                answer4.Value = leftNum4 + rigtNum4;
                answer5.Value = leftNum5 + rigtNum5;
                answer6.Value = leftNum6 + rigtNum6;
                answer7.Value = leftNum7 + rigtNum7;
                answer8.Value = leftNum8 + rigtNum8;
                answer9.Value = leftNum9 + rigtNum9;
                answer10.Value = leftNum10 + rigtNum10;
                startButton.Enabled = true;
            }
        }
    }
}
