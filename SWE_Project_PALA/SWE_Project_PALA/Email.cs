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
                        topLevelDomain.Remove(0, 1);
                    }

                    if (topLevelDomain.Length >= 2 && topLevelDomain.Length <= 4 &&
                        Regex.IsMatch(topLevelDomain, @"^[a-zA-Z]+$"))
                    {
                        if (emailAddress.Split('@')[0].Length >= 1)
                        {
                            if (Regex.IsMatch(topLevelDomain, @"^[a-zA-Z0-9!#%&'*+-{=?^_´{|}~]+$"))
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

