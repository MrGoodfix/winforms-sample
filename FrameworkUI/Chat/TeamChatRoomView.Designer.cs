namespace FrameworkUI.Chat
{
    partial class TeamChatRoomView
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
            this.lstLog = new System.Windows.Forms.ListBox();
            this.btnAddMember = new System.Windows.Forms.Button();
            this.cmbMemberType = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lstLog
            // 
            this.lstLog.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lstLog.FormattingEnabled = true;
            this.lstLog.ItemHeight = 16;
            this.lstLog.Location = new System.Drawing.Point(0, 67);
            this.lstLog.Name = "lstLog";
            this.lstLog.Size = new System.Drawing.Size(706, 388);
            this.lstLog.TabIndex = 0;
            // 
            // btnAddMember
            // 
            this.btnAddMember.Location = new System.Drawing.Point(227, 12);
            this.btnAddMember.Name = "btnAddMember";
            this.btnAddMember.Size = new System.Drawing.Size(118, 44);
            this.btnAddMember.TabIndex = 1;
            this.btnAddMember.Text = "Add member";
            this.btnAddMember.UseVisualStyleBackColor = true;
            this.btnAddMember.Click += new System.EventHandler(this.btnAddMember_Click);
            // 
            // cmbMemberType
            // 
            this.cmbMemberType.FormattingEnabled = true;
            this.cmbMemberType.Location = new System.Drawing.Point(12, 23);
            this.cmbMemberType.Name = "cmbMemberType";
            this.cmbMemberType.Size = new System.Drawing.Size(200, 24);
            this.cmbMemberType.TabIndex = 2;
            // 
            // TeamChatRoomView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 455);
            this.Controls.Add(this.cmbMemberType);
            this.Controls.Add(this.btnAddMember);
            this.Controls.Add(this.lstLog);
            this.Name = "TeamChatRoomView";
            this.Text = "Team Chatroom";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TeamChatRoomView_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TeamChatRoomView_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstLog;
        private System.Windows.Forms.Button btnAddMember;
        private System.Windows.Forms.ComboBox cmbMemberType;
    }
}