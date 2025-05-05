namespace ARTAJO
{
    partial class Form3
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
            lblWelcome = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtAmount = new TextBox();
            txtDescription = new TextBox();
            cmbType = new ComboBox();
            btnAdd = new Button();
            btnView = new Button();
            btnDelete = new Button();
            lstTransactions = new ListBox();
            lblBalance = new Label();
            btnExit = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = SystemColors.Control;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Location = new Point(19, 18);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(872, 429);
            label1.TabIndex = 2;
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.BackColor = SystemColors.Control;
            lblWelcome.Location = new Point(342, 28);
            lblWelcome.Margin = new Padding(5, 0, 5, 0);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(74, 20);
            lblWelcome.TabIndex = 8;
            lblWelcome.Text = "Welcome";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.Control;
            label2.Location = new Point(336, 52);
            label2.Name = "label2";
            label2.Size = new Size(236, 20);
            label2.TabIndex = 10;
            label2.Text = "Track your Income and Expenses";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.Window;
            label3.Location = new Point(36, 118);
            label3.Name = "label3";
            label3.Size = new Size(75, 20);
            label3.TabIndex = 11;
            label3.Text = "Amount: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.Window;
            label4.Location = new Point(36, 179);
            label4.Name = "label4";
            label4.Size = new Size(97, 20);
            label4.TabIndex = 12;
            label4.Text = "Description: ";
            // 
            // txtAmount
            // 
            txtAmount.BackColor = Color.LightGray;
            txtAmount.BorderStyle = BorderStyle.FixedSingle;
            txtAmount.Location = new Point(132, 116);
            txtAmount.Multiline = true;
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(146, 28);
            txtAmount.TabIndex = 13;
            txtAmount.KeyPress += txtAmount_KeyPress;
            // 
            // txtDescription
            // 
            txtDescription.BackColor = Color.LightGray;
            txtDescription.BorderStyle = BorderStyle.FixedSingle;
            txtDescription.Location = new Point(132, 176);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(146, 28);
            txtDescription.TabIndex = 14;
            // 
            // cmbType
            // 
            cmbType.FormattingEnabled = true;
            cmbType.Location = new Point(36, 239);
            cmbType.Name = "cmbType";
            cmbType.Size = new Size(242, 28);
            cmbType.TabIndex = 15;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.DeepSkyBlue;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Location = new Point(36, 294);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(242, 33);
            btnAdd.TabIndex = 16;
            btnAdd.Text = "ADD";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnView
            // 
            btnView.BackColor = Color.LimeGreen;
            btnView.FlatStyle = FlatStyle.Flat;
            btnView.Location = new Point(36, 343);
            btnView.Name = "btnView";
            btnView.Size = new Size(242, 33);
            btnView.TabIndex = 17;
            btnView.Text = "VIEW";
            btnView.UseVisualStyleBackColor = false;
            btnView.Click += btnView_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.IndianRed;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Location = new Point(36, 398);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(242, 33);
            btnDelete.TabIndex = 18;
            btnDelete.Text = "DELETE";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // lstTransactions
            // 
            lstTransactions.FormattingEnabled = true;
            lstTransactions.ItemHeight = 20;
            lstTransactions.Location = new Point(336, 116);
            lstTransactions.Name = "lstTransactions";
            lstTransactions.Size = new Size(516, 204);
            lstTransactions.TabIndex = 19;
            // 
            // lblBalance
            // 
            lblBalance.BackColor = SystemColors.InactiveCaptionText;
            lblBalance.ForeColor = SystemColors.Window;
            lblBalance.Location = new Point(470, 343);
            lblBalance.Margin = new Padding(4, 0, 4, 0);
            lblBalance.Name = "lblBalance";
            lblBalance.Size = new Size(237, 51);
            lblBalance.TabIndex = 20;
            lblBalance.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.Crimson;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Location = new Point(804, 18);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(87, 30);
            btnExit.TabIndex = 21;
            btnExit.Text = "LOG OUT";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(909, 458);
            Controls.Add(btnExit);
            Controls.Add(lblBalance);
            Controls.Add(lstTransactions);
            Controls.Add(btnDelete);
            Controls.Add(btnView);
            Controls.Add(btnAdd);
            Controls.Add(cmbType);
            Controls.Add(txtDescription);
            Controls.Add(txtAmount);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lblWelcome);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "Form3";
            Text = "Form3";
            Load += Form3_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblWelcome;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtAmount;
        private TextBox txtDescription;
        private ComboBox cmbType;
        private Button btnAdd;
        private Button btnView;
        private Button btnDelete;
        private ListBox lstTransactions;
        private Label lblBalance;
        private Button btnExit;
    }
}