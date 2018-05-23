namespace Foodtruck.Grafico
{
    partial class ManterBebida
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
            this.btCancelar = new System.Windows.Forms.Button();
            this.btSalvar = new System.Windows.Forms.Button();
            this.tbValorBebida = new System.Windows.Forms.TextBox();
            this.tbTamanhoBebida = new System.Windows.Forms.TextBox();
            this.tbNomeBebida = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btCancelar
            // 
            this.btCancelar.Location = new System.Drawing.Point(31, 207);
            this.btCancelar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(128, 59);
            this.btCancelar.TabIndex = 19;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            // 
            // btSalvar
            // 
            this.btSalvar.Location = new System.Drawing.Point(176, 207);
            this.btSalvar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btSalvar.Name = "btSalvar";
            this.btSalvar.Size = new System.Drawing.Size(127, 59);
            this.btSalvar.TabIndex = 18;
            this.btSalvar.Text = "Salvar";
            this.btSalvar.UseVisualStyleBackColor = true;
            this.btSalvar.Click += new System.EventHandler(this.btSalvar_Click);
            // 
            // tbValorBebida
            // 
            this.tbValorBebida.Location = new System.Drawing.Point(103, 112);
            this.tbValorBebida.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbValorBebida.Name = "tbValorBebida";
            this.tbValorBebida.Size = new System.Drawing.Size(199, 22);
            this.tbValorBebida.TabIndex = 17;
            // 
            // tbTamanhoBebida
            // 
            this.tbTamanhoBebida.Location = new System.Drawing.Point(103, 66);
            this.tbTamanhoBebida.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbTamanhoBebida.Name = "tbTamanhoBebida";
            this.tbTamanhoBebida.Size = new System.Drawing.Size(199, 22);
            this.tbTamanhoBebida.TabIndex = 16;
            // 
            // tbNomeBebida
            // 
            this.tbNomeBebida.Location = new System.Drawing.Point(103, 22);
            this.tbNomeBebida.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbNomeBebida.Name = "tbNomeBebida";
            this.tbNomeBebida.Size = new System.Drawing.Size(199, 22);
            this.tbNomeBebida.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "Valor (R$):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Tamanho:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Nome:";
            // 
            // ManterBebida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 370);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btSalvar);
            this.Controls.Add(this.tbValorBebida);
            this.Controls.Add(this.tbTamanhoBebida);
            this.Controls.Add(this.tbNomeBebida);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ManterBebida";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManterBebida";
            this.Load += new System.EventHandler(this.ManterBebida_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Button btSalvar;
        private System.Windows.Forms.TextBox tbValorBebida;
        private System.Windows.Forms.TextBox tbTamanhoBebida;
        private System.Windows.Forms.TextBox tbNomeBebida;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}