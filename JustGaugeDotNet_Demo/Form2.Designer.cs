namespace JustGaugeDotNet_Demo
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
            this.justGuage4 = new JustGaugeDotNet.JustGauge();
            this.SuspendLayout();
            // 
            // justGuage4
            // 
            this.justGuage4.BackColor = System.Drawing.Color.White;
            this.justGuage4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.justGuage4.Donut = false;
            this.justGuage4.ForeColor = System.Drawing.Color.Maroon;
            this.justGuage4.GaugeColor = System.Drawing.Color.White;
            this.justGuage4.GaugeScaleWidth = 100;
            this.justGuage4.HideInnerShadow = true;
            this.justGuage4.HideMinMax = false;
            this.justGuage4.Location = new System.Drawing.Point(0, 0);
            this.justGuage4.MaxValue = 1000;
            this.justGuage4.MinValue = 0;
            this.justGuage4.Name = "justGuage4";
            this.justGuage4.NumberFormat = true;
            this.justGuage4.Pointer = true;
            this.justGuage4.Reverse = false;
            this.justGuage4.Size = new System.Drawing.Size(284, 261);
            this.justGuage4.Subtitle = "Reverse";
            this.justGuage4.TabIndex = 3;
            this.justGuage4.Title = "JustGauge # 3";
            this.justGuage4.GaugeValue = 20;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.justGuage4);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private JustGaugeDotNet.JustGauge justGuage4;
    }
}