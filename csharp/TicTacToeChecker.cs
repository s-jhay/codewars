// If we were to set up a Tic-Tac-Toe game, we would want to know whether the board's current state is solved,
//  wouldn't we? Our goal is to create a function that will check that for us!
// 
// Assume that the board comes in the form of a 3x3 array, where the value is 0 if a spot is empty, 1 if it is 
//  an "X", or 2 if it is an "O", like so:
// 
// [[0, 0, 1],
//  [0, 1, 2],
//  [2, 1, 0]]
// We want our function to return:
// 
// -1 if the board is not yet finished AND no one has won yet (there are empty spots),
// 1 if "X" won,
// 2 if "O" won,
// 0 if it's a cat's game (i.e. a draw).
// You may assume that the board passed in is valid in the context of a game of Tic-Tac-Toe.

using System;

public class TicTacToe
{
  public int IsSolved(int[,] board)
  {
    int result = CheckWinner(board);
    int emptySpots = CountEmptySpots(board);
    
    if (result > 0)
    {
      return result;
    }
    else if (emptySpots > 0)
    {
      return -1;
    }
    else
    {
      // cat's game, assuming that board passed in is valid
      return 0;
    }
  }
  
  private int CheckWinner(int[,] board)
  {
    for (int i = 1; i < 3; i++)
    {
      // horizontal win conditions
      if (board[0,0] == i && board[0,1] == i && board[0,2] == i ||
          board[1,0] == i && board[1,1] == i && board[1,2] == i ||
          board[2,0] == i && board[2,1] == i && board[2,2] == i ||
        
          // vertical win conditions
          board[0,0] == i && board[1,0] == i && board[2,0] == i ||
          board[0,1] == i && board[1,1] == i && board[2,1] == i ||
          board[0,2] == i && board[1,2] == i && board[2,2] == i ||
        
          // diagonal win conditions
          board[0,0] == i && board[1,1] == i && board[2,2] == i ||
          board[0,2] == i && board[1,1] == i && board[2,0] == i)
      {
        return i;
      }  
      else
      {
        continue;
      }
    }
    
    // neither 'X' or 'O' has won
    return 0;
  }
  
  private int CountEmptySpots(int[,] board)
  {
    int emptyRemaining = 0;
    foreach (int position in board)
    {
      if (position == 0)
      {
        emptyRemaining++;
      }
    }
    
    return emptyRemaining;
  }
}
