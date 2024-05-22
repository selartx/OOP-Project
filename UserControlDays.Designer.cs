namespace OOPPROJECT
{
    partial class UserControlDays
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            labeldays = new Label();
            textres = new TextBox();
            SuspendLayout();
            // 
            // labeldays
            // 
            labeldays.AutoSize = true;
            labeldays.Location = new Point(15, 10);
            labeldays.Name = "labeldays";
            labeldays.Size = new Size(25, 20);
            labeldays.TabIndex = 0;
            labeldays.Text = "00";
            // 
            // textres
            // 
            textres.Location = new Point(3, 48);
            textres.Multiline = true;
            textres.Name = "textres";
            textres.Size = new Size(195, 54);
            textres.TabIndex = 1;
            // 
            // UserControlDays
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            Controls.Add(textres);
            Controls.Add(labeldays);
            Name = "UserControlDays";
            Size = new Size(201, 105);
            Load += UserControlDays_Load;
            Click += UserControlDays_Click;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labeldays;
        public TextBox textres;
    }
}
