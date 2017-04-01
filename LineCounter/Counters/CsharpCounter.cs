using System.Collections.Generic;

namespace ProjectUtilities.LineCounter.Counters
{
    public sealed class CsharpCounter : Counter
    {
        public static Counter Singleton { get; } = new CsharpCounter();

        public override string GetName()
        {
            return "cs";
        }

        public override string GetLongName()
        {
            return "C# Language Counter";
        }

        protected override ISet<string> GetExtensions()
        {
            return new HashSet<string>
            {
                ".cs"
            };
        }

        private CsharpCounter()
        {
        }
    }
}
