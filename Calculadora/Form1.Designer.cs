namespace Calculadora
{
    partial class Form1
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
            this.lbNumero1 = new System.Windows.Forms.Label();
            this.lbNumero2 = new System.Windows.Forms.Label();
            this.txtNumero1 = new System.Windows.Forms.TextBox();
            this.txtNumero2 = new System.Windows.Forms.TextBox();
            this.lbExpressao = new System.Windows.Forms.Label();
            this.lbResultado = new System.Windows.Forms.Label();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.txtExpressao = new System.Windows.Forms.TextBox();
            this.bntAdicao = new System.Windows.Forms.Button();
            this.bntSubtracao = new System.Windows.Forms.Button();
            this.bntMultiplicacao = new System.Windows.Forms.Button();
            this.bntDivisao = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbNumero1
            // 
            this.lbNumero1.AutoSize = true;
            this.lbNumero1.Location = new System.Drawing.Point(13, 13);
            this.lbNumero1.Name = "lbNumero1";
            this.lbNumero1.Size = new System.Drawing.Size(60, 13);
            this.lbNumero1.TabIndex = 0;
            this.lbNumero1.Text = "1º Número:";
            // 
            // lbNumero2
            // 
            this.lbNumero2.AutoSize = true;
            this.lbNumero2.Location = new System.Drawing.Point(136, 13);
            this.lbNumero2.Name = "lbNumero2";
            this.lbNumero2.Size = new System.Drawing.Size(60, 13);
            this.lbNumero2.TabIndex = 1;
            this.lbNumero2.Text = "2º Número:";
            // 
            // txtNumero1
            // 
            this.txtNumero1.Location = new System.Drawing.Point(16, 30);
            this.txtNumero1.Name = "txtNumero1";
            this.txtNumero1.Size = new System.Drawing.Size(100, 20);
            this.txtNumero1.TabIndex = 2;
            // 
            // txtNumero2
            // 
            this.txtNumero2.Location = new System.Drawing.Point(139, 30);
            this.txtNumero2.Name = "txtNumero2";
            this.txtNumero2.Size = new System.Drawing.Size(100, 20);
            this.txtNumero2.TabIndex = 3;
            // 
            // lbExpressao
            // 
            this.lbExpressao.AutoSize = true;
            this.lbExpressao.Location = new System.Drawing.Point(13, 120);
            this.lbExpressao.Name = "lbExpressao";
            this.lbExpressao.Size = new System.Drawing.Size(59, 13);
            this.lbExpressao.TabIndex = 4;
            this.lbExpressao.Text = "Expressão:";
            // 
            // lbResultado
            // 
            this.lbResultado.AutoSize = true;
            this.lbResultado.Location = new System.Drawing.Point(136, 120);
            this.lbResultado.Name = "lbResultado";
            this.lbResultado.Size = new System.Drawing.Size(58, 13);
            this.lbResultado.TabIndex = 5;
            this.lbResultado.Text = "Resultado:";
            // 
            // txtResultado
            // 
            this.txtResultado.Enabled = false;
            this.txtResultado.Location = new System.Drawing.Point(139, 136);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(100, 20);
            this.txtResultado.TabIndex = 7;
            // 
            // txtExpressao
            // 
            this.txtExpressao.Enabled = false;
            this.txtExpressao.Location = new System.Drawing.Point(16, 136);
            this.txtExpressao.Name = "txtExpressao";
            this.txtExpressao.Size = new System.Drawing.Size(100, 20);
            this.txtExpressao.TabIndex = 6;
            // 
            // bntAdicao
            // 
            this.bntAdicao.Location = new System.Drawing.Point(16, 56);
            this.bntAdicao.Name = "bntAdicao";
            this.bntAdicao.Size = new System.Drawing.Size(100, 25);
            this.bntAdicao.TabIndex = 8;
            this.bntAdicao.Text = "Adição (+)";
            this.bntAdicao.UseVisualStyleBackColor = true;
            this.bntAdicao.Click += new System.EventHandler(this.bntAdicao_Click);
            // 
            // bntSubtracao
            // 
            this.bntSubtracao.Location = new System.Drawing.Point(139, 56);
            this.bntSubtracao.Name = "bntSubtracao";
            this.bntSubtracao.Size = new System.Drawing.Size(100, 25);
            this.bntSubtracao.TabIndex = 9;
            this.bntSubtracao.Text = "Subtração (-)";
            this.bntSubtracao.UseVisualStyleBackColor = true;
            this.bntSubtracao.Click += new System.EventHandler(this.Subtracao);
            // 
            // bntMultiplicacao
            // 
            this.bntMultiplicacao.Location = new System.Drawing.Point(16, 92);
            this.bntMultiplicacao.Name = "bntMultiplicacao";
            this.bntMultiplicacao.Size = new System.Drawing.Size(100, 25);
            this.bntMultiplicacao.TabIndex = 10;
            this.bntMultiplicacao.Text = "Multiplicação (*)";
            this.bntMultiplicacao.UseVisualStyleBackColor = true;
            this.bntMultiplicacao.Click += new System.EventHandler(this.Multiplicacao);
            // 
            // bntDivisao
            // 
            this.bntDivisao.Location = new System.Drawing.Point(139, 92);
            this.bntDivisao.Name = "bntDivisao";
            this.bntDivisao.Size = new System.Drawing.Size(100, 25);
            this.bntDivisao.TabIndex = 11;
            this.bntDivisao.Text = "Divisão (/)";
            this.bntDivisao.UseVisualStyleBackColor = true;
            this.bntDivisao.Click += new System.EventHandler(this.bntDivisao_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(164, 163);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Fechar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnFechar);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(83, 163);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 13;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.Limpar);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(254, 198);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bntDivisao);
            this.Controls.Add(this.bntMultiplicacao);
            this.Controls.Add(this.bntSubtracao);
            this.Controls.Add(this.bntAdicao);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.txtExpressao);
            this.Controls.Add(this.lbResultado);
            this.Controls.Add(this.lbExpressao);
            this.Controls.Add(this.txtNumero2);
            this.Controls.Add(this.txtNumero1);
            this.Controls.Add(this.lbNumero2);
            this.Controls.Add(this.lbNumero1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbNumero1;
        private System.Windows.Forms.Label lbNumero2;
        private System.Windows.Forms.TextBox txtNumero1;
        private System.Windows.Forms.TextBox txtNumero2;
        private System.Windows.Forms.Label lbExpressao;
        private System.Windows.Forms.Label lbResultado;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.TextBox txtExpressao;
        private System.Windows.Forms.Button bntAdicao;
        private System.Windows.Forms.Button bntSubtracao;
        private System.Windows.Forms.Button bntMultiplicacao;
        private System.Windows.Forms.Button bntDivisao;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnLimpar;
    }
}

