using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace NHA.CRM.Interview.Tests
{
    [TestClass()]
    public class IsogramTests
    {
        [TestMethod()]
        public void IsImplemented()
        {
            try
            {
                Isogram.IsValid("");
            }
            catch(NotImplementedException ex)
            {
                Assert.Fail(ex.Message);
            }            
        }

        [TestMethod()]
        public void IsIsogram()
        {
            List<string> isograms = new List<string>
            {
               "regulations",
                "SwitZerLand",
                "PERSONALITY",
                "documentary",
                "copyrighted",
                ""
            };

            bool allTrue = true;
            isograms.ForEach(word =>
            {
                if (!Isogram.IsValid(word))
                {
                    allTrue = false;                    
                }
            });
            Assert.IsTrue(allTrue);
        }

        [TestMethod()]
        public void IsNotIsogram()
        {
            List<string> notIsograms = new List<string>
            {
                "hotdog",
                "hamBurgeR",
                "headphones",
            };
            bool allFalse = true;
            notIsograms.ForEach(word =>
            {
                if (Isogram.IsValid(word))
                {
                    allFalse = false;
                }
            });
            Assert.IsTrue(allFalse);
        }


        [TestMethod()]
        [ExpectedException(typeof(ArgumentNullException))]
        public void NullCheck()
        {
            Isogram.IsValid(null);
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]
        public void LetterOnlyCheck()
        {
            Isogram.IsValid("This Is Not and Isogram");
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]
        public void NoNumbers()
        {
            Isogram.IsValid("2Times");
        }

    }
}