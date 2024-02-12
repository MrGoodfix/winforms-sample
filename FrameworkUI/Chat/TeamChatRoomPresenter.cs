using System;
using Sample.Core.Mediator.Chat;

namespace FrameworkUI.Chat
{
    internal class TeamChatRoomPresenter
    {
        private IChatroomView _chatroomView;
        private TeamChatRoom _chatRoom;
        private int _lastMemberNo = 1;
        const int MAX_MEMBERS = 10;

        public bool IsActive
        {
            get
            {
                if (_chatRoom.GetMemberCount() > 0) { return true; }
                return false;
            }
        }

        public TeamChatRoomPresenter(IChatroomView chatroomView)
        {
            _chatroomView = chatroomView;
            _chatRoom = new TeamChatRoom();
            _chatRoom.MemberJoined += NotifyMemberJoined;
            _chatRoom.MemberLeft += NotifyMemberLeft;
            _chatRoom.MessageSent += NotifyMessageSent;
        }

        public void AddMember(TeamMemberType memberType)
        {
            if (_chatRoom.GetMemberCount() < MAX_MEMBERS)
            {
                var newMember = TeamChatMember.Construct($"Member_{_lastMemberNo}", memberType);
                _lastMemberNo++;
                _chatRoom.Register(newMember);
                var memberView = new TeamChatMemberView(newMember);
                memberView.Show();
            }
            else
            {
                _chatroomView.HandleNotification("Member could not join. Not enough room.");
            }
        }

        public void CloseRoom()
        {
            _chatRoom.Close();
        }

        private void NotifyMemberJoined(string memberName)
        {
            _chatroomView.HandleNotification($"{memberName} joined the room.");
        }

        private void NotifyMemberLeft(string memberName)
        {
            _chatroomView.HandleNotification($"{memberName} left the room.");
        }

        private void NotifyMessageSent(string from, string message)
        {
            _chatroomView.HandleNotification($"{from} ({DateTime.Now}): {message}");
        }
    }
}
