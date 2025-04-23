namespace FINALS_SIR_ARTAJO
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
            label2 = new Label();
            txtAmount = new TextBox();
            label3 = new Label();
            txtDescription = new TextBox();
            label4 = new Label();
            btnAdd = new Button();
            btnView = new Button();
            btnDelete = new Button();
            lstTransactions = new ListBox();
            cmbType = new ComboBox();
            lblBalance = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = SystemColors.Window;
            label1.Location = new Point(31, 37);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(908, 419);
            label1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.Window;
            label2.Location = new Point(442, 46);
            label2.Name = "label2";
            label2.Size = new Size(118, 18);
            label2.TabIndex = 1;
            label2.Text = "Budget Tracker";
            // 
            // txtAmount
            // 
            txtAmount.BackColor = Color.LightCoral;
            txtAmount.BorderStyle = BorderStyle.None;
            txtAmount.ForeColor = SystemColors.Window;
            txtAmount.Location = new Point(154, 110);
            txtAmount.Multiline = true;
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(189, 24);
            txtAmount.TabIndex = 2;
            txtAmount.TextAlign = HorizontalAlignment.Center;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.Window;
            label3.Location = new Point(50, 113);
            label3.Name = "label3";
            label3.Size = new Size(69, 18);
            label3.TabIndex = 3;
            label3.Text = "Amount: ";
            // 
            // txtDescription
            // 
            txtDescription.BackColor = Color.LightCoral;
            txtDescription.BorderStyle = BorderStyle.None;
            txtDescription.ForeColor = SystemColors.Window;
            txtDescription.Location = new Point(154, 189);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(189, 24);
            txtDescription.TabIndex = 4;
            txtDescription.TextAlign = HorizontalAlignment.Center;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.Window;
            label4.Location = new Point(50, 192);
            label4.Name = "label4";
            label4.Size = new Size(98, 18);
            label4.TabIndex = 5;
            label4.Text = "Description: ";
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.DeepSkyBlue;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Location = new Point(154, 306);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(189, 33);
            btnAdd.TabIndex = 8;
            btnAdd.Text = "ADD";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnView
            // 
            btnView.BackColor = Color.LimeGreen;
            btnView.FlatStyle = FlatStyle.Flat;
            btnView.Location = new Point(154, 354);
            btnView.Name = "btnView";
            btnView.Size = new Size(189, 33);
            btnView.TabIndex = 9;
            btnView.Text = "VIEW";
            btnView.UseVisualStyleBackColor = false;
            btnView.Click += btnView_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.IndianRed;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Location = new Point(154, 404);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(189, 33);
            btnDelete.TabIndex = 10;
            btnDelete.Text = "DELETE";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // lstTransactions
            // 
            lstTransactions.FormattingEnabled = true;
            lstTransactions.ItemHeight = 18;
            lstTransactions.Location = new Point(470, 110);
            lstTransactions.Name = "lstTransactions";
            lstTransactions.Size = new Size(447, 184);
            lstTransactions.TabIndex = 11;
            // 
            // cmbType
            // 
            cmbType.FormattingEnabled = true;
            cmbType.Location = new Point(154, 249);
            cmbType.Name = "cmbType";
            cmbType.Size = new Size(189, 26);
            cmbType.TabIndex = 12;
            // 
            // lblBalance
            // 
            lblBalance.BackColor = SystemColors.InactiveCaptionText;
            lblBalance.ForeColor = SystemColors.Window;
            lblBalance.Location = new Point(603, 345);
            lblBalance.Margin = new Padding(4, 0, 4, 0);
            lblBalance.Name = "lblBalance";
            lblBalance.Size = new Size(189, 46);
            lblBalance.TabIndex = 13;
            lblBalance.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(973, 481);
            Controls.Add(lblBalance);
            Controls.Add(cmbType);
            Controls.Add(lstTransactions);
            Controls.Add(btnDelete);
            Controls.Add(btnView);
            Controls.Add(btnAdd);
            Controls.Add(label4);
            Controls.Add(txtDescription);
            Controls.Add(label3);
            Controls.Add(txtAmount);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtAmount;
        private Label label3;
        private TextBox txtDescription;
        private Label label4;
        private Button btnAdd;
        private Button btnView;
        private Button btnDelete;
        private ListBox lstTransactions;
        private ComboBox cmbType;
        private Label lblBalance;
    }
}
