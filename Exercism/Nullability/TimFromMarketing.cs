using System.Collections.Generic;

static class Badge
{
  public static string Print(int? id, string name, string? department)
  {
    string? prefix = id.HasValue ? $"[{id.ToString()}]" : null;
    string suffix = (department ?? "OWNER").ToUpper();

    var badges = new List<string?> { prefix, name, suffix };
    badges.RemoveAll(b => b == null);

    return string.Join(" - ", badges);
  }
}

