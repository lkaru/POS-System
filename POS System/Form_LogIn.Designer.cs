namespace POS_System
{
    partial class Form_LogIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_LogIn));
            this.LBL_Id = new System.Windows.Forms.Label();
            this.LBL_Pwd = new System.Windows.Forms.Label();
            this.LBL_Job = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BTN_SignUp = new System.Windows.Forms.Button();
            this.BTN_LogIn = new System.Windows.Forms.Button();
            this.CBB_Job = new System.Windows.Forms.ComboBox();
            this.TBX_Pwd = new System.Windows.Forms.TextBox();
            this.TBX_Id = new System.Windows.Forms.TextBox();
            this.PTB = new System.Windows.Forms.PictureBox();
            this.LBL_Title = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PTB)).BeginInit();
            this.SuspendLayout();
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
            // LBL_Pwd
            // 
            this.LBL_Pwd.AutoSize = true;
            this.LBL_Pwd.Font = new System.Drawing.Font("굴림", 15F);
            this.LBL_Pwd.Location = new System.Drawing.Point(18, 63);
            this.LBL_Pwd.Name = "LBL_Pwd";
            this.LBL_Pwd.Size = new System.Drawing.Size(133, 30);
            this.LBL_Pwd.TabIndex = 1;
            this.LBL_Pwd.Text = "비밀번호";
            // 
            // LBL_Job
            // 
            this.LBL_Job.AutoSize = true;
            this.LBL_Job.Font = new System.Drawing.Font("굴림", 15F);
            this.LBL_Job.Location = new System.Drawing.Point(18, 111);
            this.LBL_Job.Name = "LBL_Job";
            this.LBL_Job.Size = new System.Drawing.Size(73, 30);
            this.LBL_Job.TabIndex = 2;
            this.LBL_Job.Text = "직책";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BTN_SignUp);
            this.panel1.Controls.Add(this.BTN_LogIn);
            this.panel1.Controls.Add(this.CBB_Job);
            this.panel1.Controls.Add(this.TBX_Pwd);
            this.panel1.Controls.Add(this.TBX_Id);
            this.panel1.Controls.Add(this.LBL_Job);
            this.panel1.Controls.Add(this.LBL_Pwd);
            this.panel1.Controls.Add(this.LBL_Id);
            this.panel1.Location = new System.Drawing.Point(88, 276);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(600, 162);
            this.panel1.TabIndex = 3;
            // 
            // BTN_SignUp
            // 
            this.BTN_SignUp.Location = new System.Drawing.Point(474, 108);
            this.BTN_SignUp.Name = "BTN_SignUp";
            this.BTN_SignUp.Size = new System.Drawing.Size(100, 38);
            this.BTN_SignUp.TabIndex = 8;
            this.BTN_SignUp.Text = "회원 가입";
            this.BTN_SignUp.UseVisualStyleBackColor = true;
            this.BTN_SignUp.Click += new System.EventHandler(this.BTN_SignUp_Click);
            // 
            // BTN_LogIn
            // 
            this.BTN_LogIn.Location = new System.Drawing.Point(474, 12);
            this.BTN_LogIn.Name = "BTN_LogIn";
            this.BTN_LogIn.Size = new System.Drawing.Size(100, 90);
            this.BTN_LogIn.TabIndex = 7;
            this.BTN_LogIn.Text = "로그인";
            this.BTN_LogIn.UseVisualStyleBackColor = true;
            this.BTN_LogIn.Click += new System.EventHandler(this.BTN_LogIn_Click);
            // 
            // CBB_Job
            // 
            this.CBB_Job.Font = new System.Drawing.Font("굴림", 15F);
            this.CBB_Job.FormattingEnabled = true;
            this.CBB_Job.Items.AddRange(new object[] {
            "manager",
            "worker"});
            this.CBB_Job.Location = new System.Drawing.Point(201, 108);
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
            // 
            // PTB
            // 
            this.PTB.Image = ((System.Drawing.Image)(resources.GetObject("PTB.Image")));
            this.PTB.Location = new System.Drawing.Point(229, 67);
            this.PTB.Name = "PTB";
            this.PTB.Size = new System.Drawing.Size(345, 203);
            this.PTB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PTB.TabIndex = 4;
            this.PTB.TabStop = false;
            // 
            // LBL_Title
            // 
            this.LBL_Title.AutoSize = true;
            this.LBL_Title.Font = new System.Drawing.Font("굴림", 20F);
            this.LBL_Title.Location = new System.Drawing.Point(331, 24);
            this.LBL_Title.Name = "LBL_Title";
            this.LBL_Title.Size = new System.Drawing.Size(137, 40);
            this.LBL_Title.TabIndex = 5;
            this.LBL_Title.Text = "로그인";
            // 
            // Form_LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LBL_Title);
            this.Controls.Add(this.PTB);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_LogIn";
            this.Text = "LogIn";
            this.Load += new System.EventHandler(this.Form_LogIn_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PTB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBL_Id;
        private System.Windows.Forms.Label LBL_Pwd;
        private System.Windows.Forms.Label LBL_Job;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox TBX_Pwd;
        private System.Windows.Forms.TextBox TBX_Id;
        private System.Windows.Forms.ComboBox CBB_Job;
        private System.Windows.Forms.PictureBox PTB;
        private System.Windows.Forms.Label LBL_Title;
        private System.Windows.Forms.Button BTN_LogIn;
        private System.Windows.Forms.Button BTN_SignUp;
    }
}