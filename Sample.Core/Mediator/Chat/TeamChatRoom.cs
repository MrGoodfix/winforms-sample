using System.Collections.Generic;
using System.Linq;

namespace Sample.Core.Mediator.Chat
{
    public delegate void MemberJoinedHandler(string memberName);
    public delegate void MemberLeftHandler(string memberName);
    public delegate void MessageSentHandler(string from, string message);

    public class TeamChatRoom : ChatRoom
    {
        private List<TeamChatMember> _members = new List<TeamChatMember>();

        public event MemberJoinedHandler MemberJoined;
        public event MemberLeftHandler MemberLeft;
        public event MessageSentHandler MessageSent;

        public override void Close()
        {
            for (int i = _members.Count - 1; i > -1; i--)
            {
                _members[i].LeaveChatRoom();
            }
        }

        public override int GetMemberCount()
        {
            return _members.Count;
        }

        public override void Register(TeamChatMember member)
        {
            member.SetChatRoom(this);
            _members.Add(member);
            member.LeftRoom += RemoveMember;
            MemberJoined?.Invoke(member.Name);
        }

        public void RegisterMembers(params TeamChatMember[] teamMembers)
        {
            foreach (var teamMember in teamMembers)
            {
                Register(teamMember);
            }
        }

        public void RemoveMember(TeamChatMember member)
        {
            _members.Remove(member);
            MemberLeft?.Invoke(member.Name);
        }

        public override void Send(string from, string message)
        {
            MessageSent?.Invoke(from, message);
            _members.ForEach(m => m.Receive(from, message));
        }

        public override void SendTo<T>(string from, string message)
        {
            MessageSent?.Invoke(from, message);
            _members.OfType<T>().ToList().ForEach(m => m.Receive(from, message));
        }
    }
}
