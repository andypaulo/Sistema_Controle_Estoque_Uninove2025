using Sistema_de_Estoque_de_Produtos___UNINOVE;
using System;
using System.Windows.Forms;

namespace Sistema_de_Estoque_de_Produtos___UNINOVE
{
    internal static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new UserInterface.FormLogin());
        }
    }
}