
using System;
using System.Data;
using System.Text;
using DataCore;
using Entity;


namespace Business._Base
{
	/// <summary>
	/// Class:ProductPicBase
	/// Author:Steven
    /// Create:2009/11/29 11:32:28
	/// </summary>
	public abstract class ProductPicBase
	{		
        /// <summary>
        /// 
        /// </summary>
		public ProductPicBase()
		{
		}
        public ProductPicInfo GetProductPicInfo(long _id)
        {
            ProductPicInfo productPicInfo = null;
            StringBuilder sql= new StringBuilder();
            sql.Append("SELECT * FROM");
            sql.Append(" [Tbl_ProductPic]");
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
                    productPicInfo = ProductPicInfo.SetValue(reader);
                }
              }
            }
            return productPicInfo;
        }
        public bool Insert(ProductPicInfo productPicInfo)
        {
            StringBuilder sql=new StringBuilder();
            sql.Append("INSERT INTO");
            sql.Append(" [Tbl_ProductPic](");            
            sql.Append("[OrderID],");
            sql.Append("[ProductNO],");
            sql.Append("[SmallPic],");
            sql.Append("[MidPic],");
            sql.Append("[BigPic]");
            sql.Append(") VALUES(");
            sql.Append("@OrderID,");
            sql.Append("@ProductNO,");
            sql.Append("@SmallPic,");
            sql.Append("@MidPic,");
            sql.Append("@BigPic");
            sql.Append(");SELECT @@IDENTITY;");
            
            using(NetShopHelper dbhelper=new NetShopHelper())
            {
                IDbDataParameter[] p_Parms=new IDbDataParameter[]{
                    dbhelper.CreateParameter("@OrderID",productPicInfo.OrderID),
                    dbhelper.CreateParameter("@ProductNO",productPicInfo.ProductNO),
                    dbhelper.CreateParameter("@SmallPic",productPicInfo.SmallPic),
                    dbhelper.CreateParameter("@MidPic",productPicInfo.MidPic),
                    dbhelper.CreateParameter("@BigPic",productPicInfo.BigPic)
                };
            long ret=(long)dbhelper.ExecuteScalar(sql.ToString(),p_Parms);
            productPicInfo.Id=ret;
            return true;
            }
        }
        public bool Update(ProductPicInfo productPicInfo)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("UPDATE");
            sql.Append(" [Tbl_ProductPic]");
            sql.Append(" SET");
            sql.Append(" [OrderID]=@OrderID,");
            sql.Append(" [ProductNO]=@ProductNO,");
            sql.Append(" [SmallPic]=@SmallPic,");
            sql.Append(" [MidPic]=@MidPic,");
            sql.Append(" [BigPic]=@BigPic");
            sql.Append(" WHERE");
            sql.Append(" [ID]=@ID");
            using(NetShopHelper dbhelper=new NetShopHelper())
            {
              IDbDataParameter[] p_Parms = new IDbDataParameter[]{
                dbhelper.CreateParameter("@ID",productPicInfo.Id)
              };
             return 0 < dbhelper.ExecuteNonQuery(sql.ToString(),p_Parms);             
            }
        }
        public bool Delete(long _id)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("DELETE FROM");
            sql.Append(" [Tbl_ProductPic]");
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
