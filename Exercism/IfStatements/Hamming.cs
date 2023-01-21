using System;
using System.Linq;

namespace Exercism.IfStatements
{
  public static class Hamming
  {
    public static int Distance(string firstStrand, string secondStrand)
    {
      if (firstStrand.Length != secondStrand.Length)
      {
        throw new ArgumentException();
      }

      return firstStrand.Zip(secondStrand).Count(tup => tup.First != tup.Second);
    }
  }
}

