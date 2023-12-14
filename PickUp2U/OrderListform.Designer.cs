
namespace PickUp2U
{
    partial class OrderListform
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
            this.OrderAcceptView = new System.Windows.Forms.DataGridView();
            this.BtnPickupReady = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrderAcceptView)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.OrderAcceptView);
            this.groupBox1.Location = new System.Drawing.Point(48, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1027, 506);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "주문 접수";
            // 
            // OrderAcceptView
            // 
            this.OrderAcceptView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrderAcceptView.Location = new System.Drawing.Point(29, 45);
            this.OrderAcceptView.Name = "OrderAcceptView";
            this.OrderAcceptView.RowHeadersWidth = 82;
            this.OrderAcceptView.RowTemplate.Height = 37;
            this.OrderAcceptView.Size = new System.Drawing.Size(972, 426);
            this.OrderAcceptView.TabIndex = 3;
            // 
            // BtnPickupReady
            // 
            this.BtnPickupReady.Location = new System.Drawing.Point(438, 579);
            this.BtnPickupReady.Name = "BtnPickupReady";
            this.BtnPickupReady.Size = new System.Drawing.Size(250, 70);
            this.BtnPickupReady.TabIndex = 4;
            this.BtnPickupReady.Text = "픽업 준비";
            this.BtnPickupReady.UseVisualStyleBackColor = true;
            // 
            // OrderListform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1140, 692);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BtnPickupReady);
            this.Name = "OrderListform";
            this.Text = "OrderListform";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.OrderAcceptView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView OrderAcceptView;
        private System.Windows.Forms.Button BtnPickupReady;
    }
}