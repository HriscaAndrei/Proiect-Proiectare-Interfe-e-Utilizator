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
    public partial class Chimie : Form
    {
        int counter = 0;
        int scor = 0;
        public Chimie()
        {
            InitializeComponent();
            radioButton1.Visible = false;
            radioButton2.Visible = false;
            radioButton3.Visible = false;
            radioButton4.Visible = false;
            label3.Text = Convert.ToString(scor);

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            button2.Text = "START";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
        }
        private void Intrebarea1()
        {
            label1.Text = "Care este formula chimica a apei?";
            radioButton1.Text = "H2S";
            radioButton2.Text = "H2O";
            radioButton3.Text = "H2SO4";
            radioButton4.Text = "H2CO3";
        }
        private void Intrebarea2()
        {
            label1.Text = " O hidrocarbura contine urmatoarele elemente:";
            radioButton1.Text = "carbon si oxigen";
            radioButton2.Text = "calciu si hidrogen";
            radioButton3.Text = "hidrogen si oxigen";
            radioButton4.Text = "carbon si hidrogen";

        }
        private void Intrebarea3()
        {
            label1.Text = " Din punct de vedere electric un atom este:";
            radioButton1.Text = "neutru";
            radioButton2.Text = "pozitiv";
            radioButton3.Text = "negativ";
            radioButton4.Text = "niciuna din variante";

        }
        private void Intrebarea4()
        {
            label1.Text = "  Sarea de bucătărie este………………..în ulei.";
            radioButton1.Text = "solubilă";
            radioButton2.Text = "insolubilă";
            radioButton3.Text = "dizolvată";
            radioButton4.Text = "nedizolvată";

        }
        private void Intrebarea5()
        {
            label1.Text = "  Alegeţi formula corectă a acidului clorhidric:";
            radioButton1.Text = "HCl";
            radioButton2.Text = " H2SO4";
            radioButton3.Text = "HNO3";
            radioButton4.Text = "ZnCl2";

        }
        private void Intrebarea6()
        {
            label1.Text = "  O soluţie . . . .  are pH-ul mai mic decât 7.";
            radioButton1.Text = "acidă";
            radioButton2.Text = "bazică";
            radioButton3.Text = "neutră";
            radioButton4.Text = "niciuna din variante";

        }
        private void Intrebarea7()
        {
            label1.Text = "Energia de ionizare este energia consumată la ........ de electroni. ";
            radioButton1.Text = "acceptarea";
            radioButton2.Text = "acceptarea şi cedarea";
            radioButton3.Text = "cedarea";
            radioButton4.Text = "niciuna din variante";
        }
        private void Intrebarea8()
        {
            label1.Text = "Hidroxidul de calciu (Ca(OH)2) este:";
            radioButton1.Text = "acid";
            radioButton2.Text = "sare";
            radioButton3.Text = "oxid";
            radioButton4.Text = "bază";

        }
        private void Intrebarea9()
        {
            label1.Text = "Solubilitatea gazelor în solvenţi lichizi scade cu......temperaturii:";
            radioButton1.Text = "menţinerea constantă";
            radioButton2.Text = "scăderea";
            radioButton3.Text = "creşterea";
            radioButton4.Text = "niciuna din variante";

        }
        private void Intrebarea10()
        {
            label1.Text = "Substanţele ionice sunt bune conductoare de electricitate în stare ..........";
            radioButton1.Text = "solidă";
            radioButton2.Text = "de topitură sau soluţie";
            radioButton3.Text = "gazoasă";
            radioButton4.Text = "lichidă";

        }
        private void Final()
        {
            label1.Text = "Nota obtinuta este: " + Convert.ToString(scor);
            label1.Size = new Size(200, 128);
            label1.Font = new Font("Arial", 25 );
            label1.AutoSize = false;
            radioButton1.Visible = false;
            radioButton2.Visible = false;
            radioButton3.Visible = false;
            radioButton4.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
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
                        button2.Text = "Next";
                        button2.Enabled = true;
                        button4.Text = Convert.ToString(counter);

                        button2.ForeColor = Color.Black;
                        radioButton1.Checked = false;
                        radioButton2.Checked = false;
                        radioButton3.Checked = false;
                        radioButton4.Checked = false;

                        break;
                    case 2:
                        Intrebarea2();
                        button2.Text = "Next";
                        button2.Enabled = true;
                        button4.Text = Convert.ToString(counter);

                        radioButton1.Checked = false;
                        radioButton2.Checked = false;
                        radioButton3.Checked = false;
                        radioButton4.Checked = false;

                        break;
                    case 3:
                        Intrebarea3();
                        button2.Text = "Next";
                        button2.Enabled = true;
                        button4.Text = Convert.ToString(counter);

                        radioButton1.Checked = false;
                        radioButton2.Checked = false;
                        radioButton3.Checked = false;
                        radioButton4.Checked = false;

                        break;
                    case 4:
                        Intrebarea4();
                        button2.Text = "Next";
                        button2.Enabled = true;
                        button4.Text = Convert.ToString(counter);

                        radioButton1.Checked = false;
                        radioButton2.Checked = false;
                        radioButton3.Checked = false;
                        radioButton4.Checked = false;

                        break;
                    case 5:
                        Intrebarea5();
                        button2.Text = "Next";
                        button2.Enabled = true;
                        button4.Text = Convert.ToString(counter);

                        radioButton1.Checked = false;
                        radioButton2.Checked = false;
                        radioButton3.Checked = false;
                        radioButton4.Checked = false;

                        break;
                    case 6:
                        Intrebarea6();
                        button2.Text = "Next";
                        button2.Enabled = true;
                        button4.Text = Convert.ToString(counter);

                        radioButton1.Checked = false;
                        radioButton2.Checked = false;
                        radioButton3.Checked = false;
                        radioButton4.Checked = false;

                        break;
                    case 7:
                        Intrebarea7();
                        button2.Text = "Next";
                        button2.Enabled = true;
                        button4.Text = Convert.ToString(counter);

                        radioButton1.Checked = false;
                        radioButton2.Checked = false;
                        radioButton3.Checked = false;
                        radioButton4.Checked = false;

                        break;
                    case 8:
                        Intrebarea8();
                        button2.Text = "Next";
                        button2.Enabled = true;
                        button4.Text = Convert.ToString(counter);

                        radioButton1.Checked = false;
                        radioButton2.Checked = false;
                        radioButton3.Checked = false;
                        radioButton4.Checked = false;

                        break;
                    case 9:
                        Intrebarea9();
                        button2.Text = "Next";
                        button2.Enabled = true;
                        button4.Text = Convert.ToString(counter);

                        radioButton1.Checked = false;
                        radioButton2.Checked = false;
                        radioButton3.Checked = false;
                        radioButton4.Checked = false;

                        break;
                    case 10:
                        Intrebarea10();
                        button2.Text = "Finish";
                        button2.Enabled = true;
                        button4.Text = Convert.ToString(counter);

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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f2 = new Form1();
            f2.Show();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (button4.Text == "1" && radioButton2.Checked == true)
            {
                scor += 1;
                label3.Text = Convert.ToString(scor);
                button4.Enabled = true;
            }
            if (button4.Text == "4" && radioButton2.Checked == true)
            {
                scor += 1;
                label3.Text = Convert.ToString(scor);
                button4.Enabled = true;
            }
            if (button4.Text == "10" && radioButton2.Checked == true)
            {
                scor += 1;
                label3.Text = Convert.ToString(scor);
                button4.Enabled = true;
            }

        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (button4.Text == "3" && radioButton1.Checked == true)
            {
                scor += 1;
                label3.Text = Convert.ToString(scor);
                button4.Enabled = true;
            }
            if (button4.Text == "5" && radioButton1.Checked == true)
            {
                scor += 1;
                label3.Text = Convert.ToString(scor);
                button4.Enabled = true;
            }
            if (button4.Text == "6" && radioButton1.Checked == true)
            {
                scor += 1;
                label3.Text = Convert.ToString(scor);
                button4.Enabled = true;
            }

        }
        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (button4.Text == "3" && radioButton3.Checked == true)
            {
                scor += 1;
                label3.Text = Convert.ToString(scor);
                button4.Enabled = true;
            }
            if (button4.Text == "7" && radioButton3.Checked == true)
            {
                scor += 1;
                label3.Text = Convert.ToString(scor);
                button4.Enabled = true;
            }
            if (button4.Text == "9" && radioButton3.Checked == true)
            {
                scor += 1;
                label3.Text = Convert.ToString(scor);
                button4.Enabled = true;
            }
        }
        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (button4.Text == "2" && radioButton4.Checked == true)
            {
                scor += 1;
                label3.Text = Convert.ToString(scor);
                button4.Enabled = true;
            }
            if (button4.Text == "8" && radioButton4.Checked == true)
            {
                scor += 1;
                label3.Text = Convert.ToString(scor);
                button4.Enabled = true;
            }

        }
    }
    }
