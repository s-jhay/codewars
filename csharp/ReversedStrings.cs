using System;

public static class Kata
{
  public static string Solution(string str) 
  {
    char[] strChars = str.ToCharArray();
    Array.Reverse(strChars);
    string reversedStr = new string(strChars);
    return reversedStr;
  }
}
