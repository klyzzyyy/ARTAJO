namespace ARTAJO
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label4 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtName = new TextBox();
            txtEmail = new TextBox();
            txtPassword = new TextBox();
            btnSign = new Button();
            label5 = new Label();
            btnLogin = new Button();
            chkPassword = new CheckBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = SystemColors.Control;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Location = new Point(13, 29);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(439, 493);
            label1.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.Control;
            label4.Location = new Point(157, 46);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(158, 20);
            label4.TabIndex = 7;
            label4.Text = "Create a new account";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.Control;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(183, 78);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(106, 20);
            label2.TabIndex = 8;
            label2.Text = "quick and easy";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.Control;
            label3.Location = new Point(24, 100);
            label3.Name = "label3";
            label3.Size = new Size(423, 20);
            label3.TabIndex = 9;
            label3.Text = "_____________________________________________________________________";
            // 
            // txtName
            // 
            txtName.BackColor = Color.WhiteSmoke;
            txtName.BorderStyle = BorderStyle.FixedSingle;
            txtName.Location = new Point(57, 151);
            txtName.Multiline = true;
            txtName.Name = "txtName";
            txtName.Size = new Size(346, 36);
            txtName.TabIndex = 10;
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.WhiteSmoke;
            txtEmail.BorderStyle = BorderStyle.FixedSingle;
            txtEmail.Location = new Point(57, 212);
            txtEmail.Multiline = true;
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(346, 36);
            txtEmail.TabIndex = 11;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.WhiteSmoke;
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.Location = new Point(57, 274);
            txtPassword.Multiline = true;
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(346, 36);
            txtPassword.TabIndex = 12;
            txtPassword.TextChanged += txtPassword_TextChanged;
            // 
            // btnSign
            // 
            btnSign.BackColor = Color.FromArgb(19, 207, 19);
            btnSign.FlatStyle = FlatStyle.Flat;
            btnSign.ForeColor = SystemColors.Control;
            btnSign.Location = new Point(137, 355);
            btnSign.Name = "btnSign";
            btnSign.Size = new Size(188, 35);
            btnSign.TabIndex = 13;
            btnSign.Text = "Sign up";
            btnSign.UseVisualStyleBackColor = false;
            btnSign.Click += btnSign_Click_1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.Control;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(23, 169, 253);
            label5.Location = new Point(141, 428);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(178, 20);
            label5.TabIndex = 14;
            label5.Text = "Already have an account?";
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(1, 101, 225);
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.ForeColor = SystemColors.Control;
            btnLogin.Location = new Point(169, 469);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(122, 35);
            btnLogin.TabIndex = 15;
            btnLogin.Text = "LOGIN";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // chkPassword
            // 
            chkPassword.AutoSize = true;
            chkPassword.Location = new Point(372, 286);
            chkPassword.Name = "chkPassword";
            chkPassword.Size = new Size(15, 14);
            chkPassword.TabIndex = 16;
            chkPassword.UseVisualStyleBackColor = true;
            chkPassword.CheckedChanged += chkPassword_CheckedChanged;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(465, 556);
            Controls.Add(chkPassword);
            Controls.Add(btnLogin);
            Controls.Add(label5);
            Controls.Add(btnSign);
            Controls.Add(txtPassword);
            Controls.Add(txtEmail);
            Controls.Add(txtName);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label4);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label4;
        private Label label2;
        private Label label3;
        private TextBox txtName;
        private TextBox txtEmail;
        private TextBox txtPassword;
        private Button btnSign;
        private Label label5;
        private Button btnLogin;
        private CheckBox chkPassword;
    }
}