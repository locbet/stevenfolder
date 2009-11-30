
using System;
using System.Data;
using System.Text;
using DataCore;
using Entity;


namespace Business._Base
{
	/// <summary>
	/// Class:CustomerBase
	/// Author:Steven
    /// Create:2009/11/29 11:32:27
	/// </summary>
	public abstract class CustomerBase
	{		
        /// <summary>
        /// 
        /// </summary>
		public CustomerBase()
		{
		}
        public CustomerInfo GetCustomerInfo(string _customerNO)
        {
            CustomerInfo customerInfo = null;
            StringBuilder sql= new StringBuilder();
            sql.Append("SELECT * FROM");
            sql.Append(" [Tbl_Customer]");
            sql.Append(" WHERE");
            sql.Append(" [CustomerNO]=@CustomerNO");
            using(NetShopHelper dbhelper=new NetShopHelper())
            {
              IDbDataParameter[] p_Parms = new IDbDataParameter[]{
                dbhelper.CreateParameter("@CustomerNO",_customerNO)
              };
              using(IDataReader reader=dbhelper.ExecuteReader(sql.ToString(),p_Parms))
              {
                if(reader.Read())
                {
                    customerInfo = CustomerInfo.SetValue(reader);
                }
              }
            }
            return customerInfo;
        }
        public bool Insert(CustomerInfo customerInfo)
        {
            StringBuilder sql=new StringBuilder();
            sql.Append("INSERT INTO");
            sql.Append(" [Tbl_Customer](");            
            sql.Append("[CustomerNO],");
            sql.Append("[Email],");
            sql.Append("[Password],");
            sql.Append("[NickName],");
            sql.Append("[Telephone],");
            sql.Append("[Mobile]");
            sql.Append(") VALUES(");
            sql.Append("@CustomerNO,");
            sql.Append("@Email,");
            sql.Append("@Password,");
            sql.Append("@NickName,");
            sql.Append("@Telephone,");
            sql.Append("@Mobile");
            sql.Append(")");
            
            using(NetShopHelper dbhelper=new NetShopHelper())
            {
                IDbDataParameter[] p_Parms=new IDbDataParameter[]{
                    dbhelper.CreateParameter("@CustomerNO",customerInfo.CustomerNO),
                    dbhelper.CreateParameter("@Email",customerInfo.Email),
                    dbhelper.CreateParameter("@Password",customerInfo.Password),
                    dbhelper.CreateParameter("@NickName",customerInfo.NickName),
                    dbhelper.CreateParameter("@Telephone",customerInfo.Telephone),
                    dbhelper.CreateParameter("@Mobile",customerInfo.Mobile)
                };
            return 0 < dbhelper.ExecuteNonQuery(sql.ToString(),p_Parms);
            }
        }
        public bool Update(CustomerInfo customerInfo)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("UPDATE");
            sql.Append(" [Tbl_Customer]");
            sql.Append(" SET");
            sql.Append(" [Email]=@Email,");
            sql.Append(" [Password]=@Password,");
            sql.Append(" [NickName]=@NickName,");
            sql.Append(" [Telephone]=@Telephone,");
            sql.Append(" [Mobile]=@Mobile");
            sql.Append(" WHERE");
            sql.Append(" [CustomerNO]=@CustomerNO");
            using(NetShopHelper dbhelper=new NetShopHelper())
            {
              IDbDataParameter[] p_Parms = new IDbDataParameter[]{
                dbhelper.CreateParameter("@CustomerNO",customerInfo.CustomerNO)
              };
             return 0 < dbhelper.ExecuteNonQuery(sql.ToString(),p_Parms);             
            }
        }
        public bool Delete(string _customerNO)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("DELETE FROM");
            sql.Append(" [Tbl_Customer]");
            sql.Append(" WHERE");
            sql.Append(" [CustomerNO]=@CustomerNO");
            using(NetShopHelper dbhelper=new NetShopHelper())
            {
              IDbDataParameter[] p_Parms = new IDbDataParameter[]{
                dbhelper.CreateParameter("@CustomerNO",_customerNO)
              };
             return 0 < dbhelper.ExecuteNonQuery(sql.ToString(),p_Parms);             
            }
        }
        
	}
}
