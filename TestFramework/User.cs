﻿using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;

namespace TestFramework
{
    class User
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }
    }
}
