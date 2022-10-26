using Datetimes;
using System;

namespace Exercism
{
  internal class Program
  {
    static void Main(string[] args)
    {
      // var times = SavingsAccount.YearsBeforeDesiredBalance(100.0m, 125.80m);

      var now = DateTime.Now;
      // string message = now.ToString("M/dd/yyyy h:mm:ss tt");
      string message = Appointment.Description(now);

      Console.WriteLine(message);
    }
  }
}

