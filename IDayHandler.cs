using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode
{
    public interface IDayHandler
    {
        public AdventTaskAttribute Meta { get; set; }
        Task Start();
    }
}
