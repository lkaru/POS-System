namespace POS_System
{
    partial class Main
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.LBL_Title = new System.Windows.Forms.Label();
            this.DGV = new System.Windows.Forms.DataGridView();
            this.BTN_SalesHistory = new System.Windows.Forms.Button();
            this.BTN_StockStatus = new System.Windows.Forms.Button();
            this.LBL_TradeName = new System.Windows.Forms.Label();
            this.TBX_TradeName = new System.Windows.Forms.TextBox();
            this.TBX_Price = new System.Windows.Forms.TextBox();
            this.LBL_Price = new System.Windows.Forms.Label();
            this.LBL_Count = new System.Windows.Forms.Label();
            this.TBX_Total = new System.Windows.Forms.TextBox();
            this.LBL_Total = new System.Windows.Forms.Label();
            this.NUD_Count = new System.Windows.Forms.NumericUpDown();
            this.LBL_Connectivity = new System.Windows.Forms.Label();
            this.BTN_Cancel = new System.Windows.Forms.Button();
            this.BTN_Putting = new System.Windows.Forms.Button();
            this.BTN_Calulate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Count)).BeginInit();
            this.SuspendLayout();
            // 
            // LBL_Title
            // 
            this.LBL_Title.AutoSize = true;
            this.LBL_Title.Font = new System.Drawing.Font("맑은 고딕", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.LBL_Title.Location = new System.Drawing.Point(12, 21);
            this.LBL_Title.Name = "LBL_Title";
            this.LBL_Title.Size = new System.Drawing.Size(197, 54);
            this.LBL_Title.TabIndex = 0;
            this.LBL_Title.Text = "상품 판매";
            // 
            // DGV
            // 
            this.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV.Location = new System.Drawing.Point(21, 88);
            this.DGV.Name = "DGV";
            this.DGV.RowHeadersWidth = 62;
            this.DGV.RowTemplate.Height = 30;
            this.DGV.Size = new System.Drawing.Size(649, 376);
            this.DGV.TabIndex = 1;
            // 
            // BTN_SalesHistory
            // 
            this.BTN_SalesHistory.Location = new System.Drawing.Point(22, 483);
            this.BTN_SalesHistory.Name = "BTN_SalesHistory";
            this.BTN_SalesHistory.Size = new System.Drawing.Size(150, 35);
            this.BTN_SalesHistory.TabIndex = 2;
            this.BTN_SalesHistory.Text = "판매 내역";
            this.BTN_SalesHistory.UseVisualStyleBackColor = true;
            // 
            // BTN_StockStatus
            // 
            this.BTN_StockStatus.Location = new System.Drawing.Point(178, 483);
            this.BTN_StockStatus.Name = "BTN_StockStatus";
            this.BTN_StockStatus.Size = new System.Drawing.Size(150, 35);
            this.BTN_StockStatus.TabIndex = 4;
            this.BTN_StockStatus.Text = "재고 현황";
            this.BTN_StockStatus.UseVisualStyleBackColor = true;
            // 
            // LBL_TradeName
            // 
            this.LBL_TradeName.AutoSize = true;
            this.LBL_TradeName.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.LBL_TradeName.Location = new System.Drawing.Point(676, 87);
            this.LBL_TradeName.Name = "LBL_TradeName";
            this.LBL_TradeName.Size = new System.Drawing.Size(66, 25);
            this.LBL_TradeName.TabIndex = 5;
            this.LBL_TradeName.Text = "상품명";
            // 
            // TBX_TradeName
            // 
            this.TBX_TradeName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TBX_TradeName.Location = new System.Drawing.Point(681, 115);
            this.TBX_TradeName.Name = "TBX_TradeName";
            this.TBX_TradeName.Size = new System.Drawing.Size(132, 28);
            this.TBX_TradeName.TabIndex = 6;
            // 
            // TBX_Price
            // 
            this.TBX_Price.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TBX_Price.Location = new System.Drawing.Point(681, 178);
            this.TBX_Price.Name = "TBX_Price";
            this.TBX_Price.Size = new System.Drawing.Size(132, 28);
            this.TBX_Price.TabIndex = 8;
            // 
            // LBL_Price
            // 
            this.LBL_Price.AutoSize = true;
            this.LBL_Price.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.LBL_Price.Location = new System.Drawing.Point(676, 150);
            this.LBL_Price.Name = "LBL_Price";
            this.LBL_Price.Size = new System.Drawing.Size(48, 25);
            this.LBL_Price.TabIndex = 7;
            this.LBL_Price.Text = "가격";
            // 
            // LBL_Count
            // 
            this.LBL_Count.AutoSize = true;
            this.LBL_Count.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.LBL_Count.Location = new System.Drawing.Point(676, 212);
            this.LBL_Count.Name = "LBL_Count";
            this.LBL_Count.Size = new System.Drawing.Size(48, 25);
            this.LBL_Count.TabIndex = 9;
            this.LBL_Count.Text = "개수";
            // 
            // TBX_Total
            // 
            this.TBX_Total.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TBX_Total.Location = new System.Drawing.Point(681, 302);
            this.TBX_Total.Name = "TBX_Total";
            this.TBX_Total.Size = new System.Drawing.Size(132, 28);
            this.TBX_Total.TabIndex = 12;
            // 
            // LBL_Total
            // 
            this.LBL_Total.AutoSize = true;
            this.LBL_Total.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.LBL_Total.Location = new System.Drawing.Point(676, 274);
            this.LBL_Total.Name = "LBL_Total";
            this.LBL_Total.Size = new System.Drawing.Size(48, 25);
            this.LBL_Total.TabIndex = 11;
            this.LBL_Total.Text = "합계";
            // 
            // NUD_Count
            // 
            this.NUD_Count.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NUD_Count.Location = new System.Drawing.Point(681, 240);
            this.NUD_Count.Name = "NUD_Count";
            this.NUD_Count.Size = new System.Drawing.Size(132, 28);
            this.NUD_Count.TabIndex = 13;
            // 
            // LBL_Connectivity
            // 
            this.LBL_Connectivity.Location = new System.Drawing.Point(632, 495);
            this.LBL_Connectivity.Name = "LBL_Connectivity";
            this.LBL_Connectivity.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LBL_Connectivity.Size = new System.Drawing.Size(181, 23);
            this.LBL_Connectivity.TabIndex = 14;
            this.LBL_Connectivity.Text = "Server";
            this.LBL_Connectivity.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // BTN_Cancel
            // 
            this.BTN_Cancel.Location = new System.Drawing.Point(681, 361);
            this.BTN_Cancel.Name = "BTN_Cancel";
            this.BTN_Cancel.Size = new System.Drawing.Size(132, 30);
            this.BTN_Cancel.TabIndex = 15;
            this.BTN_Cancel.Text = "취소";
            this.BTN_Cancel.UseVisualStyleBackColor = true;
            this.BTN_Cancel.Click += new System.EventHandler(this.BTN_Cancel_Click);
            // 
            // BTN_Putting
            // 
            this.BTN_Putting.Location = new System.Drawing.Point(681, 397);
            this.BTN_Putting.Name = "BTN_Putting";
            this.BTN_Putting.Size = new System.Drawing.Size(132, 30);
            this.BTN_Putting.TabIndex = 16;
            this.BTN_Putting.Text = "담기";
            this.BTN_Putting.UseVisualStyleBackColor = true;
            this.BTN_Putting.Click += new System.EventHandler(this.BTN_Putting_Click);
            // 
            // BTN_Calulate
            // 
            this.BTN_Calulate.Location = new System.Drawing.Point(681, 433);
            this.BTN_Calulate.Name = "BTN_Calulate";
            this.BTN_Calulate.Size = new System.Drawing.Size(132, 30);
            this.BTN_Calulate.TabIndex = 17;
            this.BTN_Calulate.Text = "계산";
            this.BTN_Calulate.UseVisualStyleBackColor = true;
            this.BTN_Calulate.Click += new System.EventHandler(this.BTN_Calulate_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(841, 529);
            this.Controls.Add(this.BTN_Calulate);
            this.Controls.Add(this.BTN_Putting);
            this.Controls.Add(this.BTN_Cancel);
            this.Controls.Add(this.LBL_Connectivity);
            this.Controls.Add(this.NUD_Count);
            this.Controls.Add(this.TBX_Total);
            this.Controls.Add(this.LBL_Total);
            this.Controls.Add(this.LBL_Count);
            this.Controls.Add(this.TBX_Price);
            this.Controls.Add(this.LBL_Price);
            this.Controls.Add(this.TBX_TradeName);
            this.Controls.Add(this.LBL_TradeName);
            this.Controls.Add(this.BTN_StockStatus);
            this.Controls.Add(this.BTN_SalesHistory);
            this.Controls.Add(this.DGV);
            this.Controls.Add(this.LBL_Title);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Text = "POS System";
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Count)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBL_Title;
        private System.Windows.Forms.DataGridView DGV;
        private System.Windows.Forms.Button BTN_SalesHistory;
        private System.Windows.Forms.Button BTN_StockStatus;
        private System.Windows.Forms.Label LBL_TradeName;
        private System.Windows.Forms.TextBox TBX_TradeName;
        private System.Windows.Forms.TextBox TBX_Price;
        private System.Windows.Forms.Label LBL_Price;
        private System.Windows.Forms.Label LBL_Count;
        private System.Windows.Forms.TextBox TBX_Total;
        private System.Windows.Forms.Label LBL_Total;
        private System.Windows.Forms.NumericUpDown NUD_Count;
        private System.Windows.Forms.Label LBL_Connectivity;
        private System.Windows.Forms.Button BTN_Cancel;
        private System.Windows.Forms.Button BTN_Putting;
        private System.Windows.Forms.Button BTN_Calulate;
    }
}

