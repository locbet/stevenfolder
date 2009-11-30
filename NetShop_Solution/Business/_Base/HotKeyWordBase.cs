
using System;
using System.Data;
using System.Text;
using DataCore;
using Entity;


namespace Business._Base
{
	/// <summary>
	/// Class:HotKeyWordBase
	/// Author:Steven
    /// Create:2009/11/29 11:32:27
	/// </summary>
	public abstract class HotKeyWordBase
	{		
        /// <summary>
        /// 
        /// </summary>
		public HotKeyWordBase()
		{
		}
        public bool Insert(HotKeyWordInfo hotKeyWordInfo)
        {
            StringBuilder sql=new StringBuilder();
            sql.Append("INSERT INTO");
            sql.Append(" [Tbl_HotKeyWord](");            
            sql.Append("[KeyWord],");
            sql.Append("[CateID],");
            sql.Append("[OrderID]");
            sql.Append(") VALUES(");
            sql.Append("@KeyWord,");
            sql.Append("@CateID,");
            sql.Append("@OrderID");
            sql.Append(")");
            
            using(NetShopHelper dbhelper=new NetShopHelper())
            {
                IDbDataParameter[] p_Parms=new IDbDataParameter[]{
                    dbhelper.CreateParameter("@KeyWord",hotKeyWordInfo.KeyWord),
                    dbhelper.CreateParameter("@CateID",hotKeyWordInfo.CateID),
                    dbhelper.CreateParameter("@OrderID",hotKeyWordInfo.OrderID)
                };
            return 0 < dbhelper.ExecuteNonQuery(sql.ToString(),p_Parms);
            }
        }
        
	}
}
