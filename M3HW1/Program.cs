using Autofac;
using M3HW1.Configs;

namespace M3HW1
{
    internal class Program
    {
        private static void Main()
        {
            var config = new Config();
            var container = config.RegisterTypes();
            var starter = container.Resolve<Starter>();
            starter.Run();
        }
    }
}