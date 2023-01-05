using System;
using System.Collections.Generic;
using System.Linq;

namespace ExercismTDD.Equality
{
  public struct Coord
  {
    public Coord(ushort x, ushort y)
    {
      X = x;
      Y = y;
    }

    public double DistWithOther(Coord other)
    {
      return Math.Pow((this.X - other.X), 2) + Math.Pow((this.Y - other.Y), 2);
    }

    public ushort X { get; }
    public ushort Y { get; }
  }

  public struct Plot
  {
    public Coord[] Coords { get; private set; }

    public Plot(Coord c1, Coord c2, Coord c3, Coord c4)
    {
      Coords = new Coord[] { c1, c2, c3, c4 };
    }

    public double GetLength()
    {
      double total = 0;
      total += Coords[0].DistWithOther(Coords[1]);
      total += Coords[1].DistWithOther(Coords[2]);
      total += Coords[2].DistWithOther(Coords[3]);
      total += Coords[3].DistWithOther(Coords[0]);
      return total;
    }

    public override bool Equals(object other)
    {
      if (other is Plot plot)
      {
        bool res = true;
        for (int i = 0; i < Coords.Length; i++)
        {
          res = res && Coords[i].Equals(plot.Coords[i]);
        }
        return res;
      }
      else
      {
        return false;
      }
    }
  }

  public class ClaimsHandler
  {
    List<Plot> plots = new List<Plot>();

    public void StakeClaim(Plot plot)
    {
      // parameter cannot be null (parameter source)
      plots.Add(plot);
    }

    public bool IsClaimStaked(Plot plot)
    {
      return plots.Contains(plot);
    }

    public bool IsLastClaim(Plot plot)
    {
      return plots.LastOrDefault().Equals(plot);
    }

    public Plot GetClaimWithLongestSide()
    {
      return plots.OrderByDescending(p => p.GetLength()).FirstOrDefault();
    }
  }
}

