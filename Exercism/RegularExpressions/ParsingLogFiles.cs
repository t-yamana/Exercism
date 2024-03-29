﻿using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Exercism.RegularExpressions
{
  public class LogParser
  {
    string[] LogKeys = { "TRC", "DBG", "INF", "WRN", "ERR", "FTL" };
    public bool IsValidLine(string text)
    {
      var match = Regex.Match(text, @"^\[\w{3}\]");
      return match.Success ? LogKeys.Contains(match.Value.Substring(1, 3)) : false;
    }

    public string[] SplitLogLine(string text)
    {
      Regex re = new Regex("<[-=^*]+>");
      return re.Split(text);
      // 不要 .Where(s => s.Length > 0).ToArray();
    }

    public int CountQuotedPasswords(string lines)
    {
      Regex re = new Regex("\".*password.*\"", RegexOptions.IgnoreCase);
      var txtLines = lines.Split(new[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
      return txtLines.Where(l => re.IsMatch(l)).Count();
    }

    public string RemoveEndOfLineText(string line)
    {
      Regex re = new Regex(@"end-of-line\d+");
      return re.Replace(line, String.Empty);
    }

    public string[] ListLinesWithPasswords(string[] lines)
    {
      Regex re = new Regex(@"password[\S]+", RegexOptions.IgnoreCase);

      string[] answer = new string[lines.Count()];  
      for (int i=0; i<lines.Count(); i++)
      {
        string prefix = re.IsMatch(lines[i]) ? re.Match(lines[i]).Value : "--------";
        answer[i] = $"{prefix}: {lines[i]}";
      }
      return answer;
    }
  }
}

