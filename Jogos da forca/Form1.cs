using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Configuration;
using System.Reflection;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jogos_da_forca
{
    public partial class Form1 : Form
    {
        string[] palavra = { "Fruta", "Maçã", "Banana", "Morango", "Abacaxi", "Pera",
                            "Uva", "Mamão", "Manga", "Kiwi", "Melancia",
                            "Melão", "Laranja", "Limão", "Cereja", "Ameixa",
                            "Nectarina", "Damasco", "Pêssego", "Romã", "Goiaba",
                            "Acerola", "Jabuticaba", "Caju", "Maracujá", "Pitanga",
                            "Graviola", "Carambola", "Tangerina", "Caqui", "Framboesa",
                            "Mirtilo", "Açaí", "Abacate", "Mamão papaia", "Figo",
                            "Pêssego", "Groselha", "Physalis", "Marmelo", "Jambo",
                            "Abiu", "Cupuaçu", "Guaraná", "Jaca", "Cajá",
                            "Sapoti", "Rambutã", "Pitomba", "Cambuci", "Bacaba",
                            "Grumixama", "Taperebá", "Tamarindo", "Murici", "Pitahaya",
                            "Atemoia", "Sapucaia", "Jatobá", "Pequi", "Araticum",
                            "Cajá-manga", "Goiaba vermelha", "Biribá", "Araçá", "Umbu",
                            "Murta", "Fruta-pão", "Jamelão", "Lichia", "Longan",
                            "Mangostim", "Noni", "Rambai", "Salak", "Santol",
                            "Sapote", "Seriguela", "Tucumã", "Yamamomo", "Zimbro"
                            };

        string tentativas, palavraSelecionada;
        char letra;
        int quantidade = 0, erros = 0, faltam = 0;
        bool achou = false, tenta = false;

        private void btnDesistir_Click(object sender, EventArgs e)
        {
            lblPalavra.Text = "";
            btnComeca.Enabled = true;
            btnDesistir.Enabled = false;
            txbLetra.Enabled = false;
            btnTesta.Enabled = false;
            erros = 0;
            faltam = 0;
            quantidade = 0;
            lblErro.Text = erros.ToString();
            lblFaltam.Text = faltam.ToString();

            pbCabeca.Visible = false;
            pbCorpo.Visible = false;
            pbBracoD.Visible = false;
            pbBracoE.Visible = false;
            pbPernaD.Visible = false;
            pbPernaE.Visible = false;
        }

        private void btnTesta_Click(object sender, EventArgs e)
        {
            letra = txbLetra.Text[0];
            for(int i = 0; i != quantidade; i++)
            {
                if (letra == escondido[i])
                { tenta = true; }
            }

            tentativas = lblTenta.Text;

            int quant = tentativas.Length;

            for(int i = 0;i != quant; i++)
            {
                if(letra == tentativas[i])
                { tenta = true; }
            }

            if(tenta == true)
            { MessageBox.Show("Você já digitou esta letra antes "); }
            else 
            { 
                for(int i = 0; i != quantidade; i++)
                {
                    if (letra == palavraSelecionada[i])
                    {
                        escondido[i] = letra;
                        achou = true;
                        faltam -= 1;
                    }
                }
            }

            //reiniciando palavra exibida
            lblPalavra.Text = "";
            for(int i = 0; i != quantidade; i++)
            {
                lblPalavra.Text = lblPalavra.Text + " " + escondido[i];

            }

            //caso vença
            if(faltam == 0)
            {
                MessageBox.Show("Você ganhou");
                lblTenta.Enabled = false;
                txbLetra.Enabled = false;
                btnComeca.Enabled = true;
                lblPalavra.Text = "";
                btnComeca.Focus();
            }

            if(achou == false && tenta == false)
            {
                erros++;
                lblTenta.Text = lblTenta.Text + " " + letra;
            }
            if(erros == 1)
            { pbCabeca.Visible = true; }
            if(erros == 2)
            { pbCorpo.Visible = true; }
            if(erros == 3)
            { pbBracoE.Visible = true; }
            if(erros == 4)
            { pbBracoD.Visible = true; }
            if(erros == 5)
            { pbPernaE.Visible = true; }
            if(erros == 6)
            {   
                pbPernaD.Visible = true;
                MessageBox.Show("Você perdeu");
                txbLetra.Enabled = false;
                btnComeca.Enabled = true;
                btnDesistir.Enabled = false;
                btnComeca.Focus();
                lblResposta.Text = palavraSelecionada.ToString();
                lblResposta.Visible = true;
            }

            //reiniciando variaveis
            tenta = false;
            achou = false;
            txbLetra.Text = "";
            txbLetra.Focus();

            lblFaltam.Text = faltam.ToString();
            lblErro.Text = erros.ToString();

        }

        char[] escondido = null;

        public Form1()
        {
            InitializeComponent();

            escondido = new char[20];
        }

        private void btnMaisUma_Click(object sender, EventArgs e)
        {
            //Randomizar palavras
            Random random = new Random();
            int rnd = random.Next(1, 20);
            var palavraSorteada = ((string[])palavra)[rnd];
            palavraSelecionada = palavraSorteada;

            quantidade = palavraSorteada.Length;
            faltam = quantidade;
            lblTenta.Text = "";
            lblPalavra.Text = "";

            //Logica Palavra
            for (int i = 0; i != quantidade; i++)
            {
                escondido[i] = '_';
                lblPalavra.Text = lblPalavra.Text + " " + escondido[i].ToString();
            }

            //Limpa erros
            erros = 0;


            //Campos de teste habilitados
            txbLetra.Enabled = true;
            btnTesta.Enabled = true;
            btnDesistir.Enabled = true;
            btnComeca.Enabled = false;
            lblFruta.Visible = true;
            lblFruta.Text = palavra[0];
            pbCabeca.Visible = false;
            pbCorpo.Visible = false;
            pbBracoD.Visible = false;
            pbBracoE.Visible = false;
            pbPernaD.Visible = false;
            pbPernaE.Visible = false;
            lblResposta.Text = "";
            lblResposta.Visible = false;
            txbLetra.MaxLength = 1;
            txbLetra.Focus();
            

            lblFaltam.Text = faltam.ToString();
            lblErro.Text = erros.ToString();

        }
    }
}
