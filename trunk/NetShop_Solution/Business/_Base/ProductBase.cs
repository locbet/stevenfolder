
using System;
using System.Data;
using System.Text;
using DataCore;
using Entity;


namespace Business._Base
{
	/// <summary>
	/// Class:ProductBase
	/// Author:Steven
    /// Create:2009/11/29 11:32:28
	/// </summary>
	public abstract class ProductBase
	{		
        /// <summary>
        /// 
        /// </summary>
		public ProductBase()
		{
		}
        public ProductInfo GetProductInfo(string _productNO)
        {
            ProductInfo productInfo = null;
            StringBuilder sql= new StringBuilder();
            sql.Append("SELECT * FROM");
            sql.Append(" [Tbl_Product]");
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
                    productInfo = ProductInfo.SetValue(reader);
                }
              }
            }
            return productInfo;
        }
        public bool Insert(ProductInfo productInfo)
        {
            StringBuilder sql=new StringBuilder();
            sql.Append("INSERT INTO");
            sql.Append(" [Tbl_Product](");            
            sql.Append("[ProductNO],");
            sql.Append("[CateIDPath],");
            sql.Append("[NickName],");
            sql.Append("[ProductName],");
            sql.Append("[MarketPrice],");
            sql.Append("[InnerPrice],");
            sql.Append("[BrandID],");
            sql.Append("[BrandName]");
            sql.Append(") VALUES(");
            sql.Append("@ProductNO,");
            sql.Append("@CateIDPath,");
            sql.Append("@NickName,");
            sql.Append("@ProductName,");
            sql.Append("@MarketPrice,");
            sql.Append("@InnerPrice,");
            sql.Append("@BrandID,");
            sql.Append("@BrandName");
            sql.Append(")");
            
            using(NetShopHelper dbhelper=new NetShopHelper())
            {
                IDbDataParameter[] p_Parms=new IDbDataParameter[]{
                    dbhelper.CreateParameter("@ProductNO",productInfo.ProductNO),
                    dbhelper.CreateParameter("@CateIDPath",productInfo.CateIDPath),
                    dbhelper.CreateParameter("@NickName",productInfo.NickName),
                    dbhelper.CreateParameter("@ProductName",productInfo.ProductName),
                    dbhelper.CreateParameter("@MarketPrice",productInfo.MarketPrice),
                    dbhelper.CreateParameter("@InnerPrice",productInfo.InnerPrice),
                    dbhelper.CreateParameter("@BrandID",productInfo.BrandID),
                    dbhelper.CreateParameter("@BrandName",productInfo.BrandName)
                };
            return 0 < dbhelper.ExecuteNonQuery(sql.ToString(),p_Parms);
            }
        }
        public bool Update(ProductInfo productInfo)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("UPDATE");
            sql.Append(" [Tbl_Product]");
            sql.Append(" SET");
            sql.Append(" [CateIDPath]=@CateIDPath,");
            sql.Append(" [NickName]=@NickName,");
            sql.Append(" [ProductName]=@ProductName,");
            sql.Append(" [MarketPrice]=@MarketPrice,");
            sql.Append(" [InnerPrice]=@InnerPrice,");
            sql.Append(" [BrandID]=@BrandID,");
            sql.Append(" [BrandName]=@BrandName");
            sql.Append(" WHERE");
            sql.Append(" [ProductNO]=@ProductNO");
            using(NetShopHelper dbhelper=new NetShopHelper())
            {
              IDbDataParameter[] p_Parms = new IDbDataParameter[]{
                dbhelper.CreateParameter("@ProductNO",productInfo.ProductNO)
              };
             return 0 < dbhelper.ExecuteNonQuery(sql.ToString(),p_Parms);             
            }
        }
        public bool Delete(string _productNO)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("DELETE FROM");
            sql.Append(" [Tbl_Product]");
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
