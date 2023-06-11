using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercism.Strings
{
  public static class Isogram
  {
    public static bool IsIsogram(string word)
    {
      // NOT isAlpha()
      IEnumerable<Char> chars = word.ToLower().Where(c => Char.IsLetter(c));
      return chars.Count() == chars.Distinct().Count();
    }
  }
}

