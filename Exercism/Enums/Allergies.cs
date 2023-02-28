using System;
using System.Linq;

namespace Exercism.Enums
{
  public enum Allergen
  {
    Eggs         = 1<<0,  // 1
    Peanuts      = 1<<1,  // 2
    Shellfish    = 1<<2,  // 4
    Strawberries = 1<<3,  // 8
    Tomatoes     = 1<<4,  // 16
    Chocolate    = 1<<5,  // 32
    Pollen       = 1<<6,  // 64
    Cats         = 1<<7,  // 128
  }

  public class Allergies
  {
    readonly int _score;

    public Allergies(int mask) => _score = mask;

    public bool IsAllergicTo(Allergen allergen) =>
      // ここの書き方はいろいろある
      (_score & (int)allergen) == (int)allergen;

    public Allergen[] List()
    {
      // Enum の配列取得 しかも IEnumerable
      return Enum.GetValues(typeof(Allergen)).Cast<Allergen>()

        .Where(al => IsAllergicTo(al))
        .ToArray();

      // (IEnumerable<Allergen>)Enum.GetValues(typeof(Allergen));
    }
  }
}

