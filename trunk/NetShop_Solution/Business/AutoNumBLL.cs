using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DataCore;

namespace Business
{
    public class AutoNumBLL
    {
        #region static method

        #region public method
        /// <summary>
        /// 获得一个新的产品编号
        /// </summary>
        /// <returns></returns>
        public static string NewProductNO()
        {
            return NewResult(1);
        }
        /// <summary>
        /// 获得一个新的客户编号
        /// </summary>
        /// <returns></returns>
        public static string NewCustomerNO()
        {
            return NewResult(2);
        }
        #endregion

        #region private method
        /// <summary>
        /// 根据keyid获取相应的结果数据
        /// </summary>
        /// <param name="keyid"></param>
        /// <returns></returns>
        private static string NewResult(int keyid)
        {
            IDbDataParameter p_keyid = NetShopStaticHelper.CreateParameter("@keyid", SqlDbType.Int, keyid);
            object result = NetShopStaticHelper.ExecuteScalar(CommandType.StoredProcedure, "sp_GetAutoNum", p_keyid);
            return Convert.ToString(result);
        }
        #endregion

        #endregion
    }
}
