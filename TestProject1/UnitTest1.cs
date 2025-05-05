using NUnit.Framework;

namespace TestProject1
{
    [TestFixture]
    public class SumOfTwoMinimalsTests
    {
        [Test]
        public void TestWithNegativeAndPositiveNumbers()
        {
            Assert.AreEqual(-10, Program.SumOfTwoMinimals(new int[] { 4, 0, 3, 19, 492, -10, 1 }));
        }

        [Test]
        public void TestWithAllPositiveNumbers()
        {
            Assert.AreEqual(3, Program.SumOfTwoMinimals(new int[] { 5, 1, 2, 8, 3 })); 
        }

        [Test]
        public void TestWithEmptyArray()
        {
            Assert.Throws<ArgumentException>(() => Program.SumOfTwoMinimals(new int[] { }));
        }

        [Test]
        public void TestWithOneElement()
        {
            Assert.Throws<ArgumentException>(() => Program.SumOfTwoMinimals(new int[] { 42 }));
        }

        [Test]
        public void TestWithTwoIdenticalElements()
        {
            Assert.AreEqual(4, Program.SumOfTwoMinimals(new int[] { 2, 2 }));
        }
    }
}