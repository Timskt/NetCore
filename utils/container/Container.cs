using System.Collections.Concurrent;

namespace EvocWPFUtils.utils.container;

public static class Container
{
    private static ConcurrentDictionary<string, object> _containerDict = new ConcurrentDictionary<string, object>();

    public static bool AddData(string key, object data)
    {
       return _containerDict.TryAdd(key, data);
    }

    public static bool IsExist(string key)
    {
        return _containerDict.ContainsKey(key);;
    }

    public static object GetValue(string key)
    {
        _containerDict.TryGetValue(key, out var result);
        return result;
    }

    public static bool Remove(string key)
    {
      return  _containerDict.TryRemove(key, out var result);
    }

    public static bool Update(string key, object data)
    {
        _containerDict.TryRemove(key, out var result);
       return  _containerDict.TryAdd(key, data);
    }

    public static void Clear()
    {
        _containerDict.Clear();
    }
}