﻿
namespace PickUp2U
{
    partial class MainOwnerform
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.조회ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.주문조회ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.보유매장조회ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.관리ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.픽업관리ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.매장관리ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.상품관리ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_userid = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.조회ToolStripMenuItem,
            this.관리ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(11, 4, 0, 4);
            this.menuStrip1.Size = new System.Drawing.Size(1939, 44);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 조회ToolStripMenuItem
            // 
            this.조회ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.주문조회ToolStripMenuItem,
            this.보유매장조회ToolStripMenuItem});
            this.조회ToolStripMenuItem.Name = "조회ToolStripMenuItem";
            this.조회ToolStripMenuItem.Size = new System.Drawing.Size(83, 36);
            this.조회ToolStripMenuItem.Text = "조회";
            // 
            // 주문조회ToolStripMenuItem
            // 
            this.주문조회ToolStripMenuItem.Name = "주문조회ToolStripMenuItem";
            this.주문조회ToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.주문조회ToolStripMenuItem.Text = "주문 조회";
            this.주문조회ToolStripMenuItem.Click += new System.EventHandler(this.주문조회ToolStripMenuItem_Click);
            // 
            // 보유매장조회ToolStripMenuItem
            // 
            this.보유매장조회ToolStripMenuItem.Name = "보유매장조회ToolStripMenuItem";
            this.보유매장조회ToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.보유매장조회ToolStripMenuItem.Text = "보유 매장 조회";
            this.보유매장조회ToolStripMenuItem.Click += new System.EventHandler(this.보유매장조회ToolStripMenuItem_Click);
            // 
            // 관리ToolStripMenuItem
            // 
            this.관리ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.매장관리ToolStripMenuItem,
            this.상품관리ToolStripMenuItem,
            this.픽업관리ToolStripMenuItem});
            this.관리ToolStripMenuItem.Name = "관리ToolStripMenuItem";
            this.관리ToolStripMenuItem.Size = new System.Drawing.Size(83, 36);
            this.관리ToolStripMenuItem.Text = "관리";
            // 
            // 픽업관리ToolStripMenuItem
            // 
            this.픽업관리ToolStripMenuItem.Name = "픽업관리ToolStripMenuItem";
            this.픽업관리ToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.픽업관리ToolStripMenuItem.Text = "픽업 관리";
            this.픽업관리ToolStripMenuItem.Click += new System.EventHandler(this.픽업관리ToolStripMenuItem_Click);
            // 
            // 매장관리ToolStripMenuItem
            // 
            this.매장관리ToolStripMenuItem.Name = "매장관리ToolStripMenuItem";
            this.매장관리ToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.매장관리ToolStripMenuItem.Text = "매장 관리";
            this.매장관리ToolStripMenuItem.Click += new System.EventHandler(this.매장등록ToolStripMenuItem_Click);
            // 
            // 상품관리ToolStripMenuItem
            // 
            this.상품관리ToolStripMenuItem.Name = "상품관리ToolStripMenuItem";
            this.상품관리ToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.상품관리ToolStripMenuItem.Text = "상품 관리";
            this.상품관리ToolStripMenuItem.Click += new System.EventHandler(this.상품등록ToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1241, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "회원번호";
            // 
            // txt_userid
            // 
            this.txt_userid.AutoSize = true;
            this.txt_userid.Location = new System.Drawing.Point(1358, 10);
            this.txt_userid.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.txt_userid.Name = "txt_userid";
            this.txt_userid.Size = new System.Drawing.Size(34, 24);
            this.txt_userid.TabIndex = 3;
            this.txt_userid.Text = "[]";
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(1101, 0);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(4);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(128, 44);
            this.btnLogout.TabIndex = 5;
            this.btnLogout.Text = "로그아웃";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // MainOwnerform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1939, 1060);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.txt_userid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "MainOwnerform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Owner";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 조회ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 관리ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 픽업관리ToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txt_userid;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.ToolStripMenuItem 주문조회ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 보유매장조회ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 매장관리ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 상품관리ToolStripMenuItem;
    }
}