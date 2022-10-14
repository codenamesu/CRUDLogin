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
using System.Linq.Expressions;
using CRUDLogin.Data

namespace CRUDLogin
{
    public partial class LoginForm : DevExpress.XtraEditors.XtraForm
    {
        
        public LoginForm()
        {
            InitializeComponent();
            

        }

        private void btn로그인_Click(object sender, EventArgs e)
        {
            try
            {
                
                conn.Open();
                int login_status = 0;

                string loginid = te아이디.Text;
                string loginpw = te비밀번호.Text;

                string selectQuery = "SELECT * FROM new_gin WHERE id = \'" + loginid + "\' ";

                MySqlCommand Selectcommand = new MySqlCommand(selectQuery, conn);

                MySqlDataReader userAccount = Selectcommand.ExecuteReader();

                while (userAccount.Read())
                {
                    if (loginid == (string)userAccount["id"] && loginpw == (string)userAccount["pwd"])
                    {
                        login_status = 1;
                    }
                }
                conn.Close();

                if (login_status == 1)
                {
                    MessageBox.Show("로그인 완료");
                }
                else
                {
                    MessageBox.Show("회원 정보를 확인해주세요.");
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
    
        private void btn회원가입_Click(object sender, EventArgs e)
        {
            userAddForm form02 = new userAddForm();
            form02.ShowDialog();
        }
    }
}