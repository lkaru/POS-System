namespace POS_System
{
    partial class Form_StockStatus
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_StockStatus));
            this.BTN_ModifiItem = new System.Windows.Forms.Button();
            this.BTN_BackSpace = new System.Windows.Forms.Button();
            this.BTN_Refresh = new System.Windows.Forms.Button();
            this.BTN_DeleteItem = new System.Windows.Forms.Button();
            this.TBX_Amount = new System.Windows.Forms.TextBox();
            this.LBL_Amount = new System.Windows.Forms.Label();
            this.TBX_Price = new System.Windows.Forms.TextBox();
            this.LBL_Price = new System.Windows.Forms.Label();
            this.TBX_ItemName = new System.Windows.Forms.TextBox();
            this.LBL_ItemName = new System.Windows.Forms.Label();
            this.TBX_SerialNum = new System.Windows.Forms.TextBox();
            this.LBL_SerialNum = new System.Windows.Forms.Label();
            this.BTN_SearchItem = new System.Windows.Forms.Button();
            this.TBX_SearchItem = new System.Windows.Forms.TextBox();
            this.LBL_SearchItem = new System.Windows.Forms.Label();
            this.DGV_StockStatus = new System.Windows.Forms.DataGridView();
            this.LBL_Title = new System.Windows.Forms.Label();
            this.BTN_AddItem = new System.Windows.Forms.Button();
            this.serialTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_StockStatus)).BeginInit();
            this.SuspendLayout();
            // 
            // BTN_ModifiItem
            // 
            this.BTN_ModifiItem.Location = new System.Drawing.Point(822, 472);
            this.BTN_ModifiItem.Name = "BTN_ModifiItem";
            this.BTN_ModifiItem.Size = new System.Drawing.Size(135, 32);
            this.BTN_ModifiItem.TabIndex = 64;
            this.BTN_ModifiItem.Text = "품목 수정";
            this.BTN_ModifiItem.UseVisualStyleBackColor = true;
            this.BTN_ModifiItem.Click += new System.EventHandler(this.BTN_ModifiItem_Click);
            // 
            // BTN_BackSpace
            // 
            this.BTN_BackSpace.Location = new System.Drawing.Point(822, 16);
            this.BTN_BackSpace.Name = "BTN_BackSpace";
            this.BTN_BackSpace.Size = new System.Drawing.Size(135, 32);
            this.BTN_BackSpace.TabIndex = 63;
            this.BTN_BackSpace.Text = "뒤로가기";
            this.BTN_BackSpace.UseVisualStyleBackColor = true;
            this.BTN_BackSpace.Click += new System.EventHandler(this.BTN_BackSpace_Click);
            // 
            // BTN_Refresh
            // 
            this.BTN_Refresh.Location = new System.Drawing.Point(822, 620);
            this.BTN_Refresh.Name = "BTN_Refresh";
            this.BTN_Refresh.Size = new System.Drawing.Size(135, 32);
            this.BTN_Refresh.TabIndex = 62;
            this.BTN_Refresh.Text = "새로고침";
            this.BTN_Refresh.UseVisualStyleBackColor = true;
            this.BTN_Refresh.Click += new System.EventHandler(this.BTN_Refresh_Click);
            // 
            // BTN_DeleteItem
            // 
            this.BTN_DeleteItem.Location = new System.Drawing.Point(822, 510);
            this.BTN_DeleteItem.Name = "BTN_DeleteItem";
            this.BTN_DeleteItem.Size = new System.Drawing.Size(135, 32);
            this.BTN_DeleteItem.TabIndex = 61;
            this.BTN_DeleteItem.Text = "품목 삭제";
            this.BTN_DeleteItem.UseVisualStyleBackColor = true;
            this.BTN_DeleteItem.Click += new System.EventHandler(this.BTN_DeleteItem_Click);
            // 
            // TBX_Amount
            // 
            this.TBX_Amount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TBX_Amount.Location = new System.Drawing.Point(822, 400);
            this.TBX_Amount.Name = "TBX_Amount";
            this.TBX_Amount.Size = new System.Drawing.Size(135, 28);
            this.TBX_Amount.TabIndex = 60;
            // 
            // LBL_Amount
            // 
            this.LBL_Amount.AutoSize = true;
            this.LBL_Amount.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.LBL_Amount.Location = new System.Drawing.Point(817, 372);
            this.LBL_Amount.Name = "LBL_Amount";
            this.LBL_Amount.Size = new System.Drawing.Size(48, 25);
            this.LBL_Amount.TabIndex = 59;
            this.LBL_Amount.Text = "수량";
            // 
            // TBX_Price
            // 
            this.TBX_Price.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TBX_Price.Location = new System.Drawing.Point(822, 341);
            this.TBX_Price.Name = "TBX_Price";
            this.TBX_Price.Size = new System.Drawing.Size(135, 28);
            this.TBX_Price.TabIndex = 58;
            // 
            // LBL_Price
            // 
            this.LBL_Price.AutoSize = true;
            this.LBL_Price.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.LBL_Price.Location = new System.Drawing.Point(817, 313);
            this.LBL_Price.Name = "LBL_Price";
            this.LBL_Price.Size = new System.Drawing.Size(48, 25);
            this.LBL_Price.TabIndex = 57;
            this.LBL_Price.Text = "가격";
            // 
            // TBX_ItemName
            // 
            this.TBX_ItemName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TBX_ItemName.Location = new System.Drawing.Point(822, 282);
            this.TBX_ItemName.Name = "TBX_ItemName";
            this.TBX_ItemName.Size = new System.Drawing.Size(135, 28);
            this.TBX_ItemName.TabIndex = 56;
            // 
            // LBL_ItemName
            // 
            this.LBL_ItemName.AutoSize = true;
            this.LBL_ItemName.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.LBL_ItemName.Location = new System.Drawing.Point(817, 254);
            this.LBL_ItemName.Name = "LBL_ItemName";
            this.LBL_ItemName.Size = new System.Drawing.Size(66, 25);
            this.LBL_ItemName.TabIndex = 55;
            this.LBL_ItemName.Text = "상품명";
            // 
            // TBX_SerialNum
            // 
            this.TBX_SerialNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TBX_SerialNum.Location = new System.Drawing.Point(822, 223);
            this.TBX_SerialNum.Name = "TBX_SerialNum";
            this.TBX_SerialNum.Size = new System.Drawing.Size(135, 28);
            this.TBX_SerialNum.TabIndex = 54;
            // 
            // LBL_SerialNum
            // 
            this.LBL_SerialNum.AutoSize = true;
            this.LBL_SerialNum.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.LBL_SerialNum.Location = new System.Drawing.Point(817, 195);
            this.LBL_SerialNum.Name = "LBL_SerialNum";
            this.LBL_SerialNum.Size = new System.Drawing.Size(84, 25);
            this.LBL_SerialNum.TabIndex = 53;
            this.LBL_SerialNum.Text = "고유번호";
            // 
            // BTN_SearchItem
            // 
            this.BTN_SearchItem.Location = new System.Drawing.Point(822, 135);
            this.BTN_SearchItem.Name = "BTN_SearchItem";
            this.BTN_SearchItem.Size = new System.Drawing.Size(135, 32);
            this.BTN_SearchItem.TabIndex = 52;
            this.BTN_SearchItem.Text = "검색";
            this.BTN_SearchItem.UseVisualStyleBackColor = true;
            this.BTN_SearchItem.Click += new System.EventHandler(this.BTN_SearchItem_Click);
            // 
            // TBX_SearchItem
            // 
            this.TBX_SearchItem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TBX_SearchItem.Location = new System.Drawing.Point(822, 101);
            this.TBX_SearchItem.Name = "TBX_SearchItem";
            this.TBX_SearchItem.Size = new System.Drawing.Size(135, 28);
            this.TBX_SearchItem.TabIndex = 51;
            this.TBX_SearchItem.TextChanged += new System.EventHandler(this.TBX_SearchItem_TextChanged);
            // 
            // LBL_SearchItem
            // 
            this.LBL_SearchItem.AutoSize = true;
            this.LBL_SearchItem.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.LBL_SearchItem.Location = new System.Drawing.Point(817, 73);
            this.LBL_SearchItem.Name = "LBL_SearchItem";
            this.LBL_SearchItem.Size = new System.Drawing.Size(90, 25);
            this.LBL_SearchItem.TabIndex = 50;
            this.LBL_SearchItem.Text = "물품 검색";
            // 
            // DGV_StockStatus
            // 
            this.DGV_StockStatus.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_StockStatus.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.DGV_StockStatus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_StockStatus.Location = new System.Drawing.Point(23, 74);
            this.DGV_StockStatus.Name = "DGV_StockStatus";
            this.DGV_StockStatus.RowHeadersWidth = 62;
            this.DGV_StockStatus.RowTemplate.Height = 30;
            this.DGV_StockStatus.Size = new System.Drawing.Size(784, 579);
            this.DGV_StockStatus.TabIndex = 49;
            this.DGV_StockStatus.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_StockStatus_CellContentClick);
            // 
            // LBL_Title
            // 
            this.LBL_Title.AutoSize = true;
            this.LBL_Title.Font = new System.Drawing.Font("맑은 고딕", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.LBL_Title.Location = new System.Drawing.Point(14, 17);
            this.LBL_Title.Name = "LBL_Title";
            this.LBL_Title.Size = new System.Drawing.Size(197, 54);
            this.LBL_Title.TabIndex = 48;
            this.LBL_Title.Text = "재고 현황";
            this.LBL_Title.Click += new System.EventHandler(this.LBL_Title_Click);
            // 
            // BTN_AddItem
            // 
            this.BTN_AddItem.Location = new System.Drawing.Point(822, 434);
            this.BTN_AddItem.Name = "BTN_AddItem";
            this.BTN_AddItem.Size = new System.Drawing.Size(135, 32);
            this.BTN_AddItem.TabIndex = 65;
            this.BTN_AddItem.Text = "재고 추가";
            this.BTN_AddItem.UseVisualStyleBackColor = true;
            this.BTN_AddItem.Click += new System.EventHandler(this.BTN_AddItem_Click);
            // 
            // serialTimer
            // 
            this.serialTimer.Interval = 10;
            // 
            // Form_StockStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(978, 684);
            this.Controls.Add(this.BTN_AddItem);
            this.Controls.Add(this.BTN_ModifiItem);
            this.Controls.Add(this.BTN_BackSpace);
            this.Controls.Add(this.BTN_Refresh);
            this.Controls.Add(this.BTN_DeleteItem);
            this.Controls.Add(this.TBX_Amount);
            this.Controls.Add(this.LBL_Amount);
            this.Controls.Add(this.TBX_Price);
            this.Controls.Add(this.LBL_Price);
            this.Controls.Add(this.TBX_ItemName);
            this.Controls.Add(this.LBL_ItemName);
            this.Controls.Add(this.TBX_SerialNum);
            this.Controls.Add(this.LBL_SerialNum);
            this.Controls.Add(this.BTN_SearchItem);
            this.Controls.Add(this.TBX_SearchItem);
            this.Controls.Add(this.LBL_SearchItem);
            this.Controls.Add(this.DGV_StockStatus);
            this.Controls.Add(this.LBL_Title);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_StockStatus";
            this.Text = "Form_StockStatus";
            this.Load += new System.EventHandler(this.Form_StockStatus_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_StockStatus)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTN_ModifiItem;
        private System.Windows.Forms.Button BTN_BackSpace;
        private System.Windows.Forms.Button BTN_Refresh;
        private System.Windows.Forms.Button BTN_DeleteItem;
        private System.Windows.Forms.TextBox TBX_Amount;
        private System.Windows.Forms.Label LBL_Amount;
        private System.Windows.Forms.TextBox TBX_Price;
        private System.Windows.Forms.Label LBL_Price;
        private System.Windows.Forms.TextBox TBX_ItemName;
        private System.Windows.Forms.Label LBL_ItemName;
        private System.Windows.Forms.TextBox TBX_SerialNum;
        private System.Windows.Forms.Label LBL_SerialNum;
        private System.Windows.Forms.Button BTN_SearchItem;
        private System.Windows.Forms.TextBox TBX_SearchItem;
        private System.Windows.Forms.Label LBL_SearchItem;
        private System.Windows.Forms.DataGridView DGV_StockStatus;
        private System.Windows.Forms.Label LBL_Title;
        private System.Windows.Forms.Button BTN_AddItem;
        public System.Windows.Forms.Timer serialTimer;
    }
}