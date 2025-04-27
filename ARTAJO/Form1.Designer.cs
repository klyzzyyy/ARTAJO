namespace ARTAJO
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtEmail = new TextBox();
            txtPassword = new TextBox();
            btnLogin = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnNew = new Button();
            chkPassword = new CheckBox();
            label5 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = SystemColors.Control;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Location = new Point(27, 50);
            label1.Name = "label1";
            label1.Size = new Size(460, 404);
            label1.TabIndex = 0;
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.LightGray;
            txtEmail.BorderStyle = BorderStyle.FixedSingle;
            txtEmail.Location = new Point(86, 140);
            txtEmail.Multiline = true;
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(346, 36);
            txtEmail.TabIndex = 1;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.LightGray;
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.Location = new Point(86, 180);
            txtPassword.Multiline = true;
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(346, 36);
            txtPassword.TabIndex = 2;
            txtPassword.TextChanged += txtPassword_TextChanged;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(1, 101, 225);
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.ForeColor = SystemColors.Control;
            btnLogin.Location = new Point(86, 233);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(346, 35);
            btnLogin.TabIndex = 3;
            btnLogin.Text = "LOGIN";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.Control;
            label2.Location = new Point(86, 295);
            label2.Name = "label2";
            label2.Size = new Size(147, 20);
            label2.TabIndex = 4;
            label2.Text = "_______________________";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.Control;
            label3.Location = new Point(285, 295);
            label3.Name = "label3";
            label3.Size = new Size(147, 20);
            label3.TabIndex = 5;
            label3.Text = "_______________________";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.Control;
            label4.Location = new Point(246, 299);
            label4.Name = "label4";
            label4.Size = new Size(24, 20);
            label4.TabIndex = 6;
            label4.Text = "or";
            // 
            // btnNew
            // 
            btnNew.BackColor = Color.FromArgb(19, 207, 19);
            btnNew.FlatStyle = FlatStyle.Flat;
            btnNew.ForeColor = SystemColors.Control;
            btnNew.Location = new Point(145, 349);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(224, 35);
            btnNew.TabIndex = 7;
            btnNew.Text = "Create New Account";
            btnNew.UseVisualStyleBackColor = false;
            btnNew.Click += btnNew_Click;
            // 
            // chkPassword
            // 
            chkPassword.AutoSize = true;
            chkPassword.Location = new Point(404, 193);
            chkPassword.Name = "chkPassword";
            chkPassword.Size = new Size(15, 14);
            chkPassword.TabIndex = 17;
            chkPassword.UseVisualStyleBackColor = true;
            chkPassword.CheckedChanged += chkPassword_CheckedChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.Control;
            label5.Location = new Point(194, 73);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(143, 20);
            label5.TabIndex = 18;
            label5.Text = "Login your account";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(525, 502);
            Controls.Add(label5);
            Controls.Add(chkPassword);
            Controls.Add(btnNew);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnLogin);
            Controls.Add(txtPassword);
            Controls.Add(txtEmail);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtEmail;
        private TextBox txtPassword;
        private Button btnLogin;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnNew;
        private CheckBox chkPassword;
        private Label label5;
    }
}
