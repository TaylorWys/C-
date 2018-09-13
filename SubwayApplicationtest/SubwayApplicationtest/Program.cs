using System;
using System.Collections;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SubwayApplicationtest
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Form1 fm1 = new Form1();
            Application.Run(fm1);
        }
    }
}
