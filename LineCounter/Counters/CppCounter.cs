using System;
using System.Collections.Generic;

namespace ProjectUtilities.LineCounter.Counters
{
    public sealed class CppCounter : Counter
    {
        public static Counter Singleton { get; } = new CppCounter();

        public override string GetName()
        {
            return "cpp";
        }

        public override string GetLongName()
        {
            return "C++ Language Counter";
        }

        protected override ISet<string> GetExtensions()
        {
            return new HashSet<string>
            {
                ".C", ".cc", ".cpp", ".CPP", ".c++", ".cp", ".cxx",
                ".H", ".hh", ".hpp", ".HPP", ".hxx", ".hp", ".hxx", ".h"
            };
        }

        private CppCounter()
        {
        }
    }
}
