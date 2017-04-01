using Plossum.CommandLine;

namespace ProjectUtilities.LineCounter
{
    [CommandLineManager(
        ApplicationName = "Line Counter", 
        Copyright = "Copyright (c) 2017 Nikola Bebic", 
        Description = "Application used for counting the lines in software projects")]
    public class Options
    {
        [CommandLineOption(
             Name = "root",
             Aliases = "r",
             Description = "Specifies the root folder of a project")]
        public string RootFolder { get; set; }

        [CommandLineOption(
             Name = "debug",
             Aliases = "d",
             Description = "Launches debugger")]
        public bool Debug { get; set; } = false;

        [CommandLineOption(
             Name = "help",
             Aliases = "h",
             Description = "Displays help text")]
        public bool Help { get; set; } = false;

        [CommandLineOption(
             Name = "lang",
             Aliases = "l",
             Description = "Specifies the programming language (Default: C#)")]
        public string Language { get; set; } = "cs";
    }
}
