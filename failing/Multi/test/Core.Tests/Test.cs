using System;
using Xunit;
using MyAwesomeLibrary.Core;

namespace MyAwesomeLibrary.Core.Tests
{
    public class Tests
    {
        [Fact]
        public void MessageTest()
        {
            Assert.Equal("Live long and prosper, Phillip", LibCore.GetMessage("Phillip"));
        }
    }
}
