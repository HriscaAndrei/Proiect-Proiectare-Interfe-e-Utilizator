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
    public partial class Geografie : Form
    {
        int counter = 0;
        int scor = 0;
        public Geografie()
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
            label3.Text = "Ce tara europeana este de fapt o peninsula in forma de cizma inconjurata de patru mari?";
            radioButton1.Text = "Norvegia";
            radioButton2.Text = "Suedia";
            radioButton3.Text = "Italia";
            radioButton4.Text = "Grecia";
        }
        private void Intrebarea2()
        {
            label3.Text = "Ce tara este separata geografic de Europa continentala de Muntii Pirinei?";
            radioButton1.Text = "Franta";
            radioButton2.Text = "Spania";
            radioButton3.Text = "Italia";
            radioButton4.Text = "Croatia";
        }
        private void Intrebarea3()
        {
            label3.Text = "Care este cel mai lung rau european?";
            radioButton1.Text = "Rin";
            radioButton2.Text = "Loire";
            radioButton3.Text = "Thames";
            radioButton4.Text = "Volga";
        }
        private void Intrebarea4()
        {
            label3.Text = "Ce tara europeana este inconjurata de Slovacia, Ucraina, Romania, Serbia, Croatia, Slovenia si Austria?";
            radioButton1.Text = "Ungaria";
            radioButton2.Text = "Bulgaria";
            radioButton3.Text = "Rusia";
            radioButton4.Text = "Franta";
        }
        private void Intrebarea5()
        {
            label3.Text = "In cate state este azi impartita Germania?";
            radioButton1.Text = "8";
            radioButton2.Text = "16";
            radioButton3.Text = "24";
            radioButton4.Text = "32";
        }
        private void Intrebarea6()
        {
            label3.Text = "Polonia se afla in sudul carei mari?";
            radioButton1.Text = "Egee";
            radioButton2.Text = "Neagra";
            radioButton3.Text = "Norvegiana";
            radioButton4.Text = "Baltica";
        }
        private void Intrebarea7()
        {
            label3.Text = "Ce rau izvoraste din Muntii Padurea Neagra din Germania si se varsa in Marea Neagra?";
            radioButton1.Text = "Sena";
            radioButton2.Text = "Oder";
            radioButton3.Text = "Dunarea";
            radioButton4.Text = "Elba";
        }
        private void Intrebarea8()
        {
            label3.Text = "Care este capitala Lituaniei?";
            radioButton1.Text = "Valmiera";
            radioButton2.Text = "Taurage";
            radioButton3.Text = "Vilnius";
            radioButton4.Text = "Riga";
        }
        private void Intrebarea9()
        {
            label3.Text = "Care este tara cu cea mai mare densitate de populatie?";
            radioButton1.Text = "Andorra";
            radioButton2.Text = "Liechtenstein";
            radioButton3.Text = "Croatia";
            radioButton4.Text = "Elvetia";
        }
        private void Intrebarea10()
        {
            label3.Text = "Care este cel mai inalt munte al Europei?";
            radioButton1.Text = "Elbrus";
            radioButton2.Text = "Corno";
            radioButton3.Text = "Blanc";
            radioButton4.Text = "Olympus";
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
            if (button3.Text == "7" && radioButton3.Checked == true)
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
