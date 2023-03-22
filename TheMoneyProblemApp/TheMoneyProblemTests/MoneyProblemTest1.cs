//using Microsoft.VisualStudio.TestPlatform.TestHost;
using TheMoneyProblemApp;
namespace TheMoneyProblemTests
{
    public class Tests
    {
        // Valid Value Tests
        [TestCase("£5.47","£2:2 £1:1 £0.50:0 £0.20:2 £0.10:0 £0.05:1 £0.02:1 £0.01:0")]
        [TestCase("£10.47", "£2:5 £1:0 £0.50:0 £0.20:2 £0.10:0 £0.05:1 £0.02:1 £0.01:0")]

        public void GivenACertainMoneyValueTheMethodReturnsExpectedDenominations(string totalMoney, string denominations)
        {
            Assert.That(Program.ReturnDenominations(totalMoney), Is.EqualTo(denominations));
        }

        // Invalid Tests

        [Test]
        public void GivenANegativeValue_ThrowOutOfRangeException()
        {
            Assert.That(() => Program.ReturnDenominations("-£78721.123"), Throws.TypeOf<ArgumentOutOfRangeException>());
        }

        [Test]
        public void GivenANegativeValueAndChar_ArgumentException()
        {
            Assert.That(() => Program.ReturnDenominations("-£78awsae721.123"), Throws.TypeOf<FormatException>());
        }

    }
}