namespace Sample.Core.Mediator.Chat
{
    public abstract class ChatRoom
    {
        public abstract void Register(TeamChatMember member);
        public abstract void Send(string from, string message);
        public abstract void SendTo<T>(string from, string message) where T : TeamChatMember;
        public abstract int GetMemberCount();
        public abstract void Close();
    }
}
