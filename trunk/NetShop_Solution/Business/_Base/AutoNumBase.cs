
using System;
using System.Data;
using System.Text;
using DataCore;
using Entity;


namespace Business._Base
{
	/// <summary>
	/// Class:AutoNumBase
	/// Author:Steven
    /// Create:2009/11/29 11:32:27
	/// </summary>
	public abstract class AutoNumBase
	{		
        /// <summary>
        /// 
        /// </summary>
		public AutoNumBase()
		{
		}
        public AutoNumInfo GetAutoNumInfo(int _keyID)
        {
            AutoNumInfo autoNumInfo = null;
            StringBuilder sql= new StringBuilder();
            sql.Append("SELECT * FROM");
            sql.Append(" [AutoNum]");
            sql.Append(" WHERE");
            sql.Append(" [KeyID]=@KeyID");
            using(NetShopHelper dbhelper=new NetShopHelper())
            {
              IDbDataParameter[] p_Parms = new IDbDataParameter[]{
                dbhelper.CreateParameter("@KeyID",_keyID)
              };
              using(IDataReader reader=dbhelper.ExecuteReader(sql.ToString(),p_Parms))
              {
                if(reader.Read())
                {
                    autoNumInfo = AutoNumInfo.SetValue(reader);
                }
              }
            }
            return autoNumInfo;
        }
        public bool Insert(AutoNumInfo autoNumInfo)
        {
            StringBuilder sql=new StringBuilder();
            sql.Append("INSERT INTO");
            sql.Append(" [AutoNum](");            
            sql.Append("[KeyID],");
            sql.Append("[Seed],");
            sql.Append("[SeedDate],");
            sql.Append("[Prefix],");
            sql.Append("[Summary]");
            sql.Append(") VALUES(");
            sql.Append("@KeyID,");
            sql.Append("@Seed,");
            sql.Append("@SeedDate,");
            sql.Append("@Prefix,");
            sql.Append("@Summary");
            sql.Append(")");
            
            using(NetShopHelper dbhelper=new NetShopHelper())
            {
                IDbDataParameter[] p_Parms=new IDbDataParameter[]{
                    dbhelper.CreateParameter("@KeyID",autoNumInfo.KeyID),
                    dbhelper.CreateParameter("@Seed",autoNumInfo.Seed),
                    dbhelper.CreateParameter("@SeedDate",autoNumInfo.SeedDate),
                    dbhelper.CreateParameter("@Prefix",autoNumInfo.Prefix),
                    dbhelper.CreateParameter("@Summary",autoNumInfo.Summary)
                };
            return 0 < dbhelper.ExecuteNonQuery(sql.ToString(),p_Parms);
            }
        }
        public bool Update(AutoNumInfo autoNumInfo)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("UPDATE");
            sql.Append(" [AutoNum]");
            sql.Append(" SET");
            sql.Append(" [Seed]=@Seed,");
            sql.Append(" [SeedDate]=@SeedDate,");
            sql.Append(" [Prefix]=@Prefix,");
            sql.Append(" [Summary]=@Summary");
            sql.Append(" WHERE");
            sql.Append(" [KeyID]=@KeyID");
            using(NetShopHelper dbhelper=new NetShopHelper())
            {
              IDbDataParameter[] p_Parms = new IDbDataParameter[]{
                dbhelper.CreateParameter("@KeyID",autoNumInfo.KeyID)
              };
             return 0 < dbhelper.ExecuteNonQuery(sql.ToString(),p_Parms);             
            }
        }
        public bool Delete(int _keyID)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("DELETE FROM");
            sql.Append(" [AutoNum]");
            sql.Append(" WHERE");
            sql.Append(" [KeyID]=@KeyID");
            using(NetShopHelper dbhelper=new NetShopHelper())
            {
              IDbDataParameter[] p_Parms = new IDbDataParameter[]{
                dbhelper.CreateParameter("@KeyID",_keyID)
              };
             return 0 < dbhelper.ExecuteNonQuery(sql.ToString(),p_Parms);             
            }
        }
        
	}
}
