using System.Text.RegularExpressions;

namespace Chap9_Validation
{
    class TextValidation
    {

        public static class TestEmail
        {
            /// <summary>
            /// Regular expression, which is used to validate an E-Mail address.
            /// </summary>
            public const string MatchEmailPattern =
                      @"^(([\w-]+\.)+[\w-]+|([a-zA-Z]{1}|[\w-]{2,}))@"
               + @"((([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])\.([0-1]?
				[0-9]{1,2}|25[0-5]|2[0-4][0-9])\."
               + @"([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])\.([0-1]?
				[0-9]{1,2}|25[0-5]|2[0-4][0-9])){1}|"
               + @"([a-zA-Z0-9]+[\w-]+\.)+[a-zA-Z]{1}[a-zA-Z0-9-]{1,23})$";

           
            /// <summary>
            /// Checks whether the given Email-Parameter is a valid E-Mail address.
            /// </summary>
            /// <param name="email">Parameter-string that contains an E-Mail address.</param>
            /// <returns>True, when Parameter-string is not null and 
            /// contains a valid E-Mail address;
            /// otherwise false.</returns>
            public static bool IsEmail(string email)
            {
                if (email != null)
                    return Regex.IsMatch(email, MatchEmailPattern);
                else return false;
            }

           
        }

        public static class TestPhoneNumber
        {
            public const string MatchUSPhonePattern =
               @"\(?\d{3}\)?-? *\d{3}-? *-?\d{4}";

            public static bool IsUsPhoneNumber(string phoneNumber)
            {
                if (phoneNumber != null)
                    return Regex.IsMatch(phoneNumber, MatchUSPhonePattern);
                else
                    return false;
            }
        }

        public static class TestZipCode
        {
            public const string MatchZipCodePattern =
                @"^[0-9]{5}(?:-[0-9]{4})?$";

            public static bool IsZipCode(string zipCode)
            {
                  if (zipCode != null)
                    return Regex.IsMatch(zipCode, MatchZipCodePattern);
                else
                    return false;
            }
        }

    }
}
