using System;

namespace Exercism.IfStatements
{
  public static class Darts
  {
    const double OUTER_RADIUS = 10.0;
    const double MIDDLE_RADIUS = 5.0;
    const double INNER_RADIUS = 1.0;

    const int OUTER_PT = 1;
    const int MIDDLE_PT = 5;
    const int INNER_PT = 10;

    public static int Score(double x, double y)
    {
      double distance = Math.Sqrt(x * x + y * y);

      return distance switch
      {
        <= INNER_RADIUS => INNER_PT,
        <= MIDDLE_RADIUS => MIDDLE_PT,
        <= OUTER_RADIUS => OUTER_PT,
        _ => 0,
      };
    }
  }
}

