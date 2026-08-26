// Complete the function that accepts a string parameter, and reverses each word in the string. All spaces in the string should be retained.
//
// Examples
// "This is an example!" ==> "sihT si na !elpmaxe"
// "double  spaces"      ==> "elbuod  secaps"

using System;
using System.Collections.Generic;

public static class Kata
{
  public static string ReverseWords(string str)
  {
    string output = string.Empty;
    string[] inputSubstrings = str.Split(" ");
    List<string> outputSubstrings = new();
    
    foreach (string substring in inputSubstrings)
    {
      outputSubstrings.Add(ReverseSubstring(substring));  
    }
    
    return string.Join(" ", outputSubstrings);
  }
  
  public static string ReverseSubstring(string str)
  {
    char[] charArray = str.ToCharArray();
    Array.Reverse(charArray);
    return new string(charArray);
  }
}
