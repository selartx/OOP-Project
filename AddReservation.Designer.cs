namespace OOPPROJECT
{
    partial class AddReservation
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
            combostaff = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            comboservice = new ComboBox();
            textdate = new TextBox();
            AddRes = new Button();
            combocustomer = new ComboBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // combostaff
            // 
            combostaff.FormattingEnabled = true;
            combostaff.Location = new Point(185, 114);
            combostaff.Name = "combostaff";
            combostaff.Size = new Size(151, 28);
            combostaff.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(88, 47);
            label1.Name = "label1";
            label1.Size = new Size(41, 20);
            label1.TabIndex = 1;
            label1.Text = "Date";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(88, 117);
            label2.Name = "label2";
            label2.Size = new Size(40, 20);
            label2.TabIndex = 2;
            label2.Text = "Staff";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(88, 216);
            label3.Name = "label3";
            label3.Size = new Size(56, 20);
            label3.TabIndex = 3;
            label3.Text = "Service";
            // 
            // comboservice
            // 
            comboservice.FormattingEnabled = true;
            comboservice.Location = new Point(185, 208);
            comboservice.Name = "comboservice";
            comboservice.Size = new Size(151, 28);
            comboservice.TabIndex = 4;
            // 
            // textdate
            // 
            textdate.Location = new Point(185, 47);
            textdate.Name = "textdate";
            textdate.Size = new Size(151, 27);
            textdate.TabIndex = 5;
            // 
            // AddRes
            // 
            AddRes.Location = new Point(603, 358);
            AddRes.Name = "AddRes";
            AddRes.Size = new Size(94, 29);
            AddRes.TabIndex = 6;
            AddRes.Text = "Add";
            AddRes.UseVisualStyleBackColor = true;
            AddRes.Click += AddRes_Click_1;
            // 
            // combocustomer
            // 
            combocustomer.FormattingEnabled = true;
            combocustomer.Location = new Point(185, 303);
            combocustomer.Name = "combocustomer";
            combocustomer.Size = new Size(151, 28);
            combocustomer.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(88, 311);
            label4.Name = "label4";
            label4.Size = new Size(72, 20);
            label4.TabIndex = 8;
            label4.Text = "Customer";
            // 
            // AddReservation
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(combocustomer);
            Controls.Add(AddRes);
            Controls.Add(textdate);
            Controls.Add(comboservice);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(combostaff);
            Name = "AddReservation";
            Text = "AddReservation";
            Load += AddReservation_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox combostaff;
        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox comboservice;
        private TextBox textdate;
        private Button AddRes;
        private ComboBox combocustomer;
        private Label label4;
    }
}