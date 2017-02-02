using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using RapidInterface;

namespace GsmStat
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            DBConnection.InitSkin("Office 2007 Black");
            //KMAZSBASE.ConnectionHelper.Connect(DevExpress.Xpo.DB.AutoCreateOption.SchemaAlreadyExists);
            Application.Run(new MainForm());

        }
    }
}
