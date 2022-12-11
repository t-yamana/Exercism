using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Exercism.Strings
{
  public static class Pangram
  {
    const string alphabet = "abcdefghijklmnopqrstuvwxyz";
    public static bool IsPangram(string input)
    {
      return alphabet.All(c => input.ToLower().Contains(c));
    }
    public static bool IsPangram1(string input)
    {
      var chars = new HashSet<char>();

      Regex re = new Regex("[a-z]+");
      var matches = re.Matches(input.ToLower());
      foreach (Match m in matches)
      {
        chars.UnionWith(m.Value.ToCharArray());
      }
      return chars.Count == alphabet.Length;
    }
  }
}

