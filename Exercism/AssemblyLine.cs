using System;

static class AssemblyLine
{
  private static readonly int _defaultProduce = 221;

  public static double SuccessRate(int speed)
  {
    return speed switch
    {
      <=0 => 0.0,
      <=4 => 1.0,
      <=8 => 0.9,
      <=9 => 0.8,
      _ => 0.77
    };
  }

  public static double ProductionRatePerHour(int speed)
  {
    return SuccessRate(speed) * _defaultProduce * speed;
  }

  public static int WorkingItemsPerMinute(int speed)
  {
    return (int)(ProductionRatePerHour(speed) / 60);
  }
}

