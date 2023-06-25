using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercism.Numbers
{
  public static class DifferenceOfSquares
  {
    public static int CalculateSquareOfSum(int max)
    {
      int seed = Enumerable.Range(1, max).Sum(x => x);
      return seed * seed;
    }

    public static int CalculateSumOfSquares(int max)
    {
      int sum = Enumerable.Range(1, max).Sum(x => x * x);
      return sum;
    }

    public static int CalculateDifferenceOfSquares(int max)
    {
      // (x + y + z)**2 - (x** + y** + z**) = 2(xy + yz + zx)
      return CalculateSquareOfSum(max) - CalculateSumOfSquares(max);
    }
  }
}

