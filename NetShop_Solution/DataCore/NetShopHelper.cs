using System;
using System.Data;
using DataCore.Base;

namespace DataCore
{
    /// <summary>
    /// 
    /// </summary>
    public class NetShopHelper : Base.BaseHelper
    {
        private static ConnString.NetShopConnString conn = new ConnString.NetShopConnString();

        public NetShopHelper()
            : base(conn)
        {

        }
        public void SetParameter(IDataParameter parameter, object value)
        {
            if (value == null)
            {
                value = (object)DBNull.Value;
            }
            parameter.Value = value;
        }
        ~NetShopHelper()
        {
            this.Close();
        }
    }
    /// <summary>
    /// 
    /// </summary>
    public class NetShopStaticHelper : BaseStaticHelper<ConnString.NetShopConnString>
    {

    }
}
