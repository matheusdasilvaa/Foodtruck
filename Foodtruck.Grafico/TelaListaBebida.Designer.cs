namespace Foodtruck.Grafico
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
            this.clNomeBebida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTamanhoBebida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clValorBebida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgBebidas)).BeginInit();
            this.SuspendLayout();
            // 
            // btAdicionaBebida
            // 
            this.btAdicionaBebida.Location = new System.Drawing.Point(12, 12);
            this.btAdicionaBebida.Name = "btAdicionaBebida";
            this.btAdicionaBebida.Size = new System.Drawing.Size(110, 35);
            this.btAdicionaBebida.TabIndex = 0;
            this.btAdicionaBebida.Text = "Adicionar";
            this.btAdicionaBebida.UseVisualStyleBackColor = true;
            this.btAdicionaBebida.Click += new System.EventHandler(this.btAdicionaBebida_Click);
            // 
            // btRemoverBebida
            // 
            this.btRemoverBebida.Location = new System.Drawing.Point(128, 12);
            this.btRemoverBebida.Name = "btRemoverBebida";
            this.btRemoverBebida.Size = new System.Drawing.Size(110, 35);
            this.btRemoverBebida.TabIndex = 1;
            this.btRemoverBebida.Text = "Remover";
            this.btRemoverBebida.UseVisualStyleBackColor = true;
            this.btRemoverBebida.Click += new System.EventHandler(this.btRemoverBebida_Click);
            // 
            // btAlterarBebida
            // 
            this.btAlterarBebida.Location = new System.Drawing.Point(244, 12);
            this.btAlterarBebida.Name = "btAlterarBebida";
            this.btAlterarBebida.Size = new System.Drawing.Size(110, 35);
            this.btAlterarBebida.TabIndex = 2;
            this.btAlterarBebida.Text = "Alterar";
            this.btAlterarBebida.UseVisualStyleBackColor = true;
            // 
            // dgBebidas
            // 
            this.dgBebidas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgBebidas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clNomeBebida,
            this.clTamanhoBebida,
            this.clValorBebida});
            this.dgBebidas.Location = new System.Drawing.Point(13, 54);
            this.dgBebidas.Name = "dgBebidas";
            this.dgBebidas.RowTemplate.Height = 24;
            this.dgBebidas.Size = new System.Drawing.Size(826, 386);
            this.dgBebidas.TabIndex = 3;
            // 
            // clNomeBebida
            // 
            this.clNomeBebida.HeaderText = "Nome";
            this.clNomeBebida.Name = "clNomeBebida";
            // 
            // clTamanhoBebida
            // 
            this.clTamanhoBebida.HeaderText = "Tamanho";
            this.clTamanhoBebida.Name = "clTamanhoBebida";
            // 
            // clValorBebida
            // 
            this.clValorBebida.HeaderText = "Valor (R$)";
            this.clValorBebida.Name = "clValorBebida";
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
            this.Name = "TelaListaBebida";
            this.Text = "TelaListaBebida";
            ((System.ComponentModel.ISupportInitialize)(this.dgBebidas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btAdicionaBebida;
        private System.Windows.Forms.Button btRemoverBebida;
        private System.Windows.Forms.Button btAlterarBebida;
        private System.Windows.Forms.DataGridView dgBebidas;
        private System.Windows.Forms.DataGridViewTextBoxColumn clNomeBebida;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTamanhoBebida;
        private System.Windows.Forms.DataGridViewTextBoxColumn clValorBebida;
    }
}