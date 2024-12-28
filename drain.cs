using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Zorara;

namespace drain_mainui
{
    public partial class drain : Form
    {

        private const string VersionUrl = "https://pastebin.com/raw/k1sY9QEr";
        private const string CurrentVersion = "2.0";
        private const string TgUrl = "https://drain_team.t.me/";

        public drain()
        {
            InitializeComponent();
            
        }



        private void guna2Button1_Click(object sender, EventArgs e)
        {
            CoreFunctions.Inject();

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void clean_Click(object sender, EventArgs e)
        {
            guna2TextBox1.Clear();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            CoreFunctions.ExecuteScript(fastColoredTextBox1.Text);
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            scripts scripts = new scripts();
           
            scripts.Show();
            
        }

        private void drain_Load(object sender, EventArgs e)
        {
            
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }


    }
}
