using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace ReferenceTracker
{
    public class UserService
    {
        public int GetLoginUserID(string userName,string password)
        {
            try
            {
                string query = "Select * From [User] Where UserName='" + userName + "' and Password='" + password + "'";
                DBConnection db = new DBConnection(query);
                DataTable dt = db.GetDataTable();
                if (dt.Rows.Count > 0)
                    return Convert.ToInt32(dt.Rows[0]["Id"]);
                else
                    return 0;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public bool SaveUser(User user)
        {
            try
            {
                string query = "insert into [user] values('" + user.UserName + "','" + user.Password + "','" + user.Email + "','" + user.FirstName + "','" + user.LastName + "')";
                DBConnection db = new DBConnection(query);
                db.ExecuteQuery();
                return true;
            }
            catch(Exception ex)
            {
                throw ex;
            }

        }
    }
}
