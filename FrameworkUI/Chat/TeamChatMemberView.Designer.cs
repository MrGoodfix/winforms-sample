namespace FrameworkUI.Chat
{
    partial class TeamChatMemberView
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
            this.tblFormLayout = new System.Windows.Forms.TableLayoutPanel();
            this.lstOutput = new System.Windows.Forms.ListBox();
            this.pnlInput = new System.Windows.Forms.Panel();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.lblMemberName = new System.Windows.Forms.Label();
            this.cmbSendTo = new System.Windows.Forms.ComboBox();
            this.tblFormLayout.SuspendLayout();
            this.pnlInput.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblFormLayout
            // 
            this.tblFormLayout.ColumnCount = 1;
            this.tblFormLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblFormLayout.Controls.Add(this.lstOutput, 0, 1);
            this.tblFormLayout.Controls.Add(this.pnlInput, 0, 2);
            this.tblFormLayout.Controls.Add(this.lblMemberName, 0, 0);
            this.tblFormLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblFormLayout.Location = new System.Drawing.Point(0, 0);
            this.tblFormLayout.Name = "tblFormLayout";
            this.tblFormLayout.RowCount = 3;
            this.tblFormLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblFormLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblFormLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tblFormLayout.Size = new System.Drawing.Size(659, 393);
            this.tblFormLayout.TabIndex = 0;
            // 
            // lstOutput
            // 
            this.lstOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstOutput.FormattingEnabled = true;
            this.lstOutput.ItemHeight = 16;
            this.lstOutput.Location = new System.Drawing.Point(3, 39);
            this.lstOutput.Name = "lstOutput";
            this.lstOutput.Size = new System.Drawing.Size(653, 271);
            this.lstOutput.TabIndex = 0;
            // 
            // pnlInput
            // 
            this.pnlInput.Controls.Add(this.cmbSendTo);
            this.pnlInput.Controls.Add(this.txtInput);
            this.pnlInput.Controls.Add(this.btnSend);
            this.pnlInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlInput.Location = new System.Drawing.Point(3, 316);
            this.pnlInput.Name = "pnlInput";
            this.pnlInput.Size = new System.Drawing.Size(653, 74);
            this.pnlInput.TabIndex = 1;
            // 
            // txtInput
            // 
            this.txtInput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtInput.Location = new System.Drawing.Point(9, 7);
            this.txtInput.Multiline = true;
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(434, 60);
            this.txtInput.TabIndex = 1;
            // 
            // btnSend
            // 
            this.btnSend.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSend.Location = new System.Drawing.Point(575, 7);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 60);
            this.btnSend.TabIndex = 0;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // lblMemberName
            // 
            this.lblMemberName.AutoSize = true;
            this.lblMemberName.Location = new System.Drawing.Point(5, 5);
            this.lblMemberName.Margin = new System.Windows.Forms.Padding(5);
            this.lblMemberName.Name = "lblMemberName";
            this.lblMemberName.Padding = new System.Windows.Forms.Padding(5);
            this.lblMemberName.Size = new System.Drawing.Size(10, 26);
            this.lblMemberName.TabIndex = 2;
            // 
            // cmbSendTo
            // 
            this.cmbSendTo.FormattingEnabled = true;
            this.cmbSendTo.Location = new System.Drawing.Point(449, 7);
            this.cmbSendTo.Name = "cmbSendTo";
            this.cmbSendTo.Size = new System.Drawing.Size(121, 24);
            this.cmbSendTo.TabIndex = 2;
            // 
            // TeamChatMemberView
            // 
            this.AcceptButton = this.btnSend;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 393);
            this.Controls.Add(this.tblFormLayout);
            this.Name = "TeamChatMemberView";
            this.Text = "Team Chat";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TeamChatMemberView_FormClosed);
            this.tblFormLayout.ResumeLayout(false);
            this.tblFormLayout.PerformLayout();
            this.pnlInput.ResumeLayout(false);
            this.pnlInput.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblFormLayout;
        private System.Windows.Forms.ListBox lstOutput;
        private System.Windows.Forms.Panel pnlInput;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Label lblMemberName;
        private System.Windows.Forms.ComboBox cmbSendTo;
    }
}