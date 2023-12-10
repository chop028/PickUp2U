
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
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.OrderAcceptView = new System.Windows.Forms.DataGridView();
            this.BtnOrderReady = new System.Windows.Forms.Button();
            this.BtnPickupReady = new System.Windows.Forms.Button();
            this.BtnPickupFin = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrderAcceptView)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.OrderAcceptView);
            this.groupBox1.Controls.Add(this.numericUpDown1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(48, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1027, 578);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "주문 접수";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(394, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "예상 시간";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(525, 62);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 35);
            this.numericUpDown1.TabIndex = 2;
            // 
            // OrderAcceptView
            // 
            this.OrderAcceptView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrderAcceptView.Location = new System.Drawing.Point(29, 127);
            this.OrderAcceptView.Name = "OrderAcceptView";
            this.OrderAcceptView.RowHeadersWidth = 82;
            this.OrderAcceptView.RowTemplate.Height = 37;
            this.OrderAcceptView.Size = new System.Drawing.Size(972, 426);
            this.OrderAcceptView.TabIndex = 3;
            // 
            // BtnOrderReady
            // 
            this.BtnOrderReady.Location = new System.Drawing.Point(77, 665);
            this.BtnOrderReady.Name = "BtnOrderReady";
            this.BtnOrderReady.Size = new System.Drawing.Size(250, 70);
            this.BtnOrderReady.TabIndex = 4;
            this.BtnOrderReady.Text = "상품 준비";
            this.BtnOrderReady.UseVisualStyleBackColor = true;
            this.BtnOrderReady.Click += new System.EventHandler(this.BtnOrderReady_Click);
            // 
            // BtnPickupReady
            // 
            this.BtnPickupReady.Location = new System.Drawing.Point(443, 665);
            this.BtnPickupReady.Name = "BtnPickupReady";
            this.BtnPickupReady.Size = new System.Drawing.Size(250, 70);
            this.BtnPickupReady.TabIndex = 4;
            this.BtnPickupReady.Text = "픽업 준비";
            this.BtnPickupReady.UseVisualStyleBackColor = true;
            this.BtnPickupReady.Click += new System.EventHandler(this.BtnPickupReady_Click);
            // 
            // BtnPickupFin
            // 
            this.BtnPickupFin.Location = new System.Drawing.Point(799, 665);
            this.BtnPickupFin.Name = "BtnPickupFin";
            this.BtnPickupFin.Size = new System.Drawing.Size(250, 70);
            this.BtnPickupFin.TabIndex = 4;
            this.BtnPickupFin.Text = "픽업 완료";
            this.BtnPickupFin.UseVisualStyleBackColor = true;
            this.BtnPickupFin.Click += new System.EventHandler(this.BtnPickupFin_Click);
            // 
            // OrderListform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1140, 772);
            this.Controls.Add(this.BtnPickupFin);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BtnPickupReady);
            this.Controls.Add(this.BtnOrderReady);
            this.Name = "OrderListform";
            this.Text = "OrderListform";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrderAcceptView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView OrderAcceptView;
        private System.Windows.Forms.Button BtnOrderReady;
        private System.Windows.Forms.Button BtnPickupReady;
        private System.Windows.Forms.Button BtnPickupFin;
    }
}