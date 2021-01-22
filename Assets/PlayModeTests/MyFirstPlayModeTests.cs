﻿using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class MyFirstPlayModeTests
    {
        // A Test behaves as an ordinary method
        [Test]
        public void MyFirstPlayModeTestsSimplePasses()
        {
            // Use the Assert class to test conditions
            Assert.AreEqual(1, 0);
        }

        // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
        // `yield return null;` to skip a frame.
        [UnityTest]
        public IEnumerator MyFirstPlayModeTestsWithEnumeratorPasses()
        {
            // Use the Assert class to test conditions.
            // Use yield to skip a frame.
            yield return null;
        }
    }
}
