using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpenTK_Test
{
    class Program
    {
        public static AutoResetEvent CloseEvent = new AutoResetEvent(false);

        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();

            GLTest test;
            Application.Run(test = new GLTest());
        }
    }
}
