
namespace PickUp2U
{
    partial class Shopform
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.Shop_addBtn = new System.Windows.Forms.Button();
            this.Shop_UdBtn = new System.Windows.Forms.Button();
            this.Shop_DelBtn = new System.Windows.Forms.Button();
            this.DBGrid = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.shop_id = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DBGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 12);
            this.label1.TabIndex = 30;
            this.label1.Text = "매장 이름";
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(169, 25);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(126, 21);
            this.txtid.TabIndex = 33;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(84, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 12);
            this.label2.TabIndex = 34;
            this.label2.Text = "매장 주소";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(169, 62);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(126, 21);
            this.txtName.TabIndex = 35;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(84, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 36;
            this.label4.Text = "전화번호";
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(169, 100);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(126, 21);
            this.txtNumber.TabIndex = 37;
            // 
            // Shop_addBtn
            // 
            this.Shop_addBtn.Location = new System.Drawing.Point(96, 149);
            this.Shop_addBtn.Name = "Shop_addBtn";
            this.Shop_addBtn.Size = new System.Drawing.Size(102, 39);
            this.Shop_addBtn.TabIndex = 39;
            this.Shop_addBtn.Text = "매장 등록";
            this.Shop_addBtn.UseVisualStyleBackColor = true;
            this.Shop_addBtn.Click += new System.EventHandler(this.Shop_addBtn_Click);
            // 
            // Shop_UdBtn
            // 
            this.Shop_UdBtn.Location = new System.Drawing.Point(241, 149);
            this.Shop_UdBtn.Name = "Shop_UdBtn";
            this.Shop_UdBtn.Size = new System.Drawing.Size(102, 39);
            this.Shop_UdBtn.TabIndex = 40;
            this.Shop_UdBtn.Text = "매장 수정";
            this.Shop_UdBtn.UseVisualStyleBackColor = true;
            this.Shop_UdBtn.Click += new System.EventHandler(this.Shop_UdBtn_Click);
            // 
            // Shop_DelBtn
            // 
            this.Shop_DelBtn.Location = new System.Drawing.Point(273, 404);
            this.Shop_DelBtn.Name = "Shop_DelBtn";
            this.Shop_DelBtn.Size = new System.Drawing.Size(102, 25);
            this.Shop_DelBtn.TabIndex = 41;
            this.Shop_DelBtn.Text = "매장 삭제";
            this.Shop_DelBtn.UseVisualStyleBackColor = true;
            this.Shop_DelBtn.Click += new System.EventHandler(this.Shop_DelBtn_Click);
            // 
            // DBGrid
            // 
            this.DBGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DBGrid.Location = new System.Drawing.Point(45, 215);
            this.DBGrid.Name = "DBGrid";
            this.DBGrid.RowTemplate.Height = 23;
            this.DBGrid.Size = new System.Drawing.Size(342, 172);
            this.DBGrid.TabIndex = 44;
            this.DBGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DBGrid_CellClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(56, 407);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 36;
            this.label7.Text = "매장번호";
            // 
            // shop_id
            // 
            this.shop_id.Location = new System.Drawing.Point(126, 404);
            this.shop_id.Name = "shop_id";
            this.shop_id.Size = new System.Drawing.Size(126, 21);
            this.shop_id.TabIndex = 37;
            // 
            // Shopform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 458);
            this.Controls.Add(this.DBGrid);
            this.Controls.Add(this.Shop_DelBtn);
            this.Controls.Add(this.Shop_UdBtn);
            this.Controls.Add(this.Shop_addBtn);
            this.Controls.Add(this.shop_id);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtNumber);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.label1);
            this.Name = "Shopform";
            this.Text = "Shop";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Shopform_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DBGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.Button Shop_addBtn;
        private System.Windows.Forms.Button Shop_UdBtn;
        private System.Windows.Forms.Button Shop_DelBtn;
        private System.Windows.Forms.DataGridView DBGrid;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox shop_id;
    }
}