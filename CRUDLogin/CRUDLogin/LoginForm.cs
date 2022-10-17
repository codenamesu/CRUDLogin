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
using CRUDLogin.Data;

namespace CRUDLogin
{
    public partial class LoginForm : DevExpress.XtraEditors.XtraForm
    {
        string _server = "localhost";
        int _port = 3306;
        string _database = "new_login";
        string _id = "root";
        string _pw = "dhzldqm131";
        string _connectionAddress = "";
        


        public LoginForm()
        {
            InitializeComponent();
            _connectionAddress = string.Format("Server ={0};Port={1};Database={2};Uid={3};Pwd={4}", _server, _port, _database, _id, _pw);

        }

        private void btn로그인_Click(object sender, EventArgs e)
        {
            try
            {
                int login_status = 0;

                string loginid = te아이디.Text;
                string loginpw = te비밀번호.Text;

                
                
                string selectQuery = "SELECT * FROM new_gin WHERE id = \'" + loginid + "\' ";
                MySqlConnection conn = new MySqlConnection(_connectionAddress);
                conn.Open();
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
                    DIg로그인후 dig = new DIg로그인후();
                    dig.Show();
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
            userAddForm useAdd = new userAddForm();

            useAdd.Show();
         }
    }


}