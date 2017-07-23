using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ProjectUtilities.LineCounter.Counters
{
    /// <summary>
    ///   Abstract class representing all classes that perform line counting
    /// </summary>
    public abstract class Counter
    {
        /// <summary>
        ///   Count the lines in a project
        /// </summary>
        /// <param name="root">
        ///   Root directory of a project
        /// </param>
        /// <returns>
        ///   Number of lines in the project
        /// </returns>
        public int Count(DirectoryInfo root)
        {
            return 
                // Recursive counting in all subdirectories
                root.GetDirectories().Sum(Count) + 
                // Plus actual counting in all files where the extension matches
                root.GetFiles().Where(file => GetExtensions().Contains(file.Extension)).Sum(CountLines);
        }

        /// <summary>
        ///   Count the files in a project
        /// </summary>
        /// <param name="root">
        ///   Root directory of a project
        /// </param>
        /// <returns>
        ///   Number of files in the project
        /// </returns>
        public int CountFiles(DirectoryInfo root)
        {
            return
                // Recursive counting in all subdirectories
                root.GetDirectories().Sum(CountFiles) +
                // Plus actual counting of all files where the extension matches
                root.GetFiles().Count(file => GetExtensions().Contains(file.Extension));
        }

        /// <summary>
        ///   Gets the name of the counter
        /// </summary>
        /// <returns>
        ///   Name of the counter
        /// </returns>
        public abstract string GetName();

        /// <summary>
        ///   Gets the long name of the counter
        /// </summary>
        /// <returns>
        ///   Long name of the counter
        /// </returns>
        public abstract string GetLongName();

        /// <summary>
        ///   Generates the manual for using the counter
        /// </summary>
        /// <returns>
        ///   Usage information
        /// </returns>
        public string Usage()
        {            
            return string.Concat(
                GetLongName(),
                Environment.NewLine,
                "Acronym for the -l option: ",
                GetName(),
                Environment.NewLine,
                "Supported extensions: ",
                string.Join(", ", GetExtensions()),
                Environment.NewLine);
        }

        /// <summary>
        ///   Gets the extensions set for the counters programming language
        /// </summary>
        /// <returns>
        ///   Set of file extensions
        /// </returns>
        protected abstract ISet<string> GetExtensions();

        /// <summary>
        ///   Counts the lines in a file, and outputs the number to the console
        /// </summary>
        /// <param name="file">
        ///   Source file
        /// </param>
        /// <returns>
        ///   Number of lines in a file
        /// </returns>
        private static int CountLines(FileInfo file)
        {
            var read = file.OpenText();
            var ret = 0;
            while (read.ReadLine() != null)
            {
                ret++;
            }

            Console.WriteLine($"File: {file.Name,-30} : {ret} lines");
            read.Close();
            
            return ret;
        }
    }
}
