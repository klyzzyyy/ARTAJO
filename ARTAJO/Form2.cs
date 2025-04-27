using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace ARTAJO
{
    public partial class Form2 : Form
    {
        string filePath = "users.txt";
        public Form2()
        {
            InitializeComponent();
            SetPlaceholder(txtName, "Username");
            SetPlaceholder(txtEmail, "Email address");
            SetPlaceholder(txtPassword, "Password");
        }
        private bool IsEmailTaken(string email)
        {
            if (!File.Exists(filePath)) return false;

            HashSet<string> emails = new HashSet<string>(StringComparer.OrdinalIgnoreCase);

            foreach (string line in File.ReadLines(filePath))
            {
                string[] fields = line.Split(',');

                if (fields.Length >= 2)
                {
                    string storedEmail = fields[1].Trim();
                    emails.Add(storedEmail);
                }
            }

            return emails.Contains(email.Trim());
        }

        private string HashPassword(string password)
        {
            using (SHA256 sha = SHA256.Create())
            {
                byte[] bytes = sha.ComputeHash(Encoding.UTF8.GetBytes(password));
                return Convert.ToBase64String(bytes);
            }
        }

        private void ClearFields()
        {
            txtName.Clear();
            txtEmail.Clear();
            txtPassword.Clear();
            chkPassword.Checked = false;
        }
        private void SetPlaceholder(TextBox textBox, string placeholder)
        {
            textBox.Text = placeholder;

            textBox.GotFocus += (sender, e) =>
            {
                if (textBox.Text == placeholder)
                {
                    textBox.Text = "";
                    textBox.ForeColor = Color.Black;
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


        private void btnSign_Click_1(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();
            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text;

            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (IsEmailTaken(email))
            {
                MessageBox.Show("Email is already registered.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string hashedPassword = HashPassword(password);
            string userData = $"{name},{email},{hashedPassword}";
            File.AppendAllText(filePath, userData + Environment.NewLine);

            MessageBox.Show("Registration successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ClearFields();
        }

        private void chkPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chkPassword.Checked)
            {
                txtPassword.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '*';
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            this.Hide();
            frm1.Show();
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            if (chkPassword.Checked)
            {
                txtPassword.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '*';
            }
        }
    }
}
