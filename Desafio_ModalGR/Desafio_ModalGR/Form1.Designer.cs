namespace Desafio_ModalGR
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.btnFormatar = new System.Windows.Forms.Button();
            this.txtNomeFormatado = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Digite seu nome completo:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(150, 25);
            this.txtNome.Multiline = true;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(221, 35);
            this.txtNome.TabIndex = 1;
            // 
            // btnFormatar
            // 
            this.btnFormatar.Location = new System.Drawing.Point(150, 125);
            this.btnFormatar.Name = "btnFormatar";
            this.btnFormatar.Size = new System.Drawing.Size(75, 23);
            this.btnFormatar.TabIndex = 2;
            this.btnFormatar.Text = "Formatar";
            this.btnFormatar.UseVisualStyleBackColor = true;
            this.btnFormatar.Click += new System.EventHandler(this.btnFormatar_Click);
            // 
            // txtNomeFormatado
            // 
            this.txtNomeFormatado.Location = new System.Drawing.Point(150, 67);
            this.txtNomeFormatado.Name = "txtNomeFormatado";
            this.txtNomeFormatado.Size = new System.Drawing.Size(221, 20);
            this.txtNomeFormatado.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nome formatado:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 160);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNomeFormatado);
            this.Controls.Add(this.btnFormatar);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Button btnFormatar;
        private System.Windows.Forms.TextBox txtNomeFormatado;
        private System.Windows.Forms.Label label2;
    }
}

