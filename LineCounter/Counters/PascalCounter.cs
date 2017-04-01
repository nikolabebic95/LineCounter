using System.Collections.Generic;

namespace ProjectUtilities.LineCounter.Counters
{
    public sealed class PascalCounter : Counter
    {
        public static Counter Singleton { get; } = new PascalCounter();

        public override string GetName()
        {
            return "pas";
        }

        public override string GetLongName()
        {
            return "Pascal Language Counter";
        }

        protected override ISet<string> GetExtensions()
        {
            return new HashSet<string>
            {
                ".pas"
            };
        }

        private PascalCounter()
        {
        }
    }
}
