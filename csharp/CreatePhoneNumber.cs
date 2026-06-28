public class Kata
{
  public static string CreatePhoneNumber(int[] numbers)
  {
    string digits = string.Concat(numbers);
    
    // (XXX) XXX-XXXX
    return $"({digits[..3]}) {digits[3..6]}-{digits[6..]}";
  }
}
