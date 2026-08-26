// ROT13 is a simple letter substitution cipher that replaces a letter 
// with the letter 13 letters after it in the alphabet. ROT13 is an example of the Caesar cipher.
//
// Create a function that takes a string and returns the string ciphered with Rot13. If there 
// are numbers or special characters included in the string, they should be returned as they are. 
// Only letters from the latin/english alphabet should be shifted, like in the original Rot13 "implementation".

public class Kata
{
  // unicode `a` character
  const int UnicodeA = 97;
  // unicode `z` character
  const int UnicodeZ = 122;
  // shift increment
  const int Shift = 13;
  
  public static string Rot13(string message)
  {
    string output = string.Empty;
    bool isUpper = false;
    
    foreach (char letter in message)
    {
      // check for upper case letters
      isUpper = char.IsUpper(letter);
      int place = (int)char.ToLower(letter);
      
      // char is not a letter
      if (place < UnicodeA || place > UnicodeZ)
      {
        output += letter;
        continue;
      }
      
      char shiftedLetter;
      int combined = place + Shift;
      
      // conversion would overshoot range
      if (combined > UnicodeZ)
      {
        // minus one to account for new reading position
        int remainder = (combined - UnicodeZ) - 1;
        shiftedLetter = (char)(UnicodeA + remainder);
      }
      else
      {
        shiftedLetter = (char)(combined);
      }
      
      if (isUpper) { shiftedLetter = char.ToUpper(shiftedLetter); }     
      output += shiftedLetter;
    }
    
    return output;
  }
}
