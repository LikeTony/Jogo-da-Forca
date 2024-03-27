namespace Jogos_da_forca
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
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblTenta = new System.Windows.Forms.Label();
            this.lblPalavra = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnTesta = new System.Windows.Forms.Button();
            this.lblFaltam = new System.Windows.Forms.Label();
            this.lblErro = new System.Windows.Forms.Label();
            this.btnComeca = new System.Windows.Forms.Button();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pbPernaE = new System.Windows.Forms.PictureBox();
            this.pbPernaD = new System.Windows.Forms.PictureBox();
            this.pbCabeca = new System.Windows.Forms.PictureBox();
            this.pbBracoD = new System.Windows.Forms.PictureBox();
            this.pbBracoE = new System.Windows.Forms.PictureBox();
            this.pbCorpo = new System.Windows.Forms.PictureBox();
            this.txbLetra = new System.Windows.Forms.TextBox();
            this.lblFruta = new System.Windows.Forms.Label();
            this.lblTema = new System.Windows.Forms.Label();
            this.btnDesistir = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lblResposta = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPernaE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPernaD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCabeca)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBracoD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBracoE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCorpo)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(47, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(203, 31);
            this.label3.TabIndex = 2;
            this.label3.Text = "Digite uma letra";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label5.Location = new System.Drawing.Point(46, 522);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 31);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tentativas";
            // 
            // lblTenta
            // 
            this.lblTenta.AutoSize = true;
            this.lblTenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblTenta.Location = new System.Drawing.Point(209, 481);
            this.lblTenta.Name = "lblTenta";
            this.lblTenta.Size = new System.Drawing.Size(0, 31);
            this.lblTenta.TabIndex = 5;
            // 
            // lblPalavra
            // 
            this.lblPalavra.AutoSize = true;
            this.lblPalavra.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.lblPalavra.Location = new System.Drawing.Point(45, 262);
            this.lblPalavra.Name = "lblPalavra";
            this.lblPalavra.Size = new System.Drawing.Size(0, 46);
            this.lblPalavra.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label8.Location = new System.Drawing.Point(442, 481);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 31);
            this.label8.TabIndex = 7;
            this.label8.Text = "Faltam";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label9.Location = new System.Drawing.Point(442, 522);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 31);
            this.label9.TabIndex = 8;
            this.label9.Text = "Erro";
            // 
            // btnTesta
            // 
            this.btnTesta.Enabled = false;
            this.btnTesta.Location = new System.Drawing.Point(193, 129);
            this.btnTesta.Name = "btnTesta";
            this.btnTesta.Size = new System.Drawing.Size(86, 32);
            this.btnTesta.TabIndex = 14;
            this.btnTesta.Text = "Testar";
            this.btnTesta.UseVisualStyleBackColor = true;
            this.btnTesta.Click += new System.EventHandler(this.btnTesta_Click);
            // 
            // lblFaltam
            // 
            this.lblFaltam.AutoSize = true;
            this.lblFaltam.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblFaltam.Location = new System.Drawing.Point(558, 481);
            this.lblFaltam.Name = "lblFaltam";
            this.lblFaltam.Size = new System.Drawing.Size(29, 31);
            this.lblFaltam.TabIndex = 15;
            this.lblFaltam.Text = "0";
            // 
            // lblErro
            // 
            this.lblErro.AutoSize = true;
            this.lblErro.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblErro.Location = new System.Drawing.Point(558, 522);
            this.lblErro.Name = "lblErro";
            this.lblErro.Size = new System.Drawing.Size(29, 31);
            this.lblErro.TabIndex = 16;
            this.lblErro.Text = "0";
            // 
            // btnComeca
            // 
            this.btnComeca.Location = new System.Drawing.Point(605, 499);
            this.btnComeca.Name = "btnComeca";
            this.btnComeca.Size = new System.Drawing.Size(159, 54);
            this.btnComeca.TabIndex = 17;
            this.btnComeca.Text = "Começar";
            this.btnComeca.UseVisualStyleBackColor = true;
            this.btnComeca.Click += new System.EventHandler(this.btnMaisUma_Click);
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox7.Image = global::Jogos_da_forca.Properties.Resources.icons8_gallows_1001;
            this.pictureBox7.InitialImage = global::Jogos_da_forca.Properties.Resources.icons8_triste_100;
            this.pictureBox7.Location = new System.Drawing.Point(548, 26);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(349, 369);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 28;
            this.pictureBox7.TabStop = false;
            // 
            // pbPernaE
            // 
            this.pbPernaE.BackColor = System.Drawing.Color.Transparent;
            this.pbPernaE.Image = global::Jogos_da_forca.Properties.Resources.icons8_linha_diagonal_100;
            this.pbPernaE.InitialImage = global::Jogos_da_forca.Properties.Resources.icons8_triste_100;
            this.pbPernaE.Location = new System.Drawing.Point(591, 307);
            this.pbPernaE.Name = "pbPernaE";
            this.pbPernaE.Size = new System.Drawing.Size(51, 69);
            this.pbPernaE.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbPernaE.TabIndex = 27;
            this.pbPernaE.TabStop = false;
            this.pbPernaE.Visible = false;
            // 
            // pbPernaD
            // 
            this.pbPernaD.BackColor = System.Drawing.Color.Transparent;
            this.pbPernaD.Image = global::Jogos_da_forca.Properties.Resources.icons8_linha_diagonal_100_direita;
            this.pbPernaD.InitialImage = global::Jogos_da_forca.Properties.Resources.icons8_triste_100;
            this.pbPernaD.Location = new System.Drawing.Point(646, 307);
            this.pbPernaD.Name = "pbPernaD";
            this.pbPernaD.Size = new System.Drawing.Size(51, 69);
            this.pbPernaD.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbPernaD.TabIndex = 26;
            this.pbPernaD.TabStop = false;
            this.pbPernaD.Visible = false;
            // 
            // pbCabeca
            // 
            this.pbCabeca.BackColor = System.Drawing.Color.Transparent;
            this.pbCabeca.Image = global::Jogos_da_forca.Properties.Resources.icons8_triste_100;
            this.pbCabeca.InitialImage = global::Jogos_da_forca.Properties.Resources.icons8_triste_100;
            this.pbCabeca.Location = new System.Drawing.Point(605, 171);
            this.pbCabeca.Name = "pbCabeca";
            this.pbCabeca.Size = new System.Drawing.Size(75, 60);
            this.pbCabeca.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCabeca.TabIndex = 18;
            this.pbCabeca.TabStop = false;
            this.pbCabeca.Visible = false;
            // 
            // pbBracoD
            // 
            this.pbBracoD.BackColor = System.Drawing.Color.Transparent;
            this.pbBracoD.Image = global::Jogos_da_forca.Properties.Resources.icons8_linha_diagonal_100_direita;
            this.pbBracoD.InitialImage = global::Jogos_da_forca.Properties.Resources.icons8_triste_100;
            this.pbBracoD.Location = new System.Drawing.Point(646, 232);
            this.pbBracoD.Name = "pbBracoD";
            this.pbBracoD.Size = new System.Drawing.Size(51, 76);
            this.pbBracoD.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbBracoD.TabIndex = 25;
            this.pbBracoD.TabStop = false;
            this.pbBracoD.Visible = false;
            // 
            // pbBracoE
            // 
            this.pbBracoE.BackColor = System.Drawing.Color.Transparent;
            this.pbBracoE.Image = global::Jogos_da_forca.Properties.Resources.icons8_linha_diagonal_100;
            this.pbBracoE.InitialImage = global::Jogos_da_forca.Properties.Resources.icons8_triste_100;
            this.pbBracoE.Location = new System.Drawing.Point(591, 231);
            this.pbBracoE.Name = "pbBracoE";
            this.pbBracoE.Size = new System.Drawing.Size(51, 77);
            this.pbBracoE.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbBracoE.TabIndex = 20;
            this.pbBracoE.TabStop = false;
            this.pbBracoE.Visible = false;
            // 
            // pbCorpo
            // 
            this.pbCorpo.BackColor = System.Drawing.Color.Transparent;
            this.pbCorpo.Image = global::Jogos_da_forca.Properties.Resources.icons8_linha_vertical_100;
            this.pbCorpo.InitialImage = global::Jogos_da_forca.Properties.Resources.icons8_triste_100;
            this.pbCorpo.Location = new System.Drawing.Point(588, 227);
            this.pbCorpo.Name = "pbCorpo";
            this.pbCorpo.Size = new System.Drawing.Size(112, 97);
            this.pbCorpo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCorpo.TabIndex = 19;
            this.pbCorpo.TabStop = false;
            this.pbCorpo.Visible = false;
            // 
            // txbLetra
            // 
            this.txbLetra.Enabled = false;
            this.txbLetra.Location = new System.Drawing.Point(53, 129);
            this.txbLetra.Multiline = true;
            this.txbLetra.Name = "txbLetra";
            this.txbLetra.Size = new System.Drawing.Size(117, 32);
            this.txbLetra.TabIndex = 29;
            // 
            // lblFruta
            // 
            this.lblFruta.AutoSize = true;
            this.lblFruta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFruta.Location = new System.Drawing.Point(402, 109);
            this.lblFruta.Name = "lblFruta";
            this.lblFruta.Size = new System.Drawing.Size(0, 20);
            this.lblFruta.TabIndex = 30;
            this.lblFruta.Visible = false;
            // 
            // lblTema
            // 
            this.lblTema.AutoSize = true;
            this.lblTema.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTema.Location = new System.Drawing.Point(382, 54);
            this.lblTema.Name = "lblTema";
            this.lblTema.Size = new System.Drawing.Size(91, 31);
            this.lblTema.TabIndex = 31;
            this.lblTema.Text = "Tema:";
            // 
            // btnDesistir
            // 
            this.btnDesistir.Location = new System.Drawing.Point(786, 499);
            this.btnDesistir.Name = "btnDesistir";
            this.btnDesistir.Size = new System.Drawing.Size(159, 54);
            this.btnDesistir.TabIndex = 32;
            this.btnDesistir.Text = "Desistir";
            this.btnDesistir.UseVisualStyleBackColor = true;
            this.btnDesistir.Click += new System.EventHandler(this.btnDesistir_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(47, 481);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 31);
            this.label4.TabIndex = 34;
            this.label4.Text = "Resposta:";
            // 
            // lblResposta
            // 
            this.lblResposta.AutoSize = true;
            this.lblResposta.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResposta.Location = new System.Drawing.Point(209, 414);
            this.lblResposta.Name = "lblResposta";
            this.lblResposta.Size = new System.Drawing.Size(0, 31);
            this.lblResposta.TabIndex = 35;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 598);
            this.Controls.Add(this.lblResposta);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pbPernaE);
            this.Controls.Add(this.pbPernaD);
            this.Controls.Add(this.pbCabeca);
            this.Controls.Add(this.pbBracoD);
            this.Controls.Add(this.pbBracoE);
            this.Controls.Add(this.btnDesistir);
            this.Controls.Add(this.lblTema);
            this.Controls.Add(this.lblFruta);
            this.Controls.Add(this.txbLetra);
            this.Controls.Add(this.pbCorpo);
            this.Controls.Add(this.btnComeca);
            this.Controls.Add(this.lblErro);
            this.Controls.Add(this.lblFaltam);
            this.Controls.Add(this.btnTesta);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblPalavra);
            this.Controls.Add(this.lblTenta);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox7);
            this.Name = "Form1";
            this.Text = "Jogo da forca";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPernaE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPernaD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCabeca)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBracoD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBracoE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCorpo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblTenta;
        private System.Windows.Forms.Label lblPalavra;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnTesta;
        private System.Windows.Forms.Label lblFaltam;
        private System.Windows.Forms.Label lblErro;
        private System.Windows.Forms.Button btnComeca;
        private System.Windows.Forms.PictureBox pbCabeca;
        private System.Windows.Forms.PictureBox pbCorpo;
        private System.Windows.Forms.PictureBox pbBracoE;
        private System.Windows.Forms.PictureBox pbBracoD;
        private System.Windows.Forms.PictureBox pbPernaD;
        private System.Windows.Forms.PictureBox pbPernaE;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.TextBox txbLetra;
        private System.Windows.Forms.Label lblFruta;
        private System.Windows.Forms.Label lblTema;
        private System.Windows.Forms.Button btnDesistir;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblResposta;
    }
}

