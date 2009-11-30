
using System;
using System.Data;

namespace Entity
{
	/// <summary>
	/// Class:BrandInfo
	/// Author:Steven
    /// Create:2009/11/29 11:32:27
	/// </summary>
	public class BrandInfo
	{
		#region Private Column
        
		private System.Int32 _id;
		private System.Int32 _cateID;
		private System.String _nickName;
		private System.String _brandName;
		private System.Int32 _orderID;
        
		#endregion
		
        /// <summary>
        /// 
        /// </summary>
		public BrandInfo()
		{
		}
        
		#region Public Property
        
		public System.Int32 Id
		{
			get{return this._id;}
			set{this._id = value;}
		}
		public System.Int32 CateID
		{
			get{return this._cateID;}
			set{this._cateID = value;}
		}
		public System.String NickName
		{
			get{return this._nickName;}
			set{this._nickName = value;}
		}
		public System.String BrandName
		{
			get{return this._brandName;}
			set{this._brandName = value;}
		}
		public System.Int32 OrderID
		{
			get{return this._orderID;}
			set{this._orderID = value;}
		}
		#endregion
        
        #region Public Method
        /// <summary>
        /// Convert IDataReader To BrandInfo
        /// </summary>
        /// <param name="reader"></param>
        /// <returns></returns>
		public static BrandInfo SetValue(IDataReader reader)
		{
			BrandInfo info = new BrandInfo();
            
			int idIndex = reader.GetOrdinal("ID");
			int cateIDIndex = reader.GetOrdinal("CateID");
			int nickNameIndex = reader.GetOrdinal("NickName");
			int brandNameIndex = reader.GetOrdinal("BrandName");
			int orderIDIndex = reader.GetOrdinal("OrderID");
            
			info.Id = reader.GetInt32(idIndex);
			info.CateID = reader.GetInt32(cateIDIndex);
			info.NickName = reader.GetString(nickNameIndex);
			info.BrandName = reader.GetString(brandNameIndex);
			info.OrderID = reader.GetInt32(orderIDIndex);
            
			return info;
		}
        #endregion
	}
}
