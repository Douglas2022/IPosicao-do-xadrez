﻿using System.Reflection;

namespace tabuleiro
{
    class Peca
    {
        public Posicao posicao { get; set; }
        public Cor cor { get; protected set; }
        public int qtdMovimento { get; protected set; }
        public tabuleiro tab { get; protected set; }

        public Peca(Posicao posicao, tabuleiro tab, Cor cor)
        {
            this.posicao = posicao;
            this.tab = tab;
            this.cor = cor;
            this.qtdMovimento = 0;

        }
    }
}
