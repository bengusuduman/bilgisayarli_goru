using OfficeOpenXml; // BU SATIRI EN BAŞA EKLEYİN
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2 // Namespace'iniz farklıysa sizinkiyle değiştirin
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // *** ÇÖZÜM BURADA ***
            // Lisans kodu, Form1 açılmadan önce, programın en başında burada ayarlanmalıdır.
            // EPPlus 8 ve üzeri için DOĞRU KULLANIM BUDUR:
            ExcelPackage.License.SetNonCommercialPersonal("Bengüsu Duman");

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}