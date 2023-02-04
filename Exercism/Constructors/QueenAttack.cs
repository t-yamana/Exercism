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

    public Queen ComeNearAxis1()
    {
      int row = this.Row;
      int col = this.Column;
      while (row > 0 && col > 0)
      {
        row--;
        col--;
      }
      return new Queen(row, col);
    }
    public Queen ComeNearAxis2()
    {
      int row = this.Row;
      int col = this.Column;
      while (row > 0 && col < QueenAttack.BoardRng)
      {
        row--;
        col++;
      }
      return new Queen(row, col);
    }

    public bool SamePosition(Queen other)
    {
      return this.Row == other.Row && this.Column == other.Column;
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
      if (row < 0 || column < 0) throw new ArgumentOutOfRangeException();
      if (BoardRng < row || BoardRng < column) throw new ArgumentOutOfRangeException();

      return new Queen(row, column);
    }

    static bool IsSameRowColumn(Queen q1, Queen q2)
    {
      return q1.Row == q2.Row || q1.Column == q2.Column;
    }

    static bool IsSameDiagonal(Queen q1, Queen q2)
    {
      bool Check1 = q1.ComeNearAxis1().SamePosition(q2.ComeNearAxis1());
      bool Check2 = q1.ComeNearAxis2().SamePosition(q2.ComeNearAxis2());
      return Check1 || Check2;
    }
  }
}

