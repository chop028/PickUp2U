
namespace PickUp2U
{
    partial class ProgressSettingform
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
<<<<<<< HEAD
            this.txtExpectedTime = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnComplete = new System.Windows.Forms.Button();
            this.txtCompleteTime = new System.Windows.Forms.TextBox();
            this.radPickupComplete = new System.Windows.Forms.RadioButton();
            this.txtWaitingTime = new System.Windows.Forms.TextBox();
            this.radPickupWaiting = new System.Windows.Forms.RadioButton();
            this.txtInProgressTime = new System.Windows.Forms.TextBox();
            this.radProductInProgress = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtExpectedTime
            // 
            this.txtExpectedTime.Location = new System.Drawing.Point(264, 58);
            this.txtExpectedTime.Name = "txtExpectedTime";
            this.txtExpectedTime.Size = new System.Drawing.Size(71, 35);
            this.txtExpectedTime.TabIndex = 28;
            this.txtExpectedTime.Text = "60";
            this.txtExpectedTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(260, 524);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(154, 48);
            this.btnCancel.TabIndex = 27;
            this.btnCancel.Text = "취소";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnComplete
            // 
            this.btnComplete.Location = new System.Drawing.Point(83, 524);
            this.btnComplete.Margin = new System.Windows.Forms.Padding(4);
            this.btnComplete.Name = "btnComplete";
            this.btnComplete.Size = new System.Drawing.Size(154, 48);
            this.btnComplete.TabIndex = 26;
            this.btnComplete.Text = "완료";
            this.btnComplete.UseVisualStyleBackColor = true;
            this.btnComplete.Click += new System.EventHandler(this.btnComplete_Click);
            // 
            // txtCompleteTime
            // 
            this.txtCompleteTime.Location = new System.Drawing.Point(83, 432);
            this.txtCompleteTime.Margin = new System.Windows.Forms.Padding(4);
            this.txtCompleteTime.Name = "txtCompleteTime";
            this.txtCompleteTime.Size = new System.Drawing.Size(327, 35);
            this.txtCompleteTime.TabIndex = 25;
            // 
            // radPickupComplete
            // 
            this.radPickupComplete.AutoSize = true;
            this.radPickupComplete.Location = new System.Drawing.Point(37, 392);
            this.radPickupComplete.Margin = new System.Windows.Forms.Padding(4);
            this.radPickupComplete.Name = "radPickupComplete";
            this.radPickupComplete.Size = new System.Drawing.Size(145, 28);
            this.radPickupComplete.TabIndex = 24;
            this.radPickupComplete.Text = "픽업 완료";
            this.radPickupComplete.UseVisualStyleBackColor = true;
            this.radPickupComplete.CheckedChanged += new System.EventHandler(this.radPickupComplete_CheckedChanged);
            // 
            // txtWaitingTime
            // 
            this.txtWaitingTime.Location = new System.Drawing.Point(83, 322);
            this.txtWaitingTime.Margin = new System.Windows.Forms.Padding(4);
            this.txtWaitingTime.Name = "txtWaitingTime";
            this.txtWaitingTime.Size = new System.Drawing.Size(327, 35);
            this.txtWaitingTime.TabIndex = 23;
            // 
            // radPickupWaiting
            // 
            this.radPickupWaiting.AutoSize = true;
            this.radPickupWaiting.Location = new System.Drawing.Point(37, 282);
            this.radPickupWaiting.Margin = new System.Windows.Forms.Padding(4);
            this.radPickupWaiting.Name = "radPickupWaiting";
            this.radPickupWaiting.Size = new System.Drawing.Size(169, 28);
            this.radPickupWaiting.TabIndex = 22;
            this.radPickupWaiting.Text = "픽업 대기중";
            this.radPickupWaiting.UseVisualStyleBackColor = true;
            this.radPickupWaiting.CheckedChanged += new System.EventHandler(this.radPickupWaiting_CheckedChanged);
            // 
            // txtInProgressTime
            // 
            this.txtInProgressTime.Location = new System.Drawing.Point(83, 214);
            this.txtInProgressTime.Margin = new System.Windows.Forms.Padding(4);
            this.txtInProgressTime.Name = "txtInProgressTime";
            this.txtInProgressTime.Size = new System.Drawing.Size(327, 35);
            this.txtInProgressTime.TabIndex = 21;
            // 
            // radProductInProgress
            // 
            this.radProductInProgress.AutoSize = true;
            this.radProductInProgress.Location = new System.Drawing.Point(37, 174);
            this.radProductInProgress.Margin = new System.Windows.Forms.Padding(4);
            this.radProductInProgress.Name = "radProductInProgress";
            this.radProductInProgress.Size = new System.Drawing.Size(169, 28);
            this.radProductInProgress.TabIndex = 20;
            this.radProductInProgress.Text = "상품 준비중";
            this.radProductInProgress.UseVisualStyleBackColor = true;
            this.radProductInProgress.CheckedChanged += new System.EventHandler(this.radProductInProgress_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(342, 63);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 24);
            this.label1.TabIndex = 19;
            this.label1.Text = "분";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(79, 63);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 24);
            this.label2.TabIndex = 18;
            this.label2.Text = "예상 준비시간:";
            // 
