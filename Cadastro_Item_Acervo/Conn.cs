﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro_Item_Acervo
{
    internal class Conn
    {
        private static string server = @"DESKTOP-JTN552H\SQLEXPRESS";
        private static string dataBase = "CADASTRO_AUTOR";
        private static string user = "sa";
        private static string password = "05092002";

        /*
            ALTER TABLE MvtBibItemAcervo ADD CONSTRAINT fk_codAutor_MvtBibAutor FOREIGN KEY (codAutor) REFERENCES MvtBibAutor (codAutor)
            ALTER TABLE MvtBibItemAcervo ADD CONSTRAINT fk_codEditora_MvtBIbEditora FOREIGN KEY (cod_Editora) REFERENCES MvtBIbEditora (codEditora)
         */


        public static string Strcon
        {
            get { return $"Data Source= {server}; Integrated Security=False; Initial Catalog= {dataBase};User ID={user}; Password={password}"; }
        }
    }
}
