using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JogoAdvinhação
{
    public partial class Form1 : Form
    {
        int numeroAdv, numMaximo;
        public Form1()
        {
            InitializeComponent();
            esconderJogo();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            bool numValido = int.TryParse(txtNumMax.Text, out int numMax);

            if (numValido && numMax >= 5)
            {
                esconderEscolha();
                mostrarJogo();
                numMaximo = numMax;
                labelJogo.Text = "É um número de zero a " + numMax;
                Random random = new Random();
                numeroAdv = random.Next(0, numMax + 1);
            }
            else
            {
                erroNum();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            mostrarEscolha();
            esconderJogo();
            btnJoagrDeNovo.Visible = false;
            labelResposta.Text = "...";
            txtNumMax.Clear();
            txtAdivinhar.Clear();
            txtAdivinhar.Enabled = true;
            btnPalpite.Enabled = true;
        }

        private void btnPalpite_Click(object sender, EventArgs e)
        {
            bool palpiteValido = int.TryParse(txtAdivinhar.Text, out int palpite);
            if (palpiteValido && palpite <= numMaximo && palpite >= 0)
            {
                if (palpite == numeroAdv)
                {
                    labelResposta.Text = "Você adivinhou\n meu número !!";
                    vitoria();
                }
                else if (palpite > numeroAdv)
                {
                    labelResposta.Text = "Meu número é\nmenor que esse";
                }
                else if (palpite < numeroAdv)
                {
                    labelResposta.Text = "Meu número é\nmaior que esse";
                }
            }
            else
            {
                txtAdivinhar.Clear();
                labelResposta.Text = "Digite um número\nválido de 0 a " + numMaximo;
                System.Media.SystemSounds.Hand.Play();
            }
        }
        private void esconderJogo()
        {
            label1.Visible = false;
            labelJogo.Visible = false;
            txtAdivinhar.Visible = false;
            btnPalpite.Visible = false;
            panel3.Visible = false;
            labelResposta.Visible = false;
        }
        private void mostrarJogo()
        {
            label1.Visible = true;
            label1.Location = new Point(151, 211);
            labelJogo.Visible = true;
            labelJogo.Location = new Point(215, 233);
            txtAdivinhar.Visible = true;
            txtAdivinhar.Location = new Point(155, 265);
            btnPalpite.Visible = true;
            btnPalpite.Location = new Point(155, 297);
            panel3.Visible = true;
            panel3.Location = new Point(339, 265);
            labelResposta.Visible = true;
            labelResposta.Location = new Point(11, 8);
            btnJoagrDeNovo.Location = new Point(158, 347);
        }
        private void esconderEscolha()
        {
            label3.Visible = false;
            txtNumMax.Visible = false;
            btnConfirmar.Visible = false;
        }
        private void mostrarEscolha()
        {
            label3.Visible = true;
            txtNumMax.Visible = true;
            btnConfirmar.Visible = true;
        }
        private async void erroNum()
        {
            btnConfirmar.Enabled = false;
            txtNumMax.Enabled = false;
            labelErroConfirma.Visible = true;
            System.Media.SystemSounds.Hand.Play();
            await Task.Delay(3000);
            labelErroConfirma.Visible = false;
            btnConfirmar.Enabled = true;
            txtNumMax.Enabled = true;
            txtNumMax.Clear();
        }
        private void vitoria()
        {
            btnJoagrDeNovo.Visible = true;
            txtAdivinhar.Enabled = false;
            btnPalpite.Enabled = false;
        }
    }
}
