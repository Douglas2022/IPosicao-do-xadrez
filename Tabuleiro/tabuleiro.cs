﻿namespace tabuleiro
{
    class tabuleiro
    {
        public int linha { get; set; }
        public int coluna { get; set; }
        private Peca[,] pecas;

        tabuleiro(int linha, int coluna)
        {
            this.linha = linha;
            this.coluna = coluna;
            pecas = new Peca[linha, coluna];
        }
    }

}
