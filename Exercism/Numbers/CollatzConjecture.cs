using System;

namespace Exercism.Numbers
{
  public static class CollatzConjecture
  {
    public static int Steps(int number)
    {
      if (number <= 0) throw new ArgumentOutOfRangeException();

      int step = 0;
      while (number != 1)
      {
        number = number % 2 == 0 ? (number / 2) : (3 * number + 1);
        step++;
      }
      return step;
    }
  }
}

