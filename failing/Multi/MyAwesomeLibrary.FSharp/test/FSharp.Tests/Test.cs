using System;
using Xunit;
using MyAwesomeLibrary.FSharp;

namespace MyAwesomeLibrary.FSharp.Tests
{
    public class Tests
    {
        [Fact]
        public void MessageTest()
        {
            Assert.Equal("Live long and prosper, Phillip", Lib.GetMessage("Phillip"));
        }
    }
}
