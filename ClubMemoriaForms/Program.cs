using ClubMemoriaForms.BusinessBO;
using ClubMemoriaForms.Forms;
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
            AsistenciaBO clientePruebaBO = new AsistenciaBO();
            var i = clientePruebaBO.ConsultarPeriodoAsis("26/06/2022","28/06/2022");
            Application.Run(new Login());
        }
    }
}
