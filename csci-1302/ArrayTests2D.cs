using System;
namespace csci_1302
{
    public class FourSquare
    {
        private char[,] squares;

        public FourSquare()
        {
            squares = new char[8, 8];
            Reset();
        }

        public void Reset()
        {
            for(int row = 0; row < squares.GetLength(1); row++)
            {
                for(int column = 0; column < squares.GetLength(0); column++)
                {
                    squares[column, row] = ' ';
                }
            }
        }

        public void Display()
        {
            for (int row = squares.GetLength(1) - 1; row >= 0; row--)
            {
                for (int column = 0; column < squares.GetLength(0); column++)
                {
                    Console.Write(squares[column, row]);
                }
                Console.WriteLine();
            }
        }

        public bool Drop(int column, char color)
        {
            for (int row = 0; row < squares.GetLength(1); row++)
            {
                if(squares[column, row] == ' ')
                {
                    squares[column, row] = color;
                    return true;
                }
            }
            return false; // column is full
        }

        // ways to win
        // 4 horizontal
        // 4 veritcal
        // 4 diagonal
        // 4 diagonal (the other way)

        // how to test for a win
        // divide and conquer
        public char Win()
        {
            char result = ' ';

            // solve horizontal
            result = CheckForWinnersHorizontal();
            // solve vertical
            if (result == ' ')
            {
                result = CheckForWinnersVertical();
            }
            // solve diagonal
            if (result == ' ')
            {
                result = CheckForWinnersDiagonal();
            }
            // solve other diagonal
            if (result == ' ')
            {
                result = CheckForWinnersOtherDiagonal();
            }

            return result;
        }

        private char CheckForWinnersHorizontal()
        {
            char result = ' ';
            for (int row = 0; row < squares.GetLength(1); row++)
            {
                for (int column = 0; column < 5; column++)
                {
                    if(squares[column, row] != ' ' &&
                        squares[column, row] == squares[column + 1, row] &&
                        squares[column + 1, row] == squares[column + 2, row] &&
                        squares[column + 2, row] == squares[column + 3, row])
                    {
                        return squares[column, row];
                    }
                }
            }
            return result;
        }
        private char CheckForWinnersVertical()
        {
            char result = ' ';
            for (int row = 0; row < 5; row++)
            {
                for (int column = 0; column < squares.GetLength(0); column++)
                {
                    if (squares[column, row] != ' ' &&
                        squares[column, row] == squares[column, row + 1] &&
                        squares[column, row + 1] == squares[column, row + 2] &&
                        squares[column, row + 2] == squares[column, row + 3])
                    {
                        return squares[column, row];
                    }
                }
            }
            return result;
        }
        private char CheckForWinnersDiagonal()
        {
            char result = ' ';
            for (int row = 0; row < 5; row++)
            {
                for (int column = 0; column < squares.GetLength(0); column++)
                {
                    if (squares[column, row] != ' ' &&
                        squares[column, row] == squares[column + 1, row + 1] &&
                        squares[column + 1, row + 1] == squares[column + 2, row + 2] &&
                        squares[column + 2, row + 2] == squares[column + 3, row + 3])
                    {
                        return squares[column, row];
                    }
                }
            }
            return result;
        }
        private char CheckForWinnersOtherDiagonal()
        {
            char result = ' ';
            for (int row = 0; row < 5; row++)
            {
                for (int column = 3; column < squares.GetLength(0); column++)
                {
                    if (squares[column, row] != ' ' &&
                        squares[column, row] == squares[column + 1, row - 1] &&
                        squares[column + 1, row - 1] == squares[column + 2, row - 2] &&
                        squares[column + 2, row - 2] == squares[column + 3, row - 3])
                    {
                        return squares[column, row];
                    }
                }
            }
            return result;
        }
    }

    public class ArrayTests2D
    {
        public static void Run()
        {
            // initialize
            char winner = ' ';
            FourSquare board = new FourSquare();

            // game loop
            while(winner == ' ')
            {
                board.Display();

                Console.WriteLine("Enter a column: ");
                int col = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter a game piece: ");
                char piece = char.Parse(Console.ReadLine());

                bool drop = board.Drop(col, piece);
                if(drop == false)
                {
                    Console.WriteLine("That column is full");
                }
                else
                {
                    winner = board.Win();
                }
            }

            Console.WriteLine(string.Format("{0} WON!", winner));            
        }
    }
}