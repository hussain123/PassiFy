using System;

namespace PassiFy
{
    public class PasswordGenerator
    {
        private readonly Random _random = new Random();
        public string GeneratePassword(int length)
        {
            var password = "";
            for (var i = 0; i < length; i++)
            {
                password += SelectCharacter();
            }

            return password;
        }

        public string SelectCharacter()
        {
            return Constants.PossibleCharacters[_random.Next(0, Constants.PossibleCharacters.Length)].ToString();
        }
    }
}
