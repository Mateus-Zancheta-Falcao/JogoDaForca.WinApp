using System.Threading.Channels;

namespace JogoDaForca.WinApp
{
    public partial class Form1 : Form
    {
        string palavra, tentativas;
        char letra;
        int quantidade = 0, erros = 0, faltam = 0;
        bool achou = false, tenta = false;
        char[] escondido;

        public Form1()
        {
            InitializeComponent();
            escondido = new char[20];
        }

        private void btComeca_Click(object sender, EventArgs e)
        {
            palavra = tbPalavra.Text;
            quantidade = palavra.Length;
            faltam = quantidade;
            lbPalavra.Text = "";
            lbTentativa.Text = "";

            for (int cont = 0; cont != quantidade; cont++)
            {
                escondido[cont] = '*';
                lbPalavra.Text = lbPalavra.Text + escondido[cont];
            }

            erros = 0;

            pbCabeca.Visible = false;
            pbCorpo.Visible = false;
            pbBracoEsquerdo.Visible = false;
            pbBracoDireito.Visible = false;
            pbPernaEsquerda.Visible = false;
            pbPernaDireita.Visible = false;
            pbFimDeJogo.Visible = false;

            tbPalavra.Enabled = false;
            btComeca.Enabled = false;
            mtLetra.Enabled = true;
            btTenta.Enabled = true;
            mtLetra.Focus();

            lbFaltam.Text = faltam.ToString();
            lbErros.Text = erros.ToString();
        }

        private void btTenta_Click(object sender, EventArgs e)
        {
            letra += mtLetra.Text[0];

            for (int cont = 0; cont != quantidade; cont++)
            {
                if (letra == escondido[cont])
                {
                    tenta = true;
                }
            }

            tentativas = lbTentativa.Text;
            int quant = tentativas.Length;

            for (int cont = 0; cont != quant; cont++)
            {
                if (letra == tentativas[cont])
                {
                    tenta = true;
                }
            }

            if (tenta == true)
            {
                MessageBox.Show("Você já digitou essa letra!");
            }
            else
            {
                for (int cont = 0; cont != quantidade; cont++)
                {
                    if (letra == palavra[cont])
                    {
                        escondido[cont] = letra;
                        achou = true;
                        faltam = faltam - 1;
                    }
                }
            }

            lbPalavra.Text = "";
            for (int cont = 0; cont != quantidade; cont++)
            {
                lbPalavra.Text = lbPalavra.Text + escondido[cont];
            }

            if (faltam == 0)
            {
                MessageBox.Show("Parabéns! Você venceu!!");
                tbPalavra.Enabled = true;
                btComeca.Enabled = true;
                mtLetra.Enabled = false;
                btTenta.Enabled = false;
                tbPalavra.Text = "";
                tbPalavra.Focus();
            }

            if ((achou == false) & (tenta == false))
            {
                erros = erros + 1;
                lbTentativa.Text = lbTentativa.Text + " " + letra;
            }

            if (erros == 1)
            {
                pbCabeca.Visible = true;
            }
            else if (erros == 2)
            {
                pbCorpo.Visible = true;
            }
            else if(erros == 3)
            {
                pbBracoEsquerdo.Visible = true;
            }
            else if(erros == 4)
            {
                pbBracoDireito.Visible = true;
            }
            else if(erros == 5)
            {
                pbPernaEsquerda.Visible = true;
            }
            else if(erros == 6)
            {
                pbPernaDireita.Visible = true;
            }
            else if(erros == 7)
            {
                pbFimDeJogo.Visible = true;

                MessageBox.Show("Você perdeu!!");

                tbPalavra.Enabled = true;
                btComeca.Enabled = true;
                mtLetra.Enabled = false;
                btTenta.Enabled = false;
                tbPalavra.Text = "";
                tbPalavra.Focus();
            }

            tenta = false;
            achou = false;
            mtLetra.Text = "";
            mtLetra.Focus();

            lbFaltam.Text = faltam.ToString();
            lbErros.Text = erros.ToString();    
            }
    }
}