
using System;
using System.Data;
using System.Text;
using DataCore;
using Entity;


namespace Business._Base
{
	/// <summary>
	/// Class:PriceLevelBase
	/// Author:Steven
    /// Create:2009/11/29 11:32:27
	/// </summary>
	public abstract class PriceLevelBase
	{		
        /// <summary>
        /// 
        /// </summary>
		public PriceLevelBase()
		{
		}
        public PriceLevelInfo GetPriceLevelInfo(int _id)
        {
            PriceLevelInfo priceLevelInfo = null;
            StringBuilder sql= new StringBuilder();
            sql.Append("SELECT * FROM");
            sql.Append(" [Tbl_PriceLevel]");
            sql.Append(" WHERE");
            sql.Append(" [ID]=@ID");
            using(NetShopHelper dbhelper=new NetShopHelper())
            {
              IDbDataParameter[] p_Parms = new IDbDataParameter[]{
                dbhelper.CreateParameter("@ID",_id)
              };
              using(IDataReader reader=dbhelper.ExecuteReader(sql.ToString(),p_Parms))
              {
                if(reader.Read())
                {
                    priceLevelInfo = PriceLevelInfo.SetValue(reader);
                }
              }
            }
            return priceLevelInfo;
        }
        public bool Insert(PriceLevelInfo priceLevelInfo)
        {
            StringBuilder sql=new StringBuilder();
            sql.Append("INSERT INTO");
            sql.Append(" [Tbl_PriceLevel](");            
            sql.Append("[CateID],");
            sql.Append("[NickName],");
            sql.Append("[StartPrice],");
            sql.Append("[EndPrice],");
            sql.Append("[OrderID]");
            sql.Append(") VALUES(");
            sql.Append("@CateID,");
            sql.Append("@NickName,");
            sql.Append("@StartPrice,");
            sql.Append("@EndPrice,");
            sql.Append("@OrderID");
            sql.Append(");SELECT @@IDENTITY;");
            
            using(NetShopHelper dbhelper=new NetShopHelper())
            {
                IDbDataParameter[] p_Parms=new IDbDataParameter[]{
                    dbhelper.CreateParameter("@CateID",priceLevelInfo.CateID),
                    dbhelper.CreateParameter("@NickName",priceLevelInfo.NickName),
                    dbhelper.CreateParameter("@StartPrice",priceLevelInfo.StartPrice),
                    dbhelper.CreateParameter("@EndPrice",priceLevelInfo.EndPrice),
                    dbhelper.CreateParameter("@OrderID",priceLevelInfo.OrderID)
                };
            int ret=(int)dbhelper.ExecuteScalar(sql.ToString(),p_Parms);
            priceLevelInfo.Id=ret;
            return true;
            }
        }
        public bool Update(PriceLevelInfo priceLevelInfo)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("UPDATE");
            sql.Append(" [Tbl_PriceLevel]");
            sql.Append(" SET");
            sql.Append(" [CateID]=@CateID,");
            sql.Append(" [NickName]=@NickName,");
            sql.Append(" [StartPrice]=@StartPrice,");
            sql.Append(" [EndPrice]=@EndPrice,");
            sql.Append(" [OrderID]=@OrderID");
            sql.Append(" WHERE");
            sql.Append(" [ID]=@ID");
            using(NetShopHelper dbhelper=new NetShopHelper())
            {
              IDbDataParameter[] p_Parms = new IDbDataParameter[]{
                dbhelper.CreateParameter("@ID",priceLevelInfo.Id)
              };
             return 0 < dbhelper.ExecuteNonQuery(sql.ToString(),p_Parms);             
            }
        }
        public bool Delete(int _id)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("DELETE FROM");
            sql.Append(" [Tbl_PriceLevel]");
            sql.Append(" WHERE");
            sql.Append(" [ID]=@ID");
            using(NetShopHelper dbhelper=new NetShopHelper())
            {
              IDbDataParameter[] p_Parms = new IDbDataParameter[]{
                dbhelper.CreateParameter("@ID",_id)
              };
             return 0 < dbhelper.ExecuteNonQuery(sql.ToString(),p_Parms);             
            }
        }
        
	}
}
