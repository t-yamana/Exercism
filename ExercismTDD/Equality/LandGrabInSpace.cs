using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercism.Equality
{
  public struct Coord
  {
    public Coord(ushort x, ushort y)
    {
      X = x;
      Y = y;
    }

    public ushort X { get; }
    public ushort Y { get; }
  }

  public struct Plot
  {
    public HashSet<Coord> Coords { get; private set; }

    public Plot(Coord c1, Coord c2, Coord c3, Coord c4)
    {
      Coords = new Coord[] { c1, c2, c3, c4 }.ToHashSet();
    }

    public int GetLength()
    {
      int total = 0;
      var cs = Coords.GetEnumerator();
      while (cs.MoveNext())
      {
        total += (cs.Current.X + cs.Current.Y);
      }
      return total;
    }

    public override bool Equals(object other)
    {
      if (other is Plot plot)
      {
        return Coords.All(c => plot.Coords.Contains(c));
      }
      else
      {
        return false;
      }
    }
  }

  public class ClaimsHandler
  {
    List<Plot> plots = new List<Plot>();  // abberiviate style
    public void StakeClaim(Plot plot)
    {
      // parameter cannot be null (parameter source)
      plots.Add(plot);
    }

    public bool IsClaimStaked(Plot plot)
    {
      foreach (var p in plots)
      {
        if (p.Equals(plot)) return true;
      }
      return false;
    }

    public bool IsLastClaim(Plot plot)
    {
      return plots.LastOrDefault().Equals(plot) ? true : false;
    }

    public Plot GetClaimWithLongestSide()
    {
      return plots.OrderByDescending(p => p.GetLength()).FirstOrDefault();
    }
  }
}

