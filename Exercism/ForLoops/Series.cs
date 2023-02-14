using System;
using System.Linq;

namespace Exercism.ForLoops
{
  public static class Series
  {
    public static string[] Slices(string numbers, int sliceLength)
    {
      return (sliceLength < 1 || numbers.Length < sliceLength) ?
        throw new ArgumentException() :
        Enumerable.Range(0, numbers.Length - sliceLength + 1)
          .Select(i => numbers.Substring(i, sliceLength))
          .ToArray();
    }
  }
}

