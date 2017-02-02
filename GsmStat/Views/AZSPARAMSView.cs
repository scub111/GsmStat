using System;
using System.Collections.Generic;
using System.Linq;
using RapidInterface;

namespace GsmStat
{
    [DBAttribute(Caption = "АЗС", IconFile = "AZSPARAMS.png")]
    public partial class AZSPARAMSView : DBViewInterface
    {
        public AZSPARAMSView()
        {
            InitializeComponent();
        }
    }
}
