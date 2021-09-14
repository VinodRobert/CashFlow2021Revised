using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using CashFlow.PresentationLayer;
using CashFlow.PresentationLayer.Login;
using CashFlowGlobalVariables;
namespace CashFlow
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            GlobalVariables.connectedBy = 0;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new PresentationLayer.Login.frmUserLogin());
        }
    }
}
