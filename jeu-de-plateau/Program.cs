using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] plateau = new string[3, 3];
            InitializeBoard(plateau);

            Console.WriteLine("Welcome to the game");
            Console.WriteLine("Enter Your name: ");
            string name = Console.ReadLine();

            Player player1 = new Player(name, 0, 0);
            Player player2 = new Player("Jane", 1, 1);

            bool gameWon = false;
            int moves = 0;
            const int maxMoves = 9;

            while (!gameWon && moves < maxMoves)
            {
                Player currentPlayer = (moves % 2 == 0) ? player1 : player2;
                Console.WriteLine($"\n{currentPlayer.Name}'s turn. Enter your move (row and column): ");

                int x, y;
                bool validInput = false;

                while (!validInput)
                {
                    try
                    {
                        Console.Write("Row (0-2): ");
                        x = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Column (0-2): ");
                        y = Convert.ToInt32(Console.ReadLine());

                        if (x >= 0 && x < 3 && y >= 0 && y < 3 && plateau[x, y] == ".")
                        {
                            plateau[x, y] = currentPlayer.Name[0].ToString();
                            currentPlayer.Move(x, y);
                            validInput = true;
                        }
                        else
                        {
                            Console.WriteLine("Invalid move. The cell is either occupied or out of bounds. Try again.");
                        }
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Invalid input. Please enter numbers between 0 and 2.");
                    }
                }

                Player.PrintBoard(plateau);
                gameWon = currentPlayer.GetStatus().Contains("a gagné");
                moves++;
            }

            if (gameWon)
            {
                Console.WriteLine($"{(moves % 2 == 0 ? player1.Name : player2.Name)} a gagné ! 🎉");
            }
            else
            {
                Console.WriteLine("Match nul !");
            }

            Console.ReadKey();
        }

        static void InitializeBoard(string[,] board)
        {
            for (int i = 0; i < board.GetLength(0); i++)
            {
                for (int j = 0; j < board.GetLength(1); j++)
                {
                    board[i, j] = ".";
                }
            }
        }
    }

    public class Player
    {
        public string Name;
        public int X;
        public int Y;

        public Player(string name, int x, int y)
        {
            Name = name;
            X = x;
            Y = y;
        }

        public void Move(int x, int y)
        {
            X = x;
            Y = y;
            Console.WriteLine($"{Name} moves to ({x}, {y})");
        }

        public string GetStatus()
        {
            return (X == 2 && Y == 2) 
                ? $"{Name} a gagné ! 🎉" 
                : $"{Name} est en ({X},{Y})";
        }

        public static void PrintBoard(string[,] board)
        {
            for (int i = 0; i < board.GetLength(0); i++)
            {
                for (int j = 0; j < board.GetLength(1); j++)
                {
                    string cell = board[i, j] ?? ".";
                    Console.Write($"{cell} ");
                }
                Console.WriteLine();
            }
        }
    }
}
