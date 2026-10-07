// Complete the solution so that it returns true if the first argument(string)
// passed in ends with the 2nd argument (also a string).
//
// Examples:
//
// Inputs: "abc", "bc"
// Output: true
//
// Inputs: "abc", "d"
// Output: false

using System;

public class Kata
{
  public static bool Solution(string str, string ending)
  {
    int endingLength = ending.Length;
    int strLength = str.Length;
    
    // Handle false condition where `str` is shorter than `ending`
    if (strLength < endingLength)
    {
      return false;
    }
    
    char[] endArray = ending.ToCharArray();
    Array.Reverse(endArray);
    char[] strArray = str.ToCharArray();
    Array.Reverse(strArray);
    
    // checking if chars are the same going backwards
    for ( int i = 0; i < endingLength; i++ )
    {
      if (strArray[i] != endArray[i])
      {
        return false;  
      }
    }
    
    return true;
  }
}
