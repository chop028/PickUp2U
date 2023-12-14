
namespace PickUp2U
{
    partial class ShopOrderHistoryform
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
            this.dataGridViewOrderHistory = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrderHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewOrderHistory
            // 
            this.dataGridViewOrderHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOrderHistory.Location = new System.Drawing.Point(58, 254);
            this.dataGridViewOrderHistory.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dataGridViewOrderHistory.Name = "dataGridViewOrderHistory";
            this.dataGridViewOrderHistory.RowHeadersWidth = 82;
            this.dataGridViewOrderHistory.RowTemplate.Height = 23;
            this.dataGridViewOrderHistory.Size = new System.Drawing.Size(1203, 238);
            this.dataGridViewOrderHistory.TabIndex = 0;
            this.dataGridViewOrderHistory.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewOrderHistory_CellClick_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 204);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "주문 리스트";
            // 
            // ShopOrderHistoryform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1486, 900);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewOrderHistory);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "ShopOrderHistoryform";
            this.Text = "ShopOrderHistoryform";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrderHistory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewOrderHistory;
        private System.Windows.Forms.Label label1;
    }
}