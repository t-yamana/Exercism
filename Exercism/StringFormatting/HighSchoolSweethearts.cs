using System;
using System.Globalization;

namespace Exercism.StringFormatting
{
  public static class HighSchoolSweethearts
  {
    public static string DisplaySingleLine(string studentA, string studentB)
      // {"test",  5} -> "  test"
      // {"test", -5} -> "test  "
      => $"{studentA, 29} ♡ {studentB, -29}";

    public static string DisplayBanner(string studentA, string studentB)
    {
      // String Interpolation & Template String
      return String.Format(
      $@"
     ******       ******
   **      **   **      **
 **         ** **         **
**            *            **
**                         **
**     {studentA.Trim()}  +  {studentB.Trim()}     **
 **                       **
   **                   **
     **               **
       **           **
         **       **
           **   **
             ***
              *
");
    }

    public static string DisplayGermanExchangeStudents(string studentA
        , string studentB, DateTime start, float hours)
    {
      CultureInfo ci = CultureInfo.CreateSpecificCulture("de-DE");
      string DateStr = start.ToString("d", ci);
      string HourStr = hours.ToString("N2", ci);
      return $"{studentA} and {studentB} have been dating since {DateStr} - that's {HourStr} hours";
    }
  }
}

