
namespace PickUp2U
{
    partial class UserOrderHistoryform
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
            this.dataGridViewUserHistory = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUserHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 220);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "주문 리스트";
            // 
            // dataGridViewUserHistory
            // 
            this.dataGridViewUserHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUserHistory.Location = new System.Drawing.Point(71, 280);
            this.dataGridViewUserHistory.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dataGridViewUserHistory.Name = "dataGridViewUserHistory";
            this.dataGridViewUserHistory.RowHeadersWidth = 82;
            this.dataGridViewUserHistory.RowTemplate.Height = 23;
            this.dataGridViewUserHistory.Size = new System.Drawing.Size(1203, 238);
            this.dataGridViewUserHistory.TabIndex = 2;
            this.dataGridViewUserHistory.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewUserHistory_CellClick);
            // 
            // UserOrderHistoryform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1486, 900);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewUserHistory);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "UserOrderHistoryform";
            this.Text = "UserOrderHistoryform";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUserHistory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewUserHistory;
    }
}