using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Exercism.Strings
{
  public static class Pangram
  {
    public static bool IsPangram(string input)
    {
      var chars = new HashSet<char>();

      Regex re = new Regex("[a-z]+");
      var matches = re.Matches(input.ToLower());
      foreach (Match m in matches)
      {
        chars.UnionWith(m.Value.ToCharArray());
        
        // Bad
        // m.Value.ToCharArray().Select(c => chars.Add(c));
      }

      return chars.Count == "ABCDEFGHIJKLMNOPQRSTUVWXYZ".Length;
    }
  }
}

