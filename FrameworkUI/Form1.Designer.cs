namespace FrameworkUI
{
    partial class Form1
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
            this.btnInterestCalc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnInterestCalc
            // 
            this.btnInterestCalc.Location = new System.Drawing.Point(277, 75);
            this.btnInterestCalc.Name = "btnInterestCalc";
            this.btnInterestCalc.Size = new System.Drawing.Size(150, 43);
            this.btnInterestCalc.TabIndex = 0;
            this.btnInterestCalc.Text = "Interest Calculator";
            this.btnInterestCalc.UseVisualStyleBackColor = true;
            this.btnInterestCalc.Click += new System.EventHandler(this.btnInterestCalc_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnInterestCalc);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnInterestCalc;
    }
}

