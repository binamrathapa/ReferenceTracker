using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

/// <summary>
/// Summary description for DBConnection
/// </summary>
public class DBConnection
{
    SqlConnection conn;
    string query;
    public DBConnection(string pquery)
    {
        query = pquery;
        conn = new SqlConnection("Data Source=.\\sqlexpress;Initial Catalog=ReferenceTracker;Integrated Security=True");
    }

    public DataTable GetDataTable()
    {
        try
        {
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            if (ds.Tables.Count > 0)
                return ds.Tables[0];
            else
                return null;
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }
    public int ExecuteQuery()
    {
        SqlCommand cmd = new SqlCommand(query, conn);
        try
        {

            cmd.Connection = conn;
            cmd.Connection.Open();
            return cmd.ExecuteNonQuery();
        }
        catch (Exception ex)
        {
            return 0;
        }
        finally
        {
            if (cmd.Connection.State != ConnectionState.Closed)
                cmd.Connection.Close();
        }
    }

    public int ExecuteScalar()
    {
        SqlCommand cmd = new SqlCommand(query, conn);
        try
        {

            cmd.Connection = conn;
            cmd.Connection.Open();
            return Convert.ToInt32(cmd.ExecuteScalar());
        }
        catch (Exception ex)
        {
            return 0;
        }
        finally
        {
            if (cmd.Connection.State != ConnectionState.Closed)
                cmd.Connection.Close();
        }
    }

}