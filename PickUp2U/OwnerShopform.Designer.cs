
namespace PickUp2U
{
    partial class OwnerShopform
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
            this.listViewOwnerShops = new System.Windows.Forms.ListView();
            this.매장ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.매장명 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.전화번호 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.매장주소 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtShopId = new System.Windows.Forms.TextBox();
            this.txtShopName = new System.Windows.Forms.TextBox();
            this.txtTelephone = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Btninquiry = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listViewOwnerShops
            // 
            this.listViewOwnerShops.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.매장ID,
            this.매장명,
            this.전화번호,
            this.매장주소});
            this.listViewOwnerShops.HideSelection = false;
            this.listViewOwnerShops.Location = new System.Drawing.Point(28, 46);
            this.listViewOwnerShops.Name = "listViewOwnerShops";
            this.listViewOwnerShops.Size = new System.Drawing.Size(832, 232);
            this.listViewOwnerShops.TabIndex = 0;
            this.listViewOwnerShops.UseCompatibleStateImageBehavior = false;
            this.listViewOwnerShops.View = System.Windows.Forms.View.Details;
            // 
            // 매장ID
            // 
            this.매장ID.Text = "매장ID";
            this.매장ID.Width = 96;
            // 
            // 매장명
            // 
            this.매장명.Text = "매장명";
            this.매장명.Width = 174;
            // 
            // 전화번호
            // 
            this.전화번호.Text = "전화번호";
            this.전화번호.Width = 198;
            // 
            // 매장주소
            // 
            this.매장주소.Text = "매장주소";
            this.매장주소.Width = 306;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listViewOwnerShops);
            this.groupBox1.Location = new System.Drawing.Point(40, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(886, 300);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "보유 매장";
            // 
            // txtShopId
            // 
            this.txtShopId.Location = new System.Drawing.Point(278, 377);
            this.txtShopId.Name = "txtShopId";
            this.txtShopId.ReadOnly = true;
            this.txtShopId.Size = new System.Drawing.Size(354, 35);
            this.txtShopId.TabIndex = 6;
            // 
            // txtShopName
            // 
            this.txtShopName.Location = new System.Drawing.Point(278, 443);
            this.txtShopName.Name = "txtShopName";
            this.txtShopName.ReadOnly = true;
            this.txtShopName.Size = new System.Drawing.Size(354, 35);
            this.txtShopName.TabIndex = 6;
            // 
            // txtTelephone
            // 
            this.txtTelephone.Location = new System.Drawing.Point(278, 509);
            this.txtTelephone.Name = "txtTelephone";
            this.txtTelephone.ReadOnly = true;
            this.txtTelephone.Size = new System.Drawing.Size(354, 35);
            this.txtTelephone.TabIndex = 6;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(278, 577);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.ReadOnly = true;
            this.txtAddress.Size = new System.Drawing.Size(354, 35);
            this.txtAddress.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(95, 388);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "[매장ID]";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(95, 446);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 24);
            this.label3.TabIndex = 7;
            this.label3.Text = "[매장명]";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(95, 512);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 24);
            this.label4.TabIndex = 7;
            this.label4.Text = "[전화번호]";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(95, 580);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 24);
            this.label5.TabIndex = 7;
            this.label5.Text = "[매장주소]";
            // 
            // Btninquiry
            // 
            this.Btninquiry.Location = new System.Drawing.Point(776, 364);
            this.Btninquiry.Name = "Btninquiry";
            this.Btninquiry.Size = new System.Drawing.Size(124, 57);
            this.Btninquiry.TabIndex = 8;
            this.Btninquiry.Text = "조회";
            this.Btninquiry.UseVisualStyleBackColor = true;
            this.Btninquiry.Click += new System.EventHandler(this.Btninquiry_Click);
            // 
            // OwnerShopform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1140, 872);
            this.Controls.Add(this.Btninquiry);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtTelephone);
            this.Controls.Add(this.txtShopName);
            this.Controls.Add(this.txtShopId);
            this.Controls.Add(this.groupBox1);
            this.Name = "OwnerShopform";
            this.Text = "OwnerShopform";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewOwnerShops;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtShopId;
        private System.Windows.Forms.TextBox txtShopName;
        private System.Windows.Forms.TextBox txtTelephone;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ColumnHeader 매장ID;
        private System.Windows.Forms.ColumnHeader 매장명;
        private System.Windows.Forms.ColumnHeader 전화번호;
        private System.Windows.Forms.ColumnHeader 매장주소;
        private System.Windows.Forms.Button Btninquiry;
    }
}