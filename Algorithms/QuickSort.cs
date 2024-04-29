namespace Algorithms;

public class QuickSort
{
    public static IEnumerable<int> Sort(List<int> items)
    {
        if (items.Count < 2)
        {
            return items;
        };

        var smaller = new List<int>();
        var greater = new List<int>();
        var pivot = items.First();
        items.Remove(pivot);

        foreach (var item in items)
        {
            if (item < pivot)
            {
                smaller.Add(item);
            }
            else
            {
                greater.Add(item);
            }
        }

        var sortedItems = new List<int>();
        sortedItems.AddRange(Sort(smaller));
        sortedItems.Add(pivot);
        sortedItems.AddRange(Sort(greater));
        return sortedItems;
    }
}