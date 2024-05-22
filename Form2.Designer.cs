namespace OOPPROJECT
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
            labelCustomerName = new Label();
            labelCustomerLastN = new Label();
            contactinfo = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            listView1 = new ListView();
            SuspendLayout();
            // 
            // labelCustomerName
            // 
            labelCustomerName.AutoSize = true;
            labelCustomerName.Location = new Point(39, 53);
            labelCustomerName.Name = "labelCustomerName";
            labelCustomerName.Size = new Size(49, 20);
            labelCustomerName.TabIndex = 1;
            labelCustomerName.Text = "Name";
            // 
            // labelCustomerLastN
            // 
            labelCustomerLastN.AutoSize = true;
            labelCustomerLastN.Location = new Point(145, 53);
            labelCustomerLastN.Name = "labelCustomerLastN";
            labelCustomerLastN.Size = new Size(67, 20);
            labelCustomerLastN.TabIndex = 2;
            labelCustomerLastN.Text = "Surname";
            // 
            // contactinfo
            // 
            contactinfo.AutoSize = true;
            contactinfo.Location = new Point(351, 53);
            contactinfo.Name = "contactinfo";
            contactinfo.Size = new Size(90, 20);
            contactinfo.TabIndex = 3;
            contactinfo.Text = "Contact Info";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 21);
            label1.Name = "label1";
            label1.Size = new Size(125, 20);
            label1.TabIndex = 5;
            label1.Text = "Customer's Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(162, 21);
            label2.Name = "label2";
            label2.Size = new Size(143, 20);
            label2.TabIndex = 6;
            label2.Text = "Customer's Surname";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(351, 21);
            label3.Name = "label3";
            label3.Size = new Size(90, 20);
            label3.TabIndex = 7;
            label3.Text = "Contact Info";
            // 
            // listView1
            // 
            listView1.Location = new Point(39, 109);
            listView1.Name = "listView1";
            listView1.Size = new Size(737, 400);
            listView1.TabIndex = 8;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1030, 574);
            Controls.Add(listView1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(contactinfo);
            Controls.Add(labelCustomerLastN);
            Controls.Add(labelCustomerName);
            Name = "Form2";
            Text = "CustomerMenu";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelCustomerName;
        private Label labelCustomerLastN;
        private Label contactinfo;
        private Label label1;
        private Label label2;
        private Label label3;
        private ListView listView1;
    }
}