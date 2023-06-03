using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trivia
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            QuestionSetup();
            reset();
        }

        string[] questions = { "1. In 1768, Captain James Cook set out to explore which ocean?", "2.What is actually electricity ?", " 3.Which of the following is not an international organisation ?" };
        string[,] answers = { { "Pacific Ocean","Atlantic Ocean", "Indian Ocean","Arctic Ocean" },
                              {"A flow of water","A flow of air","A flow of electrons","A flow of atoms" },
                              {"FIFA","NATO","ASEAN", "FBI"} };

        string[] correct_answers = { "Pacific Ocean", "A flow of electrons", "FBI" };
        int i = 0, j = 0;
        int Question_number = 3;
        Random rnd = new Random();
        int aux;

        void QuestionSetup()
        {
            if( i < Question_number)
            {
                aux = rnd.Next(0, 4);
                label1.Text = questions[i];
                button1.Text = answers[i, Math.Abs(aux)];
                Aux();
                button2.Text = answers[i, Math.Abs(aux)];
                Aux();
                button3.Text = answers[i, Math.Abs(aux)];
                Aux();
                button4.Text = answers[i, Math.Abs(aux)];
            }
        }

        void Aux()
        {
            if (aux == 3)
            {
                aux = 0;
            }
            
            else aux++;
           
        }

        void reset()
        {
            button1.BackColor = Color.White;
            button2.BackColor = Color.White;
            button3.BackColor = Color.White;
            button4.BackColor = Color.White;
        }

        void pass()
        {
            this.Hide();
            Form3 form3 = new Form3();
            form3.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == correct_answers[i])
            {
                
                i++;
                progressBar1.Value = i * 100 / Question_number;
                if (i < Question_number)
                {
                    QuestionSetup();
                }
                else
                {
                    pass();
                }
                reset();
            }
            else
            {
                button1.BackColor = Color.Red;
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (button2.Text == correct_answers[i])
            {
                i++;
                progressBar1.Value = i * 100 / Question_number;
                if (i < Question_number)
                {
                    QuestionSetup();
                }
                else
                {
                    pass();
                }
                reset();
            }
            else
            {
                button2.BackColor = Color.Red;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button3.Text == correct_answers[i])
            {
                i++;
                progressBar1.Value = i * 100 / Question_number;
                if (i < Question_number)
                {
                    QuestionSetup();
                }
                else
                {
                    pass();
                }
                reset();
            }
            else
            {
                button3.BackColor = Color.Red;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button4.Text == correct_answers[i])
            {
                i++;
                progressBar1.Value = i * 100 / Question_number;
                if (i < Question_number)
                {
                    QuestionSetup();
                }
                else
                {
                    pass();
                }
                reset();
            }
            else
            {
                button4.BackColor = Color.Red;
            }
        }

        
    }
}
