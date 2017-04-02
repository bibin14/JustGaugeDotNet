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
            this.tableLayoutPanel1.Controls.Add(this.justGuage5, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.justGuage4, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.justGuage2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.justGuage3, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.justGuage6, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.justGuage7, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(904, 570);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // justGuage5
            // 
            this.justGuage5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.justGuage5.Donut = false;
            this.justGuage5.Location = new System.Drawing.Point(3, 174);
            this.justGuage5.MaxValue = 100;
            this.justGuage5.MinValue = 0;
            this.justGuage5.Name = "justGuage5";
            this.justGuage5.NumberFormat = true;
            this.justGuage5.Pointer = false;
            this.justGuage5.Reverse = false;
            this.justGuage5.Size = new System.Drawing.Size(446, 193);
            this.justGuage5.Subtitle = "No Pointer";
            this.justGuage5.TabIndex = 3;
            this.justGuage5.Title = "JustGauge # 3";
            this.justGuage5.Value = new decimal(new int[] {
            90,
            0,
            0,
            0});
            // 
            // justGuage4
            // 
            this.justGuage4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.justGuage4.Donut = false;
            this.justGuage4.Location = new System.Drawing.Point(455, 174);
            this.justGuage4.MaxValue = 1000;
            this.justGuage4.MinValue = 0;
            this.justGuage4.Name = "justGuage4";
            this.justGuage4.NumberFormat = true;
            this.justGuage4.Pointer = true;
            this.justGuage4.Reverse = true;
            this.justGuage4.Size = new System.Drawing.Size(446, 193);
            this.justGuage4.Subtitle = "Reverse";
            this.justGuage4.TabIndex = 2;
            this.justGuage4.Title = "JustGauge # 4";
            this.justGuage4.Value = new decimal(new int[] {
            200,
            0,
            0,
            0});
            // 
            // justGuage2
            // 
            this.justGuage2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.justGuage2.Donut = false;
            this.justGuage2.Location = new System.Drawing.Point(3, 3);
            this.justGuage2.MaxValue = 100;
            this.justGuage2.MinValue = 0;
            this.justGuage2.Name = "justGuage2";
            this.justGuage2.NumberFormat = true;
            this.justGuage2.Pointer = true;
            this.justGuage2.Reverse = false;
            this.justGuage2.Size = new System.Drawing.Size(446, 165);
            this.justGuage2.Subtitle = "Subtitle";
            this.justGuage2.TabIndex = 0;
            this.justGuage2.Title = "JustGauge # 1";
            this.justGuage2.Value = new decimal(new int[] {
            40,
            0,
            0,
            0});
            // 
            // justGuage3
            // 
            this.justGuage3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.justGuage3.Donut = false;
            this.justGuage3.Location = new System.Drawing.Point(455, 3);
            this.justGuage3.MaxValue = 100000;
            this.justGuage3.MinValue = 0;
            this.justGuage3.Name = "justGuage3";
            this.justGuage3.NumberFormat = true;
            this.justGuage3.Pointer = false;
            this.justGuage3.Reverse = false;
            this.justGuage3.Size = new System.Drawing.Size(446, 165);
            this.justGuage3.Subtitle = "Number Format";
            this.justGuage3.TabIndex = 1;
            this.justGuage3.Title = "JustGauge # 2";
            this.justGuage3.Value = new decimal(new int[] {
            69524,
            0,
            0,
            0});
            // 
            // justGuage6
            // 
            this.justGuage6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.justGuage6.Donut = true;
            this.justGuage6.Location = new System.Drawing.Point(3, 373);
            this.justGuage6.MaxValue = 100;
            this.justGuage6.MinValue = 0;
            this.justGuage6.Name = "justGuage6";
            this.justGuage6.NumberFormat = true;
            this.justGuage6.Pointer = true;
            this.justGuage6.Reverse = false;
            this.justGuage6.Size = new System.Drawing.Size(446, 194);
            this.justGuage6.Subtitle = "Donut";
            this.justGuage6.TabIndex = 4;
            this.justGuage6.Title = "JustGauge # 5";
            this.justGuage6.Value = new decimal(new int[] {
            55,
            0,
            0,
            0});
            // 
            // justGuage7
            // 
            this.justGuage7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.justGuage7.Donut = true;
            this.justGuage7.Location = new System.Drawing.Point(455, 373);
            this.justGuage7.MaxValue = 1500;
            this.justGuage7.MinValue = 100;
            this.justGuage7.Name = "justGuage7";
            this.justGuage7.NumberFormat = false;
            this.justGuage7.Pointer = false;
            this.justGuage7.Reverse = false;
            this.justGuage7.Size = new System.Drawing.Size(446, 194);
            this.justGuage7.Subtitle = " ";
            this.justGuage7.TabIndex = 5;
            this.justGuage7.Title = "JustGauge # 6";
            this.justGuage7.Value = new decimal(new int[] {
            1100,
            0,
            0,
            0});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 570);
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
    }
}

