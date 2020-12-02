using System;
using System.Reflection;
using System.Threading.Tasks;
using System.Linq;

namespace AdventOfCode
{
    class Program
    {
        static void Main(string[] args) => new Program().MainAsync(args).GetAwaiter().GetResult();
        public async Task MainAsync(string[] args)
        {
            var handlers = from t in Assembly.GetExecutingAssembly().GetTypes()
                where t.IsClass && t.GetCustomAttribute<AdventTaskAttribute>() != null
                select t;

            foreach (var handler in handlers.Select(x => Activator.CreateInstance(x) as IDayHandler).ToArray())
            {
                var meta = handler.GetType().GetCustomAttribute<AdventTaskAttribute>();
                handler.Meta = meta;
                Console.WriteLine($"Loaded {meta.Name}\n{meta.Description}\n");
                handler.Start().GetAwaiter().GetResult();
            }
        }
    }
}
