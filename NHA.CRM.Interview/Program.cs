using System;

namespace NHA.CRM.Interview
{
	static class Program
	{
		static void Main(string[] args)
		{
            #region Test1
            //WorldClock
            //run the following, pick what the differences between option a and b 

            //WorldClockRunner.Run();
            #endregion

            #region Test2
            //ReadAndExplain
            //read the following method before running, what will it do?

            //CanYouTellMe.WhatThisDoes("What Does This Method do");
            #endregion

            #region Test3
            //Isogram
            //read instructions in the IsogramClass
            string stringToTest = "";

            Isogram.IsValid(stringToTest);
            #endregion


            Console.Read();
        }
    }
}
