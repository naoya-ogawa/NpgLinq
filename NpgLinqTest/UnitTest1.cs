
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

using Microsoft.VisualStudio.TestTools.UnitTesting;
using NpgLinq;


namespace NpgLinqTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var q = NpgQueryProvider.CreateQueryable<int>();
            var val = from x in q
                      where x > 10
                      select x;

            System.Diagnostics.Debug.WriteLine(val.First());
        }
    }
}
