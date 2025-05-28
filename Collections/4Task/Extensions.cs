namespace _4Task
{
    public static class Extensions
    {
        // Метод розширення для IEnumerable<T>
        public static T[] GetArray<T>(this IEnumerable<T> list)
        {
            return list.ToArray();
        }
    }
}
