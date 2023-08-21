using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FrameworkUI.Presenters;

namespace FrameworkUI.Views
{
    public partial class StructuralMediatorView : Form, IMediatorView
    {
        private readonly StructuralMediatorPresenter _presenter;

        public StructuralMediatorView()
        {
            InitializeComponent();
            _presenter = new StructuralMediatorPresenter(this);
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            _presenter.StartMediating();
        }

        public void HandleNotification(string message)
        {
            lstOutput.Items.Add(message);
        }
    }
}
