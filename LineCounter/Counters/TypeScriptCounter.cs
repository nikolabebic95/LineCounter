using System.Collections.Generic;

namespace ProjectUtilities.LineCounter.Counters
{
    public sealed class TypeScriptCounter : Counter
    {
        public static Counter Singleton { get; } = new TypeScriptCounter();

        public override string GetName()
        {
            return "ts";
        }

        public override string GetLongName()
        {
            return "TypeScript Language Counter";
        }

        protected override ISet<string> GetExtensions()
        {
            return new HashSet<string>
            {
                ".ts"
            };
        }

        private TypeScriptCounter()
        {
        }
    }
}
