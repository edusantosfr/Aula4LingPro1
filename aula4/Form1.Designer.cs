namespace aula4
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
            this.button1 = new System.Windows.Forms.Button();
            this.listBoxPar = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxV1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxV2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.listBoxImpar = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(123, 174);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Resultado";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBoxPar
            // 
            this.listBoxPar.FormattingEnabled = true;
            this.listBoxPar.Location = new System.Drawing.Point(80, 219);
            this.listBoxPar.Name = "listBoxPar";
            this.listBoxPar.Size = new System.Drawing.Size(70, 82);
            this.listBoxPar.TabIndex = 1;
            this.listBoxPar.SelectedIndexChanged += new System.EventHandler(this.listBoxItens_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Valor Inicial:";
            // 
            // textBoxV1
            // 
            this.textBoxV1.Location = new System.Drawing.Point(142, 86);
            this.textBoxV1.Name = "textBoxV1";
            this.textBoxV1.Size = new System.Drawing.Size(100, 20);
            this.textBoxV1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Valor Final:";
            // 
            // textBoxV2
            // 
            this.textBoxV2.Location = new System.Drawing.Point(142, 127);
            this.textBoxV2.Name = "textBoxV2";
            this.textBoxV2.Size = new System.Drawing.Size(100, 20);
            this.textBoxV2.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(110, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 26);
            this.label3.TabIndex = 6;
            this.label3.Text = "Digite os dois valores \r\n a serem analisados:";
            // 
            // listBoxImpar
            // 
            this.listBoxImpar.FormattingEnabled = true;
            this.listBoxImpar.Location = new System.Drawing.Point(172, 219);
            this.listBoxImpar.Name = "listBoxImpar";
            this.listBoxImpar.Size = new System.Drawing.Size(70, 82);
            this.listBoxImpar.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBoxImpar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxV2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxV1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxPar);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBoxPar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxV1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxV2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listBoxImpar;
    }
}

