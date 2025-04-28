namespace ARTAJO
{
    partial class Form4
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
            txtAmount = new TextBox();
            txtDescription = new TextBox();
            btnAdd = new Button();
            btnView = new Button();
            btnDelete = new Button();
            lstTransaction = new ListBox();
            lblTotal = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = SystemColors.Control;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Location = new Point(24, 26);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(576, 349);
            label1.TabIndex = 3;
            // 
            // txtAmount
            // 
            txtAmount.BackColor = Color.LightGray;
            txtAmount.BorderStyle = BorderStyle.FixedSingle;
            txtAmount.Location = new Point(59, 65);
            txtAmount.Multiline = true;
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(207, 32);
            txtAmount.TabIndex = 4;
            // 
            // txtDescription
            // 
            txtDescription.BackColor = Color.LightGray;
            txtDescription.BorderStyle = BorderStyle.FixedSingle;
            txtDescription.Location = new Point(59, 137);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(207, 32);
            txtDescription.TabIndex = 5;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(0, 132, 255);
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.ForeColor = SystemColors.Window;
            btnAdd.Location = new Point(59, 226);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(207, 33);
            btnAdd.TabIndex = 9;
            btnAdd.Text = "ADD";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnView
            // 
            btnView.BackColor = Color.LimeGreen;
            btnView.FlatStyle = FlatStyle.Flat;
            btnView.ForeColor = SystemColors.Window;
            btnView.Location = new Point(59, 279);
            btnView.Name = "btnView";
            btnView.Size = new Size(207, 33);
            btnView.TabIndex = 10;
            btnView.Text = "VIEW";
            btnView.UseVisualStyleBackColor = false;
            btnView.Click += btnView_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.IndianRed;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.ForeColor = SystemColors.Window;
            btnDelete.Location = new Point(59, 327);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(207, 33);
            btnDelete.TabIndex = 11;
            btnDelete.Text = "DELETE";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // lstTransaction
            // 
            lstTransaction.FormattingEnabled = true;
            lstTransaction.ItemHeight = 20;
            lstTransaction.Location = new Point(293, 65);
            lstTransaction.Name = "lstTransaction";
            lstTransaction.Size = new Size(294, 164);
            lstTransaction.TabIndex = 12;
            // 
            // lblTotal
            // 
            lblTotal.BackColor = SystemColors.InactiveCaptionText;
            lblTotal.ForeColor = SystemColors.Window;
            lblTotal.Location = new Point(344, 269);
            lblTotal.Margin = new Padding(4, 0, 4, 0);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(189, 46);
            lblTotal.TabIndex = 14;
            lblTotal.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(0, 132, 255);
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = SystemColors.Window;
            button1.Location = new Point(527, 26);
            button1.Name = "button1";
            button1.Size = new Size(73, 33);
            button1.TabIndex = 15;
            button1.Text = "back";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(614, 395);
            Controls.Add(button1);
            Controls.Add(lblTotal);
            Controls.Add(lstTransaction);
            Controls.Add(btnDelete);
            Controls.Add(btnView);
            Controls.Add(btnAdd);
            Controls.Add(txtDescription);
            Controls.Add(txtAmount);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "Form4";
            Text = "Form4";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtAmount;
        private TextBox txtDescription;
        private Button btnAdd;
        private Button btnView;
        private Button btnDelete;
        private ListBox lstTransaction;
        private Label lblTotal;
        private Button button1;
    }
}