using System;

namespace Exercism.MethodOverloading
{
  static class GameMaster
  {
    public static string Describe(Character character)
    {
      string answer = $"You're a level {character.Level} {character.Class} with {character.HitPoints} hit points.";
      return answer;
    }

    public static string Describe(Destination destination)
    {
      string answer = $"You've arrived at {destination.Name}, which has {destination.Inhabitants} inhabitants.";
      return answer;
    }

    public static string Describe(TravelMethod travelMethod)
    {
      string part = travelMethod switch
      {
        TravelMethod.Walking => "by walking",
        TravelMethod.Horseback => "on horseback",
        _ => throw new ArgumentException(),
      };
      string answer = $"You're traveling to your destination {part}.";
      return answer;
    }

    public static string Describe(Character character, Destination destination, TravelMethod travelMethod)
    {
      string answer1 = Describe(character);
      string answer2 = Describe(travelMethod);
      string answer3 = Describe(destination);
      return answer1 + " " + answer2 + " " + answer3;
    }

    public static string Describe(Character character, Destination destination)
    {
      return Describe(character, destination, TravelMethod.Walking);
    }
  }

  class Character
  {
    public string Class { get; set; }
    public int Level { get; set; }
    public int HitPoints { get; set; }
  }

  class Destination
  {
    public string Name { get; set; }
    public int Inhabitants { get; set; }
  }

  enum TravelMethod
  {
    Walking,
    Horseback
  }
}

