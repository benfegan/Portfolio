using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace noughtsAndCrosses
{
    class Program
    {
        
        int[,] ticTacToeBoard = new int[3, 3];

        public string convertLocation(int x, int y)
        {
            switch(ticTacToeBoard[x, y])
            {
                case 10:
                        return "O";
                case 11:
                        return "X";
                default:
                        return ticTacToeBoard[x, y].ToString();
            }
        }
        
        public void setupBoard()
        {
            ticTacToeBoard[0, 0] = 1;
            ticTacToeBoard[0, 1] = 2;
            ticTacToeBoard[0, 2] = 3;
            ticTacToeBoard[1, 0] = 4;
            ticTacToeBoard[1, 1] = 5;
            ticTacToeBoard[1, 2] = 6;
            ticTacToeBoard[2, 0] = 7;
            ticTacToeBoard[2, 1] = 8;
            ticTacToeBoard[2, 2] = 9;
        }

        public void takeMove(bool noughts, int locationInfo)
        {
            displayBoard();
            bool foundLocation = false;
            for (int x = 0; x < 3; x++)
            {
                for (int y = 0; y < 3; y++)
                {
                    if (ticTacToeBoard[x, y] == locationInfo)
                    {
                        foundLocation = true;

                        if (noughts)
                        {
                            ticTacToeBoard[x, y] = 10;
                        }
                        else
                        {
                            ticTacToeBoard[x, y] = 11;
                        }
                    }
                }
            }
            displayBoard();

            if(!foundLocation)
            {
                Console.WriteLine("There is already a nought or cross here, try again!");
            }

        }

        public void displayBoard()
        {
            Console.Clear();
            Console.WriteLine("----------------------------------");
            Console.WriteLine("|          |          |          |");
            Console.WriteLine("|    " + convertLocation(0, 0) + "     |    " + convertLocation(0, 1) + "     |    " + convertLocation(0, 2) + "     |");
            Console.WriteLine("|          |          |          |");
            Console.WriteLine("----------------------------------");
            Console.WriteLine("|          |          |          |");
            Console.WriteLine("|    " + convertLocation(1, 0) + "     |    " + convertLocation(1, 1) + "     |    " + convertLocation(1, 2) + "     |");
            Console.WriteLine("|          |          |          |");
            Console.WriteLine("----------------------------------");
            Console.WriteLine("|          |          |          |");
            Console.WriteLine("|    " + convertLocation(2, 0) + "     |    " + convertLocation(2, 1) + "     |    " + convertLocation(2, 2) + "     |");
            Console.WriteLine("|          |          |          |");
            Console.WriteLine("----------------------------------");
        }

        static void Main(string[] args)
        {
            Program ticTacToe = new Program();
            
            ticTacToe.setupBoard();
            ticTacToe.displayBoard();

            int inputtedOption = 0;
            bool noughts = true;

            do
            {
                if (noughts)
                {
                    Console.Write("Noughts: ");
                }
                else
                {
                    Console.Write("Crosses: ");
                }

                Console.WriteLine("From the numbers above, choose one to place a nought or cross");
                inputtedOption = Convert.ToInt32(Console.ReadLine());

                if (inputtedOption == 0)
                {
                    if (noughts)
                    {
                        Console.WriteLine("Noughts, you have won! Congratulations");
                    }
                    else
                    {
                        Console.WriteLine("Crosses, you have won! Congratulations");
                    }
                    break;
                }

                ticTacToe.takeMove(noughts, inputtedOption);

                noughts = !noughts;
            }
            while (inputtedOption !=0);
            Console.ReadLine();
        }
    }
}
