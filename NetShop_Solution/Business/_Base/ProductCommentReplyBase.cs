
using System;
using System.Data;
using System.Text;
using DataCore;
using Entity;


namespace Business._Base
{
	/// <summary>
	/// Class:ProductCommentReplyBase
	/// Author:Steven
    /// Create:2009/11/29 11:32:28
	/// </summary>
	public abstract class ProductCommentReplyBase
	{		
        /// <summary>
        /// 
        /// </summary>
		public ProductCommentReplyBase()
		{
		}
        public ProductCommentReplyInfo GetProductCommentReplyInfo(int _id)
        {
            ProductCommentReplyInfo productCommentReplyInfo = null;
            StringBuilder sql= new StringBuilder();
            sql.Append("SELECT * FROM");
            sql.Append(" [Tbl_ProductCommentReply]");
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
                    productCommentReplyInfo = ProductCommentReplyInfo.SetValue(reader);
                }
              }
            }
            return productCommentReplyInfo;
        }
        public bool Insert(ProductCommentReplyInfo productCommentReplyInfo)
        {
            StringBuilder sql=new StringBuilder();
            sql.Append("INSERT INTO");
            sql.Append(" [Tbl_ProductCommentReply](");            
            sql.Append("[CommentID],");
            sql.Append("[Summary]");
            sql.Append(") VALUES(");
            sql.Append("@CommentID,");
            sql.Append("@Summary");
            sql.Append(");SELECT @@IDENTITY;");
            
            using(NetShopHelper dbhelper=new NetShopHelper())
            {
                IDbDataParameter[] p_Parms=new IDbDataParameter[]{
                    dbhelper.CreateParameter("@CommentID",productCommentReplyInfo.CommentID),
                    dbhelper.CreateParameter("@Summary",productCommentReplyInfo.Summary)
                };
            int ret=(int)dbhelper.ExecuteScalar(sql.ToString(),p_Parms);
            productCommentReplyInfo.Id=ret;
            return true;
            }
        }
        public bool Update(ProductCommentReplyInfo productCommentReplyInfo)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("UPDATE");
            sql.Append(" [Tbl_ProductCommentReply]");
            sql.Append(" SET");
            sql.Append(" [CommentID]=@CommentID,");
            sql.Append(" [Summary]=@Summary");
            sql.Append(" WHERE");
            sql.Append(" [ID]=@ID");
            using(NetShopHelper dbhelper=new NetShopHelper())
            {
              IDbDataParameter[] p_Parms = new IDbDataParameter[]{
                dbhelper.CreateParameter("@ID",productCommentReplyInfo.Id)
              };
             return 0 < dbhelper.ExecuteNonQuery(sql.ToString(),p_Parms);             
            }
        }
        public bool Delete(int _id)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("DELETE FROM");
            sql.Append(" [Tbl_ProductCommentReply]");
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
