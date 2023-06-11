using System;

namespace Exercism.SwitchStatements
{
  public static class BeerSong
  {
    public static string Recite(int startBottles, int takeDown) =>
      Speech(startBottles)
      + (takeDown - 1 > 0 ?
        "\n\n" + Recite(startBottles - 1, takeDown - 1)
        : String.Empty);

    static string Speech(int bottles)
    {
      string st_bt = Bottle(bottles);
      string nx_bt = Bottle(bottles > 0 ? bottles - 1 : 99);

      return (
        $"{st_bt} of beer on the wall, {st_bt.ToLower()} of beer.\n"
        + $"{BottleSentence(bottles)} {nx_bt.ToLower()} of beer on the wall."
      );
    }

    static string Bottle(int num) =>
      num switch
      {
        > 1 => num + " bottles",
        1 => num + " bottle",
        _ => "No more bottles",
      };

    static string BottleSentence(int num) =>
      num switch
      {
        > 1 => "Take one down and pass it around,",
        1 => "Take it down and pass it around,",
        _ => "Go to the store and buy some more,",
      };
  }
}

