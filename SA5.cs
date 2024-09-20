using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chaves
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
          
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Retirar(object sender, EventArgs e)
        {
            label2.Text = "Status: indisponivel";
            button1.Enabled = false;
            button2.Enabled = true;
            panel1.BackColor = Color.Red;
        }

        private void Devolver(object sender, EventArgs e)
        {
            label2.Text = "Status: disponivel";
            button1.Enabled = true;
            button2.Enabled = false;
            panel1.BackColor = Color.Lime;
        }

        private void NomeSala(object sender, EventArgs e)
        {

        }

        private void Status(object sender, EventArgs e)
        {

        }
    }

}
