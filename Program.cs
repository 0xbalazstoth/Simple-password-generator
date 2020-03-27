using System;

namespace PasswordGenerator
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            User usr = new User();
            usr.InputPasswordLength();
            usr.IncludeSymbols();
            usr.IncludeNumbers();
            usr.IncludeLowercaseCharacters();
            usr.IncludeUppercaseCharacters();
            usr.SavePassword();
            usr.Generating();

            Console.ReadKey();
        }
    }
}