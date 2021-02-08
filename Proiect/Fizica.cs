using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect
{
    public partial class Fizica : Form

    {
        int counter = 0;
        int scor = 0;
        public Fizica() 
        {
            InitializeComponent();
            radioButton1.Visible = false;
            radioButton2.Visible = false;
            radioButton3.Visible = false;
            radioButton4.Visible = false;
            label2.Text = Convert.ToString(scor);
        }
        private void Form3_Load(object sender, EventArgs e)
        {
            button1.Text = "START";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
        }
        private void Intrebarea1()
        {
            label3.Text = "Ce nume poarta unitatea de masura a puterii?";
            radioButton1.Text = "Newton";
            radioButton2.Text = "Joule";
            radioButton3.Text = "Watt";
            radioButton4.Text = "Volt";
        }
        private void Intrebarea2()
        {
            label3.Text = "Ce simt stimuleaza sunetul?";
            radioButton1.Text = "vazul";
            radioButton2.Text = "auzul";
            radioButton3.Text = "mirosul";
            radioButton4.Text = "gustul";
        }
        private void Intrebarea3()
        {
            label3.Text = " Radiaţiile X sunt radiaţii: ";
            radioButton1.Text = "electrice";
            radioButton2.Text = "mecanice";
            radioButton3.Text = "termice";
            radioButton4.Text = "electromagnetice";
        }
        private void Intrebarea4()
        {
            label3.Text = "O lentilă convergentă poate fi: ";
            radioButton1.Text = "biconvexă";
            radioButton2.Text = "biconcavă";
            radioButton3.Text = "plan-concavă";
            radioButton4.Text = "nu are o forma stabilită";
        }
        private void Intrebarea5()
        {
            label3.Text = " Unitatea de măsură pentru rezistivitatea electrică este:";
            radioButton1.Text = "m/Ω";
            radioButton2.Text = "Ω*m";
            radioButton3.Text = "Ω/m";
            radioButton4.Text = "Ω";
        }
        private void Intrebarea6()
        {
            label3.Text = "Unitatea de masura a tensiunii electrice este: ";
            radioButton1.Text = "m";
            radioButton2.Text = "N";
            radioButton3.Text = "A";
            radioButton4.Text = "V";
        }
        private void Intrebarea7()
        {
            label3.Text = "In intervalul de temperatura 0°C - 4°C volumul apei:";
            radioButton1.Text = "Nu se modifica";
            radioButton2.Text = "Scade";
            radioButton3.Text = "Creste";
            radioButton4.Text = "Creste foarte mult";
        }
        private void Intrebarea8()
        {
            label3.Text = "Intre corpuri incarcate electric cu sarcini electrice de acelasi semn se manifesta:";
            radioButton1.Text = "Interactiuni de atractie";
            radioButton2.Text = "Interactiuni de atractie si de respingere";
            radioButton3.Text = "Interactiuni de respingere";
            radioButton4.Text = "Nu se manifesta interactiuni";
        }
        private void Intrebarea9()
        {
            label3.Text = "Forta de interactiune nu depinde de:";
            radioButton1.Text = "Masa corpurilor";
            radioButton2.Text = "Distanta dintre corpuri";
            radioButton3.Text = "Sarcinile corpurilor";
            radioButton4.Text = "Mediul in care se afla corpurile";
        }
        private void Intrebarea10()
        {
            label3.Text = "O baterie are notatia 9V. Ce reprezinta acesta valoare:";
            radioButton1.Text = "Tensiunea electromotoare";
            radioButton2.Text = "Intensitatea curentului electric";
            radioButton3.Text = "Tensiunea electrica";
            radioButton4.Text = "Tensiunea nominala";
        }
        private void Final()
        {
            label3.Text = "Nota obtinuta este: " + Convert.ToString(scor);
            label3.Size = new Size(200, 128);
            label3.Font = new Font("Arial", 25);
            label3.AutoSize = false;
            radioButton1.Visible = false;
            radioButton2.Visible = false;
            radioButton3.Visible = false;
            radioButton4.Visible = false;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;

            radioButton1.Visible = true;
            radioButton2.Visible = true;
            radioButton3.Visible = true;
            radioButton4.Visible = true;


            counter = counter + 1;

            {
                switch (counter)
                {

                    case 1:

                        Intrebarea1();

                        button1.Text = "Next";
                        button1.Enabled = true;
                        button3.Text = Convert.ToString(counter);

                        button1.ForeColor = Color.Black;
                        radioButton1.Checked = false;
                        radioButton2.Checked = false;
                        radioButton3.Checked = false;
                        radioButton4.Checked = false;

                        break;
                    case 2:
                        Intrebarea2();
                        button1.Text = "Next";
                        button1.Enabled = true;
                        button3.Text = Convert.ToString(counter);

                        radioButton1.Checked = false;
                        radioButton2.Checked = false;
                        radioButton3.Checked = false;
                        radioButton4.Checked = false;

                        break;
                    case 3:
                        Intrebarea3();
                        button1.Text = "Next";
                        button1.Enabled = true;
                        button3.Text = Convert.ToString(counter);

                        radioButton1.Checked = false;
                        radioButton2.Checked = false;
                        radioButton3.Checked = false;
                        radioButton4.Checked = false;

                        break;
                    case 4:
                        Intrebarea4();
                        button1.Text = "Next";
                        button1.Enabled = true;
                        button3.Text = Convert.ToString(counter);

                        radioButton1.Checked = false;
                        radioButton2.Checked = false;
                        radioButton3.Checked = false;
                        radioButton4.Checked = false;

                        break;
                    case 5:
                        Intrebarea5();
                        button1.Text = "Next";
                        button1.Enabled = true;
                        button3.Text = Convert.ToString(counter);

                        radioButton1.Checked = false;
                        radioButton2.Checked = false;
                        radioButton3.Checked = false;
                        radioButton4.Checked = false;

                        break;
                    case 6:
                        Intrebarea6();
                        button1.Text = "Next";
                        button1.Enabled = true;
                        button3.Text = Convert.ToString(counter);

                        radioButton1.Checked = false;
                        radioButton2.Checked = false;
                        radioButton3.Checked = false;
                        radioButton4.Checked = false;

                        break;
                    case 7:
                        Intrebarea7();
                        button1.Text = "Next";
                        button1.Enabled = true;
                        button3.Text = Convert.ToString(counter);

                        radioButton1.Checked = false;
                        radioButton2.Checked = false;
                        radioButton3.Checked = false;
                        radioButton4.Checked = false;

                        break;
                    case 8:
                        Intrebarea8();
                        button1.Text = "Next";
                        button1.Enabled = true;
                        button3.Text = Convert.ToString(counter);

                        radioButton1.Checked = false;
                        radioButton2.Checked = false;
                        radioButton3.Checked = false;
                        radioButton4.Checked = false;

                        break;
                    case 9:
                        Intrebarea9();
                        button1.Text = "Next";
                        button1.Enabled = true;
                        button3.Text = Convert.ToString(counter);

                        radioButton1.Checked = false;
                        radioButton2.Checked = false;
                        radioButton3.Checked = false;
                        radioButton4.Checked = false;

                        break;
                    case 10:
                        Intrebarea10();
                        button1.Text = "Finish";
                        button1.Enabled = true;
                        button3.Text = Convert.ToString(counter);

                        radioButton1.Checked = false;
                        radioButton2.Checked = false;
                        radioButton3.Checked = false;
                        radioButton4.Checked = false;

                        break;

                    case 11:
                        Final();
                        button2.Text = "Return";
                        radioButton1.Checked = false;
                        radioButton2.Checked = false;
                        radioButton3.Checked = false;
                        radioButton4.Checked = false;
                        break;
                    case 12:
                        Form1 f1 = new Form1();
                        this.Close();
                        f1.Show();
                        break;
                }
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f3 = new Form1();
            f3.Show();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (button3.Text == "2" && radioButton2.Checked == true)
            {
                scor += 1;
                label2.Text = Convert.ToString(scor);
                button3.Enabled = true;
            }
            if (button3.Text == "5" && radioButton2.Checked == true)
            {
                scor += 1;
                label2.Text = Convert.ToString(scor);
                button3.Enabled = true;
            }
            if (button3.Text == "7" && radioButton3.Checked == true)
            {
                scor += 1;
                label2.Text = Convert.ToString(scor);
                button3.Enabled = true;
            }

        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (button3.Text == "4" && radioButton1.Checked == true)
            {
                scor += 1;
                label2.Text = Convert.ToString(scor);
                button3.Enabled = true;
            }
            if (button3.Text == "9" && radioButton1.Checked == true)
            {
                scor += 1;
                label2.Text = Convert.ToString(scor);
                button3.Enabled = true;
            }
            if (button3.Text == "10" && radioButton1.Checked == true)
            {
                scor += 1;
                label2.Text = Convert.ToString(scor);
                button3.Enabled = true;
            }

        }
        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (button3.Text == "1" && radioButton3.Checked == true)
            {
                scor += 1;
                label2.Text = Convert.ToString(scor);
                button3.Enabled = true;
            }
            if (button3.Text == "8" && radioButton3.Checked == true)
            {
                scor += 1;
                label2.Text = Convert.ToString(scor);
                button3.Enabled = true;
            }
        }
        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (button3.Text == "3" && radioButton4.Checked == true)
            {
                scor += 1;
                label2.Text = Convert.ToString(scor);
                button3.Enabled = true;
            }
            if (button3.Text == "6" && radioButton4.Checked == true)
            {
                scor += 1;
                label2.Text = Convert.ToString(scor);
                button3.Enabled = true;
            }
        }
    }
}
