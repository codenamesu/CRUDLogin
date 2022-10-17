namespace CRUDLogin
{
    partial class LoginForm
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
            this.te아이디 = new DevExpress.XtraEditors.TextEdit();
            this.te비밀번호 = new DevExpress.XtraEditors.TextEdit();
            this.btn로그인 = new DevExpress.XtraEditors.SimpleButton();
            this.btn회원가입 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.te아이디.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.te비밀번호.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(51, 37);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(42, 14);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "아이디 : ";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(51, 80);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(52, 14);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "비밀번호 : ";
            // 
            // te아이디
            // 
            this.te아이디.Location = new System.Drawing.Point(154, 37);
            this.te아이디.Name = "te아이디";
            this.te아이디.Size = new System.Drawing.Size(137, 20);
            this.te아이디.TabIndex = 0;
            // 
            // te비밀번호
            // 
            this.te비밀번호.EditValue = "";
            this.te비밀번호.Location = new System.Drawing.Point(154, 80);
            this.te비밀번호.Name = "te비밀번호";
            this.te비밀번호.Properties.PasswordChar = '*';
            this.te비밀번호.Properties.UseSystemPasswordChar = true;
            this.te비밀번호.Size = new System.Drawing.Size(137, 20);
            this.te비밀번호.TabIndex = 1;
            // 
            // btn로그인
            // 
            this.btn로그인.Location = new System.Drawing.Point(51, 131);
            this.btn로그인.Name = "btn로그인";
            this.btn로그인.Size = new System.Drawing.Size(75, 23);
            this.btn로그인.TabIndex = 2;
            this.btn로그인.Text = "로그인";
            this.btn로그인.Click += new System.EventHandler(this.btn로그인_Click);
            // 
            // btn회원가입
            // 
            this.btn회원가입.Location = new System.Drawing.Point(154, 131);
            this.btn회원가입.Name = "btn회원가입";
            this.btn회원가입.Size = new System.Drawing.Size(75, 23);
            this.btn회원가입.TabIndex = 3;
            this.btn회원가입.Text = "회원가입";
            this.btn회원가입.Click += new System.EventHandler(this.btn회원가입_Click);
            // 
            // LoginForm
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 217);
            this.Controls.Add(this.btn회원가입);
            this.Controls.Add(this.btn로그인);
            this.Controls.Add(this.te비밀번호);
            this.Controls.Add(this.te아이디);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "로그인";
            ((System.ComponentModel.ISupportInitialize)(this.te아이디.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.te비밀번호.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit te아이디;
        private DevExpress.XtraEditors.TextEdit te비밀번호;
        private DevExpress.XtraEditors.SimpleButton btn로그인;
        private DevExpress.XtraEditors.SimpleButton btn회원가입;
    }
}