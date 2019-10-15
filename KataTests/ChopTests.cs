using System;
using NUnit.Framework;
using SharpKatas.Pages.Chop;

namespace KataTests
{
    public class ChopTests
    {
        private ChopModel Karate = new ChopModel();
        private readonly int[] OneLengthArray = new int[] { 1 };
        private readonly int[] ThreeLengthArray = new int[] { 1, 3, 5 };
        private readonly int[] FiveLengthArray = new int[] { 1, 3, 5, 7 };

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void IterativeChopSortedArrayDoesNotFindTarget_ReturnsMinus1()
        {
            Assert.That(Karate.IterativeChop(3, Array.Empty<int>()), Is.EqualTo(-1));
            Assert.That(Karate.IterativeChop(3, OneLengthArray), Is.EqualTo(-1));

            Assert.That(Karate.IterativeChop(0, ThreeLengthArray), Is.EqualTo(-1));
            Assert.That(Karate.IterativeChop(2, ThreeLengthArray), Is.EqualTo(-1));
            Assert.That(Karate.IterativeChop(4, ThreeLengthArray), Is.EqualTo(-1));
            Assert.That(Karate.IterativeChop(6, ThreeLengthArray), Is.EqualTo(-1));

            Assert.That(Karate.IterativeChop(0, FiveLengthArray), Is.EqualTo(-1));
            Assert.That(Karate.IterativeChop(2, FiveLengthArray), Is.EqualTo(-1));
            Assert.That(Karate.IterativeChop(4, FiveLengthArray), Is.EqualTo(-1));
            Assert.That(Karate.IterativeChop(6, FiveLengthArray), Is.EqualTo(-1));
            Assert.That(Karate.IterativeChop(8, FiveLengthArray), Is.EqualTo(-1));
        }

        [Test]
        public void IterativeChopSortedArrayFindsTarget_ReturnsIndex()
        {
            Assert.That(Karate.IterativeChop(1, OneLengthArray), Is.EqualTo(0));

            Assert.That(Karate.IterativeChop(1, ThreeLengthArray), Is.EqualTo(0));
            Assert.That(Karate.IterativeChop(3, ThreeLengthArray), Is.EqualTo(1));
            Assert.That(Karate.IterativeChop(5, ThreeLengthArray), Is.EqualTo(2));

            Assert.That(Karate.IterativeChop(1, FiveLengthArray), Is.EqualTo(0));
            Assert.That(Karate.IterativeChop(3, FiveLengthArray), Is.EqualTo(1));
            Assert.That(Karate.IterativeChop(5, FiveLengthArray), Is.EqualTo(2));
            Assert.That(Karate.IterativeChop(7, FiveLengthArray), Is.EqualTo(3));
        }
    }
}