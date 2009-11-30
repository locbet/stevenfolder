
using System;
using System.Data;

namespace Entity
{
	/// <summary>
	/// Class:CustomerInfo
	/// Author:Steven
    /// Create:2009/11/29 11:32:27
	/// </summary>
	public class CustomerInfo
	{
		#region Private Column
        
		private System.String _customerNO;
		private System.String _email;
		private System.String _password;
		private System.String _nickName;
		private System.String _telephone;
		private System.String _mobile;
        
		#endregion
		
        /// <summary>
        /// 
        /// </summary>
		public CustomerInfo()
		{
		}
        
		#region Public Property
        
		public System.String CustomerNO
		{
			get{return this._customerNO;}
			set{this._customerNO = value;}
		}
		public System.String Email
		{
			get{return this._email;}
			set{this._email = value;}
		}
		public System.String Password
		{
			get{return this._password;}
			set{this._password = value;}
		}
		public System.String NickName
		{
			get{return this._nickName;}
			set{this._nickName = value;}
		}
		public System.String Telephone
		{
			get{return this._telephone;}
			set{this._telephone = value;}
		}
		public System.String Mobile
		{
			get{return this._mobile;}
			set{this._mobile = value;}
		}
		#endregion
        
        #region Public Method
        /// <summary>
        /// Convert IDataReader To CustomerInfo
        /// </summary>
        /// <param name="reader"></param>
        /// <returns></returns>
		public static CustomerInfo SetValue(IDataReader reader)
		{
			CustomerInfo info = new CustomerInfo();
            
			int customerNOIndex = reader.GetOrdinal("CustomerNO");
			int emailIndex = reader.GetOrdinal("Email");
			int passwordIndex = reader.GetOrdinal("Password");
			int nickNameIndex = reader.GetOrdinal("NickName");
			int telephoneIndex = reader.GetOrdinal("Telephone");
			int mobileIndex = reader.GetOrdinal("Mobile");
            
			info.CustomerNO = reader.GetString(customerNOIndex);
			info.Email = reader.GetString(emailIndex);
			info.Password = reader.GetString(passwordIndex);
			info.NickName = reader.GetString(nickNameIndex);
			if(!reader.IsDBNull(telephoneIndex))
			info.Telephone = reader.GetString(telephoneIndex);
			if(!reader.IsDBNull(mobileIndex))
			info.Mobile = reader.GetString(mobileIndex);
            
			return info;
		}
        #endregion
	}
}
