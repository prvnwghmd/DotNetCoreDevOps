using DotNetCoreDevOps.Controllers;
using System;
using Xunit;


namespace DotNetCoreDevOpsTest
{
    public class UnitTest1
    {
        ValuesController obj = new ValuesController();
        [Fact]
        public void checkById()
        {
            var result = obj.Get(1);
            Assert.Equal("value1", result.Value);





        }
    }
}
