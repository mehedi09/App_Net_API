using ELPL_API.Utilities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ELPL_API.DAL
{
    public class API
    {
        public static SqlConnection conn = new SqlConnection(DBConnection.GetConnectionString());
        public DataTable Check_GiftVoucher(string _CODE, string _DOCDATE, string _BID,string _DEVICEID,string _USER)
        {
            DataTable dt = new DataTable();
            if (conn.State == 0)
            {
                conn.Open();
            }
            SqlCommand cmd = new SqlCommand("SP_INVOICE_GFTINSERT", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@CODE", SqlDbType.NVarChar).Value = _CODE;
            cmd.Parameters.Add("@DOCDATE", SqlDbType.NVarChar).Value = _DOCDATE;
            cmd.Parameters.Add("@BID", SqlDbType.NVarChar).Value = _BID;
            cmd.Parameters.Add("@DEVICEID", SqlDbType.NVarChar).Value = _DEVICEID;
            cmd.Parameters.Add("@USER", SqlDbType.NVarChar).Value = _USER;
            SqlDataAdapter adpt = new SqlDataAdapter(cmd);
            adpt.Fill(dt);
            return dt;
        }

        public DataTable Update_GiftVoucher(string _CODEREF, string _DOCDATE, string _BID, string _DEVICEID, string _USER)
        {
            DataTable dt = new DataTable();
            if (conn.State == 0)
            {
                conn.Open();
            }
            SqlCommand cmd = new SqlCommand("SP_INVOICE_GFTUPDATE", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@CODEREF", SqlDbType.NVarChar).Value = _CODEREF;
            cmd.Parameters.Add("@DOCDATE", SqlDbType.NVarChar).Value = _DOCDATE;
            cmd.Parameters.Add("@BID", SqlDbType.NVarChar).Value = _BID;
            cmd.Parameters.Add("@DEVICEID", SqlDbType.NVarChar).Value = _DEVICEID;
            cmd.Parameters.Add("@USER", SqlDbType.NVarChar).Value = _USER;
            SqlDataAdapter adpt = new SqlDataAdapter(cmd);
            adpt.Fill(dt);
            return dt;
        }




    }
}