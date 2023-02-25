using System.Collections.Generic;
using System.Linq;

namespace Exercism.Dictionaries
{
  public class GradeSchool
  {
    // 抽象に依存させる => IDictionary
    // readonly 付けられるし、付けるべき

    private readonly IDictionary<string, int> _students
      = new Dictionary<string, int>();

    public bool Add(string student, int grade)
    {
      // bool を返してくれるメソッドが既に存在する
      // Key の Null や重複処理も記述不要

      return _students.TryAdd(student, grade);
    }

    public IEnumerable<string> Roster()
    {
      // OrderBy -> ThenBy で二段階のソートが可能

      return _students
        .OrderBy(kvp => kvp.Value)
        .ThenBy(kvp => kvp.Key)
        .Select(kvp => kvp.Key);

      // IEnumerable はコマンドをため込んだ状態で返却: 遅延実行
      // 実行してしまうなら => .ToArray()
    }

    public IEnumerable<string> Grade(int grade)
    {
      return _students
        .Where(kvp => kvp.Value == grade)
        .OrderBy(kvp => kvp.Key)
        .Select(kvp => kvp.Key);
    }
  }
}

