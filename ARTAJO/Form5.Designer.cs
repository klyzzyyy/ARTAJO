namespace ARTAJO
{
    partial class Form5
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
            lblTotalIncome = new Label();
            lstIncome = new ListBox();
            btnDelete = new Button();
            btnView = new Button();
            btnAdd = new Button();
            txtDescription = new TextBox();
            txtAmount = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // lblTotalIncome
            // 
            lblTotalIncome.BackColor = SystemColors.InactiveCaptionText;
            lblTotalIncome.ForeColor = SystemColors.Window;
            lblTotalIncome.Location = new Point(343, 268);
            lblTotalIncome.Margin = new Padding(4, 0, 4, 0);
            lblTotalIncome.Name = "lblTotalIncome";
            lblTotalIncome.Size = new Size(189, 46);
            lblTotalIncome.TabIndex = 22;
            lblTotalIncome.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lstIncome
            // 
            lstIncome.FormattingEnabled = true;
            lstIncome.ItemHeight = 20;
            lstIncome.Location = new Point(292, 64);
            lstIncome.Name = "lstIncome";
            lstIncome.Size = new Size(294, 164);
            lstIncome.TabIndex = 21;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.IndianRed;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.ForeColor = SystemColors.Window;
            btnDelete.Location = new Point(58, 326);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(207, 33);
            btnDelete.TabIndex = 20;
            btnDelete.Text = "DELETE";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnView
            // 
            btnView.BackColor = Color.LimeGreen;
            btnView.FlatStyle = FlatStyle.Flat;
            btnView.ForeColor = SystemColors.Window;
            btnView.Location = new Point(58, 278);
            btnView.Name = "btnView";
            btnView.Size = new Size(207, 33);
            btnView.TabIndex = 19;
            btnView.Text = "VIEW";
            btnView.UseVisualStyleBackColor = false;
            btnView.Click += btnView_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(0, 132, 255);
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.ForeColor = SystemColors.Window;
            btnAdd.Location = new Point(58, 225);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(207, 33);
            btnAdd.TabIndex = 18;
            btnAdd.Text = "ADD";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtDescription
            // 
            txtDescription.BackColor = Color.LightGray;
            txtDescription.BorderStyle = BorderStyle.FixedSingle;
            txtDescription.Location = new Point(58, 136);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(207, 32);
            txtDescription.TabIndex = 17;
            // 
            // txtAmount
            // 
            txtAmount.BackColor = Color.LightGray;
            txtAmount.BorderStyle = BorderStyle.FixedSingle;
            txtAmount.Location = new Point(58, 64);
            txtAmount.Multiline = true;
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(207, 32);
            txtAmount.TabIndex = 16;
            // 
            // label1
            // 
            label1.BackColor = SystemColors.Control;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Location = new Point(23, 25);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(576, 349);
            label1.TabIndex = 15;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(617, 393);
            Controls.Add(lblTotalIncome);
            Controls.Add(lstIncome);
            Controls.Add(btnDelete);
            Controls.Add(btnView);
            Controls.Add(btnAdd);
            Controls.Add(txtDescription);
            Controls.Add(txtAmount);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "Form5";
            Text = "Form5";
            Load += Form5_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTotalIncome;
        private ListBox lstIncome;
        private Button btnDelete;
        private Button btnView;
        private Button btnAdd;
        private TextBox txtDescription;
        private TextBox txtAmount;
        private Label label1;
    }
}