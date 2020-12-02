using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;

namespace AdventOfCode
{
    public static class AdventOfCodeAssembly
    {
        /// <summary>
        /// Represents the assembly's name.
        /// </summary>
        public static string Name = Assembly.GetEntryAssembly().GetName().Name;
        public static string Contact = "admin@venipa.net";
        /// <summary>
        /// Represents the assembly's version.
        /// </summary>
        public static string Version = Assembly.GetEntryAssembly().GetName().Version.ToString(3);
        public static string GetPath(params string[] args)
        {
            return Path.Combine(new string[] { AppDomain.CurrentDomain.BaseDirectory }.Concat(args).ToArray());
        }
    }
}
