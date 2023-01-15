﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tabelas
{
    public partial class Secao : Form
    {
        public Secao()
        {
            InitializeComponent();

            try
            {
                using (SqlConnection cn = new SqlConnection(Conn.Strcon))
                {
                    cn.Open();

                    string sqlQuery = "SELECT codSecao, descricaoSecao FROM MvtBibSecao";
                    using (SqlDataAdapter da = new SqlDataAdapter(sqlQuery, cn))
                    {
                        using (DataTable dt = new DataTable())
                        {
                            da.Fill(dt);
                            dataGridView1.DataSource = dt;
                        }
                    }formatColumns();
                }


            }

            catch (Exception ex)
            {
                MessageBox.Show("Falha! \n" + ex.Message);
            }
        }

        private void txtPesquisaSecao_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(Conn.Strcon))
                {
                    cn.Open();

                    var sqlQuery = "SELECT codSecao, descricaoSecao FROM MvtBibSecao WHERE descricaoSecao LIKE " + " '" + txtPesquisaSecao.Text + "%'";
                    using (SqlDataAdapter da = new SqlDataAdapter(sqlQuery, cn))
                    {
                        using (DataTable dt = new DataTable())
                        {
                            da.Fill(dt);
                            dataGridView1.DataSource = dt;
                        }
                    }formatColumns();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha! \n" + ex.Message);
            }
        }

        private void formatColumns()
        {

            this.dataGridView1.Columns["codSecao"].DefaultCellStyle
                .Alignment = DataGridViewContentAlignment.MiddleCenter;

            this.dataGridView1.Columns["descricaoSecao"].DefaultCellStyle
                .Alignment = DataGridViewContentAlignment.MiddleLeft;


            this.dataGridView1.Columns["codSecao"].HeaderText = "Código";
            this.dataGridView1.Columns["descricaoSecao"].HeaderText = "Descrição";

        }
    }
}
