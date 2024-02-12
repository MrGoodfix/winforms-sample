namespace Sample.Core.Mediator.Chat
{
    public delegate void ReceivedMessageHandler(string from, string message);
    public delegate void LeftRoomHandler(TeamChatMember member);
    
    /// <summary>
    /// Chat colleague used to communicate with TeamChat mediator
    /// </summary>
    public abstract class TeamChatMember
    {
        private TeamChatRoom _room;
        public string Name { get; }

        public event ReceivedMessageHandler ReceivedMessage;
        public event LeftRoomHandler LeftRoom;

        public TeamChatMember(string name)
        {
            Name = name;
        }

        public void SetChatRoom(TeamChatRoom room)
        {
            _room = room;
            _room.MemberJoined += MemberJoined;
            _room.MemberLeft += MemberLeft;
        }

        public void LeaveChatRoom()
        {
            LeftRoom?.Invoke(this);
            if (_room != null)
            {
                _room.MemberJoined -= MemberJoined;
                _room.MemberLeft -= MemberLeft;
                _room = null;
            }
        }

        public void Send(string message)
        {
            _room?.Send(Name, message);
        }

        public void SendTo<T>(string message) where T : TeamChatMember
        {
            _room?.SendTo<T>(Name, message);
        }

        public virtual void Receive(string from, string message)
        {
            ReceivedMessage?.Invoke(from, message);
        }

        public void MemberLeft(string memberName)
        {
            ReceivedMessage?.Invoke("[Server]", $"{memberName} left the room");
        }

        public void MemberJoined(string memberName)
        {
            ReceivedMessage?.Invoke("[Server]", $"{memberName} entered the room");
        }

        public static TeamChatMember Construct(string name, TeamMemberType memberType)
        {
            switch (memberType)
            {
                case TeamMemberType.Developer: return new TeamChatMember_Developer(name);
                case TeamMemberType.Tester: return new TeamChatMember_Tester(name);
            }
            return null;
        }
    }
}
