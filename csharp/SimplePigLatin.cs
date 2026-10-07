// Move the first letter of each word to the end of it, then add "ay" to the end of the word. Leave punctuation marks untouched.
//
// Examples
// Kata.PigIt("Pig latin is cool"); // igPay atinlay siay oolcay
// Kata.PigIt("Hello world !");     // elloHay orldway !

using System;
using System.Collections.Generic;

public class Kata
{
  public static string PigIt(string str)
  {
    string[] originalString = str.Split(" ");
    List<string>pigLatinWords = new();
    
    foreach(string word in originalString)
    {
      // skip punctuation marks
      if (word.Length == 1 && char.IsPunctuation(word[0]))
      {
        pigLatinWords.Add(word);
        continue;
      }
      
      string pigLatinWord = word.Remove(0, 1) + word[0] +"ay";
      pigLatinWords.Add(pigLatinWord);
    }
    
    return string.Join(" ", pigLatinWords);
  }
}
