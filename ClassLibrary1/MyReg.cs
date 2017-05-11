using System.Diagnostics;
using StructureMap;

namespace ClassLibrary1
{
    public interface IBar
    {
        int Calc();
    }

    public class Bar : IBar
    {
        public int Calc()
        {
            return 5;
        }
    }

    public interface IFoo
    {
    }

    public class Foo : IFoo
    {
        public IBar Bar { get; }

        public Foo(IBar bar)
        {
            Bar = bar;
        }
    }

    public class MyReg : Registry
    {
        public MyReg()
        {
            //For<IFoo>().Use<Foo>().Singleton();
            //For<IBar>().Use<Bar>().Singleton();

            Scan(cfg =>
            {
                cfg.Description = "MyReg!!!";
                cfg.TheCallingAssembly();
                cfg.WithDefaultConventions();
            });
        }
    }
}