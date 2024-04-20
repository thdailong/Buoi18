using Xunit;
using CustomListConsole;

namespace CustomListConsole.Tests
{
    public class CustomList_Test1
    {
        [Fact]
        public void TestAdd()
        {
            CustomList list = new CustomList();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            Assert.Equal(3, list.Count());
        }

        [Fact]
        public void TestRemoveAt()
        {
            // Given
            CustomList list = new CustomList();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            // When
            list.RemoveAt(1);
            // Then
            Assert.Equal(3, list.Get(1));
        }

        [Fact]
        public void TestRemoveValue()
        {
            // Given
            CustomList list = new CustomList();
            list.Add(1);
            list.Add(5);
            list.Add(10);
            list.Add(15);
            // When
            Assert.Equal(5, list.Get(1));
            list.Remove(5);
            // Then
            Assert.Equal(10, list.Get(1));
            Assert.False(list.Contains(5));
        }

        [Fact]
        public void TestCountAndClear()
        {
            // Given
            CustomList list = new CustomList();
            list.Add(1);
            list.Add(5);
            list.Add(10);
            list.Add(15);
            // When
            Assert.Equal(4, list.Count());
            list.Clear();
            // Then
            Assert.Equal(0, list.Count());
        }

        [Fact]
        public void TestContains()
        {
            // Given
            CustomList list = new CustomList();
            list.Add(1);
            list.Add(5);
            list.Add(10);
            list.Add(15);
            // Then
            Assert.True(list.Contains(5));
            Assert.False(list.Contains(7));
        }
    }
}