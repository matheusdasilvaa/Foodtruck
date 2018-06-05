﻿namespace Foodtruck.Grafico
{
    partial class TelaListaBebida
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
            this.btAdicionaBebida = new System.Windows.Forms.Button();
            this.btRemoverBebida = new System.Windows.Forms.Button();
            this.btAlterarBebida = new System.Windows.Forms.Button();
            this.dgBebidas = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tamanho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgBebidas)).BeginInit();
            this.SuspendLayout();
            // 
            // btAdicionaBebida
            // 
            this.btAdicionaBebida.Location = new System.Drawing.Point(12, 12);
            this.btAdicionaBebida.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btAdicionaBebida.Name = "btAdicionaBebida";
            this.btAdicionaBebida.Size = new System.Drawing.Size(109, 34);
            this.btAdicionaBebida.TabIndex = 0;
            this.btAdicionaBebida.Text = "Adicionar";
            this.btAdicionaBebida.UseVisualStyleBackColor = true;
            this.btAdicionaBebida.Click += new System.EventHandler(this.btAdicionaBebida_Click);
            // 
            // btRemoverBebida
            // 
            this.btRemoverBebida.Location = new System.Drawing.Point(128, 12);
            this.btRemoverBebida.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btRemoverBebida.Name = "btRemoverBebida";
            this.btRemoverBebida.Size = new System.Drawing.Size(109, 34);
            this.btRemoverBebida.TabIndex = 1;
            this.btRemoverBebida.Text = "Remover";
            this.btRemoverBebida.UseVisualStyleBackColor = true;
            this.btRemoverBebida.Click += new System.EventHandler(this.btRemoverBebida_Click);
            // 
            // btAlterarBebida
            // 
            this.btAlterarBebida.Location = new System.Drawing.Point(244, 12);
            this.btAlterarBebida.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btAlterarBebida.Name = "btAlterarBebida";
            this.btAlterarBebida.Size = new System.Drawing.Size(109, 34);
            this.btAlterarBebida.TabIndex = 2;
            this.btAlterarBebida.Text = "Alterar";
            this.btAlterarBebida.UseVisualStyleBackColor = true;
            this.btAlterarBebida.Click += new System.EventHandler(this.btAlterarBebida_Click);
            // 
            // dgBebidas
            // 
            this.dgBebidas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgBebidas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Nome,
            this.Tamanho,
            this.Valor});
            this.dgBebidas.Location = new System.Drawing.Point(13, 54);
            this.dgBebidas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgBebidas.Name = "dgBebidas";
            this.dgBebidas.RowTemplate.Height = 24;
            this.dgBebidas.Size = new System.Drawing.Size(827, 386);
            this.dgBebidas.TabIndex = 3;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "id";
            this.Id.Name = "Id";
            // 
            // Nome
            // 
            this.Nome.DataPropertyName = "Nome";
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            // 
            // Tamanho
            // 
            this.Tamanho.DataPropertyName = "Tamanho";
            this.Tamanho.HeaderText = "Tamanho";
            this.Tamanho.Name = "Tamanho";
            // 
            // Valor
            // 
            this.Valor.DataPropertyName = "Valor";
            this.Valor.HeaderText = "Valor (R$)";
            this.Valor.Name = "Valor";
            // 
            // TelaListaBebida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 452);
            this.Controls.Add(this.dgBebidas);
            this.Controls.Add(this.btAlterarBebida);
            this.Controls.Add(this.btRemoverBebida);
            this.Controls.Add(this.btAdicionaBebida);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "TelaListaBebida";
            this.Text = "TelaListaBebida";
            this.Load += new System.EventHandler(this.TelaListaBebidas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgBebidas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btAdicionaBebida;
        private System.Windows.Forms.Button btRemoverBebida;
        private System.Windows.Forms.Button btAlterarBebida;
        private System.Windows.Forms.DataGridView dgBebidas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tamanho;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor;
    }
}