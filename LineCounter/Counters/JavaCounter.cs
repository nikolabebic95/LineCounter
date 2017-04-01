using System.Collections.Generic;

namespace ProjectUtilities.LineCounter.Counters
{
    public sealed class JavaCounter : Counter
    {
        public static Counter Singleton { get; } = new JavaCounter();

        public override string GetName()
        {
            return "java";
        }

        public override string GetLongName()
        {
            return "Java Language Counter";
        }

        protected override ISet<string> GetExtensions()
        {
            return new HashSet<string>
            {
                ".java"
            };
        }

        private JavaCounter()
        {
        }
    }
}
