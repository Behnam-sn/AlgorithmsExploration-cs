namespace Algorithms.Tests;

public class BinarySearchTests
{
    [Theory]
    [InlineData(2, 1)]
    [InlineData(9, 8)]
    [InlineData(5, 4)]
    public void TestName(int target, int expectedIndex)
    {
        // Given
        var sortedArray = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        // When
        var actual = BinarySearch.Search(sortedArray, target);
        // Then
        Assert.Equal(actual, expectedIndex);
    }
}
