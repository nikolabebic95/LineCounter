using System.Collections.Generic;

namespace ProjectUtilities.LineCounter.Counters
{
    public class MicroRiscCounter : Counter
    {
        public static Counter Singleton { get; } = new MicroRiscCounter();

        public override string GetName()
        {
            return "ss";
        }

        public override string GetLongName()
        {
            return "MicroRISC Language Counter";
        }

        protected override ISet<string> GetExtensions()
        {
            return new HashSet<string>
            {
                ".ss"
            };
        }

        private MicroRiscCounter()
        {
        }
    }
}
