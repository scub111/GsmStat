using System;
using System.Collections.Generic;
using System.Linq;
using RapidInterface;

namespace GsmStat
{
    [DBAttribute(Caption = "Оператор", IconFile = "OPERATORS.png")]
    public partial class OPERATORSView : DBViewInterface
    {
        public OPERATORSView()
        {
            InitializeComponent();
        }
    }
}
