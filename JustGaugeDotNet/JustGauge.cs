using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Permissions;
using System.Runtime.InteropServices;
using System.IO;
using System.Reflection;

namespace JustGaugeDotNet
{
    [PermissionSet(SecurityAction.Demand, Name = "FullTrust")]
    [ComVisible(true)]
    public partial class JustGauge : UserControl
    {
        #region Properties
        [Category("JustGauge Values")]
        public int MinValue { get; set; }

        [Category("JustGauge Values")]
        public int MaxValue { get; set; }

        private decimal _value;
        [Category("JustGauge Values")]
        public decimal Value {
            get {
                return _value;
            }
            set {
                //if(value >= MinValue && value <= MaxValue) { 
                _value = value;
                this.plotGauge();
                //    //this.gaugeViewer.Document.InvokeScript("setValue", new object[] {value});
                //}
                //else
                //{
                //    throw new System.ArgumentOutOfRangeException("Value out of range.", "Value must be within the defined Min and Max value");
                //}
            }
        }

        private string _title; 
        [Category("JustGauge Values")]
        public string Title {
            get {
                return _title;
            }
            set {
                _title = value;
                this.plotGauge();
            }
        }

        private string _subtitle;
        [Category("JustGauge Values")]
        public string Subtitle
        {
            get
            {
                return _subtitle;
            }
            set
            {
                _subtitle = value;
                this.plotGauge();
            }
        }

        private bool _donut = false;
        [Category("JustGauge Values")]
        public bool Donut
        {
            get
            {
                return _donut;
            }
            set
            {
                _donut = value;
                this.plotGauge();
            }
        }

        private bool _pointer = true;
        [Category("JustGauge Values")]
        public bool Pointer
        {
            get
            {
                return _pointer;
            }
            set
            {
                _pointer = value;
                this.plotGauge();
            }
        }
        
        private bool _numformat = true;
        [Category("JustGauge Values")]
        public bool NumberFormat
        {
            get
            {
                return _numformat;
            }
            set
            {
                _numformat = value;
                this.plotGauge();
            }
        }
        
        private bool _reverse = false;
        [Category("JustGauge Values")]
        public bool Reverse
        {
            get
            {
                return _reverse;
            }
            set
            {
                _reverse = value;
                this.plotGauge();
            }
        }
        #endregion

        #region DefaultValues

        #endregion

        public JustGauge()
        {
            InitializeComponent();
            MinValue = 0;
            MaxValue = 100;
            this.Title = "Title";
            this.Subtitle = "Subtitle";
            this.plotGauge();
        }

        private void plotGauge()
        {
            string gaugeHtml = JustGaugeDotNet.Properties.Resources.justgauges;

            gaugeHtml = gaugeHtml.Replace("#MinValue#", this.MinValue.ToString());
            gaugeHtml = gaugeHtml.Replace("#MaxValue#", this.MaxValue.ToString());
            gaugeHtml = gaugeHtml.Replace("#Value#", this.Value.ToString());
            gaugeHtml = gaugeHtml.Replace("#Title#", this.Title);
            gaugeHtml = gaugeHtml.Replace("#SubTitle#", this.Subtitle);
            gaugeHtml = gaugeHtml.Replace("#Donut#", this.Donut.ToString().ToLower());
            gaugeHtml = gaugeHtml.Replace("#Pointer#", this.Pointer.ToString().ToLower());
            gaugeHtml = gaugeHtml.Replace("#NumberFormat#", this.NumberFormat.ToString().ToLower());
            gaugeHtml = gaugeHtml.Replace("#Reverse#", this.Reverse.ToString().ToLower());

            this.gaugeViewer.Navigate("about:blank");
            HtmlDocument doc = this.gaugeViewer.Document;
            doc.Write(String.Empty);
            this.gaugeViewer.DocumentText = gaugeHtml;
        }

        private void gaugeViewer_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
           // File.Delete("gaugeSrc.html");
        }
    }
}
