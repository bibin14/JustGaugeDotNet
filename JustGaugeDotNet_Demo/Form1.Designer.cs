namespace JustGaugeDotNet_Demo
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.justGauge2 = new JustGaugeDotNet.JustGauge();
            this.justGauge1 = new JustGaugeDotNet.JustGauge();
            this.justGuage5 = new JustGaugeDotNet.JustGauge();
            this.justGuage4 = new JustGaugeDotNet.JustGauge();
            this.justGuage2 = new JustGaugeDotNet.JustGauge();
            this.justGuage3 = new JustGaugeDotNet.JustGauge();
            this.justGuage6 = new JustGaugeDotNet.JustGauge();
            this.justGuage7 = new JustGaugeDotNet.JustGauge();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.justGauge2, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.justGauge1, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.justGuage5, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.justGuage4, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.justGuage2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.justGuage3, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.justGuage6, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.justGuage7, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(904, 633);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // justGauge2
            // 
            this.justGauge2.BackColor = System.Drawing.Color.White;
            this.justGauge2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.justGauge2.Donut = false;
            this.justGauge2.ForeColor = System.Drawing.Color.Black;
            this.justGauge2.GaugeColor = System.Drawing.Color.Empty;
            this.justGauge2.GaugeScaleWidth = 100;
            this.justGauge2.HideInnerShadow = false;
            this.justGauge2.HideMinMax = true;
            this.justGauge2.Location = new System.Drawing.Point(3, 477);
            this.justGauge2.MaxValue = 100;
            this.justGauge2.MinValue = 0;
            this.justGauge2.Name = "justGauge2";
            this.justGauge2.NumberFormat = true;
            this.justGauge2.Pointer = true;
            this.justGauge2.Reverse = false;
            this.justGauge2.Size = new System.Drawing.Size(446, 153);
            this.justGauge2.Subtitle = "Hide MinMax";
            this.justGauge2.TabIndex = 7;
            this.justGauge2.Title = "JustGauge # 7";
            this.justGauge2.GaugeValue = 12;
            // 
            // justGauge1
            // 
            this.justGauge1.BackColor = System.Drawing.Color.White;
            this.justGauge1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.justGauge1.Donut = false;
            this.justGauge1.ForeColor = System.Drawing.Color.Black;
            this.justGauge1.GaugeColor = System.Drawing.Color.Empty;
            this.justGauge1.GaugeScaleWidth = 30;
            this.justGauge1.HideInnerShadow = false;
            this.justGauge1.HideMinMax = false;
            this.justGauge1.Location = new System.Drawing.Point(455, 477);
            this.justGauge1.MaxValue = 100;
            this.justGauge1.MinValue = 0;
            this.justGauge1.Name = "justGauge1";
            this.justGauge1.NumberFormat = true;
            this.justGauge1.Pointer = true;
            this.justGauge1.Reverse = false;
            this.justGauge1.Size = new System.Drawing.Size(446, 153);
            this.justGauge1.Subtitle = "Gauge Scale Width";
            this.justGauge1.TabIndex = 6;
            this.justGauge1.Title = "JustGauge # 8";
            this.justGauge1.GaugeValue = 35;
            // 
            // justGuage5
            // 
            this.justGuage5.BackColor = System.Drawing.Color.White;
            this.justGuage5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.justGuage5.Donut = false;
            this.justGuage5.ForeColor = System.Drawing.Color.Black;
            this.justGuage5.GaugeColor = System.Drawing.Color.Empty;
            this.justGuage5.GaugeScaleWidth = 100;
            this.justGuage5.HideInnerShadow = false;
            this.justGuage5.HideMinMax = false;
            this.justGuage5.Location = new System.Drawing.Point(455, 161);
            this.justGuage5.MaxValue = 100;
            this.justGuage5.MinValue = 0;
            this.justGuage5.Name = "justGuage5";
            this.justGuage5.NumberFormat = true;
            this.justGuage5.Pointer = false;
            this.justGuage5.Reverse = false;
            this.justGuage5.Size = new System.Drawing.Size(446, 152);
            this.justGuage5.Subtitle = "No Pointer";
            this.justGuage5.TabIndex = 3;
            this.justGuage5.Title = "JustGauge # 4";
            this.justGuage5.GaugeValue = 90;
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
            this.justGuage4.Location = new System.Drawing.Point(3, 161);
            this.justGuage4.MaxValue = 1000;
            this.justGuage4.MinValue = 0;
            this.justGuage4.Name = "justGuage4";
            this.justGuage4.NumberFormat = true;
            this.justGuage4.Pointer = true;
            this.justGuage4.Reverse = true;
            this.justGuage4.Size = new System.Drawing.Size(446, 152);
            this.justGuage4.Subtitle = "Reverse";
            this.justGuage4.TabIndex = 2;
            this.justGuage4.Title = "JustGauge # 3";
            this.justGuage4.GaugeValue = 200;
            // 
            // justGuage2
            // 
            this.justGuage2.BackColor = System.Drawing.Color.White;
            this.justGuage2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.justGuage2.Donut = false;
            this.justGuage2.ForeColor = System.Drawing.Color.Black;
            this.justGuage2.GaugeColor = System.Drawing.Color.Empty;
            this.justGuage2.GaugeScaleWidth = 100;
            this.justGuage2.HideInnerShadow = false;
            this.justGuage2.HideMinMax = false;
            this.justGuage2.Location = new System.Drawing.Point(3, 3);
            this.justGuage2.MaxValue = 100;
            this.justGuage2.MinValue = 0;
            this.justGuage2.Name = "justGuage2";
            this.justGuage2.NumberFormat = true;
            this.justGuage2.Pointer = true;
            this.justGuage2.Reverse = false;
            this.justGuage2.Size = new System.Drawing.Size(446, 152);
            this.justGuage2.Subtitle = "Subtitle";
            this.justGuage2.TabIndex = 0;
            this.justGuage2.Title = "JustGauge # 1";
            this.justGuage2.GaugeValue =40;
            // 
            // justGuage3
            // 
            this.justGuage3.BackColor = System.Drawing.Color.White;
            this.justGuage3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.justGuage3.Donut = false;
            this.justGuage3.ForeColor = System.Drawing.Color.Black;
            this.justGuage3.GaugeColor = System.Drawing.Color.Empty;
            this.justGuage3.GaugeScaleWidth = 100;
            this.justGuage3.HideInnerShadow = false;
            this.justGuage3.HideMinMax = false;
            this.justGuage3.Location = new System.Drawing.Point(455, 3);
            this.justGuage3.MaxValue = 100000;
            this.justGuage3.MinValue = 0;
            this.justGuage3.Name = "justGuage3";
            this.justGuage3.NumberFormat = true;
            this.justGuage3.Pointer = false;
            this.justGuage3.Reverse = false;
            this.justGuage3.Size = new System.Drawing.Size(446, 152);
            this.justGuage3.Subtitle = "Number Format";
            this.justGuage3.TabIndex = 1;
            this.justGuage3.Title = "JustGauge # 2";
            this.justGuage3.GaugeValue = 69525;
            // 
            // justGuage6
            // 
            this.justGuage6.BackColor = System.Drawing.Color.White;
            this.justGuage6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.justGuage6.Donut = true;
            this.justGuage6.ForeColor = System.Drawing.Color.Black;
            this.justGuage6.GaugeColor = System.Drawing.Color.Empty;
            this.justGuage6.GaugeScaleWidth = 100;
            this.justGuage6.HideInnerShadow = false;
            this.justGuage6.HideMinMax = false;
            this.justGuage6.Location = new System.Drawing.Point(3, 319);
            this.justGuage6.MaxValue = 100;
            this.justGuage6.MinValue = 0;
            this.justGuage6.Name = "justGuage6";
            this.justGuage6.NumberFormat = true;
            this.justGuage6.Pointer = true;
            this.justGuage6.Reverse = false;
            this.justGuage6.Size = new System.Drawing.Size(446, 152);
            this.justGuage6.Subtitle = "Donut";
            this.justGuage6.TabIndex = 4;
            this.justGuage6.Title = "JustGauge # 5";
            this.justGuage6.GaugeValue = 55;
            // 
            // justGuage7
            // 
            this.justGuage7.BackColor = System.Drawing.Color.White;
            this.justGuage7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.justGuage7.Donut = false;
            this.justGuage7.ForeColor = System.Drawing.Color.Black;
            this.justGuage7.GaugeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.justGuage7.GaugeScaleWidth = 100;
            this.justGuage7.HideInnerShadow = false;
            this.justGuage7.HideMinMax = false;
            this.justGuage7.Location = new System.Drawing.Point(455, 319);
            this.justGuage7.MaxValue = 1500;
            this.justGuage7.MinValue = 100;
            this.justGuage7.Name = "justGuage7";
            this.justGuage7.NumberFormat = false;
            this.justGuage7.Pointer = false;
            this.justGuage7.Reverse = false;
            this.justGuage7.Size = new System.Drawing.Size(446, 152);
            this.justGuage7.Subtitle = "Gauge Backcolor";
            this.justGuage7.TabIndex = 5;
            this.justGuage7.Title = "JustGauge # 6";
            this.justGuage7.GaugeValue = 1100;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 633);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "JustGaugeDotNet Demo";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private JustGaugeDotNet.JustGauge justGuage1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private JustGaugeDotNet.JustGauge justGuage2;
        private JustGaugeDotNet.JustGauge justGuage3;
        private JustGaugeDotNet.JustGauge justGuage5;
        private JustGaugeDotNet.JustGauge justGuage4;
        private JustGaugeDotNet.JustGauge justGuage6;
        private JustGaugeDotNet.JustGauge justGuage7;
        private JustGaugeDotNet.JustGauge justGauge2;
        private JustGaugeDotNet.JustGauge justGauge1;
    }
}

