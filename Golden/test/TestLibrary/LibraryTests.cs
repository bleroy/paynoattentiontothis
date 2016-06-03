using Xunit;
using Library;

namespace TestLibrary
{
    public class LibraryTests
    {
        [Fact]
        public void ThingGetsObjectValFromNumber()
        {
            Assert.Equal(42, new Thing().Get(42));
        }
    }
}
