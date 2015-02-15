using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using StupidSharpTricks.PropertyAbuse;

namespace StupidSharpTricks
{
	class Program
	{
		static void Main(string[] args)
		{
			PMessage pm = PMessage.New["test1", 32]["test2", 24].IncrementAll;

			breakpt();
		}


		static void breakpt()
		{
			// don't compile away
			bool blah = false;
			blah = !blah;
		}
	}
}
