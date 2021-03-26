using NUnit.Framework;
using CalculatorWpfApp;
using static CalculatorWpfApp.Algebra;

namespace CalculatorUTest
{
    public class Tests
    {
        [SetUp]
        public void Setup(){ }

        [Test]
        public void TestAdd()
        {
            Assert.AreEqual(15, DOD(9, 6), "METHOD COUNTS BADLY");
        }

        [Test]
        public void TestSub()
        {
            Assert.AreEqual(3, VID(9, 6), "METHOD COUNTS BADLY");
        }

        [Test]
        public void TestMul()
        {
            Assert.AreEqual(54, MN(9, 6), "METHOD COUNTS BADLY");
        }

        [Test]
        public void TestDiv()
        {
            Assert.AreEqual(1.5, DIL(9, 6), "METHOD COUNTS BADLY");
        }
    }
}