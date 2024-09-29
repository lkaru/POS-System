namespace POS_System
{
    partial class Form_SalesHistory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_SalesHistory));
            this.BTN_BackSpace = new System.Windows.Forms.Button();
            this.BTN_Refresh = new System.Windows.Forms.Button();
            this.BTN_ItemDelete = new System.Windows.Forms.Button();
            this.TBX_Amount = new System.Windows.Forms.TextBox();
            this.LBL_Amount = new System.Windows.Forms.Label();
            this.TBX_Price = new System.Windows.Forms.TextBox();
            this.LBL_Price = new System.Windows.Forms.Label();
            this.TBX_ItemName = new System.Windows.Forms.TextBox();
            this.LBL_ItemName = new System.Windows.Forms.Label();
            this.TBX_SerialNum = new System.Windows.Forms.TextBox();
            this.LBL_SerialNum = new System.Windows.Forms.Label();
            this.BTN_SearchForItems = new System.Windows.Forms.Button();
            this.TBX_SearchItem = new System.Windows.Forms.TextBox();
            this.LBL_SearchItems = new System.Windows.Forms.Label();
            this.DGV_SalesHistory = new System.Windows.Forms.DataGridView();
            this.LBL_Title = new System.Windows.Forms.Label();
            this.BTN_Modifi = new System.Windows.Forms.Button();
            this.TBX_Total = new System.Windows.Forms.TextBox();
            this.LBL_Total = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_SalesHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // BTN_BackSpace
            // 
            this.BTN_BackSpace.Location = new System.Drawing.Point(857, 18);
            this.BTN_BackSpace.Name = "BTN_BackSpace";
            this.BTN_BackSpace.Size = new System.Drawing.Size(135, 32);
            this.BTN_BackSpace.TabIndex = 46;
            this.BTN_BackSpace.Text = "뒤로가기";
            this.BTN_BackSpace.UseVisualStyleBackColor = true;
            this.BTN_BackSpace.Click += new System.EventHandler(this.BTN_BackSpace_Click);
            // 
            // BTN_Refresh
            // 
            this.BTN_Refresh.Location = new System.Drawing.Point(857, 606);
            this.BTN_Refresh.Name = "BTN_Refresh";
            this.BTN_Refresh.Size = new System.Drawing.Size(135, 32);
            this.BTN_Refresh.TabIndex = 45;
            this.BTN_Refresh.Text = "새로고침";
            this.BTN_Refresh.UseVisualStyleBackColor = true;
            this.BTN_Refresh.Click += new System.EventHandler(this.BTN_Refresh_Click);
            // 
            // BTN_ItemDelete
            // 
            this.BTN_ItemDelete.Location = new System.Drawing.Point(857, 533);
            this.BTN_ItemDelete.Name = "BTN_ItemDelete";
            this.BTN_ItemDelete.Size = new System.Drawing.Size(135, 32);
            this.BTN_ItemDelete.TabIndex = 44;
            this.BTN_ItemDelete.Text = "품목 삭제";
            this.BTN_ItemDelete.UseVisualStyleBackColor = true;
            this.BTN_ItemDelete.Click += new System.EventHandler(this.BTN_ItemDelete_Click);
            // 
            // TBX_Amount
            // 
            this.TBX_Amount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TBX_Amount.Location = new System.Drawing.Point(857, 402);
            this.TBX_Amount.Name = "TBX_Amount";
            this.TBX_Amount.Size = new System.Drawing.Size(135, 28);
            this.TBX_Amount.TabIndex = 43;
            this.TBX_Amount.TextChanged += new System.EventHandler(this.TBX_Amount_TextChanged);
            // 
            // LBL_Amount
            // 
            this.LBL_Amount.AutoSize = true;
            this.LBL_Amount.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.LBL_Amount.Location = new System.Drawing.Point(852, 374);
            this.LBL_Amount.Name = "LBL_Amount";
            this.LBL_Amount.Size = new System.Drawing.Size(48, 25);
            this.LBL_Amount.TabIndex = 42;
            this.LBL_Amount.Text = "수량";
            this.LBL_Amount.Click += new System.EventHandler(this.LBL_Amount_Click);
            // 
            // TBX_Price
            // 
            this.TBX_Price.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TBX_Price.Location = new System.Drawing.Point(857, 343);
            this.TBX_Price.Name = "TBX_Price";
            this.TBX_Price.Size = new System.Drawing.Size(135, 28);
            this.TBX_Price.TabIndex = 41;
            this.TBX_Price.TextChanged += new System.EventHandler(this.TBX_Price_TextChanged);
            // 
            // LBL_Price
            // 
            this.LBL_Price.AutoSize = true;
            this.LBL_Price.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.LBL_Price.Location = new System.Drawing.Point(852, 315);
            this.LBL_Price.Name = "LBL_Price";
            this.LBL_Price.Size = new System.Drawing.Size(48, 25);
            this.LBL_Price.TabIndex = 40;
            this.LBL_Price.Text = "가격";
            this.LBL_Price.Click += new System.EventHandler(this.LBL_Price_Click);
            // 
            // TBX_ItemName
            // 
            this.TBX_ItemName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TBX_ItemName.Location = new System.Drawing.Point(857, 284);
            this.TBX_ItemName.Name = "TBX_ItemName";
            this.TBX_ItemName.Size = new System.Drawing.Size(135, 28);
            this.TBX_ItemName.TabIndex = 39;
            this.TBX_ItemName.TextChanged += new System.EventHandler(this.TBX_TradeName_TextChanged);
            // 
            // LBL_ItemName
            // 
            this.LBL_ItemName.AutoSize = true;
            this.LBL_ItemName.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.LBL_ItemName.Location = new System.Drawing.Point(852, 256);
            this.LBL_ItemName.Name = "LBL_ItemName";
            this.LBL_ItemName.Size = new System.Drawing.Size(66, 25);
            this.LBL_ItemName.TabIndex = 38;
            this.LBL_ItemName.Text = "상품명";
            this.LBL_ItemName.Click += new System.EventHandler(this.LBL_TradeName_Click);
            // 
            // TBX_SerialNum
            // 
            this.TBX_SerialNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TBX_SerialNum.Location = new System.Drawing.Point(857, 225);
            this.TBX_SerialNum.Name = "TBX_SerialNum";
            this.TBX_SerialNum.Size = new System.Drawing.Size(135, 28);
            this.TBX_SerialNum.TabIndex = 37;
            this.TBX_SerialNum.TextChanged += new System.EventHandler(this.TBX_SerialNum_TextChanged);
            // 
            // LBL_SerialNum
            // 
            this.LBL_SerialNum.AutoSize = true;
            this.LBL_SerialNum.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.LBL_SerialNum.Location = new System.Drawing.Point(852, 197);
            this.LBL_SerialNum.Name = "LBL_SerialNum";
            this.LBL_SerialNum.Size = new System.Drawing.Size(84, 25);
            this.LBL_SerialNum.TabIndex = 36;
            this.LBL_SerialNum.Text = "고유번호";
            // 
            // BTN_SearchForItems
            // 
            this.BTN_SearchForItems.Location = new System.Drawing.Point(857, 137);
            this.BTN_SearchForItems.Name = "BTN_SearchForItems";
            this.BTN_SearchForItems.Size = new System.Drawing.Size(135, 32);
            this.BTN_SearchForItems.TabIndex = 35;
            this.BTN_SearchForItems.Text = "검색";
            this.BTN_SearchForItems.UseVisualStyleBackColor = true;
            this.BTN_SearchForItems.Click += new System.EventHandler(this.BTN_SearchForItems_Click);
            // 
            // TBX_SearchItem
            // 
            this.TBX_SearchItem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TBX_SearchItem.Location = new System.Drawing.Point(857, 103);
            this.TBX_SearchItem.Name = "TBX_SearchItem";
            this.TBX_SearchItem.Size = new System.Drawing.Size(135, 28);
            this.TBX_SearchItem.TabIndex = 34;
            // 
            // LBL_SearchItems
            // 
            this.LBL_SearchItems.AutoSize = true;
            this.LBL_SearchItems.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.LBL_SearchItems.Location = new System.Drawing.Point(852, 75);
            this.LBL_SearchItems.Name = "LBL_SearchItems";
            this.LBL_SearchItems.Size = new System.Drawing.Size(90, 25);
            this.LBL_SearchItems.TabIndex = 33;
            this.LBL_SearchItems.Text = "물품 검색";
            // 
            // DGV_SalesHistory
            // 
            this.DGV_SalesHistory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_SalesHistory.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.DGV_SalesHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_SalesHistory.Location = new System.Drawing.Point(27, 75);
            this.DGV_SalesHistory.Name = "DGV_SalesHistory";
            this.DGV_SalesHistory.RowHeadersWidth = 62;
            this.DGV_SalesHistory.RowTemplate.Height = 30;
            this.DGV_SalesHistory.Size = new System.Drawing.Size(809, 563);
            this.DGV_SalesHistory.TabIndex = 32;
            this.DGV_SalesHistory.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_CellContentClick);
            // 
            // LBL_Title
            // 
            this.LBL_Title.AutoSize = true;
            this.LBL_Title.Font = new System.Drawing.Font("맑은 고딕", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.LBL_Title.Location = new System.Drawing.Point(18, 18);
            this.LBL_Title.Name = "LBL_Title";
            this.LBL_Title.Size = new System.Drawing.Size(197, 54);
            this.LBL_Title.TabIndex = 31;
            this.LBL_Title.Text = "판매 내역";
            this.LBL_Title.Click += new System.EventHandler(this.LBL_Title_Click);
            // 
            // BTN_Modifi
            // 
            this.BTN_Modifi.Location = new System.Drawing.Point(857, 495);
            this.BTN_Modifi.Name = "BTN_Modifi";
            this.BTN_Modifi.Size = new System.Drawing.Size(135, 32);
            this.BTN_Modifi.TabIndex = 47;
            this.BTN_Modifi.Text = "수정";
            this.BTN_Modifi.UseVisualStyleBackColor = true;
            this.BTN_Modifi.Click += new System.EventHandler(this.BTN_Modifi_Click);
            // 
            // TBX_Total
            // 
            this.TBX_Total.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TBX_Total.Location = new System.Drawing.Point(860, 461);
            this.TBX_Total.Name = "TBX_Total";
            this.TBX_Total.Size = new System.Drawing.Size(135, 28);
            this.TBX_Total.TabIndex = 49;
            // 
            // LBL_Total
            // 
            this.LBL_Total.AutoSize = true;
            this.LBL_Total.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.LBL_Total.Location = new System.Drawing.Point(852, 433);
            this.LBL_Total.Name = "LBL_Total";
            this.LBL_Total.Size = new System.Drawing.Size(48, 25);
            this.LBL_Total.TabIndex = 48;
            this.LBL_Total.Text = "합계";
            // 
            // Form_SalesHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1007, 666);
            this.Controls.Add(this.TBX_Total);
            this.Controls.Add(this.LBL_Total);
            this.Controls.Add(this.BTN_Modifi);
            this.Controls.Add(this.BTN_BackSpace);
            this.Controls.Add(this.BTN_Refresh);
            this.Controls.Add(this.BTN_ItemDelete);
            this.Controls.Add(this.TBX_Amount);
            this.Controls.Add(this.LBL_Amount);
            this.Controls.Add(this.TBX_Price);
            this.Controls.Add(this.LBL_Price);
            this.Controls.Add(this.TBX_ItemName);
            this.Controls.Add(this.LBL_ItemName);
            this.Controls.Add(this.TBX_SerialNum);
            this.Controls.Add(this.LBL_SerialNum);
            this.Controls.Add(this.BTN_SearchForItems);
            this.Controls.Add(this.TBX_SearchItem);
            this.Controls.Add(this.LBL_SearchItems);
            this.Controls.Add(this.DGV_SalesHistory);
            this.Controls.Add(this.LBL_Title);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_SalesHistory";
            this.Text = "SalesHistory";
            this.Load += new System.EventHandler(this.Form_SalesHistory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_SalesHistory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTN_BackSpace;
        private System.Windows.Forms.Button BTN_Refresh;
        private System.Windows.Forms.Button BTN_ItemDelete;
        private System.Windows.Forms.TextBox TBX_Amount;
        private System.Windows.Forms.Label LBL_Amount;
        private System.Windows.Forms.TextBox TBX_Price;
        private System.Windows.Forms.Label LBL_Price;
        private System.Windows.Forms.TextBox TBX_ItemName;
        private System.Windows.Forms.Label LBL_ItemName;
        private System.Windows.Forms.TextBox TBX_SerialNum;
        private System.Windows.Forms.Label LBL_SerialNum;
        private System.Windows.Forms.Button BTN_SearchForItems;
        private System.Windows.Forms.TextBox TBX_SearchItem;
        private System.Windows.Forms.Label LBL_SearchItems;
        private System.Windows.Forms.DataGridView DGV_SalesHistory;
        private System.Windows.Forms.Label LBL_Title;
        private System.Windows.Forms.Button BTN_Modifi;
        private System.Windows.Forms.TextBox TBX_Total;
        private System.Windows.Forms.Label LBL_Total;
    }
}