using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace PasswordGenerator
{
    internal class User
    {
        public int inputPasswordLength;
        public bool includeSymbols;
        public bool includeNumbers;
        public bool includeLowercaseCharacters;
        public bool includeUppercaseCharacters;
        public bool savePassword;
        protected string answerSymbols;
        protected string answerNumbers;
        protected string answerLowercaseCharacters;
        protected string answerUppercaseCharacters;
        protected string answerSavePassword;

        public int InputPasswordLength()
        {
            bool error = true;
            while (error)
            {
                try
                {
                    bool wrongInputLength = true;
                    while (wrongInputLength)
                    {
                        Console.Write(Constants._QuestionPasswordLength);
                        inputPasswordLength = Convert.ToInt32(Console.ReadLine());
                        wrongInputLength = false;

                        if (inputPasswordLength < 8)
                        {
                            Console.WriteLine(Constants._ErrorMsgMinimumPasswordLength);

                            wrongInputLength = true;
                        }
                        else if (inputPasswordLength > 32)
                        {
                            Console.WriteLine(Constants._ErrorMsgMaximumPasswordLength);

                            wrongInputLength = true;
                        }
                    }

                    error = false;
                }
                catch (Exception)
                {
                    Console.WriteLine(Constants._ErrorMsgOnlyNumber);

                    error = true;
                }
            }

            return inputPasswordLength;
        }

        public bool IncludeSymbols()
        {
            includeSymbols = false;
            bool error = true;
            while (error)
            {
                try
                {
                    Console.Write(Constants._QuestionIncludeSymbols);
                    answerSymbols = Console.ReadLine().ToLower();

                    error = false;

                    if (answerSymbols != Constants._Yes && answerSymbols != Constants._No)
                    {
                        Console.WriteLine(Constants._QuestionYesOrNo);

                        error = true;
                    }
                    else if (answerSymbols == Constants._Yes)
                        return includeSymbols = true;
                    else if (answerSymbols == Constants._No)
                        return includeSymbols = false;
                }
                catch (Exception)
                {
                    Console.WriteLine(Constants._CorrectMistakes);

                    error = true;
                }
            }

            return includeSymbols;
        }

        public bool IncludeNumbers()
        {
            includeNumbers = false;
            bool error = true;
            while (error)
            {
                try
                {
                    Console.Write(Constants._QuestionIncludeNumbers);
                    answerNumbers = Console.ReadLine().ToLower();

                    error = false;

                    if (answerNumbers != Constants._Yes && answerNumbers != Constants._No)
                    {
                        Console.WriteLine(Constants._QuestionYesOrNo);

                        error = true;
                    }
                    else if (answerNumbers == Constants._Yes)
                        return includeNumbers = true;
                    else if (answerNumbers == Constants._No)
                        return includeNumbers = false;
                }
                catch (Exception)
                {
                    Console.WriteLine(Constants._CorrectMistakes);

                    error = true;
                }
            }

            return includeNumbers;
        }

        public bool IncludeLowercaseCharacters()
        {
            includeLowercaseCharacters = false;
            bool error = true;
            while (error)
            {
                try
                {
                    Console.Write(Constants._QuestionIncludeLowercaseCharacters);
                    answerLowercaseCharacters = Console.ReadLine().ToLower();

                    error = false;

                    if (answerLowercaseCharacters != Constants._Yes && answerLowercaseCharacters != Constants._No)
                    {
                        Console.WriteLine(Constants._QuestionYesOrNo);

                        error = true;
                    }
                    else if (answerLowercaseCharacters == Constants._Yes)
                        return includeLowercaseCharacters = true;
                    else if (answerLowercaseCharacters == Constants._No)
                        return includeLowercaseCharacters = false;
                }
                catch (Exception)
                {
                    Console.WriteLine(Constants._CorrectMistakes);

                    error = true;
                }
            }

            return includeLowercaseCharacters;
        }

        public bool IncludeUppercaseCharacters()
        {
            includeUppercaseCharacters = false;
            bool error = true;
            while (error)
            {
                try
                {
                    Console.Write(Constants._QuestionIncludeUppercaseCharacters);
                    answerUppercaseCharacters = Console.ReadLine().ToLower();

                    error = false;

                    if (answerUppercaseCharacters != Constants._Yes && answerUppercaseCharacters != Constants._No)
                    {
                        Console.WriteLine(Constants._QuestionYesOrNo);

                        error = true;
                    }
                    else if (answerUppercaseCharacters == Constants._Yes)
                        return includeUppercaseCharacters = true;
                    else if (answerUppercaseCharacters == Constants._No)
                        return includeUppercaseCharacters = false;
                }
                catch (Exception)
                {
                    Console.WriteLine(Constants._CorrectMistakes);

                    error = true;
                }
            }

            return includeUppercaseCharacters;
        }

        public bool SavePassword()
        {
            savePassword = false;
            bool error = true;
            while (error)
            {
                try
                {
                    Console.Write(Constants._QuestionSavePassword);
                    answerSavePassword = Console.ReadLine().ToLower();

                    error = false;

                    if (answerSavePassword != Constants._Yes && answerSavePassword != Constants._No)
                    {
                        Console.WriteLine(Constants._QuestionYesOrNo);

                        error = true;
                    }
                    else if (answerSavePassword == Constants._Yes)
                        return savePassword = true;
                    else if (answerSavePassword == Constants._No)
                        return savePassword = false;
                }
                catch (Exception)
                {
                    Console.WriteLine(Constants._CorrectMistakes);

                    error = true;
                }
            }

            return savePassword;
        }

        public void Generating()
        {
            string[] upperCaseCharacters = new string[] { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };

            Random rnd = new Random();
            var selectRandomUpperCase = upperCaseCharacters.Select(v => new { v, i = rnd.Next() }).OrderBy(x => x.i).Take(upperCaseCharacters.Length).Select(x => x.v).ToArray();

            string[] lowerCaseCharacters = new string[] { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" };
            var selectRandomLowerCase = lowerCaseCharacters.Select(v => new { v, i = rnd.Next() }).OrderBy(x => x.i).Take(lowerCaseCharacters.Length).Select(x => x.v).ToArray();

            string[] numbers = new string[] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };
            var selectRandomNumber = numbers.Select(v => new { v, i = rnd.Next() }).OrderBy(x => x.i).Take(numbers.Length).Select(x => x.v).ToArray();

            string word = string.Empty;
            string[] symbolCharacters = new string[] { " ", "!", "”", "#", "$", "%", "&", "’", "(", ")", "*", "+", "-", ".", "/", ":", ";", "<", ">", "?", "@", "[", "\\", "]", "^", "-", "`", "{", "}", "|", "~" };
            var selectRandomSymbol = symbolCharacters.Select(v => new { v, i = rnd.Next() }).OrderBy(x => x.i).Take(symbolCharacters.Length).Select(x => x.v).ToArray();

            List<string> joining = new List<string>();

            if (includeLowercaseCharacters == true && includeUppercaseCharacters == true && includeSymbols == true && includeNumbers == true)
            {
                joining.AddRange(selectRandomUpperCase);
                joining.AddRange(selectRandomLowerCase);
                joining.AddRange(selectRandomNumber);
                joining.AddRange(selectRandomSymbol);
            }
            else if (includeLowercaseCharacters == true && includeUppercaseCharacters == true && includeSymbols == true && includeNumbers == false)
            {
                joining.AddRange(selectRandomUpperCase);
                joining.AddRange(selectRandomLowerCase);
                joining.AddRange(selectRandomSymbol);
            }
            else if (includeLowercaseCharacters == true && includeUppercaseCharacters == true && includeNumbers == true && includeSymbols == false)
            {
                joining.AddRange(selectRandomUpperCase);
                joining.AddRange(selectRandomLowerCase);
                joining.AddRange(selectRandomNumber);
            }
            else if (includeLowercaseCharacters == false && includeUppercaseCharacters == true && includeNumbers == true && includeSymbols == true)
            {
                joining.AddRange(selectRandomUpperCase);
                joining.AddRange(selectRandomSymbol);
                joining.AddRange(selectRandomNumber);
            }
            else if (includeLowercaseCharacters == true && includeUppercaseCharacters == false && includeNumbers == true && includeSymbols == true)
            {
                joining.AddRange(selectRandomLowerCase);
                joining.AddRange(selectRandomSymbol);
                joining.AddRange(selectRandomNumber);
            }
            else if (includeUppercaseCharacters == false && includeLowercaseCharacters == false && includeNumbers == true && includeSymbols == true)
            {
                joining.AddRange(selectRandomSymbol);
                joining.AddRange(selectRandomNumber);
            }
            else if (includeUppercaseCharacters == true && includeLowercaseCharacters == false && includeNumbers == false && includeSymbols == false)
            {
                joining.AddRange(selectRandomUpperCase);
            }
            else if (includeLowercaseCharacters == true && includeUppercaseCharacters == false && includeNumbers == false && includeSymbols == false)
            {
                joining.AddRange(selectRandomLowerCase);
            }
            else if (includeSymbols == true && includeNumbers == false && includeLowercaseCharacters == false && includeUppercaseCharacters == false)
            {
                joining.AddRange(selectRandomSymbol);
            }
            else if (includeNumbers == true && includeSymbols == false && includeLowercaseCharacters == false && includeUppercaseCharacters == false)
            {
                joining.AddRange(selectRandomNumber);
            }
            else if (includeLowercaseCharacters == true && includeNumbers == true && includeSymbols == false && includeUppercaseCharacters == false)
            {
                joining.AddRange(selectRandomLowerCase);
                joining.AddRange(selectRandomNumber);
            }
            else if (includeLowercaseCharacters == true && includeSymbols == true && includeNumbers == false && includeUppercaseCharacters == false)
            {
                joining.AddRange(selectRandomLowerCase);
                joining.AddRange(selectRandomSymbol);
            }
            else if (includeUppercaseCharacters == true && includeNumbers == true && includeSymbols == false && includeLowercaseCharacters == false)
            {
                joining.AddRange(selectRandomUpperCase);
                joining.AddRange(selectRandomNumber);
            }
            else if (includeUppercaseCharacters == true && includeSymbols == true && includeNumbers == false && includeLowercaseCharacters == false)
            {
                joining.AddRange(selectRandomUpperCase);
                joining.AddRange(selectRandomSymbol);
            }
            else if (includeLowercaseCharacters == true && includeUppercaseCharacters == true && includeNumbers == false && includeSymbols == false)
            {
                joining.AddRange(selectRandomUpperCase);
                joining.AddRange(selectRandomLowerCase);
            }

            var randomizing = joining.OrderBy(x => rnd.Next()).ToList();
            var generatedPassword = string.Join("", randomizing);

            if (savePassword == true)
            {
                Console.WriteLine();

                FileStream file = new FileStream(Constants._SavingFileName, FileMode.Create);
                StreamWriter output = new StreamWriter(file);

                Console.WriteLine($"{Constants._MsgSavedPassword}: {generatedPassword.Substring(1, inputPasswordLength)}");
                output.WriteLine(generatedPassword.Substring(1, inputPasswordLength));
                output.Flush();

                output.Close();
                file.Close();
            }
            else
                Console.WriteLine(generatedPassword.Substring(1, inputPasswordLength));
        }
    }
}