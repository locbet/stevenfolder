using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entity;
using DataCore;
using System.Data;


namespace Business
{
    public class BrandBLL
    {
        #region protected method
        protected List<BrandInfo> GetBrands(int categoryid)
        {
            List<BrandInfo> brandList = new List<BrandInfo>();
            string sql = "SELECT * FROM [Tbl_Brand] WHERE [CateID]=@categoryid ORDER BY [OrderID] ASC";

            using (NetShopHelper ns = new NetShopHelper())
            {
                IDbDataParameter p_categoryid = ns.CreateParameter("@categoryid", SqlDbType.Int, categoryid);

                IDataReader reader = ns.ExecuteReader(sql, p_categoryid);
                while (reader.Read())
                {
                    brandList.Add(BrandInfo.SetValue(reader));
                }
            }
            return brandList;
        }
        #endregion
    }
}
