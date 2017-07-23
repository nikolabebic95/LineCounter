using System;
using System.Diagnostics;
using System.IO;
using Plossum.CommandLine;
using ProjectUtilities.LineCounter.Counters;

namespace ProjectUtilities.LineCounter
{
    public class Program
    {
        public const int LineWidth = 78;

        public static void Main(string[] args)
        {
            var options = new Options();
            var parser = new CommandLineParser(options);
            parser.Parse();

            if (options.Debug)
            {
                Debugger.Launch();
            }

            Console.WriteLine(parser.UsageInfo.GetHeaderAsString(LineWidth));

            if (parser.HasErrors)
            {
                Console.WriteLine(parser.UsageInfo.GetOptionsAsString(LineWidth));
                Console.WriteLine(parser.UsageInfo.GetErrorsAsString(LineWidth));
                return;
            }

            if (options.Help || options.RootFolder == null)
            {
                Console.WriteLine(parser.UsageInfo.GetOptionsAsString(LineWidth));
                Console.WriteLine(CounterFactory.Usage());
                return;
            }
            
            var counter = CounterFactory.GetCounter(options.Language);

            if (counter == null)
            {
                Console.WriteLine("Language not supported");
                Console.WriteLine("Supported langugages:");
                Console.WriteLine();
                Console.WriteLine(CounterFactory.Usage());
                return;
            }

            if (!Directory.Exists(options.RootFolder))
            {
                Console.WriteLine("Directory does not exist");
            }

            var rootDir = new DirectoryInfo(options.RootFolder);
            
            var count = counter.Count(rootDir);
            var fileCount = counter.CountFiles(rootDir);

            Console.WriteLine();
            Console.WriteLine($"File count is {fileCount}");
            Console.WriteLine($"Line count is {count}");
        }
    }
}
