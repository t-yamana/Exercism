using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercism.IfStatements
{
  public static class Raindrops
  {
    private static Dictionary<int, string> map = new Dictionary<int, string>()
  {
    {3, "Pling"},
    {5, "Plang"},
    {7, "Plong"},
  };

    public static string Convert(int number)
    {
      var factors = Enumerable.Range(1, (int)Math.Sqrt(number))
          .Where(n => number % n == 0)
          .Select(n => new[] { n, number / n })
          .SelectMany(x => x)  // jaggledArray
          .Distinct()
          .Where(n => n == 3 || n == 5 || n == 7);

      if (factors.Count() == 0) return number.ToString();

      return string.Join("", factors.Select(n => map[n]));
    }
  }
}

