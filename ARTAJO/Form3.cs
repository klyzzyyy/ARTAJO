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
        string filePath = "TrackedExpenses&Income.txt";
        public Form3(string username)
        {
            InitializeComponent();
            lblWelcome.Text = $"Welcome to the system, {username}";
            this.username = username;
            cmbType.Items.Add("Income");
            cmbType.Items.Add("Expense");
            cmbType.SelectedIndex = 0;
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtAmount.Text, out decimal amount))
            {
                string line = $"{DateTime.Now.ToString("yyyy-MM-dd")} | {cmbType.Text} | {amount:F2} | {txtDescription.Text}";
                File.AppendAllText(filePath, line + Environment.NewLine);
                MessageBox.Show("Transaction saved!");
                txtAmount.Clear();
                txtDescription.Clear();
            }
            else
            {
                MessageBox.Show("Invalid amount entered.");
            }
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            lstTransactions.Items.Clear();
            decimal balance = 0;

            if (File.Exists(filePath))
            {
                var lines = File.ReadAllLines(filePath);
                foreach (var line in lines)
                {
                    lstTransactions.Items.Add(line);
                    string[] parts = line.Split('|');
                    if (parts.Length >= 3 && decimal.TryParse(parts[2], out decimal amt))
                    {
                        if (parts[1].Trim() == "Income")
                            balance += amt;
                        else
                            balance -= amt;
                    }
                }
            }

            lblBalance.Text = $"Current Balance: {balance:C}";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lstTransactions.SelectedItem != null)
            {
                string selectedLine = lstTransactions.SelectedItem.ToString();
                var lines = File.ReadAllLines(filePath);
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    foreach (string line in lines)
                    {
                        if (line != selectedLine)
                        {
                            writer.WriteLine(line);
                        }
                    }
                }

                MessageBox.Show("Transaction deleted.");
                btnView_Click(sender, e);
            }
            else
            {
                MessageBox.Show("Please select a transaction to delete.");
            }
        }

        private void txtAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            this.Hide();
            frm1.Show();
        }
    }
}
