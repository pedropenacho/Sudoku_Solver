using System;
using System.IO;
using System.Linq;

namespace SudokuSolver.Workers
{
    class SudokuFileReader
    {
        public int[,] ReadFile(string filename)
        {
            int[,] sudokuBoard = new int[9, 9];

            try
            {
                var sudokuBoardLines = File.ReadAllLines(filename);

                int row = 0;
                foreach (var line in sudokuBoardLines)
                {
                    string[] lineElements = line.Split('|').Skip(1).Take(9).ToArray();

                    int col = 0;
                    foreach (var line_element in lineElements)
                    {
                        sudokuBoard[row, col] = line_element.Equals(" ") ? 0 : Convert.ToInt16(line_element); //interate through each element in the line and if is nothing turn to zero otherwise continue
                        col++;
                    }

                    row++;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Something went wrong while reading the file: " + ex.Message);
            }
            return sudokuBoard;
        }
    }
}