namespace Algorithms.Tests;

public class QuickSortTests
{
    [Theory]
    [InlineData(new int[] { }, new int[] { })]
    [InlineData(new int[] { 1 }, new int[] { 1 })]
    [InlineData(new int[] { 2, 1 }, new int[] { 1, 2 })]
    [InlineData(new int[] { 4, 2, 3, 1 }, new int[] { 1, 2, 3, 4 })]
    [InlineData(new int[] { 4, 4, 2, 3, 1, 2 }, new int[] { 1, 2, 2, 3, 4, 4 })]
    public void TestName(IEnumerable<int> items, IEnumerable<int> sortedItems)
    {
        // Given
        // When
        var actual = QuickSort.Sort(items.ToList());
        // Then
        Assert.Equal(sortedItems, actual);
    }
}
