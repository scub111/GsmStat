using System;
using System.Collections.Generic;
using System.Linq;
using RapidInterface;

namespace GsmStat
{
    [DBAttribute(Caption = "", IconFile = "")]
    public partial class UploadReport : DBViewReport
    {
        public UploadReport()
        {
            InitializeComponent();
        }
    }
}
