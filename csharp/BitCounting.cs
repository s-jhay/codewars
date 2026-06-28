using System;
using System.Linq;

public class Kata
{
    public static int CountBits(int n)
    {
        string bin = Convert.ToString(n, 2);
        return bin.Count(n => n == '1');
    }
}
