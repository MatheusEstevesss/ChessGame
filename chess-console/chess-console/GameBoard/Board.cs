using System;
using System.Collections.Generic;
using System.Text;

namespace chess_console.GameBoard
{
    class Board
    {
        public int Linhas { get; set; }
        public int Colunas { get; set; }
        private Piece[,] pieces;

        public Board(int linhas, int colunas)
        {
            Linhas = linhas;
            Colunas = colunas;
            pieces = new Piece[linhas, colunas];
        }

        public Piece piece(int linha, int coluna)
        {
            return pieces[linha, coluna];
        }
    }
}
