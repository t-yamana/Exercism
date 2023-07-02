using System;
using System.Collections.Generic;

namespace Exercism.Classes
{
  public class SpaceAge
  {
    double _sec;
    const double _earth_sec = 31557600d;

    Dictionary<string, double> _sidereal = new Dictionary<string, double>();

    public SpaceAge(int seconds)
    {
      _sidereal["Mercury"] = 0.2408467;
      _sidereal["Venus"]   = 0.61519726;
      _sidereal["Earth"]   = 1.0;
      _sidereal["Mars"]    = 1.8808158;
      _sidereal["Jupiter"] = 11.862615;
      _sidereal["Saturn"]  = 29.447498;
      _sidereal["Uranus"]  = 84.016846;
      _sidereal["Neptune"] = 164.79132;

      this._sec = seconds;
    }

    public double OnEarth()   => _sec / _earth_sec;
    public double OnMercury() => OnEarth() / _sidereal["Mercury"];
    public double OnVenus()   => OnEarth() / _sidereal["Venus"];
    public double OnMars()    => OnEarth() / _sidereal["Mars"];
    public double OnJupiter() => OnEarth() / _sidereal["Jupiter"];
    public double OnSaturn()  => OnEarth() / _sidereal["Saturn"];
    public double OnUranus()  => OnEarth() / _sidereal["Uranus"];
    public double OnNeptune() => OnEarth() / _sidereal["Neptune"];
  }
}

