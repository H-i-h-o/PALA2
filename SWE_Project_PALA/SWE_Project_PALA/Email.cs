using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SWE_Project_PALA
{
    public class Email
    {
        public string EmailAddress { private set; get; }

        public Email(string emailAddress)
        {
            EmailAddress = emailAddress;
        }

        public string Print()
        {
            return EmailAddress;    
        }

        public void ChangeEmail(string emailAddress)
        {
            EmailAddress = emailAddress;
        }

        public static bool CheckEmailInput(string emailAddress)
        {

            int count = emailAddress.Count(f => f == '@');

            if (count == 1)
            {
                if (emailAddress.Split('@')[1].Contains('.'))
                {
                    string topLevelDomain = emailAddress.Substring(emailAddress.LastIndexOf('.'));

                    if (topLevelDomain.Length > 1)
                    {
                        topLevelDomain = topLevelDomain.TrimStart('.');
                    }

                    if (topLevelDomain.Length >= 2 && topLevelDomain.Length <= 4)
                    {
                        if (emailAddress.IndexOf("@") >= 1)
                        {
                            string[] LetterArray = new[]
                            {
                                "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s",
                                "t", "u", "v", "w", "x", "y", "z"
                            };
                            string[] NumbersArray = new[] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };
                            string[] SpecialCharArray = new[] { "!", "#", "%", "&", "'", "*", "+", "-", "/", "=", "^", "_", "´", "{", "|", "}", "~", ".", "@" };
                            string emailAddressTest = String.Empty;
                            emailAddressTest = emailAddress;

                            foreach (var Char in LetterArray)
                            {
                                emailAddressTest = emailAddressTest.Replace(Char, "");
                            }
                            foreach (var Char in NumbersArray)
                            {
                                emailAddressTest = emailAddressTest.Replace(Char, "");
                            }
                            foreach (var Char in SpecialCharArray)
                            {
                                emailAddressTest = emailAddressTest.Replace(Char, "");
                            }

                            if (emailAddressTest.Length == 0)
                            {
                                return true;
                            }
                            return false;
                        }
                        return false;
                    }
                    return false;
                }
                return false;
            }
            else
            {
                return false;
            }
        }
    }
}

