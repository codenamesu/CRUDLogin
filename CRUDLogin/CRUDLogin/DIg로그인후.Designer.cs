namespace CRUDLogin
{
    partial class DIg로그인후
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
            this.btn회원수정 = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // btn회원수정
            // 
            this.btn회원수정.Location = new System.Drawing.Point(51, 289);
            this.btn회원수정.Name = "btn회원수정";
            this.btn회원수정.Size = new System.Drawing.Size(173, 87);
            this.btn회원수정.TabIndex = 0;
            this.btn회원수정.Text = "회원정보 수정";
            this.btn회원수정.Click += new System.EventHandler(this.btn회원수정_Click);
            // 
            // DIg로그인후
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 407);
            this.Controls.Add(this.btn회원수정);
            this.Name = "DIg로그인후";
            this.Text = "DIg로그인후";
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btn회원수정;
    }
}