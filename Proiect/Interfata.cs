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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Chimie f2 = new Chimie();
            f2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Matematica f3 = new Matematica();
            f3.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Geografie f4 = new Geografie();
            f4.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Istorie f5 = new Istorie();
            f5.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Fizica f6 = new Fizica();
            f6.Show();
        }
    }
}
