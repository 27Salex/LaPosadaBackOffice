using LaPosadaDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LaPosadaBackOffice
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            try
            {
                // Intenta establecer la conexión al iniciar el programa
                LaPosadaDB.WaitForConnection().GetAwaiter().GetResult();

                // Si la conexión es exitosa, inicia la aplicación
                Application.Run(new MainForm());
            }
            catch (Exception ex)
            {
                // Manejar la excepción según sea necesario en la aplicación principal
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
