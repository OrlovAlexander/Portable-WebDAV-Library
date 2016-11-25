﻿using Microsoft.VisualStudio.TestPlatform.UnitTestFramework;
using System;

namespace DecaTec.WebDav.Uwp.UnitTest
{
    [TestClass]
    public class UnitTestWebDavTimeoutHeaderValue
    {
        [TestMethod]
        public void UT_UWP_WebDavTimeoutHeaderValue_ToStringInfinite()
        {
            var wdthv = WebDavTimeoutHeaderValue.CreateInfiniteWebDavTimeout();

            Assert.AreEqual(wdthv.ToString(), "Infinite");
        }

        [TestMethod]
        public void UT_UWP_WebDavTimeoutHeaderValue_ToStringTimeout()
        {
            var wdthv = WebDavTimeoutHeaderValue.CreateWebDavTimeout(TimeSpan.FromSeconds(500));

            Assert.AreEqual(wdthv.ToString(), "Second-500");
        }

        [TestMethod]
        public void UT_UWP_WebDavTimeoutHeaderValue_ToStringInfiniteWithAlternativeTimeout()
        {
            var wdthv = WebDavTimeoutHeaderValue.CreateInfiniteWebDavTimeoutWithAlternative(TimeSpan.FromSeconds(500));

            Assert.AreEqual(wdthv.ToString(), "Infinite, Second-500");
        }
    }
}
