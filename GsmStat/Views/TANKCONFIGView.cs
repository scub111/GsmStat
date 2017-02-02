using System;
using System.Collections.Generic;
using System.Linq;
using RapidInterface;

namespace GsmStat
{
    [DBAttribute(Caption = "Резервуар", IconFile = "TANKCONFIG.png")]
    public partial class TANKCONFIGView : DBViewInterface
    {
        public TANKCONFIGView()
        {
            InitializeComponent();
        }
    }
}
