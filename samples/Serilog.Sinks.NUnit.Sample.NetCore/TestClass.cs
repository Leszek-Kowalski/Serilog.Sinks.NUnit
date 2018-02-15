﻿using NUnit.Framework;

namespace Serilog.Sinks.NUnit.Sample.NetCore
{
    [TestFixture]
    public class TestClass
    {
        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            Log.Logger = new LoggerConfiguration()
                .WriteTo.NUnitOutput()
                .CreateLogger();
        }

        [Test]
        public void DotNetCoreSampleTest()
        {
            Log.Error("Error from .netCore sample project!");
        }
    }
}
