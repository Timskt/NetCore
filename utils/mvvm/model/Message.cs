using System.Collections.Concurrent;
using CommunityToolkit.Mvvm.ComponentModel;

namespace EvocWPFUtils.utils.mvvm.model;

/// <summary>
/// 消息传递
/// </summary>
public class MessageList : ObservableObject
{
    private ConcurrentDictionary<string, object> _messageList = new();

    public ConcurrentDictionary<string, object> NowMessageList
    {
        get => _messageList;
        set => SetProperty(ref _messageList, value);
    }
}