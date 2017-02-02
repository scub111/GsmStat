using System;
using System.Collections.Generic;
using System.Linq;
using RapidInterface;

namespace GsmStat
{
    [DBAttribute(Caption = "КМАЗС", IconFile = "KMAZS.png")]
    public partial class KMAZSView : DBViewInterface
    {
        public KMAZSView()
        {
            InitializeComponent();
        }
    }
}
