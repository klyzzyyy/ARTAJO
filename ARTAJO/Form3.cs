using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace ARTAJO
{
    public partial class Form3 : Form
    {
        private string username;
        public Form3(string username)
        {
            InitializeComponent();
            lblWelcome.Text = $"Welcome to the system, {username}";
            this.username = username;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form5 frm3 = new Form5(username);
            this.Hide();
            frm3.Show();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 frm3 = new Form4(username);
            this.Hide();
            frm3.Show();
        }
    }
}
