using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PlainIoC.Tests
{
    public class DataProviderManager
    {
        private IDateProvider provider;

        public DataProviderManager(IDateProvider provider)
        {
            this.provider = provider;
        }

        public bool IsDataAvailable()
        {
            return provider.ProvideData() != null;
        }
    }
}
