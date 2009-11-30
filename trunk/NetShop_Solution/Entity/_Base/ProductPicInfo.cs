
using System;
using System.Data;

namespace Entity
{
	/// <summary>
	/// Class:ProductPicInfo
	/// Author:Steven
    /// Create:2009/11/29 11:32:28
	/// </summary>
	public class ProductPicInfo
	{
		#region Private Column
        
		private System.Int64 _id;
		private System.Int32 _orderID;
		private System.String _productNO;
		private System.String _smallPic;
		private System.String _midPic;
		private System.String _bigPic;
        
		#endregion
		
        /// <summary>
        /// 
        /// </summary>
		public ProductPicInfo()
		{
		}
        
		#region Public Property
        
		public System.Int64 Id
		{
			get{return this._id;}
			set{this._id = value;}
		}
		public System.Int32 OrderID
		{
			get{return this._orderID;}
			set{this._orderID = value;}
		}
		public System.String ProductNO
		{
			get{return this._productNO;}
			set{this._productNO = value;}
		}
		public System.String SmallPic
		{
			get{return this._smallPic;}
			set{this._smallPic = value;}
		}
		public System.String MidPic
		{
			get{return this._midPic;}
			set{this._midPic = value;}
		}
		public System.String BigPic
		{
			get{return this._bigPic;}
			set{this._bigPic = value;}
		}
		#endregion
        
        #region Public Method
        /// <summary>
        /// Convert IDataReader To ProductPicInfo
        /// </summary>
        /// <param name="reader"></param>
        /// <returns></returns>
		public static ProductPicInfo SetValue(IDataReader reader)
		{
			ProductPicInfo info = new ProductPicInfo();
            
			int idIndex = reader.GetOrdinal("ID");
			int orderIDIndex = reader.GetOrdinal("OrderID");
			int productNOIndex = reader.GetOrdinal("ProductNO");
			int smallPicIndex = reader.GetOrdinal("SmallPic");
			int midPicIndex = reader.GetOrdinal("MidPic");
			int bigPicIndex = reader.GetOrdinal("BigPic");
            
			info.Id = reader.GetInt64(idIndex);
			info.OrderID = reader.GetInt32(orderIDIndex);
			info.ProductNO = reader.GetString(productNOIndex);
			if(!reader.IsDBNull(smallPicIndex))
			info.SmallPic = reader.GetString(smallPicIndex);
			if(!reader.IsDBNull(midPicIndex))
			info.MidPic = reader.GetString(midPicIndex);
			if(!reader.IsDBNull(bigPicIndex))
			info.BigPic = reader.GetString(bigPicIndex);
            
			return info;
		}
        #endregion
	}
}
