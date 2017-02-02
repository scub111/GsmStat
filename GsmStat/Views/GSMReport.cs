using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using RapidInterface;

namespace GsmStat
{
    [DBAttribute(Caption = "Отчет ГСМ", IconFile = "GSMReport.png")]
    public partial class GSMReport : DBViewBase
    {
        public GSMReport()
        {
            InitializeComponent();
        }

        private void GSMReport_Load(object sender, EventArgs e)
        {
            GSMReportx report = new GSMReportx();
            DateTime dtNow = DateTime.Now;
            TimeSpan tpDelta = new TimeSpan(1, 0, 0, 0);
            //report.EndDate.Value = new DateTime(dtNow.Year, dtNow.Month, dtNow.Day);
            DateTime dtTemp = new DateTime(dtNow.Year, dtNow.Month, dtNow.Day);
            report.EndDate.Value = dtNow;
            report.BeginDate.Value = dtTemp - tpDelta;

            printControl1.PrintingSystem = report.PrintingSystem;
            report.CreateDocument();            
        }
    }
}
