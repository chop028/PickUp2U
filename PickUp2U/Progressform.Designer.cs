﻿
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
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.shoplable = new System.Windows.Forms.Label();
            this.locationlable = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblRemainingTime
            // 
            this.lblRemainingTime.AutoSize = true;
            this.lblRemainingTime.Location = new System.Drawing.Point(221, 40);
            this.lblRemainingTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRemainingTime.Name = "lblRemainingTime";
            this.lblRemainingTime.Size = new System.Drawing.Size(81, 12);
            this.lblRemainingTime.TabIndex = 0;
            this.lblRemainingTime.Text = "남은시간:32분";
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(100, 67);
            this.progressBar.Margin = new System.Windows.Forms.Padding(2);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(334, 38);
            this.progressBar.TabIndex = 1;
            // 
            // lblInProgressTime
            // 
            this.lblInProgressTime.AutoSize = true;
            this.lblInProgressTime.Location = new System.Drawing.Point(86, 173);
            this.lblInProgressTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblInProgressTime.Name = "lblInProgressTime";
            this.lblInProgressTime.Size = new System.Drawing.Size(155, 12);
            this.lblInProgressTime.TabIndex = 0;
            this.lblInProgressTime.Text = "상품준비: 2023-11-23-11:30";
            // 
            // lblWaitingTime
            // 
            this.lblWaitingTime.AutoSize = true;
            this.lblWaitingTime.Location = new System.Drawing.Point(86, 197);
            this.lblWaitingTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblWaitingTime.Name = "lblWaitingTime";
            this.lblWaitingTime.Size = new System.Drawing.Size(155, 12);
            this.lblWaitingTime.TabIndex = 0;
            this.lblWaitingTime.Text = "준비완료: 2023-11-23-11:30";
            // 
            // lblCompleteTime
            // 
            this.lblCompleteTime.AutoSize = true;
            this.lblCompleteTime.Location = new System.Drawing.Point(86, 220);
            this.lblCompleteTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCompleteTime.Name = "lblCompleteTime";
            this.lblCompleteTime.Size = new System.Drawing.Size(57, 12);
            this.lblCompleteTime.TabIndex = 0;
            this.lblCompleteTime.Text = "픽업완료:";
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // shoplable
            // 
            this.shoplable.AutoSize = true;
            this.shoplable.Location = new System.Drawing.Point(86, 126);
            this.shoplable.Name = "shoplable";
            this.shoplable.Size = new System.Drawing.Size(45, 12);
            this.shoplable.TabIndex = 2;
            this.shoplable.Text = "매장명:";
            // 
            // locationlable
            // 
            this.locationlable.AutoSize = true;
            this.locationlable.Location = new System.Drawing.Point(86, 150);
            this.locationlable.Name = "locationlable";
            this.locationlable.Size = new System.Drawing.Size(57, 12);
            this.locationlable.TabIndex = 3;
            this.locationlable.Text = "매장위치:";
            // 
            // Progressform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 286);
            this.Controls.Add(this.locationlable);
            this.Controls.Add(this.shoplable);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.lblCompleteTime);
            this.Controls.Add(this.lblWaitingTime);
            this.Controls.Add(this.lblInProgressTime);
            this.Controls.Add(this.lblRemainingTime);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Progressform";
            this.Text = "Progressform";
            this.Load += new System.EventHandler(this.Progressform_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRemainingTime;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label lblInProgressTime;
        private System.Windows.Forms.Label lblWaitingTime;
        private System.Windows.Forms.Label lblCompleteTime;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label shoplable;
        private System.Windows.Forms.Label locationlable;
    }
}