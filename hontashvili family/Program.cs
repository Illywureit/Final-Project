using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using hontashvili_family.UI;
using hontashvili_family;

namespace hontashvili_family
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
             //Application.Run(new Form_Client());
            Application.Run(new Form_Order());
            //Application.Run(new Form_Product());
            //Application.Run(new Form_City());
        }
    }
}
