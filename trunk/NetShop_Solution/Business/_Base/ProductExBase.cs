
using System;
using System.Data;
using System.Text;
using DataCore;
using Entity;


namespace Business._Base
{
	/// <summary>
	/// Class:ProductExBase
	/// Author:Steven
    /// Create:2009/11/29 11:32:28
	/// </summary>
	public abstract class ProductExBase
	{		
        /// <summary>
        /// 
        /// </summary>
		public ProductExBase()
		{
		}
        public ProductExInfo GetProductExInfo(string _productNO)
        {
            ProductExInfo productExInfo = null;
            StringBuilder sql= new StringBuilder();
            sql.Append("SELECT * FROM");
            sql.Append(" [Tbl_ProductEx]");
            sql.Append(" WHERE");
            sql.Append(" [ProductNO]=@ProductNO");
            using(NetShopHelper dbhelper=new NetShopHelper())
            {
              IDbDataParameter[] p_Parms = new IDbDataParameter[]{
                dbhelper.CreateParameter("@ProductNO",_productNO)
              };
              using(IDataReader reader=dbhelper.ExecuteReader(sql.ToString(),p_Parms))
              {
                if(reader.Read())
                {
                    productExInfo = ProductExInfo.SetValue(reader);
                }
              }
            }
            return productExInfo;
        }
        public bool Insert(ProductExInfo productExInfo)
        {
            StringBuilder sql=new StringBuilder();
            sql.Append("INSERT INTO");
            sql.Append(" [Tbl_ProductEx](");            
            sql.Append("[ProductNO],");
            sql.Append("[Intro],");
            sql.Append("[Standards],");
            sql.Append("[Packing],");
            sql.Append("[Service]");
            sql.Append(") VALUES(");
            sql.Append("@ProductNO,");
            sql.Append("@Intro,");
            sql.Append("@Standards,");
            sql.Append("@Packing,");
            sql.Append("@Service");
            sql.Append(")");
            
            using(NetShopHelper dbhelper=new NetShopHelper())
            {
                IDbDataParameter[] p_Parms=new IDbDataParameter[]{
                    dbhelper.CreateParameter("@ProductNO",productExInfo.ProductNO),
                    dbhelper.CreateParameter("@Intro",productExInfo.Intro),
                    dbhelper.CreateParameter("@Standards",productExInfo.Standards),
                    dbhelper.CreateParameter("@Packing",productExInfo.Packing),
                    dbhelper.CreateParameter("@Service",productExInfo.Service)
                };
            return 0 < dbhelper.ExecuteNonQuery(sql.ToString(),p_Parms);
            }
        }
        public bool Update(ProductExInfo productExInfo)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("UPDATE");
            sql.Append(" [Tbl_ProductEx]");
            sql.Append(" SET");
            sql.Append(" [Intro]=@Intro,");
            sql.Append(" [Standards]=@Standards,");
            sql.Append(" [Packing]=@Packing,");
            sql.Append(" [Service]=@Service");
            sql.Append(" WHERE");
            sql.Append(" [ProductNO]=@ProductNO");
            using(NetShopHelper dbhelper=new NetShopHelper())
            {
              IDbDataParameter[] p_Parms = new IDbDataParameter[]{
                dbhelper.CreateParameter("@ProductNO",productExInfo.ProductNO)
              };
             return 0 < dbhelper.ExecuteNonQuery(sql.ToString(),p_Parms);             
            }
        }
        public bool Delete(string _productNO)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("DELETE FROM");
            sql.Append(" [Tbl_ProductEx]");
            sql.Append(" WHERE");
            sql.Append(" [ProductNO]=@ProductNO");
            using(NetShopHelper dbhelper=new NetShopHelper())
            {
              IDbDataParameter[] p_Parms = new IDbDataParameter[]{
                dbhelper.CreateParameter("@ProductNO",_productNO)
              };
             return 0 < dbhelper.ExecuteNonQuery(sql.ToString(),p_Parms);             
            }
        }
        
	}
}
