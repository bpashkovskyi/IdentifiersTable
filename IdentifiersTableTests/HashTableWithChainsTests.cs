using IdentifiersTable.Implementations;

using Xunit;

namespace IdentifiersTableTests
{
    public class HashTableWithChainsTests
    {
        [Fact]
        public void HashTableWithChainShouldReturnCorrectValues()
        {
            var hashTableWithRehashing = new HashTableWithChains();

            hashTableWithRehashing.Add("key1", "value1");
            hashTableWithRehashing.Add("1key", "value2");
            hashTableWithRehashing.Add("ey1k", "value3");
            hashTableWithRehashing.Add("key4", "value4");
            hashTableWithRehashing.Add("key5", "value5");

            Assert.Equal("value1", hashTableWithRehashing.Get("key1"));
            Assert.Equal("value2", hashTableWithRehashing.Get("1key"));
            Assert.Equal("value3", hashTableWithRehashing.Get("ey1k"));
            Assert.Equal("value4", hashTableWithRehashing.Get("key4"));
            Assert.Equal("value5", hashTableWithRehashing.Get("key5"));
        }
    }
}