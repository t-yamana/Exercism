using System.Linq;

public static class LogAnalysis
{
  public static string SubstringAfter(this string text, string partial)
  {
    // string sbst = text[(text.IndexOf(partial) + partial.Length)..];
    string sbst = text.Split(partial).Last();
    return sbst;
  }

  public static string SubstringBetween(this string text, string char1, string char2)
  {
    // string sbst = text[(text.IndexOf(char1)+char1.Length)..text.IndexOf(char2)];
    string sbst = text.Split(char1).Last().Split(char2).First();
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