=======
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.radProductInProgress = new System.Windows.Forms.RadioButton();
            this.txtInProgressTime = new System.Windows.Forms.TextBox();
            this.radPickupWaiting = new System.Windows.Forms.RadioButton();
            this.txtWaitingTime = new System.Windows.Forms.TextBox();
            this.radPickupComplete = new System.Windows.Forms.RadioButton();
            this.txtCompleteTime = new System.Windows.Forms.TextBox();
            this.btnComplete = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtExpectedTime = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(133, 49);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "예상 준비시간:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(396, 49);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 24);
            this.label1.TabIndex = 8;
            this.label1.Text = "분";
            // 
            // radProductInProgress
            // 
            this.radProductInProgress.AutoSize = true;
            this.radProductInProgress.Location = new System.Drawing.Point(91, 160);
            this.radProductInProgress.Margin = new System.Windows.Forms.Padding(4);
            this.radProductInProgress.Name = "radProductInProgress";
            this.radProductInProgress.Size = new System.Drawing.Size(169, 28);
            this.radProductInProgress.TabIndex = 9;
            this.radProductInProgress.Text = "상품 준비중";
            this.radProductInProgress.UseVisualStyleBackColor = true;
            this.radProductInProgress.CheckedChanged += new System.EventHandler(this.radProductInProgress_CheckedChanged);
            // 
            // txtInProgressTime
            // 
            this.txtInProgressTime.Location = new System.Drawing.Point(137, 200);
            this.txtInProgressTime.Margin = new System.Windows.Forms.Padding(4);
            this.txtInProgressTime.Name = "txtInProgressTime";
            this.txtInProgressTime.Size = new System.Drawing.Size(327, 35);
            this.txtInProgressTime.TabIndex = 10;
            // 
            // radPickupWaiting
            // 
            this.radPickupWaiting.AutoSize = true;
            this.radPickupWaiting.Location = new System.Drawing.Point(91, 268);
            this.radPickupWaiting.Margin = new System.Windows.Forms.Padding(4);
            this.radPickupWaiting.Name = "radPickupWaiting";
            this.radPickupWaiting.Size = new System.Drawing.Size(169, 28);
            this.radPickupWaiting.TabIndex = 11;
            this.radPickupWaiting.Text = "픽업 대기중";
            this.radPickupWaiting.UseVisualStyleBackColor = true;
            this.radPickupWaiting.CheckedChanged += new System.EventHandler(this.radPickupWaiting_CheckedChanged);
            // 
            // txtWaitingTime
            // 
            this.txtWaitingTime.Location = new System.Drawing.Point(137, 308);
            this.txtWaitingTime.Margin = new System.Windows.Forms.Padding(4);
            this.txtWaitingTime.Name = "txtWaitingTime";
            this.txtWaitingTime.Size = new System.Drawing.Size(327, 35);
            this.txtWaitingTime.TabIndex = 12;
            // 
            // radPickupComplete
            // 
            this.radPickupComplete.AutoSize = true;
            this.radPickupComplete.Location = new System.Drawing.Point(91, 378);
            this.radPickupComplete.Margin = new System.Windows.Forms.Padding(4);
            this.radPickupComplete.Name = "radPickupComplete";
            this.radPickupComplete.Size = new System.Drawing.Size(145, 28);
            this.radPickupComplete.TabIndex = 13;
            this.radPickupComplete.Text = "픽업 완료";
            this.radPickupComplete.UseVisualStyleBackColor = true;
            this.radPickupComplete.CheckedChanged += new System.EventHandler(this.radPickupComplete_CheckedChanged);
            // 
            // txtCompleteTime
            // 
            this.txtCompleteTime.Location = new System.Drawing.Point(137, 418);
            this.txtCompleteTime.Margin = new System.Windows.Forms.Padding(4);
            this.txtCompleteTime.Name = "txtCompleteTime";
            this.txtCompleteTime.Size = new System.Drawing.Size(327, 35);
            this.txtCompleteTime.TabIndex = 14;
            // 
            // btnComplete
            // 
            this.btnComplete.Location = new System.Drawing.Point(137, 510);
            this.btnComplete.Margin = new System.Windows.Forms.Padding(4);
            this.btnComplete.Name = "btnComplete";
            this.btnComplete.Size = new System.Drawing.Size(154, 48);
            this.btnComplete.TabIndex = 15;
            this.btnComplete.Text = "완료";
            this.btnComplete.UseVisualStyleBackColor = true;
            this.btnComplete.Click += new System.EventHandler(this.btnComplete_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(314, 510);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(154, 48);
            this.btnCancel.TabIndex = 16;
            this.btnCancel.Text = "취소";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtExpectedTime
            // 
            this.txtExpectedTime.Location = new System.Drawing.Point(318, 44);
            this.txtExpectedTime.Name = "txtExpectedTime";
            this.txtExpectedTime.Size = new System.Drawing.Size(71, 35);
            this.txtExpectedTime.TabIndex = 17;
            this.txtExpectedTime.Text = "60";
            this.txtExpectedTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtExpectedTime.TextChanged += new System.EventHandler(this.txtExpectedTime_TextChanged);
            // 
>>>>>>> fa079993f9f169452dd890ef889c8ccfbc7b9512
            // ProgressSettingform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
<<<<<<< HEAD
            this.ClientSize = new System.Drawing.Size(529, 688);
=======
            this.ClientSize = new System.Drawing.Size(675, 688);
>>>>>>> fa079993f9f169452dd890ef889c8ccfbc7b9512
            this.Controls.Add(this.txtExpectedTime);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnComplete);
            this.Controls.Add(this.txtCompleteTime);
            this.Controls.Add(this.radPickupComplete);
            this.Controls.Add(this.txtWaitingTime);
            this.Controls.Add(this.radPickupWaiting);
            this.Controls.Add(this.txtInProgressTime);
            this.Controls.Add(this.radProductInProgress);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "ProgressSettingform";
            this.Text = "Progress";
