
using System;
using System.Data;
using System.Text;
using DataCore;
using Entity;


namespace Business._Base
{
	/// <summary>
	/// Class:ProductAnswerBase
	/// Author:Steven
    /// Create:2009/11/29 11:32:28
	/// </summary>
	public abstract class ProductAnswerBase
	{		
        /// <summary>
        /// 
        /// </summary>
		public ProductAnswerBase()
		{
		}
        public ProductAnswerInfo GetProductAnswerInfo(int _id)
        {
            ProductAnswerInfo productAnswerInfo = null;
            StringBuilder sql= new StringBuilder();
            sql.Append("SELECT * FROM");
            sql.Append(" [Tbl_ProductAnswer]");
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
                    productAnswerInfo = ProductAnswerInfo.SetValue(reader);
                }
              }
            }
            return productAnswerInfo;
        }
        public bool Insert(ProductAnswerInfo productAnswerInfo)
        {
            StringBuilder sql=new StringBuilder();
            sql.Append("INSERT INTO");
            sql.Append(" [Tbl_ProductAnswer](");            
            sql.Append("[ID],");
            sql.Append("[ProductNO],");
            sql.Append("[ServiceType],");
            sql.Append("[Ask],");
            sql.Append("[Answer],");
            sql.Append("[YesCount],");
            sql.Append("[NoCount]");
            sql.Append(") VALUES(");
            sql.Append("@ID,");
            sql.Append("@ProductNO,");
            sql.Append("@ServiceType,");
            sql.Append("@Ask,");
            sql.Append("@Answer,");
            sql.Append("@YesCount,");
            sql.Append("@NoCount");
            sql.Append(")");
            
            using(NetShopHelper dbhelper=new NetShopHelper())
            {
                IDbDataParameter[] p_Parms=new IDbDataParameter[]{
                    dbhelper.CreateParameter("@ID",productAnswerInfo.Id),
                    dbhelper.CreateParameter("@ProductNO",productAnswerInfo.ProductNO),
                    dbhelper.CreateParameter("@ServiceType",productAnswerInfo.ServiceType),
                    dbhelper.CreateParameter("@Ask",productAnswerInfo.Ask),
                    dbhelper.CreateParameter("@Answer",productAnswerInfo.Answer),
                    dbhelper.CreateParameter("@YesCount",productAnswerInfo.YesCount),
                    dbhelper.CreateParameter("@NoCount",productAnswerInfo.NoCount)
                };
            return 0 < dbhelper.ExecuteNonQuery(sql.ToString(),p_Parms);
            }
        }
        public bool Update(ProductAnswerInfo productAnswerInfo)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("UPDATE");
            sql.Append(" [Tbl_ProductAnswer]");
            sql.Append(" SET");
            sql.Append(" [ProductNO]=@ProductNO,");
            sql.Append(" [ServiceType]=@ServiceType,");
            sql.Append(" [Ask]=@Ask,");
            sql.Append(" [Answer]=@Answer,");
            sql.Append(" [YesCount]=@YesCount,");
            sql.Append(" [NoCount]=@NoCount");
            sql.Append(" WHERE");
            sql.Append(" [ID]=@ID");
            using(NetShopHelper dbhelper=new NetShopHelper())
            {
              IDbDataParameter[] p_Parms = new IDbDataParameter[]{
                dbhelper.CreateParameter("@ID",productAnswerInfo.Id)
              };
             return 0 < dbhelper.ExecuteNonQuery(sql.ToString(),p_Parms);             
            }
        }
        public bool Delete(int _id)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("DELETE FROM");
            sql.Append(" [Tbl_ProductAnswer]");
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
