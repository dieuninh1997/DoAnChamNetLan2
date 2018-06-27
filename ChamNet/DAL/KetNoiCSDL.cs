using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace ChamNet.DAL
{
    public class KetNoiCSDL
    {
        public static SqlConnection con;

        public void connect()
        {
            if (con == null)
                con = new SqlConnection("Data Source=" + ConfigurationManager.AppSettings["Server"].ToString() + ";Initial Catalog=" + ConfigurationManager.AppSettings["Database"].ToString() + ";Integrated Security=true;");
            if (con.State != ConnectionState.Open)
                con.Open();
        }
        public void disconnect()
        {
            if (con != null)
            {
                if (con.State == ConnectionState.Open)
                    con.Close();
            }
        }
        //chi co tac dung voi cau lenh insert,update,delete
        public void ThucthiSQL(string strSQL)
        {
            try
            {
                connect();
                SqlCommand sqlcmd = new SqlCommand(strSQL, con);
                sqlcmd.ExecuteNonQuery();
                sqlcmd.Dispose();
                disconnect();
            }
            catch
            {
                //return null;
            }

        }
        //su dung voi cau lenh select
        public DataTable gettable(string strSQL)
        {
            try
            {
                connect();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(strSQL, con);
                da.Fill(dt);
                disconnect();
                return dt;
            }
            catch
            {
                return null;
            }

        }
        //chi co tac dung voi cau lenh select lay mot gia tri don
        public string getvalue(string strSQL)
        {
            string temp = null;
            connect();
            SqlCommand sqlcmd = new SqlCommand(strSQL, con);
            SqlDataReader sqlrd = sqlcmd.ExecuteReader();
            while (sqlrd.Read())
                temp = sqlrd[0].ToString();
            return temp;

        }
        public string laymacuoi(string tenbang, string tencot)
        {
            DataTable dt = gettable("SELECT max(" + tencot + ") FROM " + tenbang + "");
            if (dt.Rows[0][0].ToString() == "")
            {
                return "DH000";
            }
            else
            {
                return dt.Rows[0][0].ToString();
            }
        }
    }
}
