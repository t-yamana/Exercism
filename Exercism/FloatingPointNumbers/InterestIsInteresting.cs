using System;

static class SavingsAccount
{
  public static float InterestRate(decimal balance)
  {
    return balance switch
    {
      < 0 => 3.213f,
      < 1000 => 0.5f,
      < 5000 => 1.621f,
      _ => 2.475f
    };
  }

  public static decimal Interest(decimal balance)
  {
    return (decimal)(InterestRate(balance) / 100) * balance;
  }

  public static decimal AnnualBalanceUpdate(decimal balance)
  {
    return Interest(balance) + balance;
  }

  public static int YearsBeforeDesiredBalance(decimal balance, decimal targetBalance)
  {
    return YBDBalanceStack(balance, targetBalance, 0);
  }

  private static int YBDBalanceStack(decimal balance, decimal targetBalance, int times)
  {
    return balance < targetBalance
    ? YBDBalanceStack(AnnualBalanceUpdate(balance), targetBalance, times + 1)
    : times;
  }
}

