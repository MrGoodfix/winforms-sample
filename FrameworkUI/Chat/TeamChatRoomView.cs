using System;
using System.Windows.Forms;
using Sample.Core.Mediator.Chat;

namespace FrameworkUI.Chat
{
    public partial class TeamChatRoomView : Form, IChatroomView
    {
        private readonly TeamChatRoomPresenter _presenter;

        public TeamChatRoomView()
        {
            InitializeComponent();
            foreach (var item in Enum.GetValues(typeof(TeamMemberType)))
            {
                cmbMemberType.Items.Add(item);
            }
            _presenter = new TeamChatRoomPresenter(this);
        }

        public void HandleNotification(string notification)
        {
            lstLog.Items.Add(notification);
        }

        public void Disconnect()
        {
            _presenter.CloseRoom();
        }

        private void btnAddMember_Click(object sender, EventArgs e)
        {
            Enum.TryParse(cmbMemberType.SelectedItem.ToString(), out TeamMemberType memberType);

            _presenter.AddMember(memberType);
        }

        private void TeamChatRoomView_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_presenter.IsActive)
            {
                var result = MessageBox.Show("The room has active chatters. Are you sure?",
                    "Close chatroom?",
                    MessageBoxButtons.YesNo);
                if (result != DialogResult.Yes)
                {
                    e.Cancel = true;
                }
            }
        }

        private void TeamChatRoomView_FormClosed(object sender, FormClosedEventArgs e)
        {
            Disconnect();
        }
    }
}
