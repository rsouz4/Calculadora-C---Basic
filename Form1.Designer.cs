namespace Calculadora
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtResultado = new TextBox();
            btnSete = new Button();
            btnCinco = new Button();
            btnDois = new Button();
            btnSoma = new Button();
            btnIgual = new Button();
            btnZero = new Button();
            btnVirgula = new Button();
            btnUm = new Button();
            btnQuatro = new Button();
            btnSeis = new Button();
            btnTres = new Button();
            btnSubtracao = new Button();
            btnOito = new Button();
            btnNove = new Button();
            btnMultiplicacao = new Button();
            btnDivisao = new Button();
            btnLimpar = new Button();
            lblOperacao = new Label();
            SuspendLayout();
            // 
            // txtResultado
            // 
            txtResultado.Location = new Point(12, 23);
            txtResultado.Name = "txtResultado";
            txtResultado.ReadOnly = true;
            txtResultado.Size = new Size(258, 23);
            txtResultado.TabIndex = 0;
            txtResultado.TextAlign = HorizontalAlignment.Right;
            txtResultado.TextChanged += txtResultado_TextChanged;
            // 
            // btnSete
            // 
            btnSete.Location = new Point(12, 112);
            btnSete.Name = "btnSete";
            btnSete.Size = new Size(60, 49);
            btnSete.TabIndex = 1;
            btnSete.Text = "7";
            btnSete.UseVisualStyleBackColor = true;
            btnSete.Click += btnSete_Click;
            // 
            // btnCinco
            // 
            btnCinco.Location = new Point(78, 167);
            btnCinco.Name = "btnCinco";
            btnCinco.Size = new Size(60, 49);
            btnCinco.TabIndex = 2;
            btnCinco.Text = "5";
            btnCinco.UseVisualStyleBackColor = true;
            btnCinco.Click += btnCinco_Click;
            // 
            // btnDois
            // 
            btnDois.Location = new Point(78, 222);
            btnDois.Name = "btnDois";
            btnDois.Size = new Size(60, 49);
            btnDois.TabIndex = 3;
            btnDois.Text = "2";
            btnDois.UseVisualStyleBackColor = true;
            btnDois.Click += btnDois_Click;
            // 
            // btnSoma
            // 
            btnSoma.Location = new Point(210, 277);
            btnSoma.Name = "btnSoma";
            btnSoma.Size = new Size(60, 49);
            btnSoma.TabIndex = 4;
            btnSoma.Text = "+";
            btnSoma.UseVisualStyleBackColor = true;
            btnSoma.Click += btnSoma_Click;
            // 
            // btnIgual
            // 
            btnIgual.Location = new Point(144, 277);
            btnIgual.Name = "btnIgual";
            btnIgual.Size = new Size(60, 49);
            btnIgual.TabIndex = 5;
            btnIgual.Text = "=";
            btnIgual.UseVisualStyleBackColor = true;
            btnIgual.Click += btnIgual_Click;
            // 
            // btnZero
            // 
            btnZero.Location = new Point(78, 277);
            btnZero.Name = "btnZero";
            btnZero.Size = new Size(60, 49);
            btnZero.TabIndex = 6;
            btnZero.Text = "0";
            btnZero.UseVisualStyleBackColor = true;
            btnZero.Click += btnZero_Click;
            // 
            // btnVirgula
            // 
            btnVirgula.Location = new Point(12, 277);
            btnVirgula.Name = "btnVirgula";
            btnVirgula.Size = new Size(60, 49);
            btnVirgula.TabIndex = 7;
            btnVirgula.Text = ",";
            btnVirgula.UseVisualStyleBackColor = true;
            btnVirgula.Click += btnVirgula_Click;
            // 
            // btnUm
            // 
            btnUm.Location = new Point(12, 222);
            btnUm.Name = "btnUm";
            btnUm.Size = new Size(60, 49);
            btnUm.TabIndex = 8;
            btnUm.Text = "1";
            btnUm.UseVisualStyleBackColor = true;
            btnUm.Click += btnUm_Click;
            // 
            // btnQuatro
            // 
            btnQuatro.Location = new Point(12, 167);
            btnQuatro.Name = "btnQuatro";
            btnQuatro.Size = new Size(60, 49);
            btnQuatro.TabIndex = 9;
            btnQuatro.Text = "4";
            btnQuatro.UseVisualStyleBackColor = true;
            btnQuatro.Click += btnQuatro_Click;
            // 
            // btnSeis
            // 
            btnSeis.Location = new Point(144, 167);
            btnSeis.Name = "btnSeis";
            btnSeis.Size = new Size(60, 49);
            btnSeis.TabIndex = 10;
            btnSeis.Text = "6";
            btnSeis.UseVisualStyleBackColor = true;
            btnSeis.Click += btnSeis_Click;
            // 
            // btnTres
            // 
            btnTres.Location = new Point(144, 222);
            btnTres.Name = "btnTres";
            btnTres.Size = new Size(60, 49);
            btnTres.TabIndex = 11;
            btnTres.Text = "3";
            btnTres.UseVisualStyleBackColor = true;
            btnTres.Click += btnTres_Click;
            // 
            // btnSubtracao
            // 
            btnSubtracao.Location = new Point(210, 222);
            btnSubtracao.Name = "btnSubtracao";
            btnSubtracao.Size = new Size(60, 49);
            btnSubtracao.TabIndex = 12;
            btnSubtracao.Text = "-";
            btnSubtracao.UseVisualStyleBackColor = true;
            btnSubtracao.Click += btnSubtracao_Click;
            // 
            // btnOito
            // 
            btnOito.Location = new Point(78, 112);
            btnOito.Name = "btnOito";
            btnOito.Size = new Size(60, 49);
            btnOito.TabIndex = 13;
            btnOito.Text = "8";
            btnOito.UseVisualStyleBackColor = true;
            btnOito.Click += btnOito_Click;
            // 
            // btnNove
            // 
            btnNove.Location = new Point(144, 112);
            btnNove.Name = "btnNove";
            btnNove.Size = new Size(60, 49);
            btnNove.TabIndex = 14;
            btnNove.Text = "9";
            btnNove.UseVisualStyleBackColor = true;
            btnNove.Click += btnNove_Click;
            // 
            // btnMultiplicacao
            // 
            btnMultiplicacao.Location = new Point(210, 167);
            btnMultiplicacao.Name = "btnMultiplicacao";
            btnMultiplicacao.Size = new Size(60, 49);
            btnMultiplicacao.TabIndex = 15;
            btnMultiplicacao.Text = "X";
            btnMultiplicacao.UseVisualStyleBackColor = true;
            btnMultiplicacao.Click += btnMultiplicacao_Click;
            // 
            // btnDivisao
            // 
            btnDivisao.Location = new Point(210, 112);
            btnDivisao.Name = "btnDivisao";
            btnDivisao.Size = new Size(60, 49);
            btnDivisao.TabIndex = 16;
            btnDivisao.Text = "/";
            btnDivisao.UseVisualStyleBackColor = true;
            btnDivisao.Click += btnDivisao_Click;
            // 
            // btnLimpar
            // 
            btnLimpar.Location = new Point(210, 57);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(60, 49);
            btnLimpar.TabIndex = 17;
            btnLimpar.Text = "C";
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += btnLimpar_Click_1;
            // 
            // lblOperacao
            // 
            lblOperacao.AutoSize = true;
            lblOperacao.Location = new Point(17, 27);
            lblOperacao.Name = "lblOperacao";
            lblOperacao.Size = new Size(0, 15);
            lblOperacao.TabIndex = 18;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(282, 343);
            Controls.Add(lblOperacao);
            Controls.Add(btnLimpar);
            Controls.Add(btnDivisao);
            Controls.Add(btnMultiplicacao);
            Controls.Add(btnNove);
            Controls.Add(btnOito);
            Controls.Add(btnSubtracao);
            Controls.Add(btnTres);
            Controls.Add(btnSeis);
            Controls.Add(btnQuatro);
            Controls.Add(btnUm);
            Controls.Add(btnVirgula);
            Controls.Add(btnZero);
            Controls.Add(btnIgual);
            Controls.Add(btnSoma);
            Controls.Add(btnDois);
            Controls.Add(btnCinco);
            Controls.Add(btnSete);
            Controls.Add(txtResultado);
            Name = "Form1";
            Text = "Calculadora";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtResultado;
        private Button btnSete;
        private Button btnCinco;
        private Button btnDois;
        private Button btnSoma;
        private Button btnIgual;
        private Button btnZero;
        private Button btnVirgula;
        private Button btnUm;
        private Button btnQuatro;
        private Button btnSeis;
        private Button btnTres;
        private Button btnSubtracao;
        private Button btnOito;
        private Button btnNove;
        private Button btnMultiplicacao;
        private Button btnDivisao;
        private Button btnLimpar;
        private Label lblOperacao;
    }
}
