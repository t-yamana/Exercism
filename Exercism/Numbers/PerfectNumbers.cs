using System;
using System.Linq;

namespace Exercism.Numbers
{
  public enum Classification
  {
    Deficient = -1,
    Perfect  = 0,
    Abundant = 1,
  }

  public static class PerfectNumbers
  {
    public static Classification Classify(int number)
    {
      if (number <= 0) throw new ArgumentOutOfRangeException();

      var total = Enumerable.Range(1, number / 2)
        .Where(n => number % n == 0)
        .Sum().CompareTo(number);

      return (Classification)total;
    }
  }
}

