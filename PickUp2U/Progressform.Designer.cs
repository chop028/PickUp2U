
namespace PickUp2U
{
    partial class Progressform
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
            this.lblRemainingTime = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.lblInProgressTime = new System.Windows.Forms.Label();
            this.lblWaitingTime = new System.Windows.Forms.Label();
            this.lblCompleteTime = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lblRemainingTime
            // 
            this.lblRemainingTime.AutoSize = true;
            this.lblRemainingTime.Location = new System.Drawing.Point(194, 42);
            this.lblRemainingTime.Name = "lblRemainingTime";
            this.lblRemainingTime.Size = new System.Drawing.Size(69, 24);
            this.lblRemainingTime.TabIndex = 0;
            this.lblRemainingTime.Text = "label1";
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(67, 122);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(620, 77);
            this.progressBar.TabIndex = 1;
            // 
            // lblInProgressTime
            // 
            this.lblInProgressTime.AutoSize = true;
            this.lblInProgressTime.Location = new System.Drawing.Point(159, 254);
            this.lblInProgressTime.Name = "lblInProgressTime";
            this.lblInProgressTime.Size = new System.Drawing.Size(69, 24);
            this.lblInProgressTime.TabIndex = 0;
            this.lblInProgressTime.Text = "label1";
            // 
            // lblWaitingTime
            // 
            this.lblWaitingTime.AutoSize = true;
            this.lblWaitingTime.Location = new System.Drawing.Point(159, 302);
            this.lblWaitingTime.Name = "lblWaitingTime";
            this.lblWaitingTime.Size = new System.Drawing.Size(69, 24);
            this.lblWaitingTime.TabIndex = 0;
            this.lblWaitingTime.Text = "label1";
            // 
            // lblCompleteTime
            // 
            this.lblCompleteTime.AutoSize = true;
            this.lblCompleteTime.Location = new System.Drawing.Point(159, 348);
            this.lblCompleteTime.Name = "lblCompleteTime";
            this.lblCompleteTime.Size = new System.Drawing.Size(69, 24);
            this.lblCompleteTime.TabIndex = 0;
            this.lblCompleteTime.Text = "label1";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Progressform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1030, 573);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.lblCompleteTime);
            this.Controls.Add(this.lblWaitingTime);
            this.Controls.Add(this.lblInProgressTime);
            this.Controls.Add(this.lblRemainingTime);
            this.Name = "Progressform";
            this.Text = "Progressform";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRemainingTime;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label lblInProgressTime;
        private System.Windows.Forms.Label lblWaitingTime;
        private System.Windows.Forms.Label lblCompleteTime;
        private System.Windows.Forms.Timer timer1;
    }
}