using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PlainIoC.Tests
{
    public class DataProvider : IDateProvider
    {
        public string ProvideData()
        {
            return "Test Data";
        }
    }
}
