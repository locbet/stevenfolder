
using System;
using System.Data;

namespace Entity
{
	/// <summary>
	/// Class:PriceLevelInfo
	/// Author:Steven
    /// Create:2009/11/29 11:32:27
	/// </summary>
	public class PriceLevelInfo
	{
		#region Private Column
        
		private System.Int32 _id;
		private System.Int32 _cateID;
		private System.String _nickName;
		private System.Int32 _startPrice;
		private System.Int32 _endPrice;
		private System.Int32 _orderID;
        
		#endregion
		
        /// <summary>
        /// 
        /// </summary>
		public PriceLevelInfo()
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
		public System.Int32 StartPrice
		{
			get{return this._startPrice;}
			set{this._startPrice = value;}
		}
		public System.Int32 EndPrice
		{
			get{return this._endPrice;}
			set{this._endPrice = value;}
		}
		public System.Int32 OrderID
		{
			get{return this._orderID;}
			set{this._orderID = value;}
		}
		#endregion
        
        #region Public Method
        /// <summary>
        /// Convert IDataReader To PriceLevelInfo
        /// </summary>
        /// <param name="reader"></param>
        /// <returns></returns>
		public static PriceLevelInfo SetValue(IDataReader reader)
		{
			PriceLevelInfo info = new PriceLevelInfo();
            
			int idIndex = reader.GetOrdinal("ID");
			int cateIDIndex = reader.GetOrdinal("CateID");
			int nickNameIndex = reader.GetOrdinal("NickName");
			int startPriceIndex = reader.GetOrdinal("StartPrice");
			int endPriceIndex = reader.GetOrdinal("EndPrice");
			int orderIDIndex = reader.GetOrdinal("OrderID");
            
			info.Id = reader.GetInt32(idIndex);
			info.CateID = reader.GetInt32(cateIDIndex);
			info.NickName = reader.GetString(nickNameIndex);
			info.StartPrice = reader.GetInt32(startPriceIndex);
			info.EndPrice = reader.GetInt32(endPriceIndex);
			info.OrderID = reader.GetInt32(orderIDIndex);
            
			return info;
		}
        #endregion
	}
}
