using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Sample.Core.Mediator.Chat;

namespace FrameworkUI.Chat
{
    public partial class TeamChatMemberView : Form, IChatroomView
    {
        private readonly TeamChatMemberPresenter _presenter;

        public TeamChatMemberView(TeamChatMember chatMember)
        {
            InitializeComponent();
            lblMemberName.Text = chatMember.Name;
            cmbSendTo.Items.Add("Everyone");
            foreach (var item in Enum.GetValues(typeof(TeamMemberType)))
            {
                cmbSendTo.Items.Add(item);
            }
            _presenter = new TeamChatMemberPresenter(this, chatMember);
        }

        public void HandleNotification(string notification)
        {
            lstOutput.Items.Add(notification);
        }

        public void Disconnect()
        {
            lstOutput.Items.Add("Lost connection to room.");
            btnSend.Enabled = false;
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (Enum.TryParse(cmbSendTo.Text, out TeamMemberType memberType))
            {
                _presenter.SendMessageTo(memberType, txtInput.Text);
            }
            else
            {
                _presenter.SendMessage(txtInput.Text);

            }

            txtInput.Clear();
        }

        private void TeamChatMemberView_FormClosed(object sender, FormClosedEventArgs e)
        {
            _presenter.Close();
        }
    }
}
