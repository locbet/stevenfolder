
using System;
using System.Data;
using System.Text;
using DataCore;
using Entity;


namespace Business._Base
{
	/// <summary>
	/// Class:BrandBase
	/// Author:Steven
    /// Create:2009/11/29 11:32:27
	/// </summary>
	public abstract class BrandBase
	{		
        /// <summary>
        /// 
        /// </summary>
		public BrandBase()
		{
		}
        public BrandInfo GetBrandInfo(int _id)
        {
            BrandInfo brandInfo = null;
            StringBuilder sql= new StringBuilder();
            sql.Append("SELECT * FROM");
            sql.Append(" [Tbl_Brand]");
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
                    brandInfo = BrandInfo.SetValue(reader);
                }
              }
            }
            return brandInfo;
        }
        public bool Insert(BrandInfo brandInfo)
        {
            StringBuilder sql=new StringBuilder();
            sql.Append("INSERT INTO");
            sql.Append(" [Tbl_Brand](");            
            sql.Append("[CateID],");
            sql.Append("[NickName],");
            sql.Append("[BrandName],");
            sql.Append("[OrderID]");
            sql.Append(") VALUES(");
            sql.Append("@CateID,");
            sql.Append("@NickName,");
            sql.Append("@BrandName,");
            sql.Append("@OrderID");
            sql.Append(");SELECT @@IDENTITY;");
            
            using(NetShopHelper dbhelper=new NetShopHelper())
            {
                IDbDataParameter[] p_Parms=new IDbDataParameter[]{
                    dbhelper.CreateParameter("@CateID",brandInfo.CateID),
                    dbhelper.CreateParameter("@NickName",brandInfo.NickName),
                    dbhelper.CreateParameter("@BrandName",brandInfo.BrandName),
                    dbhelper.CreateParameter("@OrderID",brandInfo.OrderID)
                };
            int ret=(int)dbhelper.ExecuteScalar(sql.ToString(),p_Parms);
            brandInfo.Id=ret;
            return true;
            }
        }
        public bool Update(BrandInfo brandInfo)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("UPDATE");
            sql.Append(" [Tbl_Brand]");
            sql.Append(" SET");
            sql.Append(" [CateID]=@CateID,");
            sql.Append(" [NickName]=@NickName,");
            sql.Append(" [BrandName]=@BrandName,");
            sql.Append(" [OrderID]=@OrderID");
            sql.Append(" WHERE");
            sql.Append(" [ID]=@ID");
            using(NetShopHelper dbhelper=new NetShopHelper())
            {
              IDbDataParameter[] p_Parms = new IDbDataParameter[]{
                dbhelper.CreateParameter("@ID",brandInfo.Id)
              };
             return 0 < dbhelper.ExecuteNonQuery(sql.ToString(),p_Parms);             
            }
        }
        public bool Delete(int _id)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("DELETE FROM");
            sql.Append(" [Tbl_Brand]");
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
