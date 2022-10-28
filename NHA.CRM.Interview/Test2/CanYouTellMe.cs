using System;
using System.Collections.Generic;

namespace NHA.CRM.Interview
{
	internal static class CanYouTellMe
	{
		internal static void WhatThisDoes(string inputString)
		{
			Dictionary<char, int> dictionary = new Dictionary<char, int>();

			foreach (char character in inputString) {
				if (character != ' ') {
					if (!dictionary.ContainsKey(character)) {
						dictionary.Add(character, 1);
					} else {
						dictionary[character]++;
					}
				}
			}

			foreach (KeyValuePair<char, int> character in dictionary) {
				Console.WriteLine("{0} - {1}", character.Key, character.Value);
			}
		}
	}
}
