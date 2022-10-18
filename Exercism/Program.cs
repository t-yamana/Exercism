using System;

namespace Exercism
{
  internal class Program
  {
    static void Main(string[] args)
    {
      var times = SavingsAccount.YearsBeforeDesiredBalance(100.0m, 125.80m);

      Console.WriteLine(times);
    }
  }
}

