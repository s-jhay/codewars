public class Kata
{
  public static double SumArray(double[] array)
  {
    double outNum = 0;
    
    foreach (double num in array)
    {
      outNum += num;
    }
    
    return outNum;
  }
}
