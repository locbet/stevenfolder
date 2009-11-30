
using System;
using System.Data;
using System.Text;
using DataCore;
using Entity;


namespace Business._Base
{
	/// <summary>
	/// Class:ProductAttrValueBase
	/// Author:Steven
    /// Create:2009/11/29 11:32:28
	/// </summary>
	public abstract class ProductAttrValueBase
	{		
        /// <summary>
        /// 
        /// </summary>
		public ProductAttrValueBase()
		{
		}
        public ProductAttrValueInfo GetProductAttrValueInfo(string _proID,int _attrID)
        {
            ProductAttrValueInfo productAttrValueInfo = null;
            StringBuilder sql= new StringBuilder();
            sql.Append("SELECT * FROM");
            sql.Append(" [Tbl_ProductAttrValue]");
            sql.Append(" WHERE");
            sql.Append(" [ProID]=@ProID");
            sql.Append(" AND");
            sql.Append(" [AttrID]=@AttrID");
            using(NetShopHelper dbhelper=new NetShopHelper())
            {
              IDbDataParameter[] p_Parms = new IDbDataParameter[]{
                dbhelper.CreateParameter("@ProID",_proID),
                dbhelper.CreateParameter("@AttrID",_attrID)
              };
              using(IDataReader reader=dbhelper.ExecuteReader(sql.ToString(),p_Parms))
              {
                if(reader.Read())
                {
                    productAttrValueInfo = ProductAttrValueInfo.SetValue(reader);
                }
              }
            }
            return productAttrValueInfo;
        }
        public bool Insert(ProductAttrValueInfo productAttrValueInfo)
        {
            StringBuilder sql=new StringBuilder();
            sql.Append("INSERT INTO");
            sql.Append(" [Tbl_ProductAttrValue](");            
            sql.Append("[ProID],");
            sql.Append("[AttrID],");
            sql.Append("[AttrValue]");
            sql.Append(") VALUES(");
            sql.Append("@ProID,");
            sql.Append("@AttrID,");
            sql.Append("@AttrValue");
            sql.Append(")");
            
            using(NetShopHelper dbhelper=new NetShopHelper())
            {
                IDbDataParameter[] p_Parms=new IDbDataParameter[]{
                    dbhelper.CreateParameter("@ProID",productAttrValueInfo.ProID),
                    dbhelper.CreateParameter("@AttrID",productAttrValueInfo.AttrID),
                    dbhelper.CreateParameter("@AttrValue",productAttrValueInfo.AttrValue)
                };
            return 0 < dbhelper.ExecuteNonQuery(sql.ToString(),p_Parms);
            }
        }
        public bool Update(ProductAttrValueInfo productAttrValueInfo)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("UPDATE");
            sql.Append(" [Tbl_ProductAttrValue]");
            sql.Append(" SET");
            sql.Append(" [AttrValue]=@AttrValue");
            sql.Append(" WHERE");
            sql.Append(" [ProID]=@ProID");
            sql.Append(" AND");
            sql.Append(" [AttrID]=@AttrID");
            using(NetShopHelper dbhelper=new NetShopHelper())
            {
              IDbDataParameter[] p_Parms = new IDbDataParameter[]{
                dbhelper.CreateParameter("@ProID",productAttrValueInfo.ProID),
                dbhelper.CreateParameter("@AttrID",productAttrValueInfo.AttrID)
              };
             return 0 < dbhelper.ExecuteNonQuery(sql.ToString(),p_Parms);             
            }
        }
        public bool Delete(string _proID,int _attrID)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("DELETE FROM");
            sql.Append(" [Tbl_ProductAttrValue]");
            sql.Append(" WHERE");
            sql.Append(" [ProID]=@ProID");
            sql.Append(" AND");
            sql.Append(" [AttrID]=@AttrID");
            using(NetShopHelper dbhelper=new NetShopHelper())
            {
              IDbDataParameter[] p_Parms = new IDbDataParameter[]{
                dbhelper.CreateParameter("@ProID",_proID),
                dbhelper.CreateParameter("@AttrID",_attrID)
              };
             return 0 < dbhelper.ExecuteNonQuery(sql.ToString(),p_Parms);             
            }
        }
        
	}
}
