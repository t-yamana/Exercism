using System;

namespace Constructors
{
  class RemoteControlCar
  {
    internal int Speed { get; }
    internal int BatteryDrain { get; }

    int distance;
    int battery;

    public RemoteControlCar(int speed, int batteryDrain)
    {
      Speed = speed;
      BatteryDrain = batteryDrain;

      this.battery = 100;
      this.distance = 0;
    }

    public bool BatteryDrained()
    {
      // ==0 ではないことに注意
      return this.battery < BatteryDrain;
    }

    public int DistanceDriven() => this.distance;

    public void Drive()
    {
      if (this.battery >= BatteryDrain)
      {
        this.battery -= BatteryDrain;
        this.distance += Speed;
      }
    }

    public static RemoteControlCar Nitro() => new RemoteControlCar(speed: 50, batteryDrain: 4);
  }

  class RaceTrack
  {
    int distance;

    public RaceTrack(int distance)
    {
      this.distance = distance;
    }

    public bool TryFinishTrack(RemoteControlCar car)
    {
      while (!car.BatteryDrained())
      {
        car.Drive();
      }
      return this.distance <= car.DistanceDriven();
    }
  }
}

