namespace DataCore.ConnString
{
    /// <summary>
    /// 数据库连接类
    /// </summary>
    public class NetShopConnString : Base.AbsConnString
    {
        public NetShopConnString()
        {

        }
        private string _connectionstring;
        public override string ConnectionString
        {
            get
            {
                if (string.IsNullOrEmpty(_connectionstring))
                {
                    _connectionstring = System.Configuration.ConfigurationManager.ConnectionStrings["NetShopConnString"].ConnectionString;
                }
                return _connectionstring;
            }
        }
    }
}
