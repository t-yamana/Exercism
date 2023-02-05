using System;

namespace Exercism.Constructor
{
  public class Queen
  {
    public Queen(int row, int column)
    {
      Row = row;
      Column = column;
    }

    public int Row { get; }
    public int Column { get; }
  }

  public static class QueenAttack
  {
    public const int BoardRng = 7;

    public static bool CanAttack(Queen white, Queen black) =>
      IsSameRowColumn(white, black) || IsSameDiagonal(white, black);

    public static Queen Create(int row, int column)
    {
      if (row < 0 || BoardRng < row)
        throw new ArgumentOutOfRangeException();
      if (column < 0 || BoardRng < column)
        throw new ArgumentOutOfRangeException();

      return new Queen(row, column);
    }

    static bool IsSameRowColumn(Queen q1, Queen q2)
    {
      return q1.Row == q2.Row || q1.Column == q2.Column;
    }

    static bool IsSameDiagonal(Queen q1, Queen q2)
    {
      return Math.Abs(q1.Row - q2.Row) == Math.Abs(q1.Column - q2.Column);
    }
  }
}

