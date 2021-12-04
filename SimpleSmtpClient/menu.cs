using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SimpleSmtpClient
{
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mainForm mf = new mainForm();
            mf.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            snd sd = new snd();
            sd.Show();
        }
    }
}
