// A startup office has an ongoing problem with its bin. Due to low budgets, they don't hire cleaners. 
//  As a result, the staff are left to voluntarily empty the bin. It has emerged that a voluntary system 
//  is not working and the bin is often overflowing. One staff member has suggested creating a rota 
//  system based upon the staff seating plan.
// 
// Create a function that accepts a 2D array of names. The function will return a single array 
//  containing staff names in the order that they should empty the bin.
// 
// Adding to the problem, the office has some temporary staff. This means that the seating plan changes 
//  every month. Both staff members' names and the number of rows of seats may change. Ensure that the 
//  function works when tested with these changes.
// 
// Notes:
// 
// All the rows will always be the same length as each other.
// There will be no empty spaces in the seating plan.
// There will be no empty arrays.
// Each row will be at least one seat long.
// 
// An example seating plan is as follows:
// [ ["Stefan", "Raj",    "Marie"],
//   ["Alexa",  "Amy",    "Edward"],
//   ["Liz",    "Claire", "Juan"],
//   ["Dee",    "Luke",   "Katie"] ]
//
// As an output you would expect in this case:
//
// ["Stefan", "Raj", "Marie", "Edward", "Amy", "Alexa", "Liz", "Claire", "Juan", "Katie", "Luke", "Dee"])

using System.Collections.Generic;

public class Kata
{
    /// Random tests contain jagged arrays and this solution fails...instructions specifically say that this is 
    ///  for multidimensional arrays and solution passes sample tests 
    public static string[] BinRota(string[][] matrix)
    {
      List<string> output = new();
      int rowLength = matrix.Length;
      // all rows will be the same length - assuming no jagged arrays
      int colLength = matrix[0].Length;
      
      for (int row = 0; row < rowLength; row++)
      {
          // invert order on every other row
          if (row % 2 == 1)
          {
              for (int col = colLength - 1; col > -1; col--)
              {
                  output.Add(matrix[row][col]);
              }
          }
          else
          {
              for (int col = 0; col < colLength; col++)
              {
                  output.Add(matrix[row][col]);
              }
          }
      }
      
      return output.ToArray();
    }
}
