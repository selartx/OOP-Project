namespace OOPPROJECT
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
            StaffLastN = new TextBox();
            StaffN = new TextBox();
            CustomerLastN = new TextBox();
            CustomerN = new TextBox();
            StaffSearch = new Button();
            CustomerSearch = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            Password = new Label();
            StaffP = new TextBox();
            SuspendLayout();
            // 
            // StaffLastN
            // 
            StaffLastN.Location = new Point(673, 214);
            StaffLastN.Name = "StaffLastN";
            StaffLastN.Size = new Size(125, 27);
            StaffLastN.TabIndex = 0;
            // 
            // StaffN
            // 
            StaffN.Location = new Point(673, 120);
            StaffN.Name = "StaffN";
            StaffN.Size = new Size(125, 27);
            StaffN.TabIndex = 1;
            // 
            // CustomerLastN
            // 
            CustomerLastN.Location = new Point(328, 224);
            CustomerLastN.Name = "CustomerLastN";
            CustomerLastN.Size = new Size(149, 27);
            CustomerLastN.TabIndex = 2;
            // 
            // CustomerN
            // 
            CustomerN.Location = new Point(328, 136);
            CustomerN.Name = "CustomerN";
            CustomerN.Size = new Size(149, 27);
            CustomerN.TabIndex = 3;
            // 
            // StaffSearch
            // 
            StaffSearch.Location = new Point(673, 328);
            StaffSearch.Name = "StaffSearch";
            StaffSearch.Size = new Size(94, 29);
            StaffSearch.TabIndex = 4;
            StaffSearch.Text = "Search!";
            StaffSearch.UseVisualStyleBackColor = true;
            StaffSearch.Click += StaffSearch_Click;
            // 
            // CustomerSearch
            // 
            CustomerSearch.Location = new Point(328, 294);
            CustomerSearch.Name = "CustomerSearch";
            CustomerSearch.Size = new Size(149, 29);
            CustomerSearch.TabIndex = 5;
            CustomerSearch.Text = "Search!";
            CustomerSearch.UseVisualStyleBackColor = true;
            CustomerSearch.Click += CustomerSearch_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(328, 104);
            label1.Name = "label1";
            label1.Size = new Size(119, 20);
            label1.TabIndex = 6;
            label1.Text = "Customer Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(328, 192);
            label2.Name = "label2";
            label2.Size = new Size(149, 20);
            label2.TabIndex = 7;
            label2.Text = "Customer Last Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(673, 97);
            label3.Name = "label3";
            label3.Size = new Size(111, 20);
            label3.TabIndex = 8;
            label3.Text = "Staff Name:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(673, 180);
            label4.Name = "label4";
            label4.Size = new Size(141, 20);
            label4.TabIndex = 9;
            label4.Text = "Staff Last Name:";
            // 
            // Password
            // 
            Password.AutoSize = true;
            Password.Location = new Point(673, 257);
            Password.Name = "Password";
            Password.Size = new Size(70, 20);
            Password.TabIndex = 10;
            Password.Text = "Password";
            // 
            // StaffP
            // 
            StaffP.Location = new Point(673, 280);
            StaffP.Name = "StaffP";
            StaffP.Size = new Size(125, 27);
            StaffP.TabIndex = 11;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1211, 641);
            Controls.Add(StaffP);
            Controls.Add(Password);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(CustomerSearch);
            Controls.Add(StaffSearch);
            Controls.Add(CustomerN);
            Controls.Add(CustomerLastN);
            Controls.Add(StaffN);
            Controls.Add(StaffLastN);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox StaffLastN;
        private TextBox StaffN;
        private TextBox CustomerLastN;
        private TextBox CustomerN;
        private Button StaffSearch;
        private Button CustomerSearch;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label Password;
        private TextBox StaffP;
    }
}
