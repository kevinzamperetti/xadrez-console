﻿namespace tabuleiro
{
    class Tabuleiro
    {
        public int linhas { get; set; }
        public int colunas { get; set; }
        public Peca[,] pecas;

        public Tabuleiro(int linhas, int colunas)
        {
            this.linhas = linhas;
            this.colunas = colunas;
            this.pecas = new Peca[linhas, colunas];
        }

        public Peca peca(int linha, int coluna) {
            return pecas[linha, coluna];
        }

    }
}
