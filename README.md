# Sudoku Solver
Sudoku solver project from Udemy C# course.
<br/>
https://www.udemy.com/course/learn-csharp-by-building-applications/

### Relevant repository folders

- **Strategies**: Here you can find an interface, ISudokuStrategy, to be implemented in our algorthims.
We also have 2 classes (SimpleMarkUpStrategy and NakedPairsStrategy) that are our strategies/algorithms used to solve the sudoku puzzles.
Finally we have a class that implements the logic to solve the sudoku puzzle.

- **Workers**: In this folder are the classes to read the text file where the puzzle is stored and to handle and display the state of the board.

- **Program.cs** (file): main class where program will run. Here we put everything together and display the results in the console.

**Note**: At the moment this sudoku solver engine is very basic and can only solve the simplest puzzles. However, it was built in such a way
that it easy to improve its capability. Simply create strategies/algorithms to solve the puzzle and then just add them to the list of strategies
inside the SudokuSolverEngine class.

### Usage

The program asks users to enter the **filename** where the sudoku puzzle is stored.


**User Input**

![alt text](https://github.com/pedropenacho/Sudoku_Solver/blob/master/SudokuSolver/Images/userInput_easy.png "Easy Level")

It will then run our strategies/algorithms and try to solve the puzzle, if it's successful it will display the final
solution and also a message saying the puzzle was successfully solved.

**Results**

![alt text](https://github.com/pedropenacho/Sudoku_Solver/blob/master/SudokuSolver/Images/results_easy.png "Successful")

<br/>

However, if the level chosen goes beyond the software capabilities it will display the following:

<br/>

![alt text](https://github.com/pedropenacho/Sudoku_Solver/blob/master/SudokuSolver/Images/results_difficult.png "Unsuccessful")
