using FrameworkUI.Chat;
using FrameworkUI.Views;
using System;
using System.Windows.Forms;

namespace FrameworkUI
{
    public partial class Form1 : Form
    {
        int _openWindows = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void subwindow_Closed(object sender, FormClosedEventArgs e)
        {
            _openWindows--;
        }

        private void btnInterestCalc_Click(object sender, EventArgs e)
        {
            var view = new InterestCalculatorView();
            _openWindows++;
            view.FormClosed += subwindow_Closed;
            view.Show();
        }

        private void btnStructuralMediator_Click(object sender, EventArgs e)
        {
            var view = new StructuralMediatorView();
            _openWindows++;
            view.FormClosed += subwindow_Closed;
            view.Show();
        }

        private void btnChatRoom_Click(object sender, EventArgs e)
        {
            var view = new TeamChatRoomView();
            _openWindows++;
            view.FormClosed += subwindow_Closed;
            view.Show();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_openWindows > 0)
            {
                var result = MessageBox.Show(
                    "One or more subwindows are open. Click yes to close anyways or no to keep the app open",
                    "Close all windows?",
                    MessageBoxButtons.YesNo);
                if (result != DialogResult.Yes) 
                {
                    e.Cancel = true;
                }
            }
        }
    }
}
