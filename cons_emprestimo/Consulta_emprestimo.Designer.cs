﻿namespace cons_emprestimo
{
    partial class Consulta_emprestimo
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Consulta_emprestimo));
            this.labelSecao = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.txtItem = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboTipoItem = new System.Windows.Forms.ComboBox();
            this.txtDataReserva = new System.Windows.Forms.TextBox();
            this.txtLocal = new System.Windows.Forms.TextBox();
            this.txtNomeLeitor = new System.Windows.Forms.TextBox();
            this.txtDataFinal = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtNumReserva = new System.Windows.Forms.TextBox();
            this.labelNomeLeitor = new System.Windows.Forms.Label();
            this.labelLeitor = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelSecao
            // 
            this.labelSecao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelSecao.AutoSize = true;
            this.labelSecao.Enabled = false;
            this.labelSecao.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.labelSecao.Location = new System.Drawing.Point(669, 13);
            this.labelSecao.Name = "labelSecao";
            this.labelSecao.Size = new System.Drawing.Size(0, 17);
            this.labelSecao.TabIndex = 180;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(147, 91);
            this.dataGridView1.MaximumSize = new System.Drawing.Size(1146, 310);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1146, 310);
            this.dataGridView1.TabIndex = 177;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(182, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 17);
            this.label2.TabIndex = 176;
            this.label2.Text = "Item:";
            // 
            // txtItem
            // 
            this.txtItem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtItem.Enabled = false;
            this.txtItem.Location = new System.Drawing.Point(295, 11);
            this.txtItem.Name = "txtItem";
            this.txtItem.Size = new System.Drawing.Size(47, 20);
            this.txtItem.TabIndex = 156;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Enabled = false;
            this.label9.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(787, 37);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(125, 17);
            this.label9.TabIndex = 175;
            this.label9.Text = "Data da devolução:";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Enabled = false;
            this.label7.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(787, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 17);
            this.label7.TabIndex = 174;
            this.label7.Text = "Data de inicio:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Enabled = false;
            this.label3.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(481, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 17);
            this.label3.TabIndex = 171;
            this.label3.Text = "Local:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(182, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 17);
            this.label1.TabIndex = 170;
            this.label1.Text = "Tipo do Item:";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Enabled = false;
            this.label6.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(481, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 17);
            this.label6.TabIndex = 169;
            this.label6.Text = "Código do leitor:";
            // 
            // comboTipoItem
            // 
            this.comboTipoItem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboTipoItem.Enabled = false;
            this.comboTipoItem.FormattingEnabled = true;
            this.comboTipoItem.Location = new System.Drawing.Point(295, 36);
            this.comboTipoItem.Name = "comboTipoItem";
            this.comboTipoItem.Size = new System.Drawing.Size(100, 21);
            this.comboTipoItem.TabIndex = 159;
            // 
            // txtDataReserva
            // 
            this.txtDataReserva.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDataReserva.Enabled = false;
            this.txtDataReserva.Location = new System.Drawing.Point(914, 10);
            this.txtDataReserva.Name = "txtDataReserva";
            this.txtDataReserva.Size = new System.Drawing.Size(66, 20);
            this.txtDataReserva.TabIndex = 165;
            // 
            // txtLocal
            // 
            this.txtLocal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtLocal.Enabled = false;
            this.txtLocal.Location = new System.Drawing.Point(594, 11);
            this.txtLocal.Name = "txtLocal";
            this.txtLocal.Size = new System.Drawing.Size(47, 20);
            this.txtLocal.TabIndex = 160;
            // 
            // txtNomeLeitor
            // 
            this.txtNomeLeitor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNomeLeitor.Enabled = false;
            this.txtNomeLeitor.Location = new System.Drawing.Point(594, 36);
            this.txtNomeLeitor.Name = "txtNomeLeitor";
            this.txtNomeLeitor.Size = new System.Drawing.Size(47, 20);
            this.txtNomeLeitor.TabIndex = 158;
            this.txtNomeLeitor.Leave += new System.EventHandler(this.txtNomeLeitor_Leave);
            // 
            // txtDataFinal
            // 
            this.txtDataFinal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDataFinal.Enabled = false;
            this.txtDataFinal.Location = new System.Drawing.Point(914, 35);
            this.txtDataFinal.Name = "txtDataFinal";
            this.txtDataFinal.Size = new System.Drawing.Size(66, 20);
            this.txtDataFinal.TabIndex = 183;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Enabled = false;
            this.label10.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(1173, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(0, 17);
            this.label10.TabIndex = 187;
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.Enabled = false;
            this.label11.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label11.Location = new System.Drawing.Point(1072, 11);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(127, 17);
            this.label11.TabIndex = 186;
            this.label11.Text = "Número da reserva:";
            // 
            // txtNumReserva
            // 
            this.txtNumReserva.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNumReserva.Enabled = false;
            this.txtNumReserva.Location = new System.Drawing.Point(1199, 9);
            this.txtNumReserva.Name = "txtNumReserva";
            this.txtNumReserva.Size = new System.Drawing.Size(47, 20);
            this.txtNumReserva.TabIndex = 185;
            // 
            // labelNomeLeitor
            // 
            this.labelNomeLeitor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelNomeLeitor.AutoSize = true;
            this.labelNomeLeitor.Enabled = false;
            this.labelNomeLeitor.Location = new System.Drawing.Point(669, 39);
            this.labelNomeLeitor.MaximumSize = new System.Drawing.Size(100, 13);
            this.labelNomeLeitor.Name = "labelNomeLeitor";
            this.labelNomeLeitor.Size = new System.Drawing.Size(0, 13);
            this.labelNomeLeitor.TabIndex = 190;
            // 
            // labelLeitor
            // 
            this.labelLeitor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelLeitor.AutoSize = true;
            this.labelLeitor.Enabled = false;
            this.labelLeitor.Location = new System.Drawing.Point(648, 40);
            this.labelLeitor.MaximumSize = new System.Drawing.Size(100, 13);
            this.labelLeitor.Name = "labelLeitor";
            this.labelLeitor.Size = new System.Drawing.Size(0, 13);
            this.labelLeitor.TabIndex = 191;
            // 
            // Consulta_emprestimo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 408);
            this.Controls.Add(this.labelLeitor);
            this.Controls.Add(this.labelNomeLeitor);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtNumReserva);
            this.Controls.Add(this.txtDataFinal);
            this.Controls.Add(this.labelSecao);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtItem);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboTipoItem);
            this.Controls.Add(this.txtDataReserva);
            this.Controls.Add(this.txtLocal);
            this.Controls.Add(this.txtNomeLeitor);
            this.Controls.Add(this.label11);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1364, 447);
            this.Name = "Consulta_emprestimo";
            this.Text = "Consulta Emprestimo";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelSecao;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtItem;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboTipoItem;
        private System.Windows.Forms.TextBox txtDataReserva;
        private System.Windows.Forms.TextBox txtLocal;
        private System.Windows.Forms.TextBox txtNomeLeitor;
        private System.Windows.Forms.TextBox txtDataFinal;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtNumReserva;
        private System.Windows.Forms.Label labelNomeLeitor;
        private System.Windows.Forms.Label labelLeitor;
    }
}

