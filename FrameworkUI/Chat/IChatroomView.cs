namespace FrameworkUI.Chat
{
    public interface IChatroomView
    {
        void HandleNotification(string notification);
        void Disconnect();
    }
}
