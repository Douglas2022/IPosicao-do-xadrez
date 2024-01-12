namespace tabuleiro
{
    class Posicao
    {
        public int linhs { get; set; }
        public int coluna { get; set; }

        public Posicao(int linhs, int coluna)
        {
            this.linhs = linhs;
            this.coluna = coluna;
        }
        public override string ToString()
        {
            return linhs
                + ", "
                + coluna;
        }
    }
}
