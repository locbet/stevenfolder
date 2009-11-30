
using System;
using System.Data;
using System.Text;
using DataCore;
using Entity;


namespace Business._Base
{
	/// <summary>
	/// Class:ProductCommentBase
	/// Author:Steven
    /// Create:2009/11/29 11:32:28
	/// </summary>
	public abstract class ProductCommentBase
	{		
        /// <summary>
        /// 
        /// </summary>
		public ProductCommentBase()
		{
		}
        public ProductCommentInfo GetProductCommentInfo(int _id)
        {
            ProductCommentInfo productCommentInfo = null;
            StringBuilder sql= new StringBuilder();
            sql.Append("SELECT * FROM");
            sql.Append(" [Tbl_ProductComment]");
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
                    productCommentInfo = ProductCommentInfo.SetValue(reader);
                }
              }
            }
            return productCommentInfo;
        }
        public bool Insert(ProductCommentInfo productCommentInfo)
        {
            StringBuilder sql=new StringBuilder();
            sql.Append("INSERT INTO");
            sql.Append(" [Tbl_ProductComment](");            
            sql.Append("[ProductNO],");
            sql.Append("[Title],");
            sql.Append("[Merits],");
            sql.Append("[Demerits],");
            sql.Append("[Summary],");
            sql.Append("[Star],");
            sql.Append("[ReplyCount]");
            sql.Append(") VALUES(");
            sql.Append("@ProductNO,");
            sql.Append("@Title,");
            sql.Append("@Merits,");
            sql.Append("@Demerits,");
            sql.Append("@Summary,");
            sql.Append("@Star,");
            sql.Append("@ReplyCount");
            sql.Append(");SELECT @@IDENTITY;");
            
            using(NetShopHelper dbhelper=new NetShopHelper())
            {
                IDbDataParameter[] p_Parms=new IDbDataParameter[]{
                    dbhelper.CreateParameter("@ProductNO",productCommentInfo.ProductNO),
                    dbhelper.CreateParameter("@Title",productCommentInfo.Title),
                    dbhelper.CreateParameter("@Merits",productCommentInfo.Merits),
                    dbhelper.CreateParameter("@Demerits",productCommentInfo.Demerits),
                    dbhelper.CreateParameter("@Summary",productCommentInfo.Summary),
                    dbhelper.CreateParameter("@Star",productCommentInfo.Star),
                    dbhelper.CreateParameter("@ReplyCount",productCommentInfo.ReplyCount)
                };
            int ret=(int)dbhelper.ExecuteScalar(sql.ToString(),p_Parms);
            productCommentInfo.Id=ret;
            return true;
            }
        }
        public bool Update(ProductCommentInfo productCommentInfo)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("UPDATE");
            sql.Append(" [Tbl_ProductComment]");
            sql.Append(" SET");
            sql.Append(" [ProductNO]=@ProductNO,");
            sql.Append(" [Title]=@Title,");
            sql.Append(" [Merits]=@Merits,");
            sql.Append(" [Demerits]=@Demerits,");
            sql.Append(" [Summary]=@Summary,");
            sql.Append(" [Star]=@Star,");
            sql.Append(" [ReplyCount]=@ReplyCount");
            sql.Append(" WHERE");
            sql.Append(" [ID]=@ID");
            using(NetShopHelper dbhelper=new NetShopHelper())
            {
              IDbDataParameter[] p_Parms = new IDbDataParameter[]{
                dbhelper.CreateParameter("@ID",productCommentInfo.Id)
              };
             return 0 < dbhelper.ExecuteNonQuery(sql.ToString(),p_Parms);             
            }
        }
        public bool Delete(int _id)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("DELETE FROM");
            sql.Append(" [Tbl_ProductComment]");
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
