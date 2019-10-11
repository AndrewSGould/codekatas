using System;
using NUnit.Framework;
using SharpKatas.Pages.Chop;

namespace KataTests
{
    public class ChopTests
    {
        private ChopModel Karate = new ChopModel();

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void IterativeChopSortedArrayDoesNotFindTarget_ReturnsMinus1()
        {
            Assert.That(Karate.IterativeChop(3, Array.Empty<int>()), Is.EqualTo(-1));
            Assert.That(Karate.IterativeChop(3, new int[] { 1 }), Is.EqualTo(-1));


            Assert.That(Karate.IterativeChop(0, new int[] { 1, 3, 5 }), Is.EqualTo(-1));
            Assert.That(Karate.IterativeChop(2, new int[] { 1, 3, 5 }), Is.EqualTo(-1));
            Assert.That(Karate.IterativeChop(4, new int[] { 1, 3, 5 }), Is.EqualTo(-1));
            Assert.That(Karate.IterativeChop(6, new int[] { 1, 3, 5 }), Is.EqualTo(-1));

            Assert.That(Karate.IterativeChop(0, new int[] { 1, 3, 5, 7 }), Is.EqualTo(-1));
            Assert.That(Karate.IterativeChop(2, new int[] { 1, 3, 5, 7 }), Is.EqualTo(-1));
            Assert.That(Karate.IterativeChop(4, new int[] { 1, 3, 5, 7 }), Is.EqualTo(-1));
            Assert.That(Karate.IterativeChop(6, new int[] { 1, 3, 5, 7 }), Is.EqualTo(-1));
            Assert.That(Karate.IterativeChop(8, new int[] { 1, 3, 5, 7 }), Is.EqualTo(-1));
        }

        [Test]
        public void IterativeChopSortedArrayFindsTarget_ReturnsIndex()
        {
            Assert.That(Karate.IterativeChop(1, new int[] { 1 }), Is.EqualTo(0));

            Assert.That(Karate.IterativeChop(1, new int[] { 1, 3, 5 }), Is.EqualTo(0));
            Assert.That(Karate.IterativeChop(3, new int[] { 1, 3, 5 }), Is.EqualTo(1));
            Assert.That(Karate.IterativeChop(5, new int[] { 1, 3, 5 }), Is.EqualTo(2));

            Assert.That(Karate.IterativeChop(1, new int[] { 1, 3, 5, 7 }), Is.EqualTo(0));
            Assert.That(Karate.IterativeChop(3, new int[] { 1, 3, 5, 7 }), Is.EqualTo(1));
            Assert.That(Karate.IterativeChop(5, new int[] { 1, 3, 5, 7 }), Is.EqualTo(2));
            Assert.That(Karate.IterativeChop(7, new int[] { 1, 3, 5, 7 }), Is.EqualTo(3));
        }
    }
}