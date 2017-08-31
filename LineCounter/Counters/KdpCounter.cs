using System.Collections.Generic;

namespace ProjectUtilities.LineCounter.Counters
{
    public class KdpCounter : Counter
    {
        public static Counter Singleton { get; } = new KdpCounter();

        public override string GetName()
        {
            return "kdp";
        }

        public override string GetLongName()
        {
            return "KDP Language Counter";
        }

        protected override ISet<string> GetExtensions()
        {
            return new HashSet<string>
            {
                ".kdp"
            };
        }

        private KdpCounter()
        {
        }
    }
}
