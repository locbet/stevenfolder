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
        protected List<CategoryInfo> GetCategories(int parentid, int levelid)
        {
            List<CategoryInfo> cateList = new List<CategoryInfo>();
            using (NetShopHelper ns = new NetShopHelper())
            {
                string sql = "select * from [Tbl_Category] where [ParentID]=@parentid and [LevelID]=@levelid order by OrderID asc";
                IDbDataParameter p_parentid = ns.CreateParameter("@parentid", SqlDbType.Int, parentid);
                IDbDataParameter p_levelid = ns.CreateParameter("@levelid", SqlDbType.Int, levelid);
                IDataReader reader = ns.ExecuteReader(sql, p_parentid, p_levelid);
                while (reader.Read())
                {
                    cateList.Add(CategoryInfo.SetValue(reader));
                }
            }
            return cateList;
        }
    }
}
