using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace drain_mainui
{
    public partial class Starter : Form
    {
        public Starter()
        {
            InitializeComponent();
        }

        private void update_Click(object sender, EventArgs e)
        {
            drain drain = new drain();

            drain.Show();
            this.Hide();

        }

        private void nope_Click(object sender, EventArgs e)
        {
            ProcessStartInfo sInfo = new ProcessStartInfo("http://drain_team.t.me/");
            Process.Start(sInfo);
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
