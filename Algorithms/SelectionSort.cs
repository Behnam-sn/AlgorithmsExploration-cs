
namespace Algorithms;

public class SelectionSort
{
    public static List<int> Sort(List<int> list)
    {
        if (list.Count <= 1)
        {
            return list;
        }

        var sortedList = new List<int>();
        while (list.Count > 0)
        {
            var min = list.First();
            foreach (var item in list)
            {
                if (item <= min)
                {
                    min = item;
                }
            }
            list.Remove(min);
            sortedList.Add(min);
        }
        return sortedList;
    }
}