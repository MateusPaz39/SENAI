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
        Form2 f2 = new Form2();


        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            c1.retirar(button1, button2, button3 , panel1);
            f2.ShowDialog();


        }

        private void button2_Click(object sender, EventArgs e)
        {

            c1.devolver(button1, button2, button3, panel1);
            if(label2.Visible == true)
            {
                label2.Visible = false;
            }

            if (panel2.Visible == true)
            {
                panel2.Visible = false;
            }

            if (button4.Visible == true)
            {
                button4.Visible = false;
            }

            if (button5.Visible == true)
            {
                button5.Visible = false;
            }

            if (label3.Visible == true)
            {
                label3.Visible = false;
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        int consultaPage = 0;

        bool pagConsulta = false;
        private void button3_Click(object sender, EventArgs e)
        {
            pagConsulta = !pagConsulta;

            
            label2.Visible = pagConsulta;
            label3.Visible = pagConsulta;
            panel2.Visible = pagConsulta;
            button4.Visible = pagConsulta;
            button5.Visible = pagConsulta;
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            consultaPage++;
            label3.Text = Convert.ToString(consultaPage + 1);

            String Str1 = "";

            for (int i = 0; i < 5; i++)
            {
                try
                {
                    Str1 = Str1 + f2.nomes[(consultaPage * 5) + i] + "\n";

                }catch
                {

                }
            }

            label2.Text = Str1;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(consultaPage >= 1)
            {
                consultaPage--;
                label3.Text = Convert.ToString(consultaPage + 1);
            }

            String Str1 = "";

            for (int i = 0; i < 5; i++)
            {
                try
                {
                    Str1 = Str1 + f2.nomes[(i + consultaPage) - 1] + "\n";
                }catch
                {

                }
            }

            label2.Text = Str1;


        }
    }
}
