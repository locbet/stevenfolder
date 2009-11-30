
using System;
using System.Data;

namespace Entity
{
	/// <summary>
	/// Class:HotKeyWordInfo
	/// Author:Steven
    /// Create:2009/11/29 11:32:27
	/// </summary>
	public class HotKeyWordInfo
	{
		#region Private Column
        
		private System.String _keyWord;
		private System.Int32 _cateID;
		private System.Int32 _orderID;
        
		#endregion
		
        /// <summary>
        /// 
        /// </summary>
		public HotKeyWordInfo()
		{
		}
        
		#region Public Property
        
		public System.String KeyWord
		{
			get{return this._keyWord;}
			set{this._keyWord = value;}
		}
		public System.Int32 CateID
		{
			get{return this._cateID;}
			set{this._cateID = value;}
		}
		public System.Int32 OrderID
		{
			get{return this._orderID;}
			set{this._orderID = value;}
		}
		#endregion
        
        #region Public Method
        /// <summary>
        /// Convert IDataReader To HotKeyWordInfo
        /// </summary>
        /// <param name="reader"></param>
        /// <returns></returns>
		public static HotKeyWordInfo SetValue(IDataReader reader)
		{
			HotKeyWordInfo info = new HotKeyWordInfo();
            
			int keyWordIndex = reader.GetOrdinal("KeyWord");
			int cateIDIndex = reader.GetOrdinal("CateID");
			int orderIDIndex = reader.GetOrdinal("OrderID");
            
			info.KeyWord = reader.GetString(keyWordIndex);
			info.CateID = reader.GetInt32(cateIDIndex);
			info.OrderID = reader.GetInt32(orderIDIndex);
            
			return info;
		}
        #endregion
	}
}
