using System;
using System.Collections.Generic;
using System.Linq;
using RapidInterface;

namespace GsmStat
{
    [DBAttribute(Caption = "Опрос резервуаров", IconFile = "TANKHISTORY.png")]
    public partial class TANKHISTORYView : DBViewInterface
    {
        public TANKHISTORYView()
        {
            InitializeComponent();
        }
    }
}
