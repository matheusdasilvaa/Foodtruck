﻿namespace Foodtruck.Grafico
{
    partial class TelaListaLanches
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
            this.btAdicionarLanche = new System.Windows.Forms.Button();
            this.btRemoverLanche = new System.Windows.Forms.Button();
            this.btAlteraLanche = new System.Windows.Forms.Button();
            this.dgLanches = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgLanches)).BeginInit();
            this.SuspendLayout();
            // 
            // btAdicionarLanche
            // 
            this.btAdicionarLanche.Location = new System.Drawing.Point(12, 12);
            this.btAdicionarLanche.Name = "btAdicionarLanche";
            this.btAdicionarLanche.Size = new System.Drawing.Size(96, 33);
            this.btAdicionarLanche.TabIndex = 0;
            this.btAdicionarLanche.Text = "Adicionar";
            this.btAdicionarLanche.UseVisualStyleBackColor = true;
            this.btAdicionarLanche.Click += new System.EventHandler(this.btAdicionarLanche_Click);
            // 
            // btRemoverLanche
            // 
            this.btRemoverLanche.Location = new System.Drawing.Point(114, 12);
            this.btRemoverLanche.Name = "btRemoverLanche";
            this.btRemoverLanche.Size = new System.Drawing.Size(96, 33);
            this.btRemoverLanche.TabIndex = 1;
            this.btRemoverLanche.Text = "Remover";
            this.btRemoverLanche.UseVisualStyleBackColor = true;
            this.btRemoverLanche.Click += new System.EventHandler(this.btRemoverLanche_Click);
            // 
            // btAlteraLanche
            // 
            this.btAlteraLanche.Location = new System.Drawing.Point(216, 12);
            this.btAlteraLanche.Name = "btAlteraLanche";
            this.btAlteraLanche.Size = new System.Drawing.Size(96, 33);
            this.btAlteraLanche.TabIndex = 2;
            this.btAlteraLanche.Text = "Alterar";
            this.btAlteraLanche.UseVisualStyleBackColor = true;
            this.btAlteraLanche.Click += new System.EventHandler(this.btAlterarLanche_Click);
            // 
            // dgLanches
            // 
            this.dgLanches.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgLanches.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Nome,
            this.Valor});
            this.dgLanches.Location = new System.Drawing.Point(12, 62);
            this.dgLanches.Name = "dgLanches";
            this.dgLanches.RowTemplate.Height = 24;
            this.dgLanches.Size = new System.Drawing.Size(776, 376);
            this.dgLanches.TabIndex = 3;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Codigo";
            this.Id.Name = "Id";
            // 
            // Nome
            // 
            this.Nome.DataPropertyName = "Nome";
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            // 
            // Valor
            // 
            this.Valor.DataPropertyName = "Valor";
            this.Valor.HeaderText = "Valor (R$)";
            this.Valor.Name = "Valor";
            // 
            // TelaListaLanches
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgLanches);
            this.Controls.Add(this.btAlteraLanche);
            this.Controls.Add(this.btRemoverLanche);
            this.Controls.Add(this.btAdicionarLanche);
            this.Name = "TelaListaLanches";
            this.Text = "TelaListaLanches";
            this.Load += new System.EventHandler(this.TelaListaLanches_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgLanches)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btAdicionarLanche;
        private System.Windows.Forms.Button btRemoverLanche;
        private System.Windows.Forms.Button btAlteraLanche;
        private System.Windows.Forms.DataGridView dgLanches;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor;
    }
}