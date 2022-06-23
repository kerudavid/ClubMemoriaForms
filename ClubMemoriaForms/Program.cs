using ClubMemoriaForms.BusinessBO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClubMemoriaForms
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            ClientePruebaBO clientePruebaBO = new ClientePruebaBO();
            string i = clientePruebaBO.GetParentId();
            Application.Run(new Form1());
        }
    }
}
