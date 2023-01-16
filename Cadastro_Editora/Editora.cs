﻿using Reserva;
using System.Data.SqlClient;

namespace Cadastro_Editora
{
    public class Editora
    {
        public int codEditora { get; set; }
        public string nome { get; set; }

         public void Salvar ()
         {
            if (this.codEditora == 0)
            {
                var sql = "INSERT INTO MvtBibEditora (nome) VALUES (@nome)";
                using (SqlConnection cn = new SqlConnection(Conn.Strcon))
                {
                    cn.Open();
                    using (var cmd = new SqlCommand(sql, cn))
                    {

                        cmd.Parameters.AddWithValue("@nome", this.nome);

                        cmd.ExecuteNonQuery();
                    }
                    cn.Close();
                }

                return;
            }
            else
            {
                var sql = "UPDATE MvtBibEditora SET nome = @nome WHERE codEditora = @codEditora";
                using (SqlConnection cn = new SqlConnection(Conn.Strcon))
                {
                    cn.Open();
                    using (var cmd = new SqlCommand(sql, cn))
                    {

                        cmd.Parameters.AddWithValue("@nome", this.nome);
                        cmd.Parameters.AddWithValue("@codEditora", this.codEditora);

                        cmd.ExecuteNonQuery();
                    }
                    cn.Close();
                }
            }
        }
    }
}
