using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StupidSharpTricks.PropertyAbuse
{
	public class PMessage
	{
		// enforce more "concise" syntax
		private PMessage() { }
		public static PMessage New { get { return new PMessage(); } }

		// data structures
		public Dictionary<string, float> floats = new Dictionary<string, float>();

		public PMessage this[string key, float value]
		{
			get
			{
				floats.Add(key, value);
				return this;
			}
		}

		// fun fact, this is of course triggered by mousing over the object in the IDE... so you can modify runtime state from within a breakpoint! @.@
		public PMessage IncrementAll
		{
			get
			{
				List<string> keys = new List<string>();
				foreach (KeyValuePair<string, float> kvp in floats) keys.Add(kvp.Key);
				foreach (string k in keys) floats[k]++;
				return this;
			}
		}
	}
}
