namespace Algorithms;

public class BinarySearch
{
    public static int Search(int[] sortedArray, int target)
    {
        var middle = 0;
        var item = 0;
        var begin = 0;
        var end = sortedArray.Length - 1;

        while (item != target)
        {
            middle = (begin + end) / 2;
            item = sortedArray[middle];

            if (item > target)
            {
                end = middle;
            }

            if (item < target)
            {
                begin = middle;
            }
        }

        return middle;
    }
}
