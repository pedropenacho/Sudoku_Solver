using System;
using SudokuSolver.Workers;
using SudokuSolver.Strategies;


namespace SudokuSolver
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                SudokuMapper sudokuMapper = new SudokuMapper();
                SudokuBoardStateManager sudokuBoardStateManager = new SudokuBoardStateManager();
                SudokuSolverEngine sudokuSolverEngine = new SudokuSolverEngine(sudokuBoardStateManager, sudokuMapper);
                SudokuFileReader sudokuFileReader = new SudokuFileReader();
                SudokuBoardDisplayer sudokuBoardDisplayer = new SudokuBoardDisplayer();

                Console.WriteLine("Please enter the filename containing the Sudoku Puzzle:");
                var userInput = Console.ReadLine();

                var filename = userInput + ".txt";



                var sudokuBoard = sudokuFileReader.ReadFile(filename);
                sudokuBoardDisplayer.Display("Inital State", sudokuBoard);

                bool isSudokuSolved = sudokuSolverEngine.Solve(sudokuBoard);
                sudokuBoardDisplayer.Display("Final State", sudokuBoard);

                Console.WriteLine(isSudokuSolved ?
                    "You have successfully solved this Sudoku Puzzle!"
                    : "Unfortunatley, current algorithm(s) were not enough to solve the current Sudoku Puzzle!");

                Console.WriteLine("\n\n\n Press any key to exit");
                Console.ReadLine();

            }
            catch (Exception ex)
            {
                Console.WriteLine("{0} {1}", "Sudoku puzzle cannot be solved because there was an error:", ex.Message);

                Console.WriteLine("\n\n\n Press any key to exit");
                Console.ReadLine();
            }
        }
    }
}
