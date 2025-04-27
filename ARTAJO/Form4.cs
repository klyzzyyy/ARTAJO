using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ARTAJO
{
    public partial class Form4 : Form
    {
        string filePath = "expenses.txt";
        public Form4()
        {
            InitializeComponent();
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
            lstExpenses.Items.Clear();
            decimal totalExpenses = 0;

            if (File.Exists(filePath))
            {
                var lines = File.ReadAllLines(filePath);
                foreach (var line in lines)
                {
                    lstExpenses.Items.Add(line);
                    string[] parts = line.Split('|');
                    if (parts.Length >= 3 && decimal.TryParse(parts[2], out decimal amt))
                    {
                        totalExpenses += amt;
                    }
                }
            }

            lblTotalExpenses.Text = $"Total Expenses: {totalExpenses:C}";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lstExpenses.SelectedItem != null)
            {
                string selectedLine = lstExpenses.SelectedItem.ToString();
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

                MessageBox.Show("Expense deleted.");
                btnView_Click(sender, e);
            }
            else
            {
                MessageBox.Show("Please select an expense to delete.");
            }
        }
    }
}
