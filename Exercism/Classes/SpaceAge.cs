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

    public double OnEarth()   => _sec / (_sidereal["Earth"] * _earth_sec);
    public double OnMercury() => _sec / (_sidereal["Mercury"] * _earth_sec);
    public double OnVenus()   => _sec / (_sidereal["Venus"] * _earth_sec);
    public double OnMars()    => _sec / (_sidereal["Mars"] * _earth_sec);
    public double OnJupiter() => _sec / (_sidereal["Jupiter"] * _earth_sec);
    public double OnSaturn()  => _sec / (_sidereal["Saturn"] * _earth_sec);
    public double OnUranus()  => _sec / (_sidereal["Uranus"] * _earth_sec);
    public double OnNeptune() => _sec / (_sidereal["Neptune"] * _earth_sec);
  }
}

