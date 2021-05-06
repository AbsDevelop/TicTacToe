
namespace ConversorDeMedidas
{
    partial class FormPr
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
            this.label2 = new System.Windows.Forms.Label();
            this.textMedida = new System.Windows.Forms.TextBox();
            this.btnKC = new System.Windows.Forms.Button();
            this.btnKF = new System.Windows.Forms.Button();
            this.btnCK = new System.Windows.Forms.Button();
            this.btnCF = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Dosis", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(147, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(498, 43);
            this.label1.TabIndex = 0;
            this.label1.Text = "Conversor de Medidas Termométricas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label2.Font = new System.Drawing.Font("Dosis", 9.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(212, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(369, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Digite a medida e escolha o tipo de conversão:";
            // 
            // textMedida
            // 
            this.textMedida.Font = new System.Drawing.Font("Dosis", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textMedida.Location = new System.Drawing.Point(347, 169);
            this.textMedida.Name = "textMedida";
            this.textMedida.Size = new System.Drawing.Size(100, 38);
            this.textMedida.TabIndex = 2;
            this.textMedida.TextChanged += new System.EventHandler(this.textMedida_TextChanged);
            // 
            // btnKC
            // 
            this.btnKC.BackColor = System.Drawing.SystemColors.Window;
            this.btnKC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKC.Font = new System.Drawing.Font("Dosis", 9.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKC.Location = new System.Drawing.Point(422, 241);
            this.btnKC.Name = "btnKC";
            this.btnKC.Size = new System.Drawing.Size(122, 41);
            this.btnKC.TabIndex = 5;
            this.btnKC.Text = "K -> °C";
            this.btnKC.UseVisualStyleBackColor = false;
            this.btnKC.Click += new System.EventHandler(this.btnKC_Click);
            // 
            // btnKF
            // 
            this.btnKF.BackColor = System.Drawing.SystemColors.Window;
            this.btnKF.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKF.Font = new System.Drawing.Font("Dosis", 9.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKF.Location = new System.Drawing.Point(578, 241);
            this.btnKF.Name = "btnKF";
            this.btnKF.Size = new System.Drawing.Size(122, 41);
            this.btnKF.TabIndex = 6;
            this.btnKF.Text = "K -> °F";
            this.btnKF.UseVisualStyleBackColor = false;
            this.btnKF.Click += new System.EventHandler(this.btnKF_Click);
            // 
            // btnCK
            // 
            this.btnCK.BackColor = System.Drawing.SystemColors.Window;
            this.btnCK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCK.Font = new System.Drawing.Font("Dosis", 9.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCK.Location = new System.Drawing.Point(267, 241);
            this.btnCK.Name = "btnCK";
            this.btnCK.Size = new System.Drawing.Size(122, 41);
            this.btnCK.TabIndex = 9;
            this.btnCK.Text = "°C -> K";
            this.btnCK.UseVisualStyleBackColor = false;
            this.btnCK.Click += new System.EventHandler(this.btnCK_Click);
            // 
            // btnCF
            // 
            this.btnCF.BackColor = System.Drawing.SystemColors.Window;
            this.btnCF.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCF.Font = new System.Drawing.Font("Dosis", 9.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCF.Location = new System.Drawing.Point(116, 239);
            this.btnCF.Name = "btnCF";
            this.btnCF.Size = new System.Drawing.Size(122, 43);
            this.btnCF.TabIndex = 11;
            this.btnCF.Text = "°C -> °F";
            this.btnCF.UseVisualStyleBackColor = false;
            this.btnCF.Click += new System.EventHandler(this.btnCF_Click);
            // 
            // FormPr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ConversorDeMedidas.Properties.Resources.wallpp;
            this.ClientSize = new System.Drawing.Size(800, 424);
            this.Controls.Add(this.btnCF);
            this.Controls.Add(this.btnCK);
            this.Controls.Add(this.btnKF);
            this.Controls.Add(this.btnKC);
            this.Controls.Add(this.textMedida);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormPr";
            this.Text = "Conversor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textMedida;
        private System.Windows.Forms.Button btnKC;
        private System.Windows.Forms.Button btnKF;
        private System.Windows.Forms.Button btnCK;
        private System.Windows.Forms.Button btnCF;
    }
}

