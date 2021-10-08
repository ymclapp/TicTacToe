using System;
using System.Collections.Generic;
using System.Text;

namespace Lab04_TicTacToe.Classes
{
  class Board
  {
    /// <summary>
    ///Tic Tac Toe Gameboard states
		/// </summary>
		public string[,] GameBoard = new string[,]
    {
      {"1", "2", "3"},
      {"4", "5", "6"},
      {"7", "8", "9"},
    };


    public void DisplayBoard()
    {

      //TODO: Output the board to the console
      for (int i = 0; i < GameBoard.GetLength(0); i++)
      {
        //Console.Write("||");
        for (int j = 0; j < GameBoard.GetLength(1); j++)
        {
          string tttBoard = GameBoard[i, j];
          //if ((j + 1) % 3 == 0)
            //Console.Write($"|{GameBoard[i, j]}|\n");
          //else
            Console.Write($"| {tttBoard} || {tttBoard} || {tttBoard} |");

        }
        //Console.WriteLine();
        //Console.Write($"{GameBoard[0, 0]} | {GameBoard[0, 1]} | {GameBoard[1, 02]} \n");
        //Console.Write($"| {tttBoard} || {tttBoard} || {tttBoard} |");
      }

    }
  }
}
	

