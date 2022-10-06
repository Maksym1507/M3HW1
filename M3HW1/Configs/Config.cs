using Autofac;
using M3HW1.Interfaces;
using M3HW1.Models;

namespace M3HW1.Configs
{
    public class Config
    {
        public Config()
        {
            Builder = new ContainerBuilder();
        }

        private ContainerBuilder Builder { get; }

        public IContainer RegisterTypes()
        {
            Builder.RegisterType<MyList<int>>().As<IMyList<int>>();
            Builder.RegisterType<Starter>();
            return Builder.Build();
        }
    }
}
