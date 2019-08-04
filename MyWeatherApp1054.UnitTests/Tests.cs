using System;
using NUnit.Framework;

namespace MyWeatherApp1054.UnitTests
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void PipelinesTestWithPass()
        {
            Assert.True(true);
        }
        
        [Test]
        public void PipelinesTestWithFail()
        {
            Assert.True(false);
        }
    }
}