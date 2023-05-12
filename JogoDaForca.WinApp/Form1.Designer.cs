namespace JogoDaForca.WinApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            lbPalavra = new Label();
            label5 = new Label();
            lbTentativa = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            lbErros = new Label();
            lbFaltam = new Label();
            tbPalavra = new TextBox();
            btComeca = new Button();
            btTenta = new Button();
            mtLetra = new MaskedTextBox();
            pictureBox1 = new PictureBox();
            pbCabeca = new PictureBox();
            pbCorpo = new PictureBox();
            pbBracoEsquerdo = new PictureBox();
            pbBracoDireito = new PictureBox();
            pbPernaEsquerda = new PictureBox();
            pbPernaDireita = new PictureBox();
            pbFimDeJogo = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbCabeca).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbCorpo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbBracoEsquerdo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbBracoDireito).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbPernaEsquerda).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbPernaDireita).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbFimDeJogo).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(291, 38);
            label1.Name = "label1";
            label1.Size = new Size(80, 15);
            label1.TabIndex = 0;
            label1.Text = "Jogo da Forca";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(51, 89);
            label2.Name = "label2";
            label2.Size = new Size(91, 15);
            label2.TabIndex = 1;
            label2.Text = "Digite a palavra:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(48, 190);
            label3.Name = "label3";
            label3.Size = new Size(94, 15);
            label3.TabIndex = 2;
            label3.Text = "Digite uma letra:";
            // 
            // lbPalavra
            // 
            lbPalavra.AutoSize = true;
            lbPalavra.Location = new Point(120, 305);
            lbPalavra.Name = "lbPalavra";
            lbPalavra.Size = new Size(22, 15);
            lbPalavra.TabIndex = 3;
            lbPalavra.Text = "---";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(48, 305);
            label5.Name = "label5";
            label5.Size = new Size(48, 15);
            label5.TabIndex = 4;
            label5.Text = "Palavra:";
            // 
            // lbTentativa
            // 
            lbTentativa.AutoSize = true;
            lbTentativa.Location = new Point(120, 334);
            lbTentativa.Name = "lbTentativa";
            lbTentativa.Size = new Size(22, 15);
            lbTentativa.TabIndex = 5;
            lbTentativa.Text = "---";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(48, 334);
            label7.Name = "label7";
            label7.Size = new Size(62, 15);
            label7.TabIndex = 6;
            label7.Text = "Tentativas:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(51, 375);
            label8.Name = "label8";
            label8.Size = new Size(46, 15);
            label8.TabIndex = 7;
            label8.Text = "Faltam:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(48, 409);
            label9.Name = "label9";
            label9.Size = new Size(36, 15);
            label9.TabIndex = 8;
            label9.Text = "Erros:";
            // 
            // lbErros
            // 
            lbErros.AutoSize = true;
            lbErros.Location = new Point(98, 409);
            lbErros.Name = "lbErros";
            lbErros.Size = new Size(13, 15);
            lbErros.TabIndex = 9;
            lbErros.Text = "0";
            // 
            // lbFaltam
            // 
            lbFaltam.AutoSize = true;
            lbFaltam.Location = new Point(98, 375);
            lbFaltam.Name = "lbFaltam";
            lbFaltam.Size = new Size(13, 15);
            lbFaltam.TabIndex = 10;
            lbFaltam.Text = "0";
            // 
            // tbPalavra
            // 
            tbPalavra.Location = new Point(51, 107);
            tbPalavra.Name = "tbPalavra";
            tbPalavra.PasswordChar = '*';
            tbPalavra.Size = new Size(100, 23);
            tbPalavra.TabIndex = 11;
            // 
            // btComeca
            // 
            btComeca.Location = new Point(201, 107);
            btComeca.Name = "btComeca";
            btComeca.Size = new Size(75, 23);
            btComeca.TabIndex = 13;
            btComeca.Text = "Começar";
            btComeca.UseVisualStyleBackColor = true;
            btComeca.Click += btComeca_Click;
            // 
            // btTenta
            // 
            btTenta.Enabled = false;
            btTenta.Location = new Point(201, 230);
            btTenta.Name = "btTenta";
            btTenta.Size = new Size(75, 23);
            btTenta.TabIndex = 14;
            btTenta.Text = "Tentar";
            btTenta.UseVisualStyleBackColor = true;
            btTenta.Click += btTenta_Click;
            // 
            // mtLetra
            // 
            mtLetra.Enabled = false;
            mtLetra.Location = new Point(48, 230);
            mtLetra.Mask = "a";
            mtLetra.Name = "mtLetra";
            mtLetra.Size = new Size(100, 23);
            mtLetra.TabIndex = 15;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._1;
            pictureBox1.Location = new Point(471, 28);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(297, 396);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
            // 
            // pbCabeca
            // 
            pbCabeca.Image = (Image)resources.GetObject("pbCabeca.Image");
            pbCabeca.Location = new Point(471, 28);
            pbCabeca.Name = "pbCabeca";
            pbCabeca.Size = new Size(297, 396);
            pbCabeca.SizeMode = PictureBoxSizeMode.Zoom;
            pbCabeca.TabIndex = 17;
            pbCabeca.TabStop = false;
            pbCabeca.Visible = false;
            // 
            // pbCorpo
            // 
            pbCorpo.Image = (Image)resources.GetObject("pbCorpo.Image");
            pbCorpo.Location = new Point(471, 28);
            pbCorpo.Name = "pbCorpo";
            pbCorpo.Size = new Size(297, 396);
            pbCorpo.SizeMode = PictureBoxSizeMode.Zoom;
            pbCorpo.TabIndex = 18;
            pbCorpo.TabStop = false;
            pbCorpo.Visible = false;
            // 
            // pbBracoEsquerdo
            // 
            pbBracoEsquerdo.Image = (Image)resources.GetObject("pbBracoEsquerdo.Image");
            pbBracoEsquerdo.Location = new Point(471, 28);
            pbBracoEsquerdo.Name = "pbBracoEsquerdo";
            pbBracoEsquerdo.Size = new Size(297, 396);
            pbBracoEsquerdo.SizeMode = PictureBoxSizeMode.Zoom;
            pbBracoEsquerdo.TabIndex = 19;
            pbBracoEsquerdo.TabStop = false;
            pbBracoEsquerdo.Visible = false;
            // 
            // pbBracoDireito
            // 
            pbBracoDireito.Image = (Image)resources.GetObject("pbBracoDireito.Image");
            pbBracoDireito.Location = new Point(471, 28);
            pbBracoDireito.Name = "pbBracoDireito";
            pbBracoDireito.Size = new Size(297, 396);
            pbBracoDireito.SizeMode = PictureBoxSizeMode.Zoom;
            pbBracoDireito.TabIndex = 20;
            pbBracoDireito.TabStop = false;
            pbBracoDireito.Visible = false;
            // 
            // pbPernaEsquerda
            // 
            pbPernaEsquerda.Image = (Image)resources.GetObject("pbPernaEsquerda.Image");
            pbPernaEsquerda.Location = new Point(471, 28);
            pbPernaEsquerda.Name = "pbPernaEsquerda";
            pbPernaEsquerda.Size = new Size(297, 396);
            pbPernaEsquerda.SizeMode = PictureBoxSizeMode.Zoom;
            pbPernaEsquerda.TabIndex = 21;
            pbPernaEsquerda.TabStop = false;
            pbPernaEsquerda.Visible = false;
            // 
            // pbPernaDireita
            // 
            pbPernaDireita.Image = (Image)resources.GetObject("pbPernaDireita.Image");
            pbPernaDireita.Location = new Point(471, 28);
            pbPernaDireita.Name = "pbPernaDireita";
            pbPernaDireita.Size = new Size(297, 396);
            pbPernaDireita.SizeMode = PictureBoxSizeMode.Zoom;
            pbPernaDireita.TabIndex = 22;
            pbPernaDireita.TabStop = false;
            pbPernaDireita.Visible = false;
            // 
            // pbFimDeJogo
            // 
            pbFimDeJogo.Image = (Image)resources.GetObject("pbFimDeJogo.Image");
            pbFimDeJogo.Location = new Point(471, 28);
            pbFimDeJogo.Name = "pbFimDeJogo";
            pbFimDeJogo.Size = new Size(297, 396);
            pbFimDeJogo.SizeMode = PictureBoxSizeMode.Zoom;
            pbFimDeJogo.TabIndex = 23;
            pbFimDeJogo.TabStop = false;
            pbFimDeJogo.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pbFimDeJogo);
            Controls.Add(pbPernaDireita);
            Controls.Add(pbPernaEsquerda);
            Controls.Add(pbBracoDireito);
            Controls.Add(pbBracoEsquerdo);
            Controls.Add(pbCorpo);
            Controls.Add(pbCabeca);
            Controls.Add(pictureBox1);
            Controls.Add(mtLetra);
            Controls.Add(btTenta);
            Controls.Add(btComeca);
            Controls.Add(tbPalavra);
            Controls.Add(lbFaltam);
            Controls.Add(lbErros);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(lbTentativa);
            Controls.Add(label5);
            Controls.Add(lbPalavra);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbCabeca).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbCorpo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbBracoEsquerdo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbBracoDireito).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbPernaEsquerda).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbPernaDireita).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbFimDeJogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label lbPalavra;
        private Label label5;
        private Label lbTentativa;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label lbErros;
        private Label lbFaltam;
        private TextBox tbPalavra;
        private Button btComeca;
        private Button btTenta;
        private MaskedTextBox mtLetra;
        private PictureBox pictureBox1;
        private PictureBox pbCabeca;
        private PictureBox pbCorpo;
        private PictureBox pbBracoEsquerdo;
        private PictureBox pbBracoDireito;
        private PictureBox pbPernaEsquerda;
        private PictureBox pbPernaDireita;
        private PictureBox pbFimDeJogo;
    }
}