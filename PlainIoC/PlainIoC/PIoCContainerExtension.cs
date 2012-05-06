using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PlainIoC
{
    public static class PIoCContainerExtension
    {
        public static void Record<T>(this PIoCContainer container, Func<T> f)
        {

        }
    }
}
