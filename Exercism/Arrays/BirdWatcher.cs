using System;
using System.Linq;

namespace Arrays
{
  class BirdCount
  {
    private static int[] birdsLastWeek = { 0, 2, 5, 3, 7, 8, 4 };
    private int[] birdsPerDay;

    public BirdCount(int[] birdsPerDay)
    {
      this.birdsPerDay = birdsPerDay;
    }

    public static int[] LastWeek() => birdsLastWeek;
    public int Today() => birdsPerDay.Last();

    public void IncrementTodaysCount()
    {
      birdsPerDay[^1] += 1;  // C#8.0 index from end
    }

    public bool HasDayWithoutBirds() => birdsPerDay.Contains(0);

    public int CountForFirstDays(int numberOfDays)
    {
      return birdsPerDay
        .Select((v, i) => (v, i))
        .Where(tup => tup.i < numberOfDays)
        .Sum(tup => tup.v);
    }

    public int BusyDays() => birdsPerDay.Count(v => v >= 5);
  }
}

