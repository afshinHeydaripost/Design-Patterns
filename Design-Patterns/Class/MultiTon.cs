using System.Collections.Concurrent;
namespace Design_Patterns.Class
{
    public sealed class MultiTon
    {
        private MultiTon() { }
        public static volatile ConcurrentDictionary<int, MultiTon> instance = new();
        private static object _lock = new object();
        public static MultiTon GetInstance(int instanceKey)
        {
            if (!instance.ContainsKey(instanceKey))
                lock (_lock)
                {
                    if (!instance.ContainsKey(instanceKey))
                        instance.GetOrAdd(instanceKey, new MultiTon());
                }
            return instance[instanceKey];
        }
    }
}