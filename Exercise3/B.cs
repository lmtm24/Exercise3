using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise3
{
	public class B : A, IHello

	{
		public String changingText() {

			word1 = "This is from ";
			word2 = "child class";
			String text = word1 + word2;
			return text;
		}

		public void print()
		{
			Console.WriteLine("Hello Interface");
			
		}
	}
}
