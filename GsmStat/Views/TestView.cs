using System;
using System.Collections.Generic;
using System.Linq;
using RapidInterface;

namespace GsmStat
{
    [DBAttribute(Caption = "Тест", IconFile = "Test.png")]
    public partial class TestView : DBViewInterface
    {
        public TestView()
        {
            InitializeComponent();
        }
    }
}
