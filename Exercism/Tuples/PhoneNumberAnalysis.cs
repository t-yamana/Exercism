using System;

public static class PhoneNumber
{
  private static readonly string NewYorkNum = "212";
  private static readonly string FakeNum = "555";
  public static (bool IsNewYork, bool IsFake, string LocalNumber) Analyze(string phoneNumber)
  {
    string[] nums = phoneNumber.Split('-');
    return (nums[0] == NewYorkNum, nums[1] == FakeNum, nums[2]);
  }

  public static bool IsFake((bool IsNewYork, bool IsFake, string LocalNumber) phoneNumberInfo)
  {
    return phoneNumberInfo.IsFake;
  }
}

