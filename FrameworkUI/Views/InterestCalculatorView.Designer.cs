namespace FrameworkUI.Views
{
    partial class InterestCalculatorView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txtPrincipal = new System.Windows.Forms.TextBox();
            this.txtRate = new System.Windows.Forms.TextBox();
            this.numYears = new System.Windows.Forms.NumericUpDown();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblPrincipal = new System.Windows.Forms.Label();
            this.lblRate = new System.Windows.Forms.Label();
            this.lblYears = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtOutputDisplay = new System.Windows.Forms.TextBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.numYears)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPrincipal
            // 
            this.txtPrincipal.Location = new System.Drawing.Point(135, 12);
            this.txtPrincipal.Name = "txtPrincipal";
            this.txtPrincipal.Size = new System.Drawing.Size(150, 22);
            this.txtPrincipal.TabIndex = 0;
            this.txtPrincipal.Text = "1000.00";
            this.txtPrincipal.Validating += new System.ComponentModel.CancelEventHandler(this.txtPrincipal_Validating);
            // 
            // txtRate
            // 
            this.txtRate.Location = new System.Drawing.Point(135, 40);
            this.txtRate.Name = "txtRate";
            this.txtRate.Size = new System.Drawing.Size(150, 22);
            this.txtRate.TabIndex = 1;
            this.txtRate.Text = "5";
            this.txtRate.Validating += new System.ComponentModel.CancelEventHandler(this.txtRate_Validating);
            // 
            // numYears
            // 
            this.numYears.Location = new System.Drawing.Point(135, 68);
            this.numYears.Name = "numYears";
            this.numYears.Size = new System.Drawing.Size(150, 22);
            this.numYears.TabIndex = 2;
            this.numYears.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(320, 12);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(150, 23);
            this.btnCalculate.TabIndex = 3;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lblPrincipal
            // 
            this.lblPrincipal.AutoSize = true;
            this.lblPrincipal.Location = new System.Drawing.Point(67, 15);
            this.lblPrincipal.Name = "lblPrincipal";
            this.lblPrincipal.Size = new System.Drawing.Size(62, 16);
            this.lblPrincipal.TabIndex = 4;
            this.lblPrincipal.Text = "Principal:";
            this.lblPrincipal.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblRate
            // 
            this.lblRate.AutoSize = true;
            this.lblRate.Location = new System.Drawing.Point(70, 43);
            this.lblRate.Name = "lblRate";
            this.lblRate.Size = new System.Drawing.Size(59, 16);
            this.lblRate.TabIndex = 5;
            this.lblRate.Text = "Rate(%):";
            this.lblRate.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblYears
            // 
            this.lblYears.AutoSize = true;
            this.lblYears.Location = new System.Drawing.Point(83, 70);
            this.lblYears.Name = "lblYears";
            this.lblYears.Size = new System.Drawing.Size(46, 16);
            this.lblYears.TabIndex = 6;
            this.lblYears.Text = "Years:";
            this.lblYears.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Yearly account balance:";
            // 
            // txtOutputDisplay
            // 
            this.txtOutputDisplay.Location = new System.Drawing.Point(12, 156);
            this.txtOutputDisplay.Multiline = true;
            this.txtOutputDisplay.Name = "txtOutputDisplay";
            this.txtOutputDisplay.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtOutputDisplay.Size = new System.Drawing.Size(458, 282);
            this.txtOutputDisplay.TabIndex = 8;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // InterestCalculatorView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 450);
            this.Controls.Add(this.txtOutputDisplay);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblYears);
            this.Controls.Add(this.lblRate);
            this.Controls.Add(this.lblPrincipal);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.numYears);
            this.Controls.Add(this.txtRate);
            this.Controls.Add(this.txtPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "InterestCalculatorView";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Interest Calculator";
            ((System.ComponentModel.ISupportInitialize)(this.numYears)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPrincipal;
        private System.Windows.Forms.TextBox txtRate;
        private System.Windows.Forms.NumericUpDown numYears;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblPrincipal;
        private System.Windows.Forms.Label lblRate;
        private System.Windows.Forms.Label lblYears;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtOutputDisplay;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}