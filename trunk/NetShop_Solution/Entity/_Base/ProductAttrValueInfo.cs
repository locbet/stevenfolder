
using System;
using System.Data;

namespace Entity
{
	/// <summary>
	/// Class:ProductAttrValueInfo
	/// Author:Steven
    /// Create:2009/11/29 11:32:28
	/// </summary>
	public class ProductAttrValueInfo
	{
		#region Private Column
        
		private System.String _proID;
		private System.Int32 _attrID;
		private System.String _attrValue;
        
		#endregion
		
        /// <summary>
        /// 
        /// </summary>
		public ProductAttrValueInfo()
		{
		}
        
		#region Public Property
        
		public System.String ProID
		{
			get{return this._proID;}
			set{this._proID = value;}
		}
		public System.Int32 AttrID
		{
			get{return this._attrID;}
			set{this._attrID = value;}
		}
		public System.String AttrValue
		{
			get{return this._attrValue;}
			set{this._attrValue = value;}
		}
		#endregion
        
        #region Public Method
        /// <summary>
        /// Convert IDataReader To ProductAttrValueInfo
        /// </summary>
        /// <param name="reader"></param>
        /// <returns></returns>
		public static ProductAttrValueInfo SetValue(IDataReader reader)
		{
			ProductAttrValueInfo info = new ProductAttrValueInfo();
            
			int proIDIndex = reader.GetOrdinal("ProID");
			int attrIDIndex = reader.GetOrdinal("AttrID");
			int attrValueIndex = reader.GetOrdinal("AttrValue");
            
			info.ProID = reader.GetString(proIDIndex);
			info.AttrID = reader.GetInt32(attrIDIndex);
			info.AttrValue = reader.GetString(attrValueIndex);
            
			return info;
		}
        #endregion
	}
}
