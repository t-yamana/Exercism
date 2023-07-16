using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercism.Numbers
{
  public static class SumOfMultiples
  {
    public static int Sum(IEnumerable<int> multiples, int max)
    {
      var pt = multiples
        .Where(n => 0 < n && n <= max)
        .Select(n => Enumerable.Range(1, (max-1) / n).Select(m => n * m))
        .SelectMany(arr => arr)
        .Distinct()
        .Sum();

      return pt;
    }
  }
}

