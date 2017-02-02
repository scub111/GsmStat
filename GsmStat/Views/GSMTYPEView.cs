using System;
using System.Collections.Generic;
using System.Linq;
using RapidInterface;

namespace GsmStat
{
    [DBAttribute(Caption = "ГСМ", IconFile = "GSMTYPE.png")]
    public partial class GSMTYPEView : DBViewInterface
    {
        public GSMTYPEView()
        {
            InitializeComponent();
        }
    }
}
