using System;
using System.Linq;

namespace Exercism.ForLoops
{
  public static class Series
  {
    public static string[] Slices(string numbers, int sliceLength)
    {
      int patterns = numbers.Count() - sliceLength + 1;
      if (patterns <= 0 || sliceLength <= 0)
      {
        throw new ArgumentException();
      }

      var answers = new string[patterns];
      for (int i = 0; i < patterns; i++)
      {
        answers[i] = new string(numbers.Take(new Range(i, i + sliceLength)).ToArray());
      }
      return answers;
    }
  }
}

