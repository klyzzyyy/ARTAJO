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
    public partial class Form5 : Form
    {
        string filePath = "income.txt";
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtAmount.Text, out decimal amount))
            {
                string line = $"{DateTime.Now:yyyy-MM-dd} | Income | {amount:F2} | {txtDescription.Text}";
                File.AppendAllText(filePath, line + Environment.NewLine);
                MessageBox.Show("Income recorded!");
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
            lstIncome.Items.Clear();
            decimal totalIncome = 0;

            if (File.Exists(filePath))
            {
                var lines = File.ReadAllLines(filePath);
                foreach (var line in lines)
                {
                    lstIncome.Items.Add(line);
                    string[] parts = line.Split('|');
                    if (parts.Length >= 3 && decimal.TryParse(parts[2], out decimal amt))
                    {
                        totalIncome += amt;
                    }
                }
            }

            lblTotalIncome.Text = $"Total Income: {totalIncome:C}";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lstIncome.SelectedItem != null)
            {
                string selectedLine = lstIncome.SelectedItem.ToString();
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

                MessageBox.Show("Income entry deleted.");
                btnView_Click(sender, e);
            }
            else
            {
                MessageBox.Show("Please select an income to delete.");
            }
        }
    }
}
