using System;
using System.Collections.Generic;
using System.Linq;
using RapidInterface;

namespace GsmStat
{
    [DBAttribute(Caption = "Отгрузка", IconFile = "TIDELOG.png")]
    public partial class TIDELOGView : DBViewInterface
    {
        public TIDELOGView()
        {
            InitializeComponent();
        }
    }
}
