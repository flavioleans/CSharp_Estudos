using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameJokenpo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPedra_Click(object sender, EventArgs e)
        {
            StartGame(0);
        }

        private void btnPapel_Click(object sender, EventArgs e)
        {
            StartGame(1);
        }

        private void btnTesoura_Click(object sender, EventArgs e)
        {
            StartGame(2);
        }

        private void StartGame(int opcao)
        {
            lblResultado.Visible = false;
            Game jogo = new Game();
            switch (jogo.Jogar(opcao))
            {
                case Game.Resultado.Ganhou:
                    pictResultado.BackgroundImage = Image.FromFile("Imagens/Ganhar.png");
                    goto default;
                case Game.Resultado.Perdeu:
                    pictResultado.BackgroundImage = Image.FromFile("Imagens/Perder.png");
                    goto default;
                case Game.Resultado.Empatou:
                    pictResultado.BackgroundImage = Image.FromFile("Imagens/Empatar.png");
                    goto default;
                default:
                    pictureBox1.Image = jogo.imgJogador;
                    pictureBox2.Image = jogo.ImgPc;
                    break;
            }
        }
    }
}
