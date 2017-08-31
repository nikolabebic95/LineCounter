using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectUtilities.LineCounter.Counters
{
    public static class CounterFactory
    {
        private static readonly Dictionary<string, Counter> Counters = new Dictionary<string, Counter>
        {
            { CppCounter.Singleton.GetName(), CppCounter.Singleton },
            { ClanguageCounter.Singleton.GetName(), ClanguageCounter.Singleton },
            { JavaCounter.Singleton.GetName(), JavaCounter.Singleton },
            { CsharpCounter.Singleton.GetName(), CsharpCounter.Singleton },
            { PascalCounter.Singleton.GetName(), PascalCounter.Singleton },
            { TypeScriptCounter.Singleton.GetName(), TypeScriptCounter.Singleton },
            { KdpCounter.Singleton.GetName(), KdpCounter.Singleton },
            { MicroRiscCounter.Singleton.GetName(), KdpCounter.Singleton }
        };

        public static Counter GetCounter(string name)
        {
            return Counters.ContainsKey(name) ? Counters[name] : null;
        }

        public static string Usage()
        {
            var ret = new StringBuilder();
            foreach (var counter in Counters.Values)
            {
                ret.Append(counter.Usage()).Append(Environment.NewLine);
            }

            return ret.ToString();
        }        
    }
}
