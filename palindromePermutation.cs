// Brian McIlwain
// Interview Prep
// Cracking the Coding Interview 1.4
// Palindrome Permutation: Given a string, write a function to check if it is a permutation of a palindrome. 
// A palindrome is a word or phrase that is the same forwards and backwards, 
// and it need not be limited to just dictionary words.

using System;
using System.Collections.Generic;

namespace PalindromePermutationNS
{
    class TestClass
    {
        public static void Main()
        {
            Console.WriteLine("Enter a string to check for permutations of palindromes: ");
            string str = Console.ReadLine();
            PalindromePermutation pp = new PalindromePermutation();

            if (pp.IsPalindromePermutation(str))
            {
                Console.WriteLine("Yea! You got yourself a permutation of a palindrome!");
            }
            else
            {
                Console.WriteLine("Nope, no permutations of palindromes here :(");
            }
        }
    }

    class PalindromePermutation
    {
        private Dictionary<char, bool> IsCharOccuranceCountOdd = new Dictionary<char, bool>();
        private int OddCharCount = 0;

        private void ToggleOddCharCountFlag(char c)
        {
            if (IsCharOccuranceCountOdd.ContainsKey(c) && IsCharOccuranceCountOdd[c])
            {
                IsCharOccuranceCountOdd[c] = false;
                OddCharCount--;
            }
            else
            {
                IsCharOccuranceCountOdd[c] = true;
                OddCharCount++;
            }
        }

        public bool IsPalindromePermutation(string s)
        {
            foreach(char c in s)
            {
                ToggleOddCharCountFlag(c);
            }

            return (OddCharCount > 1) ? false : true;
        }
    }
}
