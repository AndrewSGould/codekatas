using NUnit.Framework;
using SharpKatas.Pages.DataMunging;

namespace KataTests
{
    class DataMungingTests
    {
        private DataMungingModel Munge = new DataMungingModel();
            
        [Test]
        public void MungeReturnsLowestTempSpread()
        {
            var result = Munge.GetLowestTempSpread();
            Assert.That(result.Day, Is.EqualTo(14));
            Assert.That(result.TempSpread, Is.EqualTo(2));
        }

        [Test]
        public void MungeReturnsLowestScoreSpread()
        {
            var result = Munge.GetLowestScoreSpread();
            Assert.That(result.Team, Is.EqualTo("Leicester"));
            Assert.That(result.GoalSpread, Is.EqualTo(-34));
        }
    }
}
