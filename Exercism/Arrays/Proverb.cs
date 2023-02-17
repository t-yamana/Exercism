using System;
using System.Linq;

namespace Exercism.Arrays
{
  public static class Proverb
  {
    public static string[] Recite(string[] subjects)
    {
      if (subjects == Array.Empty<string>()) return subjects;

      return subjects
        .Zip(subjects.Skip(1), (s1, s2) => $"For want of a {s1} the {s2} was lost.")
        .Append($"And all for the want of a {subjects[0]}.")
        .ToArray();

      // 参考:

      // Enumerable.Range(0, subjects.Length - 1)
      //   .Select(i => $"For want of a {subjects[i]} the {subjects[i+1]} was lost.");
    }
  }
}

