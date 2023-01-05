using System;
using System.Collections.Generic;
using System.Linq;

namespace ExercismTDD.ExtensionMethods
{
  public static class AccumulateExtensions
  {
    public static IEnumerable<U> Accumulate<T, U>(this IEnumerable<T> collection, Func<T, U> func)
    {
      return collection.Select(func);
    }
  }
}

