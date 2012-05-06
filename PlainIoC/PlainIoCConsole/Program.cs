using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PlainIoC;
using System.Reflection;

namespace PlainIoCConsole
{
    class Program
    {
        private static PIoCContainer container;

        static void Main(string[] args)
        {
            ConfigureIoC();
            TestDataProviderManager();
        }

        static void ConfigureIoC()
        {
            container = new PIoCContainer();
            container.RecordAssembly(Assembly.GetEntryAssembly());
            container.Prepare();
        }

        static void TestDataProviderManager()
        {
            DataProviderManager manager = new DataProviderManager(container.Return<DataProvider>());
            Console.WriteLine(manager.IsDataAvailable() == true);
            Console.ReadLine();
        }
    }
}
