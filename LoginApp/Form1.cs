using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void TXTUser_Enter(object sender, EventArgs e)
        {
            if (TXTUser.Text == "Usuario")
            {
                TXTUser.Text = "";
            }
        }

        private void TXTPass_Enter(object sender, EventArgs e)
        {
            if (TXTPass.Text == "Contraseña")
            {
                TXTPass.Text = "";
                TXTPass.UseSystemPasswordChar = true;
            }
        }

        private void TXTUser_Leave(object sender, EventArgs e)
        {
            if (TXTUser.Text == "")
            {
                TXTUser.Text = "Usuario";
            }
        }

        private void TXTPass_Leave(object sender, EventArgs e)
        {
            if (TXTPass.Text == "")
            {
                TXTPass.Text = "Contraseña";
                TXTPass.UseSystemPasswordChar = false;
            }
        }
    }
}
