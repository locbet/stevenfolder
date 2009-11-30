
using System;
using System.Data;

namespace Entity
{
	/// <summary>
	/// Class:ProductAttrInfo
	/// Author:Steven
    /// Create:2009/11/29 11:32:28
	/// </summary>
	public class ProductAttrInfo
	{
		#region Private Column
        
		private System.Int32 _attrID;
		private System.Int32 _cateID;
		private System.String _attrName;
        
		#endregion
		
        /// <summary>
        /// 
        /// </summary>
		public ProductAttrInfo()
		{
		}
        
		#region Public Property
        
		public System.Int32 AttrID
		{
			get{return this._attrID;}
			set{this._attrID = value;}
		}
		public System.Int32 CateID
		{
			get{return this._cateID;}
			set{this._cateID = value;}
		}
		public System.String AttrName
		{
			get{return this._attrName;}
			set{this._attrName = value;}
		}
		#endregion
        
        #region Public Method
        /// <summary>
        /// Convert IDataReader To ProductAttrInfo
        /// </summary>
        /// <param name="reader"></param>
        /// <returns></returns>
		public static ProductAttrInfo SetValue(IDataReader reader)
		{
			ProductAttrInfo info = new ProductAttrInfo();
            
			int attrIDIndex = reader.GetOrdinal("AttrID");
			int cateIDIndex = reader.GetOrdinal("CateID");
			int attrNameIndex = reader.GetOrdinal("AttrName");
            
			info.AttrID = reader.GetInt32(attrIDIndex);
			info.CateID = reader.GetInt32(cateIDIndex);
			info.AttrName = reader.GetString(attrNameIndex);
            
			return info;
		}
        #endregion
	}
}
