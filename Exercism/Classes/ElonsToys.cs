namespace Excercism.Classes
{
  class RemoteControlCar
  {
    private int distance;
    private int battery;

    public RemoteControlCar()
    {
      (distance, battery) = (0, 100);
    }

    public static RemoteControlCar Buy() => new();

    public string DistanceDisplay() => $"Driven {this.distance} meters";

    public string BatteryDisplay()
    {
      return this.battery > 0 ? $"Battery at {this.battery}%" : "Battery empty";
    }

    public void Drive()
    {
      if (this.battery > 0)
      {
        this.distance += 20;
        this.battery -= 1;
      }
    }
  }
}

