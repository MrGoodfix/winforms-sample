using System;
using Sample.Core.Mediator.Chat;

namespace FrameworkUI.Chat
{
    public class TeamChatMemberPresenter
    {
        private IChatroomView _view;
        private TeamChatMember _chatMember;
        
        public TeamChatMemberPresenter(IChatroomView view, TeamChatMember chatMember)
        {
            _view = view;
            _chatMember = chatMember;
            _chatMember.ReceivedMessage += NotifyMessageReceived;
            _chatMember.LeftRoom += LeftRoom;
        }

        private void NotifyMessageReceived(string from, string message)
        {
            _view.HandleNotification($"{from} ({DateTime.Now}): {message}");
        }

        private void LeftRoom(TeamChatMember chatMember)
        {
            _view.Disconnect();
        }

        public void SendMessage(string message)
        {
            _chatMember.Send(message);
        }

        public void SendMessageTo(TeamMemberType memberType, string message)
        {
            switch (memberType)
            {
                case TeamMemberType.Developer:
                    _chatMember.SendTo<TeamChatMember_Developer>(message);
                    break;
                case TeamMemberType.Tester:
                    _chatMember.SendTo<TeamChatMember_Tester>(message);
                    break;
            }
        }

        public void Close()
        {
            _chatMember.LeaveChatRoom();
        }
    }
}
