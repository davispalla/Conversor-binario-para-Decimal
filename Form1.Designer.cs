namespace BinarioParaDecimal
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Executar = new System.Windows.Forms.Button();
            this.txt_Binario = new System.Windows.Forms.TextBox();
            this.txt_Resultado = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Binário:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Resultado:";
            // 
            // btn_Executar
            // 
            this.btn_Executar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Executar.Location = new System.Drawing.Point(95, 138);
            this.btn_Executar.Name = "btn_Executar";
            this.btn_Executar.Size = new System.Drawing.Size(148, 102);
            this.btn_Executar.TabIndex = 3;
            this.btn_Executar.Text = "CONVERTER!";
            this.btn_Executar.UseVisualStyleBackColor = true;
            this.btn_Executar.Click += new System.EventHandler(this.btn_Executar_Click);
            // 
            // txt_Binario
            // 
            this.txt_Binario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Binario.Location = new System.Drawing.Point(95, 30);
            this.txt_Binario.MaxLength = 8;
            this.txt_Binario.Name = "txt_Binario";
            this.txt_Binario.Size = new System.Drawing.Size(148, 20);
            this.txt_Binario.TabIndex = 1;
            this.txt_Binario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_Binario.WordWrap = false;
            this.txt_Binario.Click += new System.EventHandler(this.txt_Binario_Click);
            this.txt_Binario.Enter += new System.EventHandler(this.txt_Binario_Enter);
            this.txt_Binario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Binario_KeyPress);
            this.txt_Binario.Leave += new System.EventHandler(this.txt_Binario_Leave);
            this.txt_Binario.Validating += new System.ComponentModel.CancelEventHandler(this.txt_Binario_Validating);
            // 
            // txt_Resultado
            // 
            this.txt_Resultado.Location = new System.Drawing.Point(95, 81);
            this.txt_Resultado.Name = "txt_Resultado";
            this.txt_Resultado.ReadOnly = true;
            this.txt_Resultado.Size = new System.Drawing.Size(148, 20);
            this.txt_Resultado.TabIndex = 2;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 265);
            this.Controls.Add(this.txt_Resultado);
            this.Controls.Add(this.txt_Binario);
            this.Controls.Add(this.btn_Executar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Conversor Binário para Decimal";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Executar;
        private System.Windows.Forms.TextBox txt_Binario;
        private System.Windows.Forms.TextBox txt_Resultado;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

