﻿using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FakeHost;

namespace Example.MsTest {
  /// <summary>
  /// Summary description for UnitTest1
  /// </summary>
  [TestClass]
  public class UnitTest1 {
    [TestMethod]
    public void TestMethod1() {
      var browser = new Browser();
      var result = browser.Get("home/index");
      Assert.AreEqual(200, result.StatusCode);
    }
  }
}
