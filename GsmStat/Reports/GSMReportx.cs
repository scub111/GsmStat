using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using DevExpress.Data.Filtering;
using DevExpress.Xpo;

namespace GsmStat
{
    public partial class GSMReportx : XtraReport
    {
        public GSMReportx()
        {
            InitializeComponent();
        }
        

        private void repxControlDates_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            TIDELOGXPCollection.Criteria = CriteriaOperator.Parse("[KM_ID].[KM_ID] == 1 && [TD_TIME] Between(?, ?)", BeginDate.Value, EndDate.Value);
            TANKHISTORYXPCollection.Criteria = CriteriaOperator.Parse("[KM_ID].[KM_ID] == 1 && [TH_ST_TIME] Between(?, ?)", BeginDate.Value, EndDate.Value);
            
            TimeSpan delta = new TimeSpan(48, 0, 0);

            for (int i = 0; i < TIDELOGXPCollection.Count; i++)
            {
                TIDELOG tide = TIDELOGXPCollection[i] as TIDELOG;
                TANKHISTORYXPCollection.Filter = CriteriaOperator.Parse("[TH_ST_TIME] Between(?, ?)", tide.TD_TIME, tide.TD_TIME + delta);
                if (TANKHISTORYXPCollection.Count > 0)
                {
                    TANKHISTORY history = TANKHISTORYXPCollection[0] as TANKHISTORY;
                    tide.TankTime = history.TH_ST_TIME;
                    tide.TankLevel = (history.TH_ST_LEVEL / 10.0);
                    tide.TankTemperature = (history.TH_ST_TEMPER / 2.0);
                    tide.TankDensity = (history.TH_ST_PLOTN / 10000.0);
                }
            } 
            TANKHISTORYXPCollection.Filter = null;
            DateTime endDate = (DateTime)EndDate.Value;
            if (endDate != null)
                DisplayName = string.Format("Отчет ГСМ ({0:0000}.{1:00}.{2:00})", endDate.Year, endDate.Month, endDate.Day);
        } 
    }
}
