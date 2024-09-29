namespace POS_System
{
    partial class Form_SignUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_SignUp));
            this.LBL_Title = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BTN_BackSpace = new System.Windows.Forms.Button();
            this.BTN_CreateAcount = new System.Windows.Forms.Button();
            this.TBX_Name = new System.Windows.Forms.TextBox();
            this.LBL_Name = new System.Windows.Forms.Label();
            this.CBB_Job = new System.Windows.Forms.ComboBox();
            this.TBX_Pwd = new System.Windows.Forms.TextBox();
            this.TBX_Id = new System.Windows.Forms.TextBox();
            this.LBL_Job = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LBL_Id = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LBL_Title
            // 
            this.LBL_Title.AutoSize = true;
            this.LBL_Title.Font = new System.Drawing.Font("굴림", 20F);
            this.LBL_Title.Location = new System.Drawing.Point(312, 102);
            this.LBL_Title.Name = "LBL_Title";
            this.LBL_Title.Size = new System.Drawing.Size(190, 40);
            this.LBL_Title.TabIndex = 7;
            this.LBL_Title.Text = "회원 가입";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BTN_BackSpace);
            this.panel1.Controls.Add(this.BTN_CreateAcount);
            this.panel1.Controls.Add(this.TBX_Name);
            this.panel1.Controls.Add(this.LBL_Name);
            this.panel1.Controls.Add(this.CBB_Job);
            this.panel1.Controls.Add(this.TBX_Pwd);
            this.panel1.Controls.Add(this.TBX_Id);
            this.panel1.Controls.Add(this.LBL_Job);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.LBL_Id);
            this.panel1.Location = new System.Drawing.Point(98, 145);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(598, 210);
            this.panel1.TabIndex = 6;
            // 
            // BTN_BackSpace
            // 
            this.BTN_BackSpace.Location = new System.Drawing.Point(471, 156);
            this.BTN_BackSpace.Name = "BTN_BackSpace";
            this.BTN_BackSpace.Size = new System.Drawing.Size(100, 38);
            this.BTN_BackSpace.TabIndex = 10;
            this.BTN_BackSpace.Text = "뒤로가기";
            this.BTN_BackSpace.UseVisualStyleBackColor = true;
            this.BTN_BackSpace.Click += new System.EventHandler(this.BTN_BackSpace_Click);
            // 
            // BTN_CreateAcount
            // 
            this.BTN_CreateAcount.Location = new System.Drawing.Point(471, 12);
            this.BTN_CreateAcount.Name = "BTN_CreateAcount";
            this.BTN_CreateAcount.Size = new System.Drawing.Size(100, 138);
            this.BTN_CreateAcount.TabIndex = 9;
            this.BTN_CreateAcount.Text = "계정 생성";
            this.BTN_CreateAcount.UseVisualStyleBackColor = true;
            this.BTN_CreateAcount.Click += new System.EventHandler(this.BTN_CreateAcount_Click);
            // 
            // TBX_Name
            // 
            this.TBX_Name.Font = new System.Drawing.Font("굴림", 15F);
            this.TBX_Name.Location = new System.Drawing.Point(201, 108);
            this.TBX_Name.Name = "TBX_Name";
            this.TBX_Name.Size = new System.Drawing.Size(237, 42);
            this.TBX_Name.TabIndex = 8;
            // 
            // LBL_Name
            // 
            this.LBL_Name.AutoSize = true;
            this.LBL_Name.Font = new System.Drawing.Font("굴림", 15F);
            this.LBL_Name.Location = new System.Drawing.Point(18, 111);
            this.LBL_Name.Name = "LBL_Name";
            this.LBL_Name.Size = new System.Drawing.Size(73, 30);
            this.LBL_Name.TabIndex = 7;
            this.LBL_Name.Text = "이름";
            // 
            // CBB_Job
            // 
            this.CBB_Job.Font = new System.Drawing.Font("굴림", 15F);
            this.CBB_Job.FormattingEnabled = true;
            this.CBB_Job.Items.AddRange(new object[] {
            "manager",
            "worker"});
            this.CBB_Job.Location = new System.Drawing.Point(201, 156);
            this.CBB_Job.Name = "CBB_Job";
            this.CBB_Job.Size = new System.Drawing.Size(237, 38);
            this.CBB_Job.TabIndex = 6;
            // 
            // TBX_Pwd
            // 
            this.TBX_Pwd.Font = new System.Drawing.Font("굴림", 15F);
            this.TBX_Pwd.Location = new System.Drawing.Point(201, 60);
            this.TBX_Pwd.Name = "TBX_Pwd";
            this.TBX_Pwd.Size = new System.Drawing.Size(237, 42);
            this.TBX_Pwd.TabIndex = 5;
            // 
            // TBX_Id
            // 
            this.TBX_Id.Font = new System.Drawing.Font("굴림", 15F);
            this.TBX_Id.Location = new System.Drawing.Point(201, 12);
            this.TBX_Id.Name = "TBX_Id";
            this.TBX_Id.Size = new System.Drawing.Size(237, 42);
            this.TBX_Id.TabIndex = 4;
            this.TBX_Id.TextChanged += new System.EventHandler(this.TBX_Id_TextChanged);
            // 
            // LBL_Job
            // 
            this.LBL_Job.AutoSize = true;
            this.LBL_Job.Font = new System.Drawing.Font("굴림", 15F);
            this.LBL_Job.Location = new System.Drawing.Point(18, 159);
            this.LBL_Job.Name = "LBL_Job";
            this.LBL_Job.Size = new System.Drawing.Size(73, 30);
            this.LBL_Job.TabIndex = 2;
            this.LBL_Job.Text = "직책";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 15F);
            this.label1.Location = new System.Drawing.Point(18, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "비밀번호";
            // 
            // LBL_Id
            // 
            this.LBL_Id.AutoSize = true;
            this.LBL_Id.Font = new System.Drawing.Font("굴림", 15F);
            this.LBL_Id.Location = new System.Drawing.Point(18, 15);
            this.LBL_Id.Name = "LBL_Id";
            this.LBL_Id.Size = new System.Drawing.Size(103, 30);
            this.LBL_Id.TabIndex = 0;
            this.LBL_Id.Text = "아이디";
            // 
            // Form_SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LBL_Title);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_SignUp";
            this.Text = "SignUp";
            this.Load += new System.EventHandler(this.Form_SignUp_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBL_Title;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox TBX_Name;
        private System.Windows.Forms.Label LBL_Name;
        private System.Windows.Forms.ComboBox CBB_Job;
        private System.Windows.Forms.TextBox TBX_Pwd;
        private System.Windows.Forms.TextBox TBX_Id;
        private System.Windows.Forms.Label LBL_Job;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LBL_Id;
        private System.Windows.Forms.Button BTN_CreateAcount;
        private System.Windows.Forms.Button BTN_BackSpace;
    }
}