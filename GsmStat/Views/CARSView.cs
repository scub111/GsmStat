using System;
using System.Collections.Generic;
using System.Linq;
using RapidInterface;

namespace GsmStat
{
    [DBAttribute(Caption = "Машина", IconFile = "CARS.png")]
    public partial class CARSView : DBViewInterface
    {
        public CARSView()
        {
            InitializeComponent();
        }
    }
}
