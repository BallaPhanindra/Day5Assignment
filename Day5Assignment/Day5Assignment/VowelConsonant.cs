using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5Assignment
{
	public class VowelConsonant
	{
		public void VowelOrConsonant(char x)
		{
			if (x == 'a' || x == 'e' || x == 'i' ||
							x == 'o' || x == 'u')
				Console.WriteLine("Vowel");
			else
				Console.WriteLine("Consonant");
		}
	}

}
