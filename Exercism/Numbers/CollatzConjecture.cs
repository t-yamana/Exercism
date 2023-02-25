using System;

namespace Exercism.Numbers
{
  public static class CollatzConjecture
  {
    public static int Steps(int number)
    {
      if (number <= 0)
      {
        throw new ArgumentOutOfRangeException("number must be non-negative");
      }
      else if(number == 1)
      {
        return 0;  // count only if Steps() called
      }
      else if(number % 2 == 0)  // Even
      {
        return 1 + Steps(number / 2);
      }
      else  // Odd
      {
        return 1 + Steps(3 * number + 1);
      }
    }
  }
}

