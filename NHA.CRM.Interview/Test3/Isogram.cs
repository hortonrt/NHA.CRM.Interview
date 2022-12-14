using System;
using System.Linq;

namespace NHA.CRM.Interview
{
    public static class Isogram
    {
        #region Instructions
        /*
         * Write a function to tell me if a word is an isogram
         * An isogram is a word that has no repeating letters, consecutive or non-consecutive.
         * Implement a function that determines whether a string that contains only letters is an isogram. 
         * 
         * Rules
         * 1) Letters Only, throw ArgumentException
         * 2) No Nulls, throw ArgumentNullException
         * 3) Assume the empty string is an isogram
         * 4) Ignore letter case
         * 5) This exercise is complete when all tests pass
         */
        #endregion

        public static bool IsValid(string WordToTest)
        {
            if (WordToTest == null) throw new ArgumentNullException("WordToTest", "Value is null");
            if (!WordToTest.All(Char.IsLetter)) throw new ArgumentException("Must be letters only", "WordToTest");
            if (WordToTest.ToLower().Distinct().Count() == WordToTest.Length) return true;
            return false;
        }
    }
}
