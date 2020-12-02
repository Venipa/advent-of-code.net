using System;
using System.Collections.Generic;
using System.Text;

namespace AdventOfCode
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
    public class AdventTaskAttribute : Attribute
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public AdventTaskAttribute(string Name, string Description = "-")
        {
            this.Name = Name;
            this.Description = Description;
        }
    }
}
