﻿namespace Reserva
{
    partial class CadReserva
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadReserva));
            this.button1 = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.prazoReserva = new System.Windows.Forms.TextBox();
            this.dataReserva = new System.Windows.Forms.TextBox();
            this.nomeLeitor = new System.Windows.Forms.TextBox();
            this.codLeitor = new System.Windows.Forms.TextBox();
            this.localizacao = new System.Windows.Forms.TextBox();
            this.tipoItem = new System.Windows.Forms.TextBox();
            this.numExemplar = new System.Windows.Forms.TextBox();
            this.nomeItem = new System.Windows.Forms.TextBox();
            this.codItem = new System.Windows.Forms.TextBox();
            this.intencao = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblSituacao = new System.Windows.Forms.Label();
            this.situacao = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtNumReserva = new System.Windows.Forms.TextBox();
            this.btnItem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.Location = new System.Drawing.Point(698, 104);
            this.button1.MaximumSize = new System.Drawing.Size(75, 23);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 81;
            this.button1.Text = "Excluir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // save
            // 
            this.save.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.save.Location = new System.Drawing.Point(617, 104);
            this.save.MaximumSize = new System.Drawing.Size(75, 23);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(75, 23);
            this.save.TabIndex = 80;
            this.save.Text = "Salvar";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(109, 133);
            this.dataGridView1.MaximumSize = new System.Drawing.Size(1144, 263);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1144, 263);
            this.dataGridView1.TabIndex = 79;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // prazoReserva
            // 
            this.prazoReserva.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.prazoReserva.Location = new System.Drawing.Point(1176, 8);
            this.prazoReserva.Name = "prazoReserva";
            this.prazoReserva.Size = new System.Drawing.Size(77, 20);
            this.prazoReserva.TabIndex = 67;
            this.prazoReserva.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.prazoReserva_KeyPress);
            // 
            // dataReserva
            // 
            this.dataReserva.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataReserva.Location = new System.Drawing.Point(871, 57);
            this.dataReserva.Name = "dataReserva";
            this.dataReserva.Size = new System.Drawing.Size(68, 20);
            this.dataReserva.TabIndex = 66;
            this.dataReserva.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dataReserva_KeyPress);
            // 
            // nomeLeitor
            // 
            this.nomeLeitor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nomeLeitor.Enabled = false;
            this.nomeLeitor.Location = new System.Drawing.Point(871, 31);
            this.nomeLeitor.Name = "nomeLeitor";
            this.nomeLeitor.Size = new System.Drawing.Size(100, 20);
            this.nomeLeitor.TabIndex = 65;
            // 
            // codLeitor
            // 
            this.codLeitor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.codLeitor.Location = new System.Drawing.Point(871, 5);
            this.codLeitor.Name = "codLeitor";
            this.codLeitor.Size = new System.Drawing.Size(35, 20);
            this.codLeitor.TabIndex = 64;
            this.codLeitor.Leave += new System.EventHandler(this.codLeitor_Leave);
            // 
            // localizacao
            // 
            this.localizacao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.localizacao.Enabled = false;
            this.localizacao.Location = new System.Drawing.Point(575, 57);
            this.localizacao.Name = "localizacao";
            this.localizacao.Size = new System.Drawing.Size(100, 20);
            this.localizacao.TabIndex = 63;
            // 
            // tipoItem
            // 
            this.tipoItem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tipoItem.Enabled = false;
            this.tipoItem.Location = new System.Drawing.Point(575, 31);
            this.tipoItem.Name = "tipoItem";
            this.tipoItem.Size = new System.Drawing.Size(100, 20);
            this.tipoItem.TabIndex = 62;
            // 
            // numExemplar
            // 
            this.numExemplar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numExemplar.Enabled = false;
            this.numExemplar.Location = new System.Drawing.Point(575, 5);
            this.numExemplar.Name = "numExemplar";
            this.numExemplar.Size = new System.Drawing.Size(33, 20);
            this.numExemplar.TabIndex = 61;
            // 
            // nomeItem
            // 
            this.nomeItem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nomeItem.Enabled = false;
            this.nomeItem.Location = new System.Drawing.Point(242, 60);
            this.nomeItem.Name = "nomeItem";
            this.nomeItem.Size = new System.Drawing.Size(100, 20);
            this.nomeItem.TabIndex = 60;
            // 
            // codItem
            // 
            this.codItem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.codItem.Location = new System.Drawing.Point(242, 34);
            this.codItem.Name = "codItem";
            this.codItem.Size = new System.Drawing.Size(33, 20);
            this.codItem.TabIndex = 59;
            this.codItem.Text = " ";
            this.codItem.Leave += new System.EventHandler(this.codItem_Leave);
            // 
            // intencao
            // 
            this.intencao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.intencao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.intencao.FormattingEnabled = true;
            this.intencao.Items.AddRange(new object[] {
            "Reservar",
            "Devolver",
            " "});
            this.intencao.Location = new System.Drawing.Point(242, 7);
            this.intencao.Name = "intencao";
            this.intencao.Size = new System.Drawing.Size(100, 21);
            this.intencao.TabIndex = 58;
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label11.Location = new System.Drawing.Point(1040, 34);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 17);
            this.label11.TabIndex = 78;
            this.label11.Text = "Situação:";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(1039, 8);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(110, 17);
            this.label10.TabIndex = 77;
            this.label10.Text = "Prazo de reserva:";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(734, 57);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(105, 17);
            this.label9.TabIndex = 76;
            this.label9.Text = "Data de reserva:";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(734, 31);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 17);
            this.label8.TabIndex = 75;
            this.label8.Text = "Nome do Leitor:";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(734, 5);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 17);
            this.label7.TabIndex = 74;
            this.label7.Text = "Código do Leitor:";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(429, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 17);
            this.label6.TabIndex = 73;
            this.label6.Text = "Localização:";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(429, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 17);
            this.label5.TabIndex = 72;
            this.label5.Text = "Tipo  do Item:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(429, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 17);
            this.label4.TabIndex = 71;
            this.label4.Text = "Número do Exemplar:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(105, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 17);
            this.label3.TabIndex = 70;
            this.label3.Text = "Nome do Item:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(106, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 17);
            this.label1.TabIndex = 69;
            this.label1.Text = "Código do item:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(105, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 17);
            this.label2.TabIndex = 68;
            this.label2.Text = "Tipo de Movimento:";
            // 
            // lblSituacao
            // 
            this.lblSituacao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSituacao.AutoSize = true;
            this.lblSituacao.Location = new System.Drawing.Point(452, 117);
            this.lblSituacao.Name = "lblSituacao";
            this.lblSituacao.Size = new System.Drawing.Size(0, 13);
            this.lblSituacao.TabIndex = 82;
            // 
            // situacao
            // 
            this.situacao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.situacao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.situacao.FormattingEnabled = true;
            this.situacao.Items.AddRange(new object[] {
            "Disponivel ",
            "Reservado ",
            " "});
            this.situacao.Location = new System.Drawing.Point(1176, 33);
            this.situacao.Name = "situacao";
            this.situacao.Size = new System.Drawing.Size(77, 21);
            this.situacao.TabIndex = 83;
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label12.Location = new System.Drawing.Point(1040, 63);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(127, 17);
            this.label12.TabIndex = 84;
            this.label12.Text = "Número da reserva:";
            // 
            // txtNumReserva
            // 
            this.txtNumReserva.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNumReserva.Enabled = false;
            this.txtNumReserva.Location = new System.Drawing.Point(1176, 63);
            this.txtNumReserva.Name = "txtNumReserva";
            this.txtNumReserva.Size = new System.Drawing.Size(77, 20);
            this.txtNumReserva.TabIndex = 85;
            // 
            // btnItem
            // 
            this.btnItem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnItem.Location = new System.Drawing.Point(281, 34);
            this.btnItem.MaximumSize = new System.Drawing.Size(19, 20);
            this.btnItem.MinimumSize = new System.Drawing.Size(19, 20);
            this.btnItem.Name = "btnItem";
            this.btnItem.Size = new System.Drawing.Size(19, 20);
            this.btnItem.TabIndex = 158;
            this.btnItem.Text = "🔎";
            this.btnItem.UseVisualStyleBackColor = true;
            this.btnItem.Click += new System.EventHandler(this.btnItem_Click);
            // 
            // CadReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 408);
            this.Controls.Add(this.btnItem);
            this.Controls.Add(this.txtNumReserva);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.situacao);
            this.Controls.Add(this.lblSituacao);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.save);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.prazoReserva);
            this.Controls.Add(this.dataReserva);
            this.Controls.Add(this.nomeLeitor);
            this.Controls.Add(this.codLeitor);
            this.Controls.Add(this.localizacao);
            this.Controls.Add(this.tipoItem);
            this.Controls.Add(this.numExemplar);
            this.Controls.Add(this.nomeItem);
            this.Controls.Add(this.codItem);
            this.Controls.Add(this.intencao);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1364, 447);
            this.Name = "CadReserva";
            this.Text = "Cadastro de Reservas";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox prazoReserva;
        private System.Windows.Forms.TextBox dataReserva;
        private System.Windows.Forms.TextBox nomeLeitor;
        private System.Windows.Forms.TextBox codLeitor;
        private System.Windows.Forms.TextBox localizacao;
        private System.Windows.Forms.TextBox tipoItem;
        private System.Windows.Forms.TextBox numExemplar;
        private System.Windows.Forms.TextBox nomeItem;
        private System.Windows.Forms.TextBox codItem;
        private System.Windows.Forms.ComboBox intencao;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblSituacao;
        private System.Windows.Forms.ComboBox situacao;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtNumReserva;
        private System.Windows.Forms.Button btnItem;
    }
}