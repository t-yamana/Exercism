using Datetimes;
using System;
using IntegralNumbers;

namespace Exercism
{
  internal class Program
  {
    static void Main(string[] args)
    {
      // var times = SavingsAccount.YearsBeforeDesiredBalance(100.0m, 125.80m);

      var answer = TelemetryBuffer.ToBuffer(5);

      // var now = DateTime.Now;
      // string message = now.ToString("M/dd/yyyy h:mm:ss tt");
      // string message = Appointment.Description(now);

      Console.WriteLine(BitConverter.ToString(answer));
    }
  }
}

