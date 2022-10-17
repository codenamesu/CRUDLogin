using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Data.ODataLinq.Helpers;
using DevExpress.Utils.VisualEffects;
using MySql.Data.MySqlClient;

namespace CRUDLogin.Data
{
    class DataManager
    {
        private static DataManager Instance = null;
        private static string ConnectString = "Server=localhost; port=3306; Database=new_login;Uid=root;Pwd=dhzldqm131#;allow user variables=true;";
        private MySqlConnection con = null;
        private MySqlConnection cmdCon = null;

        public static DataManager NewInstance()
        {
            if(Instance is null)
                Instance = new DataManager();
            return Instance;
        }

        public static DataManager GetInstance()
        {
            return Instance;
        }

        //public bool ConnectDatabase()
        //{
        //    bool isConnected = false;
        //    try
        //    {
        //        MysqlBD
        //    }
        //}
        //private void MysqlDBConnection()
        //{
        //    con = new MySqlConnection(ConnectString);
        //    con.Open();
        //    cmd = new 
        //}
        public void Server()
        {
        }
       


    }
    }
    
    

