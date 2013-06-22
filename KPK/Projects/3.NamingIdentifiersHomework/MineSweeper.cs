using System;
using System.Collections.Generic;

namespace ConsoleMinesweeper
{
    public class MineSweeper
    {
        public class Player
        {
            string name;
            int score;

            public string Name
            {
                get
                {
                    return name;
                }
                set
                {
                    name = value;
                }
            }

            public int Score
            {
                get
                {
                    return score;
                }
                set
                {
                    score = value;
                }
            }

            public Player()
            {
            }

            public Player(string name, int score)
            {
                this.Name = name;
                this.Score = score;
            }
        }

        static void Main(string[] args)
        {
            string command = string.Empty;
            char[,] field = MakeField();
            char[,] bombsField = PlaceBombs();
            int counter = 0;
            bool isGameOver = false;
            List<Player> highScorePlayers = new List<Player>(6);
            int row = 0;
            int column = 0;
            bool isGameJustStarted = true;
            const int MaximumCells = 35;
            bool allCellsVisited = false;

            do
            {
                if (isGameJustStarted)
                {
                    Console.WriteLine("Lets play the game called “MinesSweeper”. Try your luck to find all the fields without mines on them." +
                                      " Command 'top' shows the Score Board, 'restart' starts new game, 'exit' exits the game. Have fun!");
                    PrintBoard(field);
                    isGameJustStarted = false;
                }
                Console.Write("Enter Row and Column separated by space: ");
                command = Console.ReadLine().Trim();
                if (command.Length >= 3)
                {
                    if (int.TryParse(command[0].ToString(), out row) &&
                        int.TryParse(command[2].ToString(), out column) &&
                        row <= field.GetLength(0) && column <= field.GetLength(1))
                    {
                        command = "turn";
                    }
                }
                switch (command)
                {
                    case "top":
                        PrintScoreBoard(highScorePlayers);
                        break;
                    case "restart":
                        field = MakeField();
                        bombsField = PlaceBombs();
                        PrintBoard(field);
                        isGameOver = false;
                        isGameJustStarted = false;
                        break;
                    case "exit":
                        Console.WriteLine("Bye and thanks for playing!");
                        break;
                    case "turn":
                        if (bombsField[row, column] != '*')
                        {
                            if (bombsField[row, column] == '-')
                            {
                                MakeMove(field, bombsField, row, column);
                                counter++;
                            }
                            if (MaximumCells == counter)
                            {
                                allCellsVisited = true;
                            }
                            else
                            {
                                PrintBoard(field);
                            }
                        }
                        else
                        {
                            isGameOver = true;
                        }
                        break;
                    default:
                        Console.WriteLine("\nError! Invalid command!\n");
                        break;
                }
                if (isGameOver)
                {
                    PrintBoard(bombsField);
                    Console.WriteLine();
                    Console.Write("Hrrrrrr! You are dead and got {0} points. " +
                                  "Enter Nickname: ", counter);
                    string nickName = Console.ReadLine();
                    Player player = new Player(nickName, counter);
                    if (highScorePlayers.Count < 5)
                    {
                        highScorePlayers.Add(player);
                    }
                    else
                    {
                        for (int i = 0; i < highScorePlayers.Count; i++)
                        {
                            if (highScorePlayers[i].Score < player.Score)
                            {
                                highScorePlayers.Insert(i, player);
                                highScorePlayers.RemoveAt(highScorePlayers.Count - 1);
                                break;
                            }
                        }
                    }
                    highScorePlayers.Sort((Player playerOne, Player playerTwo) => playerTwo.Name.CompareTo(playerOne.Name));
                    highScorePlayers.Sort((Player playerOne, Player playerTwo) => playerTwo.Score.CompareTo(playerOne.Score));
                    PrintScoreBoard(highScorePlayers);

                    field = MakeField();
                    bombsField = PlaceBombs();
                    counter = 0;
                    isGameOver = false;
                    isGameJustStarted = true;
                }
                if (allCellsVisited)
                {
                    Console.WriteLine("\nBRAVOOO! You won the game.");
                    PrintBoard(bombsField);
                    Console.WriteLine("Give me your nickname , winner: ");
                    string winnerName = Console.ReadLine();
                    Player winner = new Player(winnerName, counter);
                    highScorePlayers.Add(winner);
                    PrintScoreBoard(highScorePlayers);
                    field = MakeField();
                    bombsField = PlaceBombs();
                    counter = 0;
                    allCellsVisited = false;
                    isGameJustStarted = true;
                }
            }
            while (command != "exit");
            Console.WriteLine("Made in Bulgaria!");
            Console.WriteLine("Bye.");
            Console.Read();
        }

