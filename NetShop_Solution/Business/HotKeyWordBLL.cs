using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataCore;
using System.Data;

namespace Business
{
    public class HotKeyWordBLL
    {
        #region static method
        #region public method
        public static List<string> GetHotKeyWords()
        {
            List<string> lst_keyword = new List<string>();
            string sql = "select [KeyWord] from dbo.Tbl_HotKeyWord where CateID=0 order by OrderID asc";

            using (NetShopHelper nsh = new NetShopHelper())
            {
                using (IDataReader reader = nsh.ExecuteReader(sql))
                {
                    while (reader.Read())
                    {
                        lst_keyword.Add(reader.GetString(0));
                    }
                }
            }
            return lst_keyword;
        }
        #endregion
        #endregion
    }
}
