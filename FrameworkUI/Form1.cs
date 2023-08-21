using FrameworkUI.Views;
using System;
using System.Windows.Forms;

namespace FrameworkUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnInterestCalc_Click(object sender, EventArgs e)
        {
            new InterestCalculatorView().Show();
        }

        private void btnStructuralMediator_Click(object sender, EventArgs e)
        {
            new StructuralMediatorView().Show();
        }
    }
}
