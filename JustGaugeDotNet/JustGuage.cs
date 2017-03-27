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
    public partial class JustGuage : UserControl
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
                if(value >= MinValue && value <= MaxValue) { 
                    _value = value;
                    this.plotGauge();
                    //this.gaugeViewer.Document.InvokeScript("setValue", new object[] {value});
                }
                else
                {
                    throw new System.ArgumentOutOfRangeException("Value out of range.", "Value must be within the defined Min and Max value");
                }
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

        private bool _donut = true;
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

        #endregion

        #region DefaultValues

        #endregion

        public JustGuage()
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
            if (this.Value >= this.MinValue & this.Value <= this.MaxValue)
            {
                gaugeHtml = gaugeHtml.Replace("#Value#", this.Value.ToString());
            }
            else {  /// html : getRandomInt(0, 100)
                gaugeHtml = gaugeHtml.Replace("#Value#", "getRandomInt(" + this.MinValue + ","  + this.MaxValue + ")");
            }
          
            gaugeHtml = gaugeHtml.Replace("#Title#", this.Title);
            gaugeHtml = gaugeHtml.Replace("#SubTitle#", this.Subtitle);
            gaugeHtml = gaugeHtml.Replace("#Donut#", this.Donut.ToString().ToLower());

            //TextWriter tw = new StreamWriter("gaugeSrc.html", true);
            //tw.WriteLine(gaugeHtml);
            //tw.Close();

            //this.gaugeViewer.Url = new System.Uri(System.Environment.CurrentDirectory + "/gaugeSrc.html");

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