        private static void PrintScoreBoard(List<Player> highScorePlayers)
        {
            Console.WriteLine();
            Console.WriteLine("Score Board:");
            if (highScorePlayers.Count > 0)
            {
                for (int i = 0; i < highScorePlayers.Count; i++)
                {
                    Console.WriteLine("{0}. {1} --> {2} bombs",
                        i + 1, highScorePlayers[i].Name, highScorePlayers[i].Score);
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Empty Score Board!");
                Console.WriteLine();
            }
        }

        private static void MakeMove(char[,] field,
            char[,] mines, int row, int column)
        {
            char surroundingBombsCount = GetSurroundingBombsCount(mines, row, column);
            mines[row, column] = surroundingBombsCount;
            field[row, column] = surroundingBombsCount;
        }

        private static void PrintBoard(char[,] board)
        {
            const string DashedLine = "   ---------------------";
            int rows = board.GetLength(0);
            int columns = board.GetLength(1);
            Console.WriteLine();
            Console.WriteLine("    0 1 2 3 4 5 6 7 8 9");
            Console.WriteLine(DashedLine);
            for (int i = 0; i < rows; i++)
            {
                Console.Write("{0} | ", i);
                for (int j = 0; j < columns; j++)
                {
                    Console.Write(string.Format("{0} ", board[i, j]));
                }
                Console.Write("|");
                Console.WriteLine();
            }
            Console.WriteLine(DashedLine);
            Console.WriteLine();
        }

        private static char[,] MakeField()
        {
            int boardRows = 5;
            int boardColumns = 10;
            char[,] board = new char[boardRows, boardColumns];
            for (int i = 0; i < boardRows; i++)
            {
                for (int j = 0; j < boardColumns; j++)
                {
                    board[i, j] = '?';
                }
            }
            
            return board;
        }

        private static char[,] PlaceBombs()
        {
            int boardRows = 5;
            int boardColumns = 10;
            char[,] board = new char[boardRows, boardColumns];

            for (int i = 0; i < boardRows; i++)
            {
                for (int j = 0; j < boardColumns; j++)
                {
                    board[i, j] = '-';
                }
            }

            List<int> generatedBombs = new List<int>();
            while (generatedBombs.Count < 15)
            {
                Random randomBombPosition = new Random();
                int bombPosition = randomBombPosition.Next(50);
                if (!generatedBombs.Contains(bombPosition))
                {
                    generatedBombs.Add(bombPosition);
                }
            }

            foreach (int bombPosition in generatedBombs)
            {
                int currentColumn = (bombPosition / boardColumns);
                int currentRow = (bombPosition % boardColumns);
                if (currentRow == 0 && bombPosition != 0)
                {
                    currentColumn--;
                    currentRow = boardColumns;
                }
                else
                {
                    currentRow++;
                }
                board[currentColumn, currentRow - 1] = '*';
            }

            return board;
        }

        private static void Calculations(char[,] field)
        {
            int rows = field.GetLength(0);
            int columns = field.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (field[i, j] != '*')
                    {
                        char surroundingBombsCount = GetSurroundingBombsCount(field, i, j);
                        field[i, j] = surroundingBombsCount;
                    }
                }
            }
        }

        private static char GetSurroundingBombsCount(char[,] field, int row, int column)
        {
            int bombsCounter = 0;
            int rows = field.GetLength(0);
            int columns = field.GetLength(1);

            if (row - 1 >= 0)
            {
                if (field[row - 1, column] == '*')
                { 
                    bombsCounter++; 
                }
            }
            if (row + 1 < rows)
            {
                if (field[row + 1, column] == '*')
                { 
                    bombsCounter++; 
                }
            }
            if (column - 1 >= 0)
            {
                if (field[row, column - 1] == '*')
                { 
                    bombsCounter++;
                }
            }
            if (column + 1 < columns)
            {
                if (field[row, column + 1] == '*')
                { 
                    bombsCounter++;
                }
            }
            if ((row - 1 >= 0) && (column - 1 >= 0))
            {
                if (field[row - 1, column - 1] == '*')
                { 
                    bombsCounter++; 
                }
            }
            if ((row - 1 >= 0) && (column + 1 < columns))
            {
                if (field[row - 1, column + 1] == '*')
                { 
                    bombsCounter++; 
                }
            }
            if ((row + 1 < rows) && (column - 1 >= 0))
            {
                if (field[row + 1, column - 1] == '*')
                { 
                    bombsCounter++; 
                }
            }
            if ((row + 1 < rows) && (column + 1 < columns))
            {
                if (field[row + 1, column + 1] == '*')
                { 
                    bombsCounter++; 
                }
            }
            return char.Parse(bombsCounter.ToString());
        }
    }
}