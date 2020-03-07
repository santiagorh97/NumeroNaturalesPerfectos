namespace Interfaz
{
    partial class Presentacion
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnValidar = new System.Windows.Forms.Button();
            this.TbNumeroInicial = new System.Windows.Forms.TextBox();
            this.TbNumeroFinal = new System.Windows.Forms.TextBox();
            this.TbResultado = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnValidar
            // 
            this.BtnValidar.Location = new System.Drawing.Point(428, 20);
            this.BtnValidar.Name = "BtnValidar";
            this.BtnValidar.Size = new System.Drawing.Size(75, 23);
            this.BtnValidar.TabIndex = 0;
            this.BtnValidar.Text = "Validar";
            this.BtnValidar.UseVisualStyleBackColor = true;
            this.BtnValidar.Click += new System.EventHandler(this.BtnValidar_Click);
            // 
            // TbNumeroInicial
            // 
            this.TbNumeroInicial.Location = new System.Drawing.Point(95, 22);
            this.TbNumeroInicial.Name = "TbNumeroInicial";
            this.TbNumeroInicial.Size = new System.Drawing.Size(100, 20);
            this.TbNumeroInicial.TabIndex = 1;
            // 
            // TbNumeroFinal
            // 
            this.TbNumeroFinal.Location = new System.Drawing.Point(279, 22);
            this.TbNumeroFinal.Name = "TbNumeroFinal";
            this.TbNumeroFinal.Size = new System.Drawing.Size(100, 20);
            this.TbNumeroFinal.TabIndex = 2;
            // 
            // TbResultado
            // 
            this.TbResultado.Location = new System.Drawing.Point(12, 49);
            this.TbResultado.Multiline = true;
            this.TbResultado.Name = "TbResultado";
            this.TbResultado.Size = new System.Drawing.Size(491, 107);
            this.TbResultado.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Numero Inicial:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(201, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Numero Final:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 171);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TbResultado);
            this.Controls.Add(this.TbNumeroFinal);
            this.Controls.Add(this.TbNumeroInicial);
            this.Controls.Add(this.BtnValidar);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Presentacion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnValidar;
        private System.Windows.Forms.TextBox TbNumeroInicial;
        private System.Windows.Forms.TextBox TbNumeroFinal;
        private System.Windows.Forms.TextBox TbResultado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

