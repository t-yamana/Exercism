using System;
using System.Linq;

namespace Exercism.Constructor
{
  public class DndCharacter
  {
    static Random rnd = new Random(DateTime.Now.Millisecond);

    public int Strength { get; }
    public int Dexterity { get; }
    public int Constitution { get; }
    public int Intelligence { get; }
    public int Wisdom { get; }
    public int Charisma { get; }
    public int Hitpoints { get; }

    DndCharacter()
    {
      Strength = Ability();
      Dexterity = Ability();
      Constitution = Ability();
      Intelligence = Ability();
      Wisdom = Ability();
      Charisma = Ability();
      Hitpoints = 10 + Modifier(Constitution);
    }

    public static int Modifier(int score) => (int)Math.Floor((score - 10) / 2.0);

    public static int Ability()
    {
      int[] Dies = { RollDice(), RollDice(), RollDice(), RollDice() };
      return Dies.OrderByDescending(die => die).Take(3).Sum();
    }

    public static DndCharacter Generate()
    {
      return new DndCharacter();
    }

    static int RollDice() => rnd.Next(1, 6 + 1);
  }
}

