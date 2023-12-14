
namespace PickUp2U
{
    partial class Productform
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
            this.Pd_UdBtn = new System.Windows.Forms.Button();
            this.Pd_Del = new System.Windows.Forms.Button();
            this.DBGrid_PD = new System.Windows.Forms.DataGridView();
            this.Pd_addBtn = new System.Windows.Forms.Button();
            this.Pd_price = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Pd_name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Pd_stock = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Pd_id = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pd_shop = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DBGrid_PD)).BeginInit();
            this.SuspendLayout();
            // 
            // Pd_UdBtn
            // 
            this.Pd_UdBtn.Location = new System.Drawing.Point(390, 326);
            this.Pd_UdBtn.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Pd_UdBtn.Name = "Pd_UdBtn";
            this.Pd_UdBtn.Size = new System.Drawing.Size(126, 78);
            this.Pd_UdBtn.TabIndex = 67;
            this.Pd_UdBtn.Text = "상품 수정";
            this.Pd_UdBtn.UseVisualStyleBackColor = true;
            // 
            // Pd_Del
            // 
            this.Pd_Del.Location = new System.Drawing.Point(425, 766);
            this.Pd_Del.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Pd_Del.Name = "Pd_Del";
            this.Pd_Del.Size = new System.Drawing.Size(126, 42);
            this.Pd_Del.TabIndex = 66;
            this.Pd_Del.Text = "상품 삭제";
            this.Pd_Del.UseVisualStyleBackColor = true;
            this.Pd_Del.Click += new System.EventHandler(this.Pd_Del_Click);
            // 
            // DBGrid_PD
            // 
            this.DBGrid_PD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DBGrid_PD.Location = new System.Drawing.Point(87, 438);
            this.DBGrid_PD.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.DBGrid_PD.Name = "DBGrid_PD";
            this.DBGrid_PD.RowHeadersWidth = 82;
            this.DBGrid_PD.RowTemplate.Height = 23;
            this.DBGrid_PD.Size = new System.Drawing.Size(513, 288);
            this.DBGrid_PD.TabIndex = 65;
            this.DBGrid_PD.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DBGrid_PD_CellContentClick);
            // 
            // Pd_addBtn
            // 
            this.Pd_addBtn.Location = new System.Drawing.Point(173, 326);
            this.Pd_addBtn.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Pd_addBtn.Name = "Pd_addBtn";
            this.Pd_addBtn.Size = new System.Drawing.Size(126, 78);
            this.Pd_addBtn.TabIndex = 64;
            this.Pd_addBtn.Text = "상품 등록";
            this.Pd_addBtn.UseVisualStyleBackColor = true;
            this.Pd_addBtn.Click += new System.EventHandler(this.Pd_addBtn_Click);
            // 
            // Pd_price
            // 
            this.Pd_price.Location = new System.Drawing.Point(282, 170);
            this.Pd_price.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Pd_price.Name = "Pd_price";
            this.Pd_price.Size = new System.Drawing.Size(231, 35);
            this.Pd_price.TabIndex = 61;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(84, 176);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 24);
            this.label5.TabIndex = 60;
            this.label5.Text = "상품 가격";
            // 
            // Pd_name
            // 
            this.Pd_name.Location = new System.Drawing.Point(282, 96);
            this.Pd_name.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Pd_name.Name = "Pd_name";
            this.Pd_name.Size = new System.Drawing.Size(231, 35);
            this.Pd_name.TabIndex = 59;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(84, 102);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 24);
            this.label3.TabIndex = 58;
            this.label3.Text = "상품 이름";
            // 
            // Pd_stock
            // 
            this.Pd_stock.Location = new System.Drawing.Point(282, 246);
            this.Pd_stock.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Pd_stock.Name = "Pd_stock";
            this.Pd_stock.Size = new System.Drawing.Size(231, 35);
            this.Pd_stock.TabIndex = 63;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(84, 252);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 24);
            this.label6.TabIndex = 62;
            this.label6.Text = "재고";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 772);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 24);
            this.label1.TabIndex = 62;
            this.label1.Text = "제품 번호";
            // 
            // Pd_id
            // 
            this.Pd_id.Location = new System.Drawing.Point(184, 766);
            this.Pd_id.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Pd_id.Name = "Pd_id";
            this.Pd_id.Size = new System.Drawing.Size(197, 35);
            this.Pd_id.TabIndex = 63;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(84, 34);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 24);
            this.label2.TabIndex = 58;
            this.label2.Text = "매장 ID";
            // 
            // pd_shop
            // 
            this.pd_shop.Location = new System.Drawing.Point(282, 28);
            this.pd_shop.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.pd_shop.Name = "pd_shop";
            this.pd_shop.Size = new System.Drawing.Size(231, 35);
            this.pd_shop.TabIndex = 59;
            // 
            // Productform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 854);
            this.Controls.Add(this.Pd_UdBtn);
            this.Controls.Add(this.Pd_Del);
            this.Controls.Add(this.DBGrid_PD);
            this.Controls.Add(this.Pd_addBtn);
            this.Controls.Add(this.Pd_id);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Pd_stock);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Pd_price);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pd_shop);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Pd_name);
            this.Controls.Add(this.label3);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Productform";
            this.Text = "Productform";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Productform_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DBGrid_PD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Pd_UdBtn;
        private System.Windows.Forms.Button Pd_Del;
        private System.Windows.Forms.DataGridView DBGrid_PD;
        private System.Windows.Forms.Button Pd_addBtn;
        private System.Windows.Forms.TextBox Pd_price;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Pd_name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Pd_stock;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Pd_id;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox pd_shop;
    }
}