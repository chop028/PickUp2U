
namespace PickUp2U
{
    partial class Searchform
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.sc_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.sc_item = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.sc_hold = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.sc_Pdlist = new System.Windows.Forms.Button();
            this.sc_list = new System.Windows.Forms.DataGridView();
            this.sc_in = new System.Windows.Forms.Button();
            this.sc_Productid = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button1sa = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.sc_clear = new System.Windows.Forms.Button();
            this.sc_basket = new System.Windows.Forms.ListBox();
            this.sc_total = new System.Windows.Forms.Label();
            this.sc_pay = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sc_hold)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sc_list)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.sc_btn);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.sc_item);
            this.groupBox1.Location = new System.Drawing.Point(43, 41);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(410, 50);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "상품검색";
            // 
            // sc_btn
            // 
            this.sc_btn.Location = new System.Drawing.Point(316, 18);
            this.sc_btn.Margin = new System.Windows.Forms.Padding(2);
            this.sc_btn.Name = "sc_btn";
            this.sc_btn.Size = new System.Drawing.Size(81, 19);
            this.sc_btn.TabIndex = 2;
            this.sc_btn.Text = "조회";
            this.sc_btn.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "상품명";
            // 
            // sc_item
            // 
            this.sc_item.Location = new System.Drawing.Point(104, 19);
            this.sc_item.Margin = new System.Windows.Forms.Padding(2);
            this.sc_item.Name = "sc_item";
            this.sc_item.Size = new System.Drawing.Size(189, 21);
            this.sc_item.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 110);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 12);
            this.label2.TabIndex = 20;
            this.label2.Text = "상품보유 매장";
            // 
            // sc_hold
            // 
            this.sc_hold.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sc_hold.Location = new System.Drawing.Point(43, 134);
            this.sc_hold.Margin = new System.Windows.Forms.Padding(2);
            this.sc_hold.Name = "sc_hold";
            this.sc_hold.RowHeadersWidth = 82;
            this.sc_hold.RowTemplate.Height = 37;
            this.sc_hold.Size = new System.Drawing.Size(410, 154);
            this.sc_hold.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 306);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 12);
            this.label3.TabIndex = 22;
            this.label3.Text = "상품 목록";
            // 
            // sc_Pdlist
            // 
            this.sc_Pdlist.Location = new System.Drawing.Point(401, 300);
            this.sc_Pdlist.Margin = new System.Windows.Forms.Padding(2);
            this.sc_Pdlist.Name = "sc_Pdlist";
            this.sc_Pdlist.Size = new System.Drawing.Size(52, 24);
            this.sc_Pdlist.TabIndex = 23;
            this.sc_Pdlist.Text = "조회";
            this.sc_Pdlist.UseVisualStyleBackColor = true;
            this.sc_Pdlist.Click += new System.EventHandler(this.sc_Pdlist_Click);
            // 
            // sc_list
            // 
            this.sc_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sc_list.Location = new System.Drawing.Point(43, 328);
            this.sc_list.Margin = new System.Windows.Forms.Padding(2);
            this.sc_list.Name = "sc_list";
            this.sc_list.RowHeadersWidth = 82;
            this.sc_list.RowTemplate.Height = 37;
            this.sc_list.Size = new System.Drawing.Size(410, 140);
            this.sc_list.TabIndex = 24;
            // 
            // sc_in
            // 
            this.sc_in.Location = new System.Drawing.Point(201, 485);
            this.sc_in.Margin = new System.Windows.Forms.Padding(2);
            this.sc_in.Name = "sc_in";
            this.sc_in.Size = new System.Drawing.Size(96, 22);
            this.sc_in.TabIndex = 25;
            this.sc_in.Text = "담기";
            this.sc_in.UseVisualStyleBackColor = true;
            // 
            // sc_Productid
            // 
            this.sc_Productid.AutoSize = true;
            this.sc_Productid.Location = new System.Drawing.Point(558, 41);
            this.sc_Productid.Name = "sc_Productid";
            this.sc_Productid.Size = new System.Drawing.Size(88, 12);
            this.sc_Productid.TabIndex = 28;
            this.sc_Productid.Text = "PRODUCTID = ";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Location = new System.Drawing.Point(652, 3);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(286, 88);
            this.listBox1.TabIndex = 29;
            // 
            // button1sa
            // 
            this.button1sa.Location = new System.Drawing.Point(943, 37);
            this.button1sa.Margin = new System.Windows.Forms.Padding(2);
            this.button1sa.Name = "button1sa";
            this.button1sa.Size = new System.Drawing.Size(51, 20);
            this.button1sa.TabIndex = 30;
            this.button1sa.Text = "상품삭제";
            this.button1sa.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(558, 110);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 12);
            this.label4.TabIndex = 31;
            this.label4.Text = "담긴 상품";
            // 
            // sc_clear
            // 
            this.sc_clear.Location = new System.Drawing.Point(874, 110);
            this.sc_clear.Margin = new System.Windows.Forms.Padding(2);
            this.sc_clear.Name = "sc_clear";
            this.sc_clear.Size = new System.Drawing.Size(99, 20);
            this.sc_clear.TabIndex = 32;
            this.sc_clear.Text = "상품삭제";
            this.sc_clear.UseVisualStyleBackColor = true;
            // 
            // sc_basket
            // 
            this.sc_basket.FormattingEnabled = true;
            this.sc_basket.ItemHeight = 12;
            this.sc_basket.Location = new System.Drawing.Point(560, 150);
            this.sc_basket.Name = "sc_basket";
            this.sc_basket.Size = new System.Drawing.Size(413, 196);
            this.sc_basket.TabIndex = 33;
            // 
            // sc_total
            // 
            this.sc_total.AutoSize = true;
            this.sc_total.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.sc_total.Location = new System.Drawing.Point(559, 361);
            this.sc_total.Name = "sc_total";
            this.sc_total.Size = new System.Drawing.Size(114, 24);
            this.sc_total.TabIndex = 34;
            this.sc_total.Text = "총 금액 : ";
            // 
            // sc_pay
            // 
            this.sc_pay.Location = new System.Drawing.Point(605, 446);
            this.sc_pay.Margin = new System.Windows.Forms.Padding(2);
            this.sc_pay.Name = "sc_pay";
            this.sc_pay.Size = new System.Drawing.Size(126, 22);
            this.sc_pay.TabIndex = 35;
            this.sc_pay.Text = "현장 결제";
            this.sc_pay.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(792, 446);
            this.button7.Margin = new System.Windows.Forms.Padding(2);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(126, 22);
            this.button7.TabIndex = 36;
            this.button7.Text = "즉시 결제";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // Searchform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1013, 647);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.sc_pay);
            this.Controls.Add(this.sc_total);
            this.Controls.Add(this.sc_basket);
            this.Controls.Add(this.sc_clear);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1sa);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.sc_Productid);
            this.Controls.Add(this.sc_in);
            this.Controls.Add(this.sc_list);
            this.Controls.Add(this.sc_Pdlist);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.sc_hold);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Searchform";
            this.Text = "Search";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sc_hold)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sc_list)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button sc_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox sc_item;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView sc_hold;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button sc_Pdlist;
        private System.Windows.Forms.DataGridView sc_list;
        private System.Windows.Forms.Button sc_in;
        private System.Windows.Forms.Label sc_Productid;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button1sa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button sc_clear;
        private System.Windows.Forms.ListBox sc_basket;
        private System.Windows.Forms.Label sc_total;
        private System.Windows.Forms.Button sc_pay;
        private System.Windows.Forms.Button button7;
    }
}