<<<<<<< HEAD
=======
            this.Load += new System.EventHandler(this.ProgressSettingform_Load);
>>>>>>> fa079993f9f169452dd890ef889c8ccfbc7b9512
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

<<<<<<< HEAD
        private System.Windows.Forms.TextBox txtExpectedTime;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnComplete;
        private System.Windows.Forms.TextBox txtCompleteTime;
        private System.Windows.Forms.RadioButton radPickupComplete;
        private System.Windows.Forms.TextBox txtWaitingTime;
        private System.Windows.Forms.RadioButton radPickupWaiting;
        private System.Windows.Forms.TextBox txtInProgressTime;
        private System.Windows.Forms.RadioButton radProductInProgress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
=======
        private System.Windows.Forms.Label label2;
     
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radProductInProgress;
        private System.Windows.Forms.TextBox txtInProgressTime;
        private System.Windows.Forms.RadioButton radPickupWaiting;
        private System.Windows.Forms.TextBox txtWaitingTime;
        private System.Windows.Forms.RadioButton radPickupComplete;
        private System.Windows.Forms.TextBox txtCompleteTime;
        private System.Windows.Forms.Button btnComplete;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtExpectedTime;
>>>>>>> fa079993f9f169452dd890ef889c8ccfbc7b9512
    }
}