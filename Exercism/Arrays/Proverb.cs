using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercism.Arrays
{
  public static class Proverb
  {
    public static string[] Recite(string[] subjects)
    {
      if (subjects == Array.Empty<string>()) return subjects;

      // 空の IEnumerable を準備
      IEnumerable<string> message = Enumerable.Empty<string>();

      if (subjects.Length > 1)
      {
        message = Enumerable.Range(0, subjects.Length - 1)
        .Select(i => $"For want of a {subjects[i]} the {subjects[i + 1]} was lost.");
      }
      return message.Append($"And all for the want of a {subjects[0]}.").ToArray();
    }
  }
}

