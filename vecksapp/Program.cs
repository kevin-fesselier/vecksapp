using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using CefSharp.WinForms;

namespace vecksapp
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

            CefSettings settings = new CefSettings();
            settings.CachePath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\vecksapp";
            CefSharp.Cef.Initialize(settings);

            var mainForm = new mainForm();
            var browser = new ChromiumWebBrowser("https://web.whatsapp.com/");
            mainForm.Controls.Add(browser);

            mainForm.ShowInTaskbar = false;
            Application.Run(mainForm);

        }
    }
}


