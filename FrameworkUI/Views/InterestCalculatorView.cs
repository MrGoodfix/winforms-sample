using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Forms;
using FrameworkUI.Presenters;
using Sample.Core.Interest;

namespace FrameworkUI.Views
{
    public partial class InterestCalculatorView : Form, IInterestCalculatorView
    {
        private readonly IInterestCalculatorPresenter _presenter;

        public InterestCalculatorView()
        {
            InitializeComponent();
            _presenter = new InterestCalculatorPresenter(this);
        }

        public void HandleNotification(string message)
        {
            MessageBox.Show(message, "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                var request = new InterestForecastRequest
                {
                    Principal = decimal.Parse(txtPrincipal.Text),
                    Rate = decimal.Parse(txtRate.Text),
                    Years = (int)numYears.Value
                };

                _presenter.Calculate(request);
            }
        }

        public void DisplayForecasts(List<BalanceForecast> forecasts)
        {
            displayBalanceForecasts(forecasts);
        }

        private void displayBalanceForecasts(List<BalanceForecast> forecasts)
        {
            var builder = new StringBuilder();
            builder.AppendLine("Year\tAmount on deposit");
            foreach (var forecast in forecasts)
            {
                builder.AppendLine($"{forecast.Year}\t{string.Format("{0:C}", forecast.Balance)}");
            }
            string display = builder.ToString();
            txtOutputDisplay.Text = display;
        }

        private void txtPrincipal_Validating(object sender, CancelEventArgs e)
        {
            if (decimal.TryParse(txtPrincipal.Text, out decimal result)) 
            {
                e.Cancel = false;
                errorProvider.SetError(txtPrincipal, string.Empty);
            }
            else
            {
                e.Cancel = true;
                txtPrincipal.Focus();
                errorProvider.SetError(txtPrincipal, "Cannot convert value to a number");
            }
        }

        private void txtRate_Validating(object sender, CancelEventArgs e)
        {
            if (decimal.TryParse(txtRate.Text, out decimal result))
            {
                e.Cancel = false;
                errorProvider.SetError(txtRate, string.Empty);
            }
            else
            {
                e.Cancel = true;
                txtRate.Focus();
                errorProvider.SetError(txtRate, "Cannot convert value to a number");
            }
        }
    }
}
