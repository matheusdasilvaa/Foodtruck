namespace Foodtruck.Grafico
{
    partial class ManterLanche
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
            this.btCancelarCadastrolanche = new System.Windows.Forms.Button();
            this.btSalvarLanche = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbNomeLanche = new System.Windows.Forms.TextBox();
            this.tbValorLanche = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbIdLanche = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btCancelarCadastrolanche
            // 
            this.btCancelarCadastrolanche.Location = new System.Drawing.Point(182, 209);
            this.btCancelarCadastrolanche.Name = "btCancelarCadastrolanche";
            this.btCancelarCadastrolanche.Size = new System.Drawing.Size(82, 31);
            this.btCancelarCadastrolanche.TabIndex = 0;
            this.btCancelarCadastrolanche.Text = "Cancelar";
            this.btCancelarCadastrolanche.UseVisualStyleBackColor = true;
            // 
            // btSalvarLanche
            // 
            this.btSalvarLanche.Location = new System.Drawing.Point(42, 209);
            this.btSalvarLanche.Name = "btSalvarLanche";
            this.btSalvarLanche.Size = new System.Drawing.Size(82, 31);
            this.btSalvarLanche.TabIndex = 1;
            this.btSalvarLanche.Text = "Salvar";
            this.btSalvarLanche.UseVisualStyleBackColor = true;
            this.btSalvarLanche.Click += new System.EventHandler(this.btSalvarLanche_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Valor (R$):";
            // 
            // tbNomeLanche
            // 
            this.tbNomeLanche.Location = new System.Drawing.Point(164, 86);
            this.tbNomeLanche.Name = "tbNomeLanche";
            this.tbNomeLanche.Size = new System.Drawing.Size(100, 22);
            this.tbNomeLanche.TabIndex = 4;
            this.tbNomeLanche.TextChanged += new System.EventHandler(this.tbNomeLanche_TextChanged);
            // 
            // tbValorLanche
            // 
            this.tbValorLanche.Location = new System.Drawing.Point(164, 129);
            this.tbValorLanche.Name = "tbValorLanche";
            this.tbValorLanche.Size = new System.Drawing.Size(100, 22);
            this.tbValorLanche.TabIndex = 5;
            this.tbValorLanche.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textbox11_num);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(92, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Cadastrar Lanche";
            // 
            // tbIdLanche
            // 
            this.tbIdLanche.Location = new System.Drawing.Point(164, 44);
            this.tbIdLanche.Name = "tbIdLanche";
            this.tbIdLanche.Size = new System.Drawing.Size(100, 22);
            this.tbIdLanche.TabIndex = 8;
            this.tbIdLanche.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textbox11_num);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Código";
            // 
            // ManterLanche
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 323);
            this.Controls.Add(this.tbIdLanche);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbValorLanche);
            this.Controls.Add(this.tbNomeLanche);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btSalvarLanche);
            this.Controls.Add(this.btCancelarCadastrolanche);
            this.Name = "ManterLanche";
            this.Text = "TelaAdicionaLanche";
            this.Load += new System.EventHandler(this.TelaAdicionaLanche_Load);
            this.Shown += new System.EventHandler(this.TelaAdicionaLanche_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btCancelarCadastrolanche;
        private System.Windows.Forms.Button btSalvarLanche;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbNomeLanche;
        
        private System.Windows.Forms.TextBox tbValorLanche;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbIdLanche;
        private System.Windows.Forms.Label label4;
    }
}