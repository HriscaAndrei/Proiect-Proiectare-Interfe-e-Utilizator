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
    public partial class Matematica : Form
    {
        int counter = 0;
        int scor = 0;
        public Matematica()
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
            label3.Text = "Care este cel de-al 10-lea termen al şirului 1,3,5,7,...?";
            radioButton1.Text = "11";
            radioButton2.Text = "15";
            radioButton3.Text = "19";
            radioButton4.Text = "17";
        }
        private void Intrebarea2()
        {
            label3.Text = "Rezultatul calculului 6 : 3 – 6 · 3 este egal cu....";
            radioButton1.Text = "-12";
            radioButton2.Text = "-16";
            radioButton3.Text = "12";
            radioButton4.Text = "16";
        }
        private void Intrebarea3()
        {
            label3.Text = "Probabilitatea ca alegând un număr da la 1 la 100, acesta să fie pătrat perfect este...";
            radioButton1.Text = "20%";
            radioButton2.Text = "50%";
            radioButton3.Text = "40%";
            radioButton4.Text = "10%";
        }
        private void Intrebarea4()
        {
            label3.Text = "Media geometrică a numerelor 2 şi 8 este egală cu...";
            radioButton1.Text = "4";
            radioButton2.Text = "6";
            radioButton3.Text = "5";
            radioButton4.Text = "10";
        }
        private void Intrebarea5()
        {
            label3.Text = "Complementul unui unghi cu măsura de 38 grade este unghiul cu masura de …. grade";
            radioButton1.Text = "7";
            radioButton2.Text = "52";
            radioButton3.Text = "142";
            radioButton4.Text = "38";
        }
        private void Intrebarea6()
        {
            label3.Text = "Restul împărţirii numărului 53 la numărul 4 este egal cu ...";
            radioButton1.Text = "0";
            radioButton2.Text = "3";
            radioButton3.Text = "2";
            radioButton4.Text = "1";
        }
        private void Intrebarea7()
        {
            label3.Text = "Măsurile a două unghiuri ale unui triunghi sunt 38 grade şi 54 grade. Al treilea unghi are măsura de ...";
            radioButton1.Text = "28 grade";
            radioButton2.Text = "8 grade";
            radioButton3.Text = "88 grade";
            radioButton4.Text = "58 grade";
        }
        private void Intrebarea8()
        {
            label3.Text = "Latura unui cub cu diagonala de 5*radical(3)cm, este egală cu ..... cm";
            radioButton1.Text = "2,5";
            radioButton2.Text = "3";
            radioButton3.Text = "5";
            radioButton4.Text = "10";
        }
        private void Intrebarea9()
        {
            label3.Text = "Numărul care reprezintă trei pătrimi din 120 este egal cu ...";
            radioButton1.Text = "90";
            radioButton2.Text = "30";
            radioButton3.Text = "40";
            radioButton4.Text = "12";
        }
        private void Intrebarea10()
        {
            label3.Text = "In mulţimea A={4/4;4/3;4/8;4/5} fracţia supraunitară este egală cu ...";
            radioButton1.Text = "4/3";
            radioButton2.Text = "4/5";
            radioButton3.Text = "4/8";
            radioButton4.Text = "4/4";
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
