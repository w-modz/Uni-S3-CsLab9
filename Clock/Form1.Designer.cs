namespace Clock
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
            components = new System.ComponentModel.Container();
            label_date = new Label();
            label_time = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // label_date
            // 
            label_date.AutoSize = true;
            label_date.Location = new Point(31, 28);
            label_date.Name = "label_date";
            label_date.Size = new Size(184, 41);
            label_date.TabIndex = 0;
            label_date.Text = "sample_date";
            label_date.Click += label1_Click;
            // 
            // label_time
            // 
            label_time.AutoSize = true;
            label_time.Location = new Point(31, 105);
            label_time.Name = "label_time";
            label_time.Size = new Size(184, 41);
            label_time.TabIndex = 1;
            label_time.Text = "sample_time";
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label_time);
            Controls.Add(label_date);
            Name = "Form1";
            Text = "Clock";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_date;
        private Label label_time;
        private System.Windows.Forms.Timer timer1;
    }
}