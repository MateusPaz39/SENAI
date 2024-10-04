using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        Class1 c1 = new Class1();

   
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            c1.retirar(button1, button2, panel1);
            Form2 f2 = new Form2();
            f2.ShowDialog();


        }

        private void button2_Click(object sender, EventArgs e)
        {

            c1.devolver(button1, button2, panel1);

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
