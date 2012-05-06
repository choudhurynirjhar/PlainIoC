using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;
using PlainIoC;
using System.Reflection;

namespace PlainIoC.Tests
{
    public class PIoCTest
    {
        private PIoCContainer container;

        public PIoCTest()
        {
            container = new PIoCContainer();
            container.RecordAssembly(Assembly.GetEntryAssembly());
            container.Prepare();
        }

        [Fact]
        public void TestDataProviderManager()
        {
            DataProviderManager manager = new DataProviderManager(container.Return<IDateProvider>());
            Assert.Equal(true, manager.IsDataAvailable());
        }

    }
}
