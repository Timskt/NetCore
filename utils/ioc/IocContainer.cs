using System.Collections.Concurrent;
using CommunityToolkit.Mvvm.DependencyInjection;

namespace EvocWPFUtils.utils.ioc;

public static class IocContainer
{
    /// <summary>
    /// ioc容器
    /// </summary>
    private static ConcurrentDictionary<string, object> _iocDict = new ConcurrentDictionary<string, object>();
    
    
}