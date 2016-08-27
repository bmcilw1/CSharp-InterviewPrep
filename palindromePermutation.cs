// Brian McIlwain
// Interview Prep
// Cracking the Coding Interview 1.4
// Palindrome Permutation: Given a string, write a function to check if it is a permutation of a palindrome. 
// A palindrome is a word or phrase that is the same forwards and backwards, 
// and it need not be limited to just dictionary words.

using System;
using System.Collections.Generic;

class testClass
{
    public static void Main()
    {
        Console.WriteLine("Enter a string to check for permutations of palindromes: ");
        string str = Console.ReadLine();
        PalindromePermutation pp = new PalindromePermutation();

        if (pp.isPalindromePermutation(str))
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
    private Dictionary<char, bool> isCharOccuranceCountOdd = new Dictionary<char, bool>();
    private int oddCharCount = 0;

    private void toggleOddCharCountFlag(char c)
    {
        if (isCharOccuranceCountOdd.ContainsKey(c) && isCharOccuranceCountOdd[c])
        {
            isCharOccuranceCountOdd[c] = false;
            oddCharCount--;
        }
        else
        {
            isCharOccuranceCountOdd[c] = true;
            oddCharCount++;
        }
    }

    public bool isPalindromePermutation(string s)
    {
        foreach(char c in s)
        {
            toggleOddCharCountFlag(c);
        }

        return (oddCharCount > 1) ? false : true;
    }
}
