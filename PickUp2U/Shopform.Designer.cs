
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
            this.shop_id = new System.Windows.Forms.Label();
            this.DBGrid = new System.Windows.Forms.DataGridView();
            this.Shop_list = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.Pd_name = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Pd_price = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Pd_stock = new System.Windows.Forms.TextBox();
            this.Pd_id = new System.Windows.Forms.Label();
            this.Pd_addBtn = new System.Windows.Forms.Button();
            this.DBGrid_PD = new System.Windows.Forms.DataGridView();
            this.Pd_Del = new System.Windows.Forms.Button();
            this.Pd_UdBtn = new System.Windows.Forms.Button();
            this.Product_list = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DBGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DBGrid_PD)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 12);
            this.label1.TabIndex = 30;
            this.label1.Text = "매장 이름";
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(124, 24);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(126, 21);
            this.txtid.TabIndex = 33;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 12);
            this.label2.TabIndex = 34;
            this.label2.Text = "매장 주소";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(124, 61);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(126, 21);
            this.txtName.TabIndex = 35;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 36;
            this.label4.Text = "전화번호";
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(124, 99);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(126, 21);
            this.txtNumber.TabIndex = 37;
            // 
            // Shop_addBtn
            // 
            this.Shop_addBtn.Location = new System.Drawing.Point(28, 146);
            this.Shop_addBtn.Name = "Shop_addBtn";
            this.Shop_addBtn.Size = new System.Drawing.Size(102, 39);
            this.Shop_addBtn.TabIndex = 39;
            this.Shop_addBtn.Text = "매장 등록";
            this.Shop_addBtn.UseVisualStyleBackColor = true;
            // 
            // Shop_UdBtn
            // 
            this.Shop_UdBtn.Location = new System.Drawing.Point(148, 146);
            this.Shop_UdBtn.Name = "Shop_UdBtn";
            this.Shop_UdBtn.Size = new System.Drawing.Size(102, 39);
            this.Shop_UdBtn.TabIndex = 40;
            this.Shop_UdBtn.Text = "매장 수정";
            this.Shop_UdBtn.UseVisualStyleBackColor = true;
            // 
            // Shop_DelBtn
            // 
            this.Shop_DelBtn.Location = new System.Drawing.Point(268, 146);
            this.Shop_DelBtn.Name = "Shop_DelBtn";
            this.Shop_DelBtn.Size = new System.Drawing.Size(102, 39);
            this.Shop_DelBtn.TabIndex = 41;
            this.Shop_DelBtn.Text = "매장 삭제";
            this.Shop_DelBtn.UseVisualStyleBackColor = true;
            // 
            // shop_id
            // 
            this.shop_id.AutoSize = true;
            this.shop_id.Location = new System.Drawing.Point(299, 24);
            this.shop_id.Name = "shop_id";
            this.shop_id.Size = new System.Drawing.Size(71, 12);
            this.shop_id.TabIndex = 43;
            this.shop_id.Text = "매장 번호 = ";
            // 
            // DBGrid
            // 
            this.DBGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DBGrid.Location = new System.Drawing.Point(28, 212);
            this.DBGrid.Name = "DBGrid";
            this.DBGrid.RowTemplate.Height = 23;
            this.DBGrid.Size = new System.Drawing.Size(342, 172);
            this.DBGrid.TabIndex = 44;
            // 
            // Shop_list
            // 
            this.Shop_list.Location = new System.Drawing.Point(302, 401);
            this.Shop_list.Name = "Shop_list";
            this.Shop_list.Size = new System.Drawing.Size(68, 25);
            this.Shop_list.TabIndex = 45;
            this.Shop_list.Text = "매장 조회";
            this.Shop_list.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(484, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 12);
            this.label3.TabIndex = 46;
            this.label3.Text = "상품 이름";
            // 
            // Pd_name
            // 
            this.Pd_name.Location = new System.Drawing.Point(558, 24);
            this.Pd_name.Name = "Pd_name";
            this.Pd_name.Size = new System.Drawing.Size(126, 21);
            this.Pd_name.TabIndex = 47;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(484, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 12);
            this.label5.TabIndex = 48;
            this.label5.Text = "상품 가격";
            // 
            // Pd_price
            // 
            this.Pd_price.Location = new System.Drawing.Point(558, 61);
            this.Pd_price.Name = "Pd_price";
            this.Pd_price.Size = new System.Drawing.Size(126, 21);
            this.Pd_price.TabIndex = 49;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(484, 102);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 50;
            this.label6.Text = "재고";
            // 
            // Pd_stock
            // 
            this.Pd_stock.Location = new System.Drawing.Point(558, 99);
            this.Pd_stock.Name = "Pd_stock";
            this.Pd_stock.Size = new System.Drawing.Size(126, 21);
            this.Pd_stock.TabIndex = 51;
            // 
            // Pd_id
            // 
            this.Pd_id.AutoSize = true;
            this.Pd_id.Location = new System.Drawing.Point(299, 108);
            this.Pd_id.Name = "Pd_id";
            this.Pd_id.Size = new System.Drawing.Size(71, 12);
            this.Pd_id.TabIndex = 52;
            this.Pd_id.Text = "상품 번호 = ";
            // 
            // Pd_addBtn
            // 
            this.Pd_addBtn.Location = new System.Drawing.Point(486, 146);
            this.Pd_addBtn.Name = "Pd_addBtn";
            this.Pd_addBtn.Size = new System.Drawing.Size(68, 39);
            this.Pd_addBtn.TabIndex = 53;
            this.Pd_addBtn.Text = "상품 등록";
            this.Pd_addBtn.UseVisualStyleBackColor = true;
            // 
            // DBGrid_PD
            // 
            this.DBGrid_PD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DBGrid_PD.Location = new System.Drawing.Point(486, 212);
            this.DBGrid_PD.Name = "DBGrid_PD";
            this.DBGrid_PD.RowTemplate.Height = 23;
            this.DBGrid_PD.Size = new System.Drawing.Size(276, 172);
            this.DBGrid_PD.TabIndex = 54;
            // 
            // Pd_Del
            // 
            this.Pd_Del.Location = new System.Drawing.Point(694, 146);
            this.Pd_Del.Name = "Pd_Del";
            this.Pd_Del.Size = new System.Drawing.Size(68, 39);
            this.Pd_Del.TabIndex = 55;
            this.Pd_Del.Text = "상품 삭제";
            this.Pd_Del.UseVisualStyleBackColor = true;
            // 
            // Pd_UdBtn
            // 
            this.Pd_UdBtn.Location = new System.Drawing.Point(591, 146);
            this.Pd_UdBtn.Name = "Pd_UdBtn";
            this.Pd_UdBtn.Size = new System.Drawing.Size(68, 39);
            this.Pd_UdBtn.TabIndex = 56;
            this.Pd_UdBtn.Text = "상품 수정";
            this.Pd_UdBtn.UseVisualStyleBackColor = true;
            // 
            // Product_list
            // 
            this.Product_list.Location = new System.Drawing.Point(694, 401);
            this.Product_list.Name = "Product_list";
            this.Product_list.Size = new System.Drawing.Size(68, 25);
            this.Product_list.TabIndex = 57;
            this.Product_list.Text = "상품 조회";
            this.Product_list.UseVisualStyleBackColor = true;
            // 
            // Shopform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Product_list);
            this.Controls.Add(this.Pd_UdBtn);
            this.Controls.Add(this.Pd_Del);
            this.Controls.Add(this.DBGrid_PD);
            this.Controls.Add(this.Pd_addBtn);
            this.Controls.Add(this.Pd_id);
            this.Controls.Add(this.Pd_stock);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Pd_price);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Pd_name);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Shop_list);
            this.Controls.Add(this.DBGrid);
            this.Controls.Add(this.shop_id);
            this.Controls.Add(this.Shop_DelBtn);
            this.Controls.Add(this.Shop_UdBtn);
            this.Controls.Add(this.Shop_addBtn);
            this.Controls.Add(this.txtNumber);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.label1);
            this.Name = "Shopform";
            this.Text = "Shop";
            ((System.ComponentModel.ISupportInitialize)(this.DBGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DBGrid_PD)).EndInit();
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
        private System.Windows.Forms.Label shop_id;
        private System.Windows.Forms.DataGridView DBGrid;
        private System.Windows.Forms.Button Shop_list;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Pd_name;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Pd_price;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Pd_stock;
        private System.Windows.Forms.Label Pd_id;
        private System.Windows.Forms.Button Pd_addBtn;
        private System.Windows.Forms.DataGridView DBGrid_PD;
        private System.Windows.Forms.Button Pd_Del;
        private System.Windows.Forms.Button Pd_UdBtn;
        private System.Windows.Forms.Button Product_list;
    }
}