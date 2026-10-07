// A format for expressing an ordered list of integers is to use a comma separated list of either
//
// - individual integers
// - or a range of integers denoted by the starting integer separated from the end integer in the 
//    range by a dash, '-'. The range includes all integers in the interval including both endpoints. 
//    It is not considered a range unless it spans at least 3 numbers. For example "12,13,15-17"
// 
// Complete the solution so that it takes a list of integers in increasing order and returns a 
//  correctly formatted string in the range format.
// 
// Example:
// 
// solution([-10, -9, -8, -6, -3, -2, -1, 0, 1, 3, 4, 5, 7, 8, 9, 10, 11, 14, 15, 17, 18, 19, 20]);
// returns "-10--8,-6,-3-1,3-5,7-11,14,15,17-20"
// 
// Courtesy of rosettacode.org

using System.Collections.Generic;
using System.Text;

public class RangeExtraction
{
    public static string Extract(int[] args)
    {
        List<int> block = [];
        List<List<int>> totalBlocks = [];
    
        foreach (int num in args)
        {
            // start of loop, add int and move on to next
            if (block.Count == 0 && totalBlocks.Count == 0)
            {
                block.Add(num);
                continue;
            }
        
            // break off if not valid range
            if (block.Count < 3
                && num - 1 != block[^1])
            {
                foreach (int n in block)
                {
                    totalBlocks.Add(new List<int>{n});
                }
                block.Clear();
                block.Add(num);
            }
            // break off if missing last number
            else if (num - 1 != block[^1])
            {
                totalBlocks.Add(new List<int>(block));
                block.Clear();
                block.Add(num);
            }
            else
            {
                block.Add(num);
            }
        }
        
        // see if last block is valid range
        if (block.Count < 3)
        {
            foreach (int n in block)
            {
                totalBlocks.Add(new List<int>{n});
            }
        }
        else
        {
            totalBlocks.Add(new List<int>(block));
        }

        StringBuilder sb = new();
        
        foreach(List<int> b in totalBlocks)
        {
            if (b.Count > 1)
            {
                sb.Append($"{b[0]}-{b[^1]},");
            }
            else
            {
                sb.Append($"{b[0]},");
            }
        }

        sb.Remove(sb.Length - 1, 1);
        return sb.ToString();
    }
}
