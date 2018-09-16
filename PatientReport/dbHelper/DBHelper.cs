using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace PatientReport.dbHelper
{
    /// <summary>
    /// <para>Establish a connection to database</para>
    /// </summary>
    public class DBHelper
    {
        #region Fields
        private  SqlConnection con;
        #endregion
        #region Connection
        #region DbConnetion
        public DBHelper()
        {
            string conString = ConfigurationManager.ConnectionStrings["LifeSpring"].ToString();
            con = new SqlConnection(conString);
        }
        #endregion

        public  DataSet SqlQuery(string query)
        {
            DataSet ds=null;
            SqlCommand cmd = null;
            SqlDataAdapter adap = null;
            try
            {
                con.Open();
                cmd = new SqlCommand(query, con); 
                 adap = new SqlDataAdapter(cmd);
                ds = new DataSet();
                adap.Fill(ds);
                con.Close();

                
                //cmd.CommandType = CommandType.
                //dbo.getPatientDetails
            }
            catch(Exception e)
            {
                //TODO
                //LogExMsg
                //e.Message;
            }
            finally
            {
                cmd.Dispose();
                adap.Dispose();
                con.Dispose();
            }
            return ds;
        }
    }
    #endregion

}