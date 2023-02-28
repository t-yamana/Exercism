using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercism.Enums
{
  public enum Allergen
  {
    Eggs,
    Peanuts,
    Shellfish,
    Strawberries,
    Tomatoes,
    Chocolate,
    Pollen,
    Cats
  }

  public class Allergies
  {
    readonly int _mask;

    public Allergies(int mask)
    {
      _mask = mask;
    }

    public bool IsAllergicTo(Allergen allergen)
    {
      int mask = 1 << (int)allergen;
      return (_mask & mask) > 0;
    }

    public Allergen[] List()
    {
      // Enum の配列(IEnumerable)化
      var arrAllergen = (IEnumerable<Allergen>)Enum.GetValues(typeof(Allergen));

      return arrAllergen
        .OrderBy(al => (int)al)
        .Where(al => (1 << (int)al & _mask) > 0).ToArray();
    }
  }
}

