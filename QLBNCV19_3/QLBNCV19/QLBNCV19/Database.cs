using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace QLBNCV19
{
    public class Database : IDisposable
    {
        private string connectionString = @"Server= VTK0918690920\SQLEXPRESS; database=QLBNCV19; integrated Security=true";
        private SqlConnection cnn;
        private SqlCommand cmd;
        private SqlDataAdapter da;

        public void Dispose()
        {
            if (cnn != null)
            {
                cnn.Dispose();
                cnn = null;
            }
            if (cmd != null)
            {
                cmd.Dispose();
                cmd = null;
            }
            if (da != null)
            {
                da.Dispose();
                da = null;
            }
        }
        public Database()
        {
            cnn = new SqlConnection();
            cnn.ConnectionString = connectionString;
        }
        public bool KiemTraKetNoi(ref string err)
        {
            try
            {
                cnn.Open();
                return true;
            }
            catch (Exception ex)
            {
                err = ex.Message;
                return false;
            }
            finally
            {
                cnn.Close();
            }
        }
        public DataTable GetDataTable(ref string err, string Sql, CommandType ct, params SqlParameter[] param)
        {
            DataTable dt = null;
            try
            {
                if (cnn.State == ConnectionState.Open)
                {
                    cnn.Close();
                }
                cnn.Open();
                cmd = new SqlCommand(Sql, cnn);
                cmd.CommandType = ct;
                cmd.CommandTimeout = 6000;
                if (param != null)
                {

                    foreach (SqlParameter item in param)
                    {
                        cmd.Parameters.Add(item);
                    }
                }
                da = new SqlDataAdapter(cmd);
                dt = new DataTable();
                da.Fill(dt);
                // return dt;
            }
            catch (Exception ex)
            {
                err = ex.Message;
            }
            finally
            {
                cnn.Close();
            }
            return dt;
        }
        
        public bool myExcutenonQuery(ref string err, string procedudeName, CommandType cmt, params SqlParameter[] param)
        {
            bool result = false;
            try
            {
                if (cnn.State == ConnectionState.Open)
                {
                    cnn.Close();
                }
                cnn.Open();
                cmd = new SqlCommand(procedudeName, cnn);
                cmd.CommandType = cmt;
                cmd.CommandTimeout = 600;
                if (param != null)
                {
                    foreach (var item in param)
                    {
                        cmd.Parameters.Add(item);
                    }
                }
                cmd.ExecuteNonQuery();
                result = true;
            }
            catch (Exception ex)
            {
                err = ex.Message;
            }
            return result;
        }
    }
}

