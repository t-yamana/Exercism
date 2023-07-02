using System;
using System.Collections.Generic;

namespace Exercism.Classes
{
  public class Robot
  {
    static readonly HashSet<string> uniqueNames = new HashSet<string>();
    string name;

    public string Name
    {
      get => name;
      private set
      {
        if (uniqueNames.Contains(value))
          throw new InvalidOperationException("Name is already assigned.");

        name = value;
      }
    }

    public Robot()
    {
      Reset();
    }

    public void Reset()
    {
      var random = new Random();
      string newName;

      do
      {
        char c1 = (char)random.Next('A', 'Z' + 1);
        char c2 = (char)random.Next('A', 'Z' + 1);
        string no = random.Next(1, 1000).ToString("D3");
        newName = $"{c1}{c2}{no}";
      }
      while (uniqueNames.Contains(newName));
      Name = newName;
      uniqueNames.Add(newName);  // 順番必須
    }
  }
}

