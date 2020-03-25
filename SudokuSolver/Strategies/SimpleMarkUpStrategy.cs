using System;
using System.Linq;
using SudokuSolver.Workers;

namespace SudokuSolver.Strategies
{
    class SimpleMarkUpStrategy : ISudokuStrategy
    {
        private readonly SudokuMapper _sudokuMapper;

        public SimpleMarkUpStrategy(SudokuMapper sudokuMapper)
        {
            _sudokuMapper = sudokuMapper;
        }

        public int[,] Solve(int[,] sudokuBoard)
        {
            for (int row = 0; row < sudokuBoard.GetLength(0); row++)
            {
                for (int col = 0; col < sudokuBoard.GetLength(1); col++)
                {
                    if (sudokuBoard[row, col] == 0 || sudokuBoard[row, col].ToString().Length > 1)
                    {
                        var possibilitiesInRowAndCol = GetPossibilitiesInRowAndCol(sudokuBoard, row, col);
                        var possibilitiesInBlock = GetPossibilitiesInBlock(sudokuBoard, row, col);
                        sudokuBoard[row, col] = GetPossibilityIntersection(possibilitiesInRowAndCol, possibilitiesInBlock);

                    }
                }
            }
            return sudokuBoard;
        }

        private object GetPossibilitiesInRowAndCol(int[,] sudokuBoard, int givenRow, int givenCol)
        {
            int[] possibilities = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            //This will iterate through all columns and rows, check each cell value and confirm that they are between 1-9, if they are access the possibilities array in its correct index and turn its value to 0, so that number cannot be used again.
            for (int col = 0; col < 9; col++) if (IsValidSingle(sudokuBoard[givenRow, col])) possibilities[sudokuBoard[givenRow, col] - 1] = 0;
            for (int row = 0; row < 9; row++) if (IsValidSingle(sudokuBoard[row, givenCol])) possibilities[sudokuBoard[row, givenCol] - 1] = 0;

            //return all the values in the array that aren't zeros
            return Convert.ToInt32(String.Join(string.Empty, possibilities.Select(p => p).Where(p => p != 0)));
        }


        private object GetPossibilitiesInBlock(int[,] sudokuBoard, int row, int col)
        {
            throw new NotImplementedException();
        }


        private int GetPossibilityIntersection(object possibilitiesInRowAndCol, object possibilitiesInBlock)
        {
            throw new NotImplementedException();
        }

        private bool IsValidSingle(int cellDigit)
        {
            return cellDigit != 0 && cellDigit.ToString().Length == 1;
        }
    }
}
