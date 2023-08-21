using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrameworkUI.Views
{
    public interface IMediatorView
    {
        void HandleNotification(string message);
    }
}
