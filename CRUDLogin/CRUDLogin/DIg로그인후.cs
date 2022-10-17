using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MySql.Data.MySqlClient;
using CRUDLogin.Data;

namespace CRUDLogin
{ 
   
    public partial class DIg로그인후 : DevExpress.XtraEditors.XtraForm
    {
        
        public DIg로그인후()
        {
            InitializeComponent();
           
        }

        private void btn회원수정_Click(object sender, EventArgs e)
        {
            DIg회원정보수정 dig회원수정 = new DIg회원정보수정();
            dig회원수정.Show();
        }
    }
}