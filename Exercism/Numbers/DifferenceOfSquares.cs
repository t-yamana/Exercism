using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercism.Numbers
{
  public static class DifferenceOfSquares
  {
    public static int CalculateSquareOfSum(int max)
    {
      int sum = Enumerable.Range(1, max).Aggregate(
        new List<int> { 0 },
        (list, n) =>
        {
          list.Add(list.Last() + n);
          return list;
        }).Last();
      return sum * sum;
    }

    public static int CalculateSumOfSquares(int max)
    {
      int sum = Enumerable.Range(1, max).Aggregate(
        new List<int> (),  // answer container
        (list, n) =>
        {
          list.Add(n * n);
          return list;
        }).Sum();
      return sum;
    }

    public static int CalculateDifferenceOfSquares(int max)
    {
      int a = CalculateSquareOfSum(max);
      int b = CalculateSumOfSquares(max);
      return Math.Abs(a - b);
    }
  }
}

