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
    public partial class Istorie : Form
    {
        int counter = 0;
        int scor = 0;
        public Istorie()
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
            label3.Text = "Care a fost prima capitala a Egiptului Antic?";
            radioButton1.Text = "Alexandria";
            radioButton2.Text = "Thebes";
            radioButton3.Text = "Memphis";
            radioButton4.Text = "Baltimore";
        }
        private void Intrebarea2()
        {
            label3.Text = "De pe ce insula provine civilizatia greaca?";
            radioButton1.Text = "Samos";
            radioButton2.Text = "Creta";
            radioButton3.Text = "Olimp";
            radioButton4.Text = "Rhodos";
        }
        private void Intrebarea3()
        {
            label3.Text = "Cate din cele 7 minuni ale lumii antice mai exista inca?";
            radioButton1.Text = "3";
            radioButton2.Text = "2";
            radioButton3.Text = "0";
            radioButton4.Text = "1";
        }
        private void Intrebarea4()
        {
            label3.Text = "In ce an au avut loc primele jocuri olimpice? ";
            radioButton1.Text = "776 IH";
            radioButton2.Text = "432 IH";
            radioButton3.Text = "112 IH";
            radioButton4.Text = "6";
        }
        private void Intrebarea5()
        {
            label3.Text = "Ce eveniment istoric a avut loc in Roma, in anul 64?";
            radioButton1.Text = "Asasinarea lui Iulius Caesar";
            radioButton2.Text = "Incendierea Romei";
            radioButton3.Text = "Distrugerea Romei de goti";
            radioButton4.Text = "Sfarsitul celui de-al treilea razboi punic";
        }
        private void Intrebarea6()
        {
            label3.Text = "Care doua tari erau deja in razboi inainte de inceperea celui de-al doilea razboi mondial?";
            radioButton1.Text = "Germania si Polonia";
            radioButton2.Text = "Germania si Polonia";
            radioButton3.Text = "Japonia si India";
            radioButton4.Text = "Japonia si China";
        }
        private void Intrebarea7()
        {
            label3.Text = "In cate zone de ocupatie a fost impartita Germania dupa cel de-al doilea razboi mondial ?";
            radioButton1.Text = "2";
            radioButton2.Text = "3";
            radioButton3.Text = "4";
            radioButton4.Text = "12";
        }
        private void Intrebarea8()
        {
            label3.Text = "Ce intalnire a puterilor de aproape de sfarsitul celui de-al doilea razboi mondial a marcat inceperea razboiului rece?";
            radioButton1.Text = "Conferinta de la Haga";
            radioButton2.Text = "Conferinta de la Varsovia";
            radioButton3.Text = "Conferinta de la Yalta";
            radioButton4.Text = "Conferinta de pace de la Versailles";
        }
        private void Intrebarea9()
        {
            label3.Text = "Cum se numeste monarhul care a avut cea mai lunga domnie din istorie?";
            radioButton1.Text = "Ludovic al XIV-lea";
            radioButton2.Text = "Ludovic al III-lea";
            radioButton3.Text = "Ludovic al IV-lea";
            radioButton4.Text = "Ludovic al V-lea";
        }
        private void Intrebarea10()
        {
            label3.Text = "In ce an s-a destramat URSS?";
            radioButton1.Text = "1991";
            radioButton2.Text = "1998";
            radioButton3.Text = "1989";
            radioButton4.Text = "1990";
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
