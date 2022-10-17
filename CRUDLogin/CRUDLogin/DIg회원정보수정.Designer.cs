namespace CRUDLogin
{
    partial class DIg회원정보수정
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
            this.btn저장 = new DevExpress.XtraEditors.SimpleButton();
            this.te핸드폰 = new DevExpress.XtraEditors.TextEdit();
            this.te비밀번호 = new DevExpress.XtraEditors.TextEdit();
            this.te이름 = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.te핸드폰.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.te비밀번호.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.te이름.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btn저장
            // 
            this.btn저장.Location = new System.Drawing.Point(109, 286);
            this.btn저장.Name = "btn저장";
            this.btn저장.Size = new System.Drawing.Size(182, 53);
            this.btn저장.TabIndex = 15;
            this.btn저장.Text = "저장";
            this.btn저장.Click += new System.EventHandler(this.btn저장_Click);
            // 
            // te핸드폰
            // 
            this.te핸드폰.Location = new System.Drawing.Point(191, 191);
            this.te핸드폰.Name = "te핸드폰";
            this.te핸드폰.Size = new System.Drawing.Size(100, 20);
            this.te핸드폰.TabIndex = 14;
            // 
            // te비밀번호
            // 
            this.te비밀번호.Location = new System.Drawing.Point(191, 156);
            this.te비밀번호.Name = "te비밀번호";
            this.te비밀번호.Properties.PasswordChar = '*';
            this.te비밀번호.Properties.UseSystemPasswordChar = true;
            this.te비밀번호.Size = new System.Drawing.Size(100, 20);
            this.te비밀번호.TabIndex = 13;
            // 
            // te이름
            // 
            this.te이름.Location = new System.Drawing.Point(191, 79);
            this.te이름.Name = "te이름";
            this.te이름.Size = new System.Drawing.Size(100, 20);
            this.te이름.TabIndex = 6;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(109, 194);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(30, 14);
            this.labelControl5.TabIndex = 9;
            this.labelControl5.Text = "핸드폰";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(109, 159);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(40, 14);
            this.labelControl4.TabIndex = 10;
            this.labelControl4.Text = "비밀번호";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(109, 79);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(20, 14);
            this.labelControl2.TabIndex = 12;
            this.labelControl2.Text = "이름";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(191, 44);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(40, 14);
            this.labelControl1.TabIndex = 7;
            this.labelControl1.Text = "회원가입";
            // 
            // DIg회원정보수정
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 375);
            this.Controls.Add(this.btn저장);
            this.Controls.Add(this.te핸드폰);
            this.Controls.Add(this.te비밀번호);
            this.Controls.Add(this.te이름);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Name = "DIg회원정보수정";
            this.Text = "DIg회원정보수정";
            ((System.ComponentModel.ISupportInitialize)(this.te핸드폰.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.te비밀번호.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.te이름.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.SimpleButton btn저장;
        private DevExpress.XtraEditors.TextEdit te핸드폰;
        private DevExpress.XtraEditors.TextEdit te비밀번호;
        private DevExpress.XtraEditors.TextEdit te이름;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}