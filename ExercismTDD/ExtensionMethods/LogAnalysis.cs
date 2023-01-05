using System.Linq;

namespace ExercismTDD.ExtensionMethods
{
  public static class LogAnalysis
  {
    public static string SubstringAfter(this string text, string partial)
    {
      // string[0] => char Type
      string sbst = text.Split(partial[0]).Last();
      return sbst;
    }

    public static string SubstringBetween(this string text, string char1, string char2)
    {
      string sbst = text.Split(char1[0]).Last().Split(char2[0]).First();
      return sbst;
    }

    public static string Message(this string text)
    {
      return text.SubstringAfter(": ");
    }

    public static string LogLevel(this string text)
    {
      return text.SubstringBetween("[", "]");
    }
  }
}

