using System;

namespace Exercism.IfStatements
{
  public static class Darts
  {
    public static int Score(double x, double y)
    {
      double distance = Math.Sqrt(x * x + y * y);

      return distance switch
      {
        <=  1.0 => 10,
        <=  5.0 => 5,
        <= 10.0 => 1,
        _ => 0,
      };
    }
  }
}

