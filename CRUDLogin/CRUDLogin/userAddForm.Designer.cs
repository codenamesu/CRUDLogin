namespace CRUDLogin
{
    partial class userAddForm
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
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.te이름 = new DevExpress.XtraEditors.TextEdit();
            this.te아이디 = new DevExpress.XtraEditors.TextEdit();
            this.te비밀번호 = new DevExpress.XtraEditors.TextEdit();
            this.btn회원가입 = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.te핸드폰 = new DevExpress.XtraEditors.TextEdit();
            this.btn회원탈퇴 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.te이름.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.te아이디.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.te비밀번호.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.te핸드폰.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(108, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(40, 14);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "회원가입";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(26, 47);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(20, 14);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "이름";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(26, 86);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(30, 14);
            this.labelControl3.TabIndex = 1;
            this.labelControl3.Text = "아이디";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(26, 127);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(40, 14);
            this.labelControl4.TabIndex = 1;
            this.labelControl4.Text = "비밀번호";
            // 
            // te이름
            // 
            this.te이름.Location = new System.Drawing.Point(108, 47);
            this.te이름.Name = "te이름";
            this.te이름.Size = new System.Drawing.Size(100, 20);
            this.te이름.TabIndex = 0;
            // 
            // te아이디
            // 
            this.te아이디.Location = new System.Drawing.Point(108, 83);
            this.te아이디.Name = "te아이디";
            this.te아이디.Size = new System.Drawing.Size(100, 20);
            this.te아이디.TabIndex = 1;
            // 
            // te비밀번호
            // 
            this.te비밀번호.Location = new System.Drawing.Point(108, 124);
            this.te비밀번호.Name = "te비밀번호";
            this.te비밀번호.Properties.PasswordChar = '*';
            this.te비밀번호.Properties.UseSystemPasswordChar = true;
            this.te비밀번호.Size = new System.Drawing.Size(100, 20);
            this.te비밀번호.TabIndex = 2;
            // 
            // btn회원가입
            // 
            this.btn회원가입.Location = new System.Drawing.Point(26, 254);
            this.btn회원가입.Name = "btn회원가입";
            this.btn회원가입.Size = new System.Drawing.Size(64, 45);
            this.btn회원가입.TabIndex = 4;
            this.btn회원가입.Text = "회원가입";
            this.btn회원가입.Click += new System.EventHandler(this.btn회원가입_Click);
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(26, 162);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(30, 14);
            this.labelControl5.TabIndex = 1;
            this.labelControl5.Text = "핸드폰";
            // 
            // te핸드폰
            // 
            this.te핸드폰.Location = new System.Drawing.Point(108, 159);
            this.te핸드폰.Name = "te핸드폰";
            this.te핸드폰.Size = new System.Drawing.Size(100, 20);
            this.te핸드폰.TabIndex = 3;
            // 
            // btn회원탈퇴
            // 
            this.btn회원탈퇴.Location = new System.Drawing.Point(123, 254);
            this.btn회원탈퇴.Name = "btn회원탈퇴";
            this.btn회원탈퇴.Size = new System.Drawing.Size(66, 45);
            this.btn회원탈퇴.TabIndex = 5;
            this.btn회원탈퇴.Text = "회원탈퇴";
            this.btn회원탈퇴.Click += new System.EventHandler(this.btn회원탈퇴_Click);
            // 
            // userAddForm
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(249, 332);
            this.Controls.Add(this.btn회원탈퇴);
            this.Controls.Add(this.btn회원가입);
            this.Controls.Add(this.te핸드폰);
            this.Controls.Add(this.te비밀번호);
            this.Controls.Add(this.te아이디);
            this.Controls.Add(this.te이름);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow;
            this.Name = "userAddForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "회원가입";
            this.Load += new System.EventHandler(this.userAddForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.te이름.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.te아이디.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.te비밀번호.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.te핸드폰.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit te이름;
        private DevExpress.XtraEditors.TextEdit te아이디;
        private DevExpress.XtraEditors.TextEdit te비밀번호;
        private DevExpress.XtraEditors.SimpleButton btn회원가입;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit te핸드폰;
        private DevExpress.XtraEditors.SimpleButton btn회원탈퇴;
    }
}