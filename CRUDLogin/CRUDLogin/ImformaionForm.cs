using DevExpress.XtraEditors;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUDLogin
{
    public partial class ImformaionForm : DevExpress.XtraEditors.XtraForm
    {
        string _server = "localhost";
        int _port = 3306;
        string _database = "new_login";
        string _id = "root";
        string _pw = "dhzldqm131";
        string _connectionAddress = "";

        public ImformaionForm()
        {
            InitializeComponent();
            _connectionAddress = string.Format("Server ={0};Port={1};Database={2};Uid={3};Pwd={4}", _server, _port, _database, _id, _pw);
        }
          

        private void btn회원탈퇴_Click(object sender, EventArgs e)
        {
            
                try
                {

                    MySqlConnection mysqlConnection = new MySqlConnection(_connectionAddress);
                    mysqlConnection.Open();
                    string deleteQuery = "DELETE FROM new_gin WHERE id = '" + this.te아이디삭제.Text + "';";

                    MySqlCommand cmd = new MySqlCommand(deleteQuery, mysqlConnection);
                    MySqlDataReader dr = cmd.ExecuteReader();
                MessageBox.Show("아이디가 삭제되었습니다.");

                while (dr.Read())
                     {
                      }
                mysqlConnection.Close();   
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.Message);
                }
            }
        }
    }