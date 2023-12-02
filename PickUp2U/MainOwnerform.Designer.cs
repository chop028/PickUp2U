
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
            this.등록ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.매장등록ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.상품등록ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.조회ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.상품조회ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.관리ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.픽업관리ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_userid = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.등록ToolStripMenuItem,
            this.조회ToolStripMenuItem,
            this.관리ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1044, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 등록ToolStripMenuItem
            // 
            this.등록ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.매장등록ToolStripMenuItem,
            this.상품등록ToolStripMenuItem});
            this.등록ToolStripMenuItem.Name = "등록ToolStripMenuItem";
            this.등록ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.등록ToolStripMenuItem.Text = "등록";
            // 
            // 매장등록ToolStripMenuItem
            // 
            this.매장등록ToolStripMenuItem.Name = "매장등록ToolStripMenuItem";
            this.매장등록ToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.매장등록ToolStripMenuItem.Text = "매장 등록";
            this.매장등록ToolStripMenuItem.Click += new System.EventHandler(this.매장등록ToolStripMenuItem_Click);
            // 
            // 상품등록ToolStripMenuItem
            // 
            this.상품등록ToolStripMenuItem.Name = "상품등록ToolStripMenuItem";
            this.상품등록ToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.상품등록ToolStripMenuItem.Text = "상품 등록";
            this.상품등록ToolStripMenuItem.Click += new System.EventHandler(this.상품등록ToolStripMenuItem_Click);
            // 
            // 조회ToolStripMenuItem
            // 
            this.조회ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.상품조회ToolStripMenuItem});
            this.조회ToolStripMenuItem.Name = "조회ToolStripMenuItem";
            this.조회ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.조회ToolStripMenuItem.Text = "조회";
            // 
            // 상품조회ToolStripMenuItem
            // 
            this.상품조회ToolStripMenuItem.Name = "상품조회ToolStripMenuItem";
            this.상품조회ToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.상품조회ToolStripMenuItem.Text = "상품 조회";
            // 
            // 관리ToolStripMenuItem
            // 
            this.관리ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.픽업관리ToolStripMenuItem});
            this.관리ToolStripMenuItem.Name = "관리ToolStripMenuItem";
            this.관리ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.관리ToolStripMenuItem.Text = "관리";
            // 
            // 픽업관리ToolStripMenuItem
            // 
            this.픽업관리ToolStripMenuItem.Name = "픽업관리ToolStripMenuItem";
            this.픽업관리ToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.픽업관리ToolStripMenuItem.Text = "픽업 관리";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(814, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "회원번호";
            // 
            // txt_userid
            // 
            this.txt_userid.AutoSize = true;
            this.txt_userid.Location = new System.Drawing.Point(874, 9);
            this.txt_userid.Name = "txt_userid";
            this.txt_userid.Size = new System.Drawing.Size(17, 12);
            this.txt_userid.TabIndex = 3;
            this.txt_userid.Text = "[]";
            // 
            // MainOwnerform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1044, 586);
            this.Controls.Add(this.txt_userid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
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
        private System.Windows.Forms.ToolStripMenuItem 등록ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 매장등록ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 상품등록ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 조회ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 상품조회ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 관리ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 픽업관리ToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txt_userid;
    }
}