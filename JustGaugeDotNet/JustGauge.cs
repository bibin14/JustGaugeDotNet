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
        [DisplayName("Min Value")]
        [Description("Beginning Value of the Gauge")]
        public int MinValue { get; set; }

        [Category("JustGauge Values")]
        [Description("Ending Value of the Gauge")]
        [DisplayName("Max Value")]
        public int MaxValue { get; set; }

        private decimal _value;
        [Category("JustGauge Values")]
        public decimal GaugeValue
        {
            get {
                return _value;
            }
            set {
                _value = value;
                if (this.gaugeViewer.DocumentText != "")
                {
                    object[] args = { _value };
                    this.gaugeViewer.Document.InvokeScript("setValue", args);
                }
                
              //  this.plotGauge();
            }
        }

        private string _title = "Title"; 
        [Category("JustGauge Values")]
        public string Title {
            get {
                return _title;
            }
            set {
                _title = value;
                if (this.gaugeViewer.DocumentText != "")
                {
                    this.plotGauge();
                }
            }
        }

        private string _subtitle = "Subtitle";
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
                if (this.gaugeViewer.DocumentText != "")
                {
                    this.plotGauge();
                }
            }
        }

        private bool _donut = false;
        [Category("JustGauge Values")]
        [Description("Indicates whether to display as Donut or not")]
        public bool Donut
        {
            get
            {
                return _donut;
            }
            set
            {
                _donut = value;
                if (this.gaugeViewer.DocumentText != "")
                {
                    this.plotGauge();
                }
            }
        }

        private bool _pointer = true;
        [Category("JustGauge Values")]
        [DisplayName("Enable Pointer")]
        [Description("Indicates whether to display Pointer on the Gauge or not")]
        public bool Pointer
        {
            get
            {
                return _pointer;
            }
            set
            {
                _pointer = value;
                if (this.gaugeViewer.DocumentText != "")
                {
                    this.plotGauge();
                }
            }
        }
        
        private bool _numformat = true;
        [Category("JustGauge Values")]
        [DisplayName("Format Numbers")]
        public bool NumberFormat
        {
            get
            {
                return _numformat;
            }
            set
            {
                _numformat = value;
                if (this.gaugeViewer.DocumentText != "")
                {
                    this.plotGauge();
                }
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
                if (this.gaugeViewer.DocumentText != "")
                {
                    this.plotGauge();
                }
            }
        }

        private bool _hideMinMax = false;
        [Category("JustGauge Values")]
        [DisplayName("Hide Min Max")]
        public bool HideMinMax
        {
            get
            {
                return _hideMinMax;
            }
            set
            {
                _hideMinMax = value;
                if (this.gaugeViewer.DocumentText != "")
                {
                    this.plotGauge();
                }
            }
        }

        private bool _hideInnerShadow = false;
        [Category("JustGauge Values")]
        [DisplayName("Hide Inner Shadow")]
        [Description("Indicates whether to display Inner Shadow of the Gauge or not")]
        public bool HideInnerShadow
        {
            get
            {
                return _hideInnerShadow;
            }
            set
            {
                _hideInnerShadow = value;
                if (this.gaugeViewer.DocumentText != "")
                {
                    this.plotGauge();
                }
            }
        }

        private Color _gaugeColor = Color.Empty; //= System.Drawing.Color.Gainsboro;
        [Category("JustGauge Values")]
        [DisplayName("Gauge BackColor")]
        public Color GaugeColor
        {
            get
            {
                return _gaugeColor;
            }
            set
            {
                _gaugeColor = value;
                if (this.gaugeViewer.DocumentText != "")
                {
                    this.plotGauge();
                }
            }
        }

        private int _gaugeScaleWidth =100;
        [Category("JustGauge Values")]
        [DisplayName("Gauge Scale Width")]
        public int GaugeScaleWidth
        {
            get
            {
                return _gaugeScaleWidth;
            }
            set
            {
                if (value >= 0 && value <= 100)
                {
                    _gaugeScaleWidth = value;
                    if (this.gaugeViewer.DocumentText != "")
                    {
                        this.plotGauge();
                    }
                }
                else
                {
                    throw new System.ArgumentOutOfRangeException("Value out of range.", "Value must be within the defined 1 and 100");
                }
            }
        }

        ////customSectors Property
        //private List<GaugeSector> _sectors = new List<GaugeSector>();
        //[Category("JustGauge Values")]
        //[DisplayName("Gauge Custom Sectors")]
        //[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        //[Browsable(true)]
        //List<GaugeSector> Sectors
        //{
        //    get {
        //        return _sectors;
        //    }
        //    set
        //    {
        //        _sectors = value;
        //    }
        // }

        #endregion

        #region DefaultValues

        #endregion

        public JustGauge()
        {
            InitializeComponent();
            MinValue = 0;
            MaxValue = 100;
            //this._gaugeColor = Color.Gainsboro;
            this.ForeColor = Color.Black;
            this.ForeColorChanged += new System.EventHandler(this.JustGauge_ForeColorChanged);
        }

        private void plotGauge()
        {
            string gaugeHtml = JustGaugeDotNet.Properties.Resources.justgauges;

            gaugeHtml = gaugeHtml.Replace("#MinValue#", this.MinValue.ToString());
            gaugeHtml = gaugeHtml.Replace("#MaxValue#", this.MaxValue.ToString());
            gaugeHtml = gaugeHtml.Replace("#Title#", this.Title);
            gaugeHtml = gaugeHtml.Replace("#SubTitle#", this.Subtitle);
            gaugeHtml = gaugeHtml.Replace("#Donut#", this.Donut.ToString().ToLower());
            gaugeHtml = gaugeHtml.Replace("#Pointer#", this.Pointer.ToString().ToLower());
            gaugeHtml = gaugeHtml.Replace("#NumberFormat#", this.NumberFormat.ToString().ToLower());
            gaugeHtml = gaugeHtml.Replace("#Reverse#", this.Reverse.ToString().ToLower());
            gaugeHtml = gaugeHtml.Replace("#HideMinMax#", this.HideMinMax.ToString().ToLower());
            gaugeHtml = gaugeHtml.Replace("#HideInnerShadow#", this.HideInnerShadow.ToString().ToLower());
            gaugeHtml = gaugeHtml.Replace("#FontFamily#", this.Font.Name.ToString());
            gaugeHtml = gaugeHtml.Replace("#FontColor#", this.ForeColor.Name.ToLower());
            gaugeHtml = gaugeHtml.Replace("#BackColor#", this.BackColor.Name.ToLower());
            gaugeHtml = gaugeHtml.Replace("#MTop#", this.Margin.Top.ToString());
            gaugeHtml = gaugeHtml.Replace("#MBtm#", this.Margin.Bottom.ToString());
            gaugeHtml = gaugeHtml.Replace("#MLft#", this.Margin.Left.ToString());
            gaugeHtml = gaugeHtml.Replace("#MRgt#", this.Margin.Right.ToString());
            gaugeHtml = gaugeHtml.Replace("#BackColor#", this.BackColor.Name.ToLower());
            gaugeHtml = gaugeHtml.Replace("#GaugeCustomSector#", this.GetCustomSectors());
            gaugeHtml = gaugeHtml.Replace("#GaugeScaleWidth#", Convert.ToDecimal(this.GaugeScaleWidth / 100.00).ToString());
            if (this.GaugeColor == Color.Empty)
            {
                gaugeHtml = gaugeHtml.Replace("#GaugeColor#", "");
            }
            else
            {
                gaugeHtml = gaugeHtml.Replace("#GaugeColor#", "gaugeColor: '" + this.GaugeColor.Name.ToLower() + "', ");

            }
           
            if (this.Font.Italic == true)
            {
                gaugeHtml = gaugeHtml.Replace("#FontStyle#", "italic");
            }
            else
            {
                gaugeHtml = gaugeHtml.Replace("#FontStyle#", "normal");
            }
                
            gaugeHtml = gaugeHtml.Replace("#Value#", this.GaugeValue.ToString());

            this.gaugeViewer.Navigate("about:blank");
            HtmlDocument doc = this.gaugeViewer.Document;
            doc.Write(String.Empty);
            this.gaugeViewer.DocumentText = gaugeHtml;
        }

        private void gaugeViewer_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
           // File.Delete("gaugeSrc.html");
        }

        #region Appearance
        private void JustGauge_FontChanged(object sender, EventArgs e)
        {
            if (this.gaugeViewer.DocumentText != "")
            {
                this.plotGauge();
            }
        }

        private void JustGauge_ForeColorChanged(object sender, EventArgs e)
        {
            if (this.gaugeViewer.DocumentText != "")
            {
                this.plotGauge();
            }
        }

        private void JustGauge_BackColorChanged(object sender, EventArgs e)
        {
            if (this.gaugeViewer.DocumentText != "")
            {
                this.plotGauge();
            }
        }

        private void JustGauge_MarginChanged(object sender, EventArgs e)
        {
            if (this.gaugeViewer.DocumentText != "")
            {
                this.plotGauge();
            }
        }
        #endregion

        #region Custom Sectors

        private List<GaugeSector> GaugeSectors = new List<GaugeSector>();

        public void AddCustomSector(Color SectorColor, int LowValue, int HighValue)
        {
            GaugeSector _sector = new JustGaugeDotNet.GaugeSector();
            _sector.SectorColor = SectorColor;
            _sector.LowValue = LowValue;
            _sector.HighValue = HighValue;
            GaugeSectors.Add(_sector);
        }

        private string GetCustomSectors()
        {
            string sectorStr = "";
            foreach( GaugeSector _gSector in GaugeSectors)
            {
                if (sectorStr == "")
                {
                    sectorStr += sectorStr + ", ";
                }
                sectorStr += "{ color: '" + _gSector.SectorColor.Name.ToLower() + "', lo: " + _gSector.LowValue + ", hi: " + _gSector.HighValue + " }";
            }
            if(GaugeSectors.Count > 0)
            {
                sectorStr += "customSectors: [ " + sectorStr + " ], ";
            }
            return sectorStr;
        }

        #endregion

        private void JustGauge_Load(object sender, EventArgs e)
        {
            this.plotGauge();
        }
    }
}
