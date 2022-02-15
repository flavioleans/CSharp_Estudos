using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameJokenpo
{
    class Game
    {
        public enum Resultado
        {
            Ganhou, Perdeu, Empatou
        }

        public static Image[] imagens =
        {
            Image.FromFile("imagens/Pedra.png"),
            Image.FromFile("imagens/Papel.png"),
            Image.FromFile("imagens/Tesoura.png")
        };

        public Image ImgPc { get; private set; }
        public Image imgJogador { get; private set; }

        public Resultado Jogar(int jogador)
        {
            int pc = JogadaPc();

            imgJogador = imagens[jogador];
            ImgPc = imagens[pc];

            if (jogador == pc)
            {
                return Resultado.Empatou;
            }
            else if ((jogador == 1 && pc == 0) || (jogador == 2 && pc == 1) || (jogador == 0 && pc == 2))
            {
                return Resultado.Ganhou;
            }
            else
            {
                return Resultado.Perdeu;
            }

            
        }

        private int JogadaPc()
        {
           int mil =  DateTime.Now.Millisecond;

            if (mil < 333)
            {
                return 0;
            }
            else if(mil >= 333 && mil < 667)
            {
                return 1;
            }
            else
            {
                return 2;
            }
        }
    }
}
