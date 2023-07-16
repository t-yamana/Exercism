using System.Collections.Generic;
using System.Linq;

namespace Exercism.Numbers
{
  public static class SumOfMultiples
  {
    public static int Sum(IEnumerable<int> multiples, int max)
    {
      var pt = Enumerable
        .Range(0, max)
        .Where(n => multiples.Any(m => 0 < m && n % m == 0))
        .Sum();

      return pt;
    }
  }
}

