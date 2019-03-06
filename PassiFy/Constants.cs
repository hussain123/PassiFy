namespace PassiFy
{
    public class Constants
    {
        private const string PasswordCharsLcase = "abcdefgijkmnopqrstwxyz";
        private const string PasswordCharsUcase = "ABCDEFGHJKLMNPQRSTWXYZ";
        private const string PasswordCharsNumeric = "23456789";
        private const string PasswordCharsSpecial = "*$-+?_&=!%{}/";

        public const string PossibleCharacters = PasswordCharsLcase + PasswordCharsUcase + PasswordCharsNumeric + PasswordCharsSpecial;
    }
}
