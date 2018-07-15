using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace zalohook
{ 
    class Program
    { 
        [STAThread]
        static void Main(string[] args)
        {
            //v01.Run();
            //v02.Run();
            status_01.Run(180000);
        }   
    }
}
