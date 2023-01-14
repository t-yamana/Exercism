using System;
using System.Linq;

namespace Exercism.Strings
{
  public static class ReverseString
  {
    public static string Reverse(string input) =>
      new string(input.Reverse().ToArray());
      // string.Join("", input.Reverse());
  }
}

