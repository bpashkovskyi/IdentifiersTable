using System.ComponentModel;

using IdentifiersTable.Implementations;

using Xunit;

namespace IdentifiersTableTests
{
    public class SimpleListTests
    {
        [Fact]
        public void SimpleListShouldReturnCorrectValues()
        {
            var simpleList = new SimpleList();

            simpleList.Add("key1", "value1");
            simpleList.Add("key2", "value2");
            simpleList.Add("key3", "value3");
            simpleList.Add("key4", "value4");
            simpleList.Add("key5", "value5");
            
            Assert.Equal("value1", simpleList.Get("key1"));
            Assert.Equal("value2", simpleList.Get("key2"));
            Assert.Equal("value3", simpleList.Get("key3"));
            Assert.Equal("value4", simpleList.Get("key4"));
            Assert.Equal("value5", simpleList.Get("key5"));
        }
    }
}