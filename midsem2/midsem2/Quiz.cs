using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace midsem2
{
    public partial class Quiz : Form
    {
        int correctanswer;
        int questionnumber = 1;
        int score;
        int percentage;
        int totalquestions;

        public Quiz()
        {
            InitializeComponent();
            askquestion(questionnumber);
            totalquestions = 5;
        }

        private void AnswerEvent(object sender, EventArgs e)
        {
            var senderobject = (Button)sender;
            int buttontag = Convert.ToInt32(senderobject.Tag);
            if(buttontag==correctanswer)
            {
                score++;
            }
            if (questionnumber==totalquestions)
            {
               string  s = score.ToString();
                MessageBox.Show("your test over");
                report r = new report();
                r.getscore(score);
                this.Close();


            }

            questionnumber++;
            askquestion(questionnumber);

        }

        private void askquestion(int qnum)
        {
            switch(qnum)
            {
                case 1:
                    label1.Text = "What is the maximum possible length of an identifier?";
                    button1.Text = "16";
                    button2.Text = "32";
                    button3.Text = "64";
                    button4.Text = "none of these above";
                    correctanswer = 4;
                    break;
                case 2:
                    label1.Text = " Who developed the Python language?";
                    button1.Text = "Zim Den";
                    button2.Text = "Guido van Rossum";
                    button3.Text = "Niene Stom";
                    button4.Text = "Wick van Rossum";
                    correctanswer = 2;
                    break;
                case 3:
                    label1.Text = "Which of the following statements is correct regarding the object-oriented programming concept in Python?";
                    button1.Text = "Classes are real-world entities while objects are not real";
                    button2.Text = "Objects are real-world entities while classes are not real";
                    button3.Text = "Both objects and classes are real-world entities";
                    button4.Text = "all of the above";
                    correctanswer = 2;
                    break;
                case 4:
                    label1.Text = "Which of the following declarations is incorrect?";
                    button1.Text = "_x = 2";
                    button2.Text = "__x = 3";
                    button3.Text = "__xyz__ = 5";
                    button4.Text = "none of these above";
                    correctanswer = 4;
                    break;
                case 5:
                    label1.Text = "Which of the following is not a keyword in Python language?";
                    button1.Text = "val";
                    button2.Text = "raise";
                    button3.Text = "try";
                    button4.Text = "with";
                    correctanswer = 1;
                    break;

            }
        }
    }
}
