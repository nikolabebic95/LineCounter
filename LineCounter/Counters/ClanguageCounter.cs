using System.Collections.Generic;

namespace ProjectUtilities.LineCounter.Counters
{
    public sealed class ClanguageCounter : Counter
    {
        public static Counter Singleton { get; } = new ClanguageCounter();

        public override string GetName()
        {
            return "c";
        }

        public override string GetLongName()
        {
            return "C Language Counter";
        }
        
        protected override ISet<string> GetExtensions()
        {
            return new HashSet<string>
            {
                ".c",
                ".h"
            };
        }

        private ClanguageCounter()
        {
        }
    }
}
