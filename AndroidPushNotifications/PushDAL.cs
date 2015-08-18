using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace AndroidPushNotifications
{
    public class PushDAL
    {
        private static string strcon = ConfigurationManager.ConnectionStrings["ApplicationServices"].ToString();
        private static SqlConnection con = null;
        private static SqlCommand cmd = null;
        private static SqlDataAdapter da = null;
        private static DataSet ds = null;
        string Sp_name = null;

        internal DataSet GetAndroidRegIds()
        {
            Sp_name = "Proc_PushGetRegId";
            con = new SqlConnection(strcon);
            cmd = new SqlCommand(Sp_name, con);
            cmd.CommandType = CommandType.StoredProcedure;

            da = new SqlDataAdapter(cmd);
            ds = new DataSet();
            da.Fill(ds);
            return ds;
        }
    }
}