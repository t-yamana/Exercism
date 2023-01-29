using System.Collections.Generic;

namespace Exercism.FloatingPointNumbers
{
  public static class Triangle
  {
    static bool IsTriangle(double a, double b, double c) =>
      (a * b * c > 0) &&  // contains degenerate triangle
        (a <= b + c) && (b <= a + c) && (c <= a + b);

    /// <summary> Scalene: 不等辺三角形
    /// </summary>
    public static bool IsScalene(double a, double b, double c) =>
      IsTriangle(a, b, c) && new HashSet<double>() { a, b, c }.Count == 3;

    /// <summary> Isosceles: 二等辺三角形
    /// </summary>
    public static bool IsIsosceles(double a, double b, double c) =>
      IsTriangle(a, b, c) && new HashSet<double>() { a, b, c }.Count <= 2;

    /// <summary> Equilateral: 正三角形
    /// </summary>
    public static bool IsEquilateral(double a, double b, double c) =>
      IsTriangle(a, b, c) && new HashSet<double>() { a, b, c }.Count == 1;
  }
}

