namespace OOPPROJECT
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
            flowLayoutPanel1 = new FlowLayoutPanel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            Next = new Button();
            Previous = new Button();
            labeldate = new Label();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Location = new Point(12, 25);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1450, 670);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(85, 2);
            label1.Name = "label1";
            label1.Size = new Size(63, 20);
            label1.TabIndex = 2;
            label1.Text = "Monday";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(296, 2);
            label2.Name = "label2";
            label2.Size = new Size(63, 20);
            label2.TabIndex = 3;
            label2.Text = "Tuesday";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(493, 2);
            label3.Name = "label3";
            label3.Size = new Size(85, 20);
            label3.TabIndex = 4;
            label3.Text = "Wednasday";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(692, 2);
            label4.Name = "label4";
            label4.Size = new Size(68, 20);
            label4.TabIndex = 5;
            label4.Text = "Thursday";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(912, 2);
            label5.Name = "label5";
            label5.Size = new Size(49, 20);
            label5.TabIndex = 6;
            label5.Text = "Friday";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(1120, 2);
            label6.Name = "label6";
            label6.Size = new Size(67, 20);
            label6.TabIndex = 7;
            label6.Text = "Saturday";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(1314, 2);
            label7.Name = "label7";
            label7.Size = new Size(57, 20);
            label7.TabIndex = 8;
            label7.Text = "Sunday";
            // 
            // Next
            // 
            Next.Location = new Point(1314, 709);
            Next.Name = "Next";
            Next.Size = new Size(94, 29);
            Next.TabIndex = 9;
            Next.Text = "Next";
            Next.UseVisualStyleBackColor = true;
            Next.Click += Next_Click;
            // 
            // Previous
            // 
            Previous.Location = new Point(1157, 709);
            Previous.Name = "Previous";
            Previous.Size = new Size(94, 29);
            Previous.TabIndex = 10;
            Previous.Text = "Previous";
            Previous.UseVisualStyleBackColor = true;
            Previous.Click += Previous_Click;
            // 
            // labeldate
            // 
            labeldate.AutoSize = true;
            labeldate.Location = new Point(12, 718);
            labeldate.Name = "labeldate";
            labeldate.Size = new Size(102, 20);
            labeldate.TabIndex = 11;
            labeldate.Text = "MONTH YEAR";
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(1494, 754);
            Controls.Add(labeldate);
            Controls.Add(Previous);
            Controls.Add(Next);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(flowLayoutPanel1);
            Name = "Form3";
            Text = "PersonalMenu";
            Load += Form3_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private FlowLayoutPanel flowLayoutPanel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button Next;
        private Button Previous;
        private Label labeldate;
    }
}