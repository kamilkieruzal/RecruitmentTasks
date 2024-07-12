using System.ComponentModel;

namespace ExportReport.Utils
{
    public static class BindingListExtensions
    {
        public static void AddRange<T>(this BindingList<T> list, IEnumerable<T> items)
        {
            foreach(var item in items)
                list.Add(item);
        }
    }
}
