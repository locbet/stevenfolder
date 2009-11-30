
using System;
using System.Data;
using System.Text;
using DataCore;
using Entity;


namespace Business._Base
{
	/// <summary>
	/// Class:CategoryBase
	/// Author:Steven
    /// Create:2009/11/29 11:32:27
	/// </summary>
	public abstract class CategoryBase
	{		
        /// <summary>
        /// 
        /// </summary>
		public CategoryBase()
		{
		}
        public CategoryInfo GetCategoryInfo(int _id)
        {
            CategoryInfo categoryInfo = null;
            StringBuilder sql= new StringBuilder();
            sql.Append("SELECT * FROM");
            sql.Append(" [Tbl_Category]");
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
                    categoryInfo = CategoryInfo.SetValue(reader);
                }
              }
            }
            return categoryInfo;
        }
        public bool Insert(CategoryInfo categoryInfo)
        {
            StringBuilder sql=new StringBuilder();
            sql.Append("INSERT INTO");
            sql.Append(" [Tbl_Category](");            
            sql.Append("[CateName],");
            sql.Append("[ParentID],");
            sql.Append("[LevelID],");
            sql.Append("[OrderID],");
            sql.Append("[FullPath],");
            sql.Append("[PageUrl]");
            sql.Append(") VALUES(");
            sql.Append("@CateName,");
            sql.Append("@ParentID,");
            sql.Append("@LevelID,");
            sql.Append("@OrderID,");
            sql.Append("@FullPath,");
            sql.Append("@PageUrl");
            sql.Append(");SELECT @@IDENTITY;");
            
            using(NetShopHelper dbhelper=new NetShopHelper())
            {
                IDbDataParameter[] p_Parms=new IDbDataParameter[]{
                    dbhelper.CreateParameter("@CateName",categoryInfo.CateName),
                    dbhelper.CreateParameter("@ParentID",categoryInfo.ParentID),
                    dbhelper.CreateParameter("@LevelID",categoryInfo.LevelID),
                    dbhelper.CreateParameter("@OrderID",categoryInfo.OrderID),
                    dbhelper.CreateParameter("@FullPath",categoryInfo.FullPath),
                    dbhelper.CreateParameter("@PageUrl",categoryInfo.PageUrl)
                };
            int ret=(int)dbhelper.ExecuteScalar(sql.ToString(),p_Parms);
            categoryInfo.Id=ret;
            return true;
            }
        }
        public bool Update(CategoryInfo categoryInfo)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("UPDATE");
            sql.Append(" [Tbl_Category]");
            sql.Append(" SET");
            sql.Append(" [CateName]=@CateName,");
            sql.Append(" [ParentID]=@ParentID,");
            sql.Append(" [LevelID]=@LevelID,");
            sql.Append(" [OrderID]=@OrderID,");
            sql.Append(" [FullPath]=@FullPath,");
            sql.Append(" [PageUrl]=@PageUrl");
            sql.Append(" WHERE");
            sql.Append(" [ID]=@ID");
            using(NetShopHelper dbhelper=new NetShopHelper())
            {
              IDbDataParameter[] p_Parms = new IDbDataParameter[]{
                dbhelper.CreateParameter("@ID",categoryInfo.Id)
              };
             return 0 < dbhelper.ExecuteNonQuery(sql.ToString(),p_Parms);             
            }
        }
        public bool Delete(int _id)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("DELETE FROM");
            sql.Append(" [Tbl_Category]");
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
