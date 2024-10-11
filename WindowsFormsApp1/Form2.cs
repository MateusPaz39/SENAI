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
    public partial class Form2 : Form
    {
        public List<String> nomes = new List<String>();
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //label2.Text = this.nomes[0];
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            nomes.Add(textBox1.Text);
            textBox1.Clear();
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
    
        }
    }
}
