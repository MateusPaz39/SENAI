﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1;

namespace WindowsFormsApp1
{
    public class Class1
    {
       
        public void retirar(Button b1, Button b2,Panel p1)
        {

            b1.Visible = false;
            b2.Visible = true;
            p1.BackColor = Color.Red;

        }

        public void devolver(Button b1, Button b2, Panel p1)
        {

            b2.Visible = false;
            b1.Visible = true;
            p1.BackColor = Color.Lime;

        }

        public void criarForms(Form2 f2)
        {
            f2.Show();
        }


    }
}
