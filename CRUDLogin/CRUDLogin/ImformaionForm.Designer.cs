namespace CRUDLogin
{
    partial class ImformaionForm
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
            this.te아이디삭제 = new DevExpress.XtraEditors.TextEdit();
            this.btn회원탈퇴 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.te아이디삭제.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(43, 55);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(42, 14);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "아이디 : ";
            // 
            // te아이디삭제
            // 
            this.te아이디삭제.Location = new System.Drawing.Point(138, 52);
            this.te아이디삭제.Name = "te아이디삭제";
            this.te아이디삭제.Size = new System.Drawing.Size(100, 20);
            this.te아이디삭제.TabIndex = 1;
            // 
            // btn회원탈퇴
            // 
            this.btn회원탈퇴.Location = new System.Drawing.Point(43, 113);
            this.btn회원탈퇴.Name = "btn회원탈퇴";
            this.btn회원탈퇴.Size = new System.Drawing.Size(147, 77);
            this.btn회원탈퇴.TabIndex = 2;
            this.btn회원탈퇴.Text = "회원탈퇴";
            this.btn회원탈퇴.Click += new System.EventHandler(this.btn회원탈퇴_Click);
            // 
            // Form03
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 268);
            this.Controls.Add(this.btn회원탈퇴);
            this.Controls.Add(this.te아이디삭제);
            this.Controls.Add(this.labelControl1);
            this.Name = "Form03";
            this.Text = "Form03";
            ((System.ComponentModel.ISupportInitialize)(this.te아이디삭제.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit te아이디삭제;
        private DevExpress.XtraEditors.SimpleButton btn회원탈퇴;
    }
}