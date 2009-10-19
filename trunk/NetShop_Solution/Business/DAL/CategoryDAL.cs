using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entity;
using DataCore;
using System.Data;

namespace Business.DAL
{
    public class CategoryDAL
    {
        public CategoryInfo CheckLogin()
        {
            string sql = "select * from [User] where [UserName]=@username";
            using (NetShopHelper db = new NetShopHelper())
            {
                IDbDataParameter p = db.CreateParameter("@username", SqlDbType.NVarChar, 50, "steven");
                IDataReader reader = db.ExecuteReader(sql, p);
                if (reader.Read())
                {
                    return CategoryInfo.SetValue(reader);
                }
                else
                {
                    return null;
                }
            }
        }
        public int GetUserCount()
        {
            string sql = "select count(*) from [User]";
            return Convert.ToInt32(NetShopStaticHelper.ExecuteScalar(CommandType.Text, sql));
        }
    }
}
