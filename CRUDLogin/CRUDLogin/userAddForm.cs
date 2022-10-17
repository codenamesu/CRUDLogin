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
    public partial class userAddForm : DevExpress.XtraEditors.XtraForm
    {
        string _server = "localhost";
        int _port = 3306;
        string _database = "new_login";
        string _id = "root";
        string _pw = "dhzldqm131";
        string _connectionAddress = "";
        public userAddForm()
        {
            InitializeComponent();
            _connectionAddress = string.Format("Server ={0};Port={1};Database={2};Uid={3};Pwd={4}", _server, _port, _database, _id, _pw);
        }

        private void btn회원가입_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection mySqlConnection = new MySqlConnection(_connectionAddress);
                mySqlConnection.Open();

                string insertQuery = "INSERT INTO new_gin(name, id, pwd, phonenumber) VALUES('" + te이름.Text+"','" + te아이디.Text+"','"+te비밀번호.Text+"','" +te핸드폰.Text+"')";
                
                MySqlCommand cmd = new MySqlCommand(insertQuery, mySqlConnection);

                if(cmd.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show(te이름.Text + "님의 회원가입 완료, 사용할 아이디는 " + te아이디.Text + "입니다.");
                    mySqlConnection.Close();

                    Close();
                }
                else
                {
                    MessageBox.Show("재확인 요망");
                }
               
                
            }
            catch(Exception exc)
            {
                MessageBox.Show("아이디가 중복되었습니다.");
            }

        }

        private void btn회원탈퇴_Click(object sender, EventArgs e)
        {
            ImformaionForm form03 = new ImformaionForm();
            form03.ShowDialog();
        }

        private void userAddForm_Load(object sender, EventArgs e)
        {

        }
    }
}