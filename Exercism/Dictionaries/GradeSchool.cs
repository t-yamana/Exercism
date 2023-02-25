using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercism.Dictionaries
{
  public class GradeSchool
  {
    Dictionary<int, string[]> grades = new Dictionary<int, string[]>();
    HashSet<string> uniqueNames = new HashSet<string>();

    public bool Add(string student, int grade)
    {
      if (student == null) return false;

      if (uniqueNames.Contains(student))
      {
        return false;
      }
      else
      {
        if (grades.TryGetValue(grade, out var names))
        {
          var idx = names.ToList().FindIndex(n => n[0] > student[0]);

          // 順序を維持しながら更新
          var answer = names.ToList();
          answer.Insert(idx == -1 ? names.Length : idx, student);

          grades[grade] = answer.ToArray();
        }
        else
        {
          grades.Add(grade, new string[] { student });
        }
        uniqueNames.Add(student);
        return true;
      }
    }

    public IEnumerable<string> Roster()
    {
      var sortedGrades = grades.Keys.OrderBy(k => k);
      List<string> answer = new List<string>();
      foreach (var g in sortedGrades)
      {
        answer.AddRange(grades[g]);
      }
      return answer.ToArray();
    }

    public IEnumerable<string> Grade(int grade)
    {
      if (grades.ContainsKey(grade))
      {
        return grades[grade];
      }
      else
      {
        return Array.Empty<string>();
      }
    }
  }
}

