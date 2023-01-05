using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

using ExercismTDD.Equality;

namespace ExercismTest.Equality
{
  [TestClass]
  public class LandGrabInSpace
  {
    [TestMethod]
    public void Test1()
    {
      var ch = new ClaimsHandler();
      ch.StakeClaim(new Plot(new Coord(1, 1), new Coord(2, 1), new Coord(1, 2), new Coord(2, 2)));
      var claimed = ch.IsClaimStaked(new Plot(new Coord(1, 1), new Coord(2, 1), new Coord(1, 2), new Coord(2, 2)));
      Assert.IsTrue(claimed);
    }

    [TestMethod]
    public void Test2()
    {
      var ch = new ClaimsHandler();
      ch.StakeClaim(new Plot(new Coord(1, 1), new Coord(2, 1), new Coord(1, 2), new Coord(2, 2)));
      ch.StakeClaim(new Plot(new Coord(10, 1), new Coord(20, 1), new Coord(10, 2), new Coord(20, 2)));
      var lastClaim = ch.IsLastClaim(new Plot(new Coord(10, 1), new Coord(20, 1), new Coord(10, 2), new Coord(20, 2)));
      Assert.IsTrue(lastClaim);
    }

    [TestMethod]
    public void Test3()
    {
      var ch = new ClaimsHandler();
      var longer = new Plot(new Coord(10, 1), new Coord(20, 1), new Coord(10, 2), new Coord(20, 2));
      var shorter = new Plot(new Coord(1, 1), new Coord(2, 1), new Coord(1, 2), new Coord(2, 2));
      ch.StakeClaim(longer);
      ch.StakeClaim(shorter);
      Assert.AreEqual(longer, ch.GetClaimWithLongestSide());
    }
  }
}

