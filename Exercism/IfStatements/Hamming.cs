using System;

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

      int hamdist = 0;
      for (int i = 0; i < firstStrand.Length; i++)
      {
        hamdist += firstStrand[i] == secondStrand[i] ? 0 : 1;
      }
      return hamdist;
    }
  }
}

