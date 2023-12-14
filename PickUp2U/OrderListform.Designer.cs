
namespace PickUp2U
{
    partial class OrderListForm
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
            this.OrderView = new System.Windows.Forms.DataGridView();
            this.BtnPickupReady = new System.Windows.Forms.Button();
            this.BtnOderView = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrderView)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.OrderView);
            this.groupBox1.Location = new System.Drawing.Point(48, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1027, 506);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "주문 접수";
            // 
            // OrderView
            // 
            this.OrderView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrderView.Location = new System.Drawing.Point(29, 45);
            this.OrderView.Name = "OrderView";
            this.OrderView.RowHeadersWidth = 82;
            this.OrderView.RowTemplate.Height = 37;
            this.OrderView.Size = new System.Drawing.Size(972, 426);
            this.OrderView.TabIndex = 3;
            // 
            // BtnPickupReady
            // 
            this.BtnPickupReady.Location = new System.Drawing.Point(237, 579);
            this.BtnPickupReady.Name = "BtnPickupReady";
            this.BtnPickupReady.Size = new System.Drawing.Size(250, 70);
            this.BtnPickupReady.TabIndex = 4;
            this.BtnPickupReady.Text = "픽업 준비";
            this.BtnPickupReady.UseVisualStyleBackColor = true;
            // 
            // BtnOderView
            // 
            this.BtnOderView.Location = new System.Drawing.Point(667, 579);
            this.BtnOderView.Name = "BtnOderView";
            this.BtnOderView.Size = new System.Drawing.Size(250, 70);
            this.BtnOderView.TabIndex = 4;
            this.BtnOderView.Text = "주문 보기";
            this.BtnOderView.UseVisualStyleBackColor = true;
            this.BtnOderView.Click += new System.EventHandler(this.BtnOrderView_Click);
            // 
            // OrderListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1140, 692);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BtnOderView);
            this.Controls.Add(this.BtnPickupReady);
            this.Name = "OrderListForm";
            this.Text = "OrderListform";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.OrderView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView OrderView;
        private System.Windows.Forms.Button BtnPickupReady;
        private System.Windows.Forms.Button BtnOderView;
    }
}