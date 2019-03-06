using NUnit.Framework;
using PassiFy;

namespace PassiFyTests
{
    [TestFixture]
    public class PasswordGeneratorTests
    {
        public PasswordGenerator PasswordGenerator;

        [SetUp]
        public void SetUp()
        {
            PasswordGenerator = new PasswordGenerator();
        }

        [Test]
        public void ShouldGetRandomValidCharacter()
        {
            var randomCharacter = PasswordGenerator.SelectCharacter();
            Assert.IsTrue(Constants.PossibleCharacters.Contains(randomCharacter));
        }

        [Test]
        public void ShouldGeneratePasswordOfSpecifiedLength()
        {
            const int length = 3;
            var password = PasswordGenerator.GeneratePassword(length);
            Assert.AreEqual(password.Length, length);
        }

    }
}
