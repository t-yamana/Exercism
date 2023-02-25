using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercism.Dictionaries
{
  public static class ScrabbleScore
  {
    static int MappingScore(char c)
    {
      var group1 = new HashSet<char> { 'a', 'e', 'i', 'o', 'u', 'l', 'n', 'r', 's', 't' };
      var group2 = new HashSet<char> { 'd', 'g' };
      var group3 = new HashSet<char> { 'b', 'c', 'm', 'p' };
      var group4 = new HashSet<char> { 'f', 'h', 'v', 'w', 'y' };
      var group5 = new HashSet<char> { 'k' };
      var group8 = new HashSet<char> { 'j', 'x' };
      var group10 = new HashSet<char> { 'q', 'z' };

      return c switch
      {
        _ when group1.Contains(c) => 1,
        _ when group2.Contains(c) => 2,
        _ when group3.Contains(c) => 3,
        _ when group4.Contains(c) => 4,
        _ when group5.Contains(c) => 5,
        _ when group8.Contains(c) => 8,
        _ when group10.Contains(c) => 10,
        _ => throw new ArgumentException(),
      };
    }


    public static int Score(string input)
    {
      return input.ToLower().Select(c => MappingScore(c)).Sum();
    }
  }
}

