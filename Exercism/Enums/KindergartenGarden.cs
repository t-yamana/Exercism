using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercism.Enums
{
  public enum Plant
  {
    Clover = 'C',
    Grass = 'G',
    Radishes = 'R',
    Violets = 'V',
  }

  public class KindergartenGarden
  {
    string _diagram;

    public KindergartenGarden(string diagram)
    {
      this._diagram = diagram;
    }

    public IEnumerable<Plant> Plants(string student)
    {
      int idx = student.First() - 'A';

      if (idx < 0)
        throw new ArgumentOutOfRangeException();

      foreach (string line in this._diagram.Split(new[] { '\n' }, StringSplitOptions.RemoveEmptyEntries))
      {
        // IEnumerable なので可能
        yield return (Plant)line[idx * 2];  // Enum へ変換
        yield return (Plant)line[idx * 2 + 1];
      }
    }
  }
}

