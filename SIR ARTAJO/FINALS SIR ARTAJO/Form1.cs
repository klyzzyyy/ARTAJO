using System;
using System.IO;
using System.Windows.Forms;

namespace FINALS_SIR_ARTAJO
{
    public partial class Form1 : Form
    {
        string filePath = "budget.txt";

        public Form1()
        {
            InitializeComponent();
            cmbType.Items.Add("Income");
            cmbType.Items.Add("Expense");
            cmbType.SelectedIndex = 0;
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

    }
}
