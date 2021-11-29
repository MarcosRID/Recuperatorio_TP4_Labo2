using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace Mercado
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                Application.SetHighDpiMode(HighDpiMode.SystemAware);
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new FormPrincipal());

            }
            catch (InvalidOperationException ioe)
            {
                Archivos<Exception>.SerializarExceptionATexto(ioe);
            }
            catch (Exception ex)
            {

                Archivos<Exception>.SerializarExceptionATexto(ex);
            }
        }
    }
}
