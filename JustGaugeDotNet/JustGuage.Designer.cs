﻿namespace JustGaugeDotNet
{
    partial class JustGuage
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
            this.gaugeViewer = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // gaugeViewer
            // 
            this.gaugeViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gaugeViewer.Location = new System.Drawing.Point(0, 0);
            this.gaugeViewer.MinimumSize = new System.Drawing.Size(20, 20);
            this.gaugeViewer.Name = "gaugeViewer";
            this.gaugeViewer.ScriptErrorsSuppressed = true;
            this.gaugeViewer.ScrollBarsEnabled = false;
            this.gaugeViewer.Size = new System.Drawing.Size(386, 287);
            this.gaugeViewer.TabIndex = 0;
            this.gaugeViewer.Url = new System.Uri("", System.UriKind.Relative);
            this.gaugeViewer.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.gaugeViewer_DocumentCompleted);
            // 
            // JustGuage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gaugeViewer);
            this.Name = "JustGuage";
            this.Size = new System.Drawing.Size(386, 287);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser gaugeViewer;
    }
}
