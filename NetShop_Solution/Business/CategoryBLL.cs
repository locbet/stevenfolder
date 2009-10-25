using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entity;
using System.Data;
using DataCore;

namespace Business
{
    public class CategoryBLL
    {
        #region protected method
        private List<CategoryInfo> GetCategories(int parentid, int levelid)
        {
            List<CategoryInfo> cateList = new List<CategoryInfo>();
            using (NetShopHelper ns = new NetShopHelper())
            {
                string sql = "SELECT * FROM [Tbl_Category] WHERE [ParentID]=@parentid AND [LevelID]=@levelid ORDER BY [OrderID] ASC";
                IDbDataParameter p_parentid = ns.CreateParameter("@parentid", SqlDbType.Int, parentid);
                IDbDataParameter p_levelid = ns.CreateParameter("@levelid", SqlDbType.Int, levelid);
                using (IDataReader reader = ns.ExecuteReader(sql, p_parentid, p_levelid))
                {
                    while (reader.Read())
                    {
                        cateList.Add(CategoryInfo.SetValue(reader));
                    }
                }
            }
            return cateList;
        }
        #endregion

        public List<CategoryInfo> GetFirst()
        {
            return GetCategories(0, 0);
        }
        public List<CategoryInfo> GetSecond(int parentid)
        {
            return GetCategories(parentid, 1);
        }
        public List<CategoryInfo> GetThird(int parentid)
        {
            return GetCategories(parentid, 2);
        }
    }
}
