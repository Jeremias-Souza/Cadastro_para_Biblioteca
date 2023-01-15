using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteca_Estágio
{
    internal static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        /// 

        public static readonly string StrCon= @"Data Source=DESKTOP-LMGKQ6A\TREINAMENTO;Initial Catalog=CADASTRO_AUTOR;User ID='Jeremias Souza'; Password=MOVTECH2022; Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new CadastroAutor());
        }
    }
}
