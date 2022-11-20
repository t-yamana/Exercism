using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercism.Interfaces
{
  public interface IRemoteControlCar
  {
    int DistanceTravelled { get; }  // set なし
    void Drive();
  }

  public class ProductionRemoteControlCar : IRemoteControlCar, IComparable<ProductionRemoteControlCar>
  {
    public int DistanceTravelled { get; private set; } = 0;
    public int NumberOfVictories { get; set; }

    public int CompareTo(ProductionRemoteControlCar? other)
    {
      return this.NumberOfVictories.CompareTo(other?.NumberOfVictories);
    }

    public void Drive() => DistanceTravelled += 10;
  }

  public class ExperimentalRemoteControlCar : IRemoteControlCar
  {
    public int DistanceTravelled { get; private set; } = 0;
    public void Drive() => DistanceTravelled += 20;
  }

  public static class TestTrack
  {
    public static void Race(IRemoteControlCar car) => car.Drive();
    public static List<ProductionRemoteControlCar> GetRankedCars(ProductionRemoteControlCar prc1,
        ProductionRemoteControlCar prc2)
    {
      // return new[] { prc1, prc2 }.OrderBy(car => car).ToList();
      var list = new List<ProductionRemoteControlCar> { prc1, prc2 };
      list.Sort();
      return list;
    }
  }
}

