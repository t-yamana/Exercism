using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercism.Enums
{
  public enum Plant
  {
    Clover   = 67,
    Grass    = 71,
    Radishes = 82,
    Violets  = 86,
  }

  public class KindergartenGarden
  {
    string[] students;

    public KindergartenGarden(string diagram)
    {
      var lines = diagram.Split(new char[] { '\n' }, StringSplitOptions.RemoveEmptyEntries);

      var studentsCnt = lines[0].Length / 2;
      students = new string[studentsCnt];

      for (int i=0; i < lines[0].Length/2; i++)
      {
        var studentSet = lines[0].Substring(i*2, 2) + lines[1].Substring(i*2, 2);
        students[i] = studentSet;
      }
    }

    public IEnumerable<Plant> Plants(string student)
    {
      int idx = SearchIdxForStudent(student);
      string plantInStr = students[idx];

      return ConvertToPlant(plantInStr).AsEnumerable();
    }

    int SearchIdxForStudent(string student)
    {
      int diff = student.First() - 'A';

      if (diff < 0)
        throw new ArgumentOutOfRangeException();

      return diff;
    }

    Plant[] ConvertToPlant(string signs)
    {
      char[] keys = signs.ToCharArray();
      Plant[] plantArray = new Plant[keys.Length];
      for (int i = 0; i < keys.Length; i++)
      {
          plantArray[i] = (Plant)Enum.ToObject(typeof(Plant), keys[i]);
      }
      return plantArray;
    }
  }
}

