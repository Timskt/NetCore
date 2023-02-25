using CommunityToolkit.Mvvm.Messaging.Messages;

namespace EvocWPFUtils.utils.mvvm.model;
/// <summary>
/// 
/// </summary>
public class MessageModel : ValueChangedMessage<MessageList>
{
    public MessageModel(MessageList value) : base(value)
    {
    }
}