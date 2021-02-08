using System;

namespace Csharp_Palindrome_Maggie
{
    class Program
    {
        static void Main(string[] args)
        {
            string strOne = "racecar";
            string strTwo = "Solos";
            string strThree = "Mygym";
            string strFour = "I ate an apple";
            string strFive = "Lorem Ipsum";

            PrintString(strOne);
            PrintString(strTwo);
            PrintString(strThree);            
            PrintString(strFour);
            PrintString(strFive);

        }

        static string verifyString(string testString)
        {
            string normalize = testString.ToLower();                       
            return normalize;
        }

        static string reverseString(string testString)
        {
            string verifiedString = verifyString(testString);
            char[] stringChars = verifiedString.ToCharArray();
            Array.Reverse(stringChars);
            return new string(stringChars);
        }

        static bool isPalindrome(string testString)
        {
            verifyString(testString);
            bool PalindromeString = false;
            string stringTest = reverseString(testString);

            if (testString == stringTest)
                PalindromeString = true;

            return PalindromeString;
        }

        static void PrintString(string testString)
        {
            string verifiedString = verifyString(testString);
            bool verifyPalindrome = isPalindrome(verifiedString);
            if (verifiedString.Contains(" "))
            {
                    Console.WriteLine("The string \"{0}\" contains spaces, please remove the spaces to check if it is a Palindrome.", testString);                
            } else if (verifyPalindrome == true)
            {
                Console.WriteLine("\"{0}\" is a Palindrome!", verifiedString);
            }
            else
            {
                Console.WriteLine("\"{0}\" is not a Palindrome!", verifiedString);
            }

        }


        static char[] duplicateCharacters(string testString)
        {

        }
    }
}
