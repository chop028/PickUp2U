
namespace PickUp2U
{
    partial class MainUserform
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
            this.주문하기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.픽업정보ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.주문내역ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txt_userid = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.주문하기ToolStripMenuItem,
            this.픽업정보ToolStripMenuItem,
            this.주문내역ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(11, 4, 0, 4);
            this.menuStrip1.Size = new System.Drawing.Size(1924, 46);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 주문하기ToolStripMenuItem
            // 
            this.주문하기ToolStripMenuItem.Name = "주문하기ToolStripMenuItem";
            this.주문하기ToolStripMenuItem.Size = new System.Drawing.Size(83, 38);
            this.주문하기ToolStripMenuItem.Text = "주문";
            this.주문하기ToolStripMenuItem.Click += new System.EventHandler(this.주문하기ToolStripMenuItem_Click);
            // 
            // 픽업정보ToolStripMenuItem
            // 
            this.픽업정보ToolStripMenuItem.Name = "픽업정보ToolStripMenuItem";
            this.픽업정보ToolStripMenuItem.Size = new System.Drawing.Size(139, 38);
            this.픽업정보ToolStripMenuItem.Text = "픽업 정보";
            this.픽업정보ToolStripMenuItem.Click += new System.EventHandler(this.픽업정보ToolStripMenuItem_Click);
            // 
            // 주문내역ToolStripMenuItem
            // 
            this.주문내역ToolStripMenuItem.Name = "주문내역ToolStripMenuItem";
            this.주문내역ToolStripMenuItem.Size = new System.Drawing.Size(139, 38);
            this.주문내역ToolStripMenuItem.Text = "주문 내역";
            this.주문내역ToolStripMenuItem.Click += new System.EventHandler(this.주문내역ToolStripMenuItem_Click);
            // 
            // txt_userid
            // 
            this.txt_userid.AutoSize = true;
            this.txt_userid.Location = new System.Drawing.Point(1172, 10);
            this.txt_userid.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.txt_userid.Name = "txt_userid";
            this.txt_userid.Size = new System.Drawing.Size(34, 24);
            this.txt_userid.TabIndex = 5;
            this.txt_userid.Text = "[]";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1053, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "회원번호";
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(916, 0);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(128, 44);
            this.btnLogout.TabIndex = 7;
            this.btnLogout.Text = "로그아웃";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // MainUserform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1060);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.txt_userid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "MainUserform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 주문하기ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 픽업정보ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 주문내역ToolStripMenuItem;
        private System.Windows.Forms.Label txt_userid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLogout;
    }
}