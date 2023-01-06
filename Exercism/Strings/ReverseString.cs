using System;
using System.Linq;

namespace Exercism.Strings
{
  public static class ReverseString
  {
    public static string Reverse(string input) => string.Join("", input.Reverse());
  }
}

