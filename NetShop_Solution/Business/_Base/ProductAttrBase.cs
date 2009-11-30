
using System;
using System.Data;
using System.Text;
using DataCore;
using Entity;


namespace Business._Base
{
	/// <summary>
	/// Class:ProductAttrBase
	/// Author:Steven
    /// Create:2009/11/29 11:32:28
	/// </summary>
	public abstract class ProductAttrBase
	{		
        /// <summary>
        /// 
        /// </summary>
		public ProductAttrBase()
		{
		}
        public ProductAttrInfo GetProductAttrInfo(int _attrID)
        {
            ProductAttrInfo productAttrInfo = null;
            StringBuilder sql= new StringBuilder();
            sql.Append("SELECT * FROM");
            sql.Append(" [Tbl_ProductAttr]");
            sql.Append(" WHERE");
            sql.Append(" [AttrID]=@AttrID");
            using(NetShopHelper dbhelper=new NetShopHelper())
            {
              IDbDataParameter[] p_Parms = new IDbDataParameter[]{
                dbhelper.CreateParameter("@AttrID",_attrID)
              };
              using(IDataReader reader=dbhelper.ExecuteReader(sql.ToString(),p_Parms))
              {
                if(reader.Read())
                {
                    productAttrInfo = ProductAttrInfo.SetValue(reader);
                }
              }
            }
            return productAttrInfo;
        }
        public bool Insert(ProductAttrInfo productAttrInfo)
        {
            StringBuilder sql=new StringBuilder();
            sql.Append("INSERT INTO");
            sql.Append(" [Tbl_ProductAttr](");            
            sql.Append("[CateID],");
            sql.Append("[AttrName]");
            sql.Append(") VALUES(");
            sql.Append("@CateID,");
            sql.Append("@AttrName");
            sql.Append(");SELECT @@IDENTITY;");
            
            using(NetShopHelper dbhelper=new NetShopHelper())
            {
                IDbDataParameter[] p_Parms=new IDbDataParameter[]{
                    dbhelper.CreateParameter("@CateID",productAttrInfo.CateID),
                    dbhelper.CreateParameter("@AttrName",productAttrInfo.AttrName)
                };
            int ret=(int)dbhelper.ExecuteScalar(sql.ToString(),p_Parms);
            productAttrInfo.AttrID=ret;
            return true;
            }
        }
        public bool Update(ProductAttrInfo productAttrInfo)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("UPDATE");
            sql.Append(" [Tbl_ProductAttr]");
            sql.Append(" SET");
            sql.Append(" [CateID]=@CateID,");
            sql.Append(" [AttrName]=@AttrName");
            sql.Append(" WHERE");
            sql.Append(" [AttrID]=@AttrID");
            using(NetShopHelper dbhelper=new NetShopHelper())
            {
              IDbDataParameter[] p_Parms = new IDbDataParameter[]{
                dbhelper.CreateParameter("@AttrID",productAttrInfo.AttrID)
              };
             return 0 < dbhelper.ExecuteNonQuery(sql.ToString(),p_Parms);             
            }
        }
        public bool Delete(int _attrID)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("DELETE FROM");
            sql.Append(" [Tbl_ProductAttr]");
            sql.Append(" WHERE");
            sql.Append(" [AttrID]=@AttrID");
            using(NetShopHelper dbhelper=new NetShopHelper())
            {
              IDbDataParameter[] p_Parms = new IDbDataParameter[]{
                dbhelper.CreateParameter("@AttrID",_attrID)
              };
             return 0 < dbhelper.ExecuteNonQuery(sql.ToString(),p_Parms);             
            }
        }
        
	}
}
