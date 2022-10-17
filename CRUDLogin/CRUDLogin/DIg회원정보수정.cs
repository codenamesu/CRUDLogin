using DevExpress.XtraEditors;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUDLogin
{
    public partial class DIg회원정보수정 : DevExpress.XtraEditors.XtraForm
    {
        string _server = "localhost";
        int _port = 3306;
        string _database = "new_login";
        string _id = "root";
        string _pw = "dhzldqm131";
        string _connectionAddress = "";
        public DIg회원정보수정()
        {
            InitializeComponent();
            _connectionAddress = string.Format("Server ={0};Port={1};Database={2};Uid={3};Pwd={4}", _server, _port, _database, _id, _pw);
        }

        private void btn저장_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection con = new MySqlConnection(_connectionAddress);
                con.Open();

                string updateQuery = "UPDATE new_gin SET name = '" + this.te이름.Text +
                    "',pwd='" + this.te비밀번호.Text +
                    "',phonenumber='" + this.te핸드폰.Text+ "'";

                MySqlCommand com = new MySqlCommand(updateQuery, con);
                if (com.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("회원정보가 수정되었습니다.");
                    con.Close();
                    Close();
                }
                else
                {
                    MessageBox.Show("회원정보가 없습니다.");
                }
            }
            catch(Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
    }
}