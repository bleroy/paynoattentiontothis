using System;
using Xunit;
using MyAwesomeLibrary.CSharp;

namespace MyAwesomeLibrary.CSharp.Tests
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
