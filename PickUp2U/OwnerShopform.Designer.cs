
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Btninquiry = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listViewOwnerShops
            // 
            this.listViewOwnerShops.HideSelection = false;
            this.listViewOwnerShops.Location = new System.Drawing.Point(29, 50);
            this.listViewOwnerShops.Name = "listViewOwnerShops";
            this.listViewOwnerShops.Size = new System.Drawing.Size(832, 232);
            this.listViewOwnerShops.TabIndex = 0;
            this.listViewOwnerShops.UseCompatibleStateImageBehavior = false;
            this.listViewOwnerShops.View = System.Windows.Forms.View.Details;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listViewOwnerShops);
            this.groupBox1.Location = new System.Drawing.Point(40, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(886, 318);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "보유 매장";
            // 
            // Btninquiry
            // 
            this.Btninquiry.Location = new System.Drawing.Point(421, 370);
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
            this.ClientSize = new System.Drawing.Size(968, 546);
            this.Controls.Add(this.Btninquiry);
            this.Controls.Add(this.groupBox1);
            this.Name = "OwnerShopform";
            this.Text = "OwnerShopform";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewOwnerShops;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Btninquiry;
    }
}