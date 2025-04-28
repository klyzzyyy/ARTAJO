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
    public partial class Form4 : Form
    {
        string filePath = "transactions.txt";
        private string username;
        public Form4(string username)
        {
            InitializeComponent();
            SetPlaceholder(txtAmount, "Amount");
            SetPlaceholder(txtDescription, "Description");
            this.username = username;
        }
        private void SetPlaceholder(TextBox textBox, string placeholder)
        {
            textBox.Text = placeholder;

            textBox.GotFocus += (sender, e) =>
            {
                if (textBox.Text == placeholder)
                {
                    textBox.Text = "";
                }
            };

            textBox.LostFocus += (sender, e) =>
            {
                if (string.IsNullOrWhiteSpace(textBox.Text))
                {
                    textBox.Text = placeholder;
                }
            };
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtAmount.Text, out decimal amount))
            {
                string line = $"{DateTime.Now:yyyy-MM-dd} | Expense | {amount:F2} | {txtDescription.Text}";
                File.AppendAllText(filePath, line + Environment.NewLine);
                MessageBox.Show("Expense recorded!");
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
            lstTransaction.Items.Clear();
            decimal incomeTotal = 0;
            decimal expenseTotal = 0;

            string filePath = "transactions.txt";

            if (File.Exists(filePath))
            {
                var lines = File.ReadAllLines(filePath);
                foreach (var line in lines)
                {
                    lstTransaction.Items.Add(line);
                    string[] parts = line.Split('|');
                    if (parts.Length >= 3)
                    {
                        decimal amount;
                        if (decimal.TryParse(parts[2], out amount))
                        {
                            if (parts[1].Trim() == "Income")
                            {
                                incomeTotal += amount;
                            }
                            else if (parts[1].Trim() == "Expense")
                            {
                                expenseTotal += amount; 
                            }
                        }
                    }
                }
            }
            if (this.Name == "Form4")
            {
                lblTotal.Text = $"Total Expenses: ₱{expenseTotal}";
            }
            else if (this.Name == "Form5")
            {
                lblTotal.Text = $"Total Income: ₱{incomeTotal}";
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string filePath = "transactions.txt";

            if (lstTransaction.SelectedItem != null)
            {
                string selectedLine = lstTransaction.SelectedItem.ToString();
                var lines = File.ReadAllLines(filePath);
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    foreach (string line in lines)
                    {
                        string formattedLine = FormatTransactionLine(line);
                        if (formattedLine != selectedLine)
                        {
                            writer.WriteLine(line);
                        }
                    }
                }

                MessageBox.Show("Transaction deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadTransactions();
            }
            else
            {
                MessageBox.Show("Please select a transaction to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void LoadTransactions()
        {
            lstTransaction.Items.Clear();
            decimal balance = 0;
            string filePath = "transactions.txt";

            if (File.Exists(filePath))
            {
                var lines = File.ReadAllLines(filePath);
                foreach (var line in lines)
                {
                    string[] parts = line.Split('|');
                    if (parts.Length >= 4)
                    {
                        string type = parts[0].Trim();
                        decimal amount;
                        if (decimal.TryParse(parts[1], out amount))
                        {
                            if (type == "Income")
                                balance += amount;
                            else if (type == "Expense")
                                balance -= amount;

                            lstTransaction.Items.Add($"{parts[2]} | {type} | {amount} | {parts[3]}");
                        }
                    }
                }
            }

            lblTotal.Text = $"Balance: ₱{balance}";
        }
        private void btnCalculateExpenses_Click(object sender, EventArgs e)
        {
            btnView_Click(sender, e);
        }

        private string FormatTransactionLine(string line)
        {
            string[] parts = line.Split('|');
            if (parts.Length >= 4)
            {
                return $"{parts[2].Trim()} | {parts[0].Trim()} | {parts[1].Trim()} | {parts[3].Trim()}";
            }
            return line;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3(username);
            this.Hide();
            frm3.Show();
        }
    }
}
