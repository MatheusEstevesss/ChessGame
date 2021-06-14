using chess_console.GameBoard;


namespace chess_console
{
    class Screen
    {
        public static void printBoard(Board board)
        {
            for (int i = 0; i < board.Linhas; i++) {
                for (int j = 0; j < board.Colunas; j++) {

                    if ( board.piece(i, j) == null )
                    {
                        System.Console.Write("- ");
                    } 
                    else
                    {
                        System.Console.Write(board.piece(i, j) + " ");
                    }                    
                }
                System.Console.WriteLine();
            }
        }
    }
}
