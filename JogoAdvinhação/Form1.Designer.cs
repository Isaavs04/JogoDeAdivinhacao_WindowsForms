namespace JogoAdvinhação
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnPalpite = new System.Windows.Forms.Button();
            this.txtAdivinhar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelJogo = new System.Windows.Forms.Label();
            this.txtNumMax = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.labelResposta = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnJoagrDeNovo = new System.Windows.Forms.Button();
            this.labelErroConfirma = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Orchid;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(623, 49);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::JogoAdvinhação.Properties.Resources.adivinhar;
            this.pictureBox1.Location = new System.Drawing.Point(238, 66);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(129, 127);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btnPalpite
            // 
            this.btnPalpite.BackColor = System.Drawing.Color.Orchid;
            this.btnPalpite.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPalpite.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPalpite.ForeColor = System.Drawing.SystemColors.Control;
            this.btnPalpite.Location = new System.Drawing.Point(152, 363);
            this.btnPalpite.Name = "btnPalpite";
            this.btnPalpite.Size = new System.Drawing.Size(178, 34);
            this.btnPalpite.TabIndex = 2;
            this.btnPalpite.Text = "Palpitar";
            this.btnPalpite.UseVisualStyleBackColor = false;
            this.btnPalpite.Click += new System.EventHandler(this.btnPalpite_Click);
            // 
            // txtAdivinhar
            // 
            this.txtAdivinhar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdivinhar.ForeColor = System.Drawing.Color.DarkMagenta;
            this.txtAdivinhar.Location = new System.Drawing.Point(152, 331);
            this.txtAdivinhar.Name = "txtAdivinhar";
            this.txtAdivinhar.Size = new System.Drawing.Size(178, 26);
            this.txtAdivinhar.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkMagenta;
            this.label1.Location = new System.Drawing.Point(148, 279);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(324, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tente advinhar o número que estou pensando \r\n";
            // 
            // labelJogo
            // 
            this.labelJogo.AutoSize = true;
            this.labelJogo.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelJogo.ForeColor = System.Drawing.Color.DarkMagenta;
            this.labelJogo.Location = new System.Drawing.Point(212, 298);
            this.labelJogo.Name = "labelJogo";
            this.labelJogo.Size = new System.Drawing.Size(190, 19);
            this.labelJogo.TabIndex = 5;
            this.labelJogo.Text = "É um número de zero a ___";
            // 
            // txtNumMax
            // 
            this.txtNumMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumMax.ForeColor = System.Drawing.Color.DarkMagenta;
            this.txtNumMax.Location = new System.Drawing.Point(117, 233);
            this.txtNumMax.Name = "txtNumMax";
            this.txtNumMax.Size = new System.Drawing.Size(178, 26);
            this.txtNumMax.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkMagenta;
            this.label3.Location = new System.Drawing.Point(113, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(388, 19);
            this.label3.TabIndex = 7;
            this.label3.Text = "Qual o número máximo para nosso jogo de adivinhação?";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkMagenta;
            this.panel2.Location = new System.Drawing.Point(0, 470);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(623, 10);
            this.panel2.TabIndex = 8;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.BackColor = System.Drawing.Color.Orchid;
            this.btnConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmar.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnConfirmar.Location = new System.Drawing.Point(301, 233);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(200, 26);
            this.btnConfirmar.TabIndex = 9;
            this.btnConfirmar.Text = "Confirmar número";
            this.btnConfirmar.UseVisualStyleBackColor = false;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.labelResposta);
            this.panel3.Location = new System.Drawing.Point(336, 331);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(136, 66);
            this.panel3.TabIndex = 10;
            // 
            // labelResposta
            // 
            this.labelResposta.AutoSize = true;
            this.labelResposta.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResposta.ForeColor = System.Drawing.Color.DarkMagenta;
            this.labelResposta.Location = new System.Drawing.Point(11, 8);
            this.labelResposta.Name = "labelResposta";
            this.labelResposta.Size = new System.Drawing.Size(20, 18);
            this.labelResposta.TabIndex = 0;
            this.labelResposta.Text = "...";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkMagenta;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Orchid;
            this.button1.Location = new System.Drawing.Point(562, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 26);
            this.button1.TabIndex = 11;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnJoagrDeNovo
            // 
            this.btnJoagrDeNovo.BackColor = System.Drawing.Color.DarkMagenta;
            this.btnJoagrDeNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnJoagrDeNovo.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJoagrDeNovo.ForeColor = System.Drawing.SystemColors.Control;
            this.btnJoagrDeNovo.Location = new System.Drawing.Point(155, 413);
            this.btnJoagrDeNovo.Name = "btnJoagrDeNovo";
            this.btnJoagrDeNovo.Size = new System.Drawing.Size(317, 26);
            this.btnJoagrDeNovo.TabIndex = 12;
            this.btnJoagrDeNovo.Text = "Jogar novamente";
            this.btnJoagrDeNovo.UseVisualStyleBackColor = false;
            this.btnJoagrDeNovo.Visible = false;
            this.btnJoagrDeNovo.Click += new System.EventHandler(this.button2_Click);
            // 
            // labelErroConfirma
            // 
            this.labelErroConfirma.AutoSize = true;
            this.labelErroConfirma.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelErroConfirma.ForeColor = System.Drawing.Color.DarkMagenta;
            this.labelErroConfirma.Location = new System.Drawing.Point(167, 262);
            this.labelErroConfirma.Name = "labelErroConfirma";
            this.labelErroConfirma.Size = new System.Drawing.Size(269, 19);
            this.labelErroConfirma.TabIndex = 13;
            this.labelErroConfirma.Text = "Digite um número igual ou maior que 5";
            this.labelErroConfirma.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 479);
            this.Controls.Add(this.labelErroConfirma);
            this.Controls.Add(this.btnJoagrDeNovo);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNumMax);
            this.Controls.Add(this.labelJogo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAdivinhar);
            this.Controls.Add(this.btnPalpite);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnPalpite;
        private System.Windows.Forms.TextBox txtAdivinhar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelJogo;
        private System.Windows.Forms.TextBox txtNumMax;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label labelResposta;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnJoagrDeNovo;
        private System.Windows.Forms.Label labelErroConfirma;
    }
}

