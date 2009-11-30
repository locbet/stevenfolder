
using System;
using System.Data;

namespace Entity
{
	/// <summary>
	/// Class:CategoryInfo
	/// Author:Steven
    /// Create:2009/11/29 11:32:27
	/// </summary>
	public class CategoryInfo
	{
		#region Private Column
        
		private System.Int32 _id;
		private System.String _cateName;
		private System.Int32 _parentID;
		private System.Int32 _levelID;
		private System.Int32 _orderID;
		private System.String _fullPath;
		private System.String _pageUrl;
        
		#endregion
		
        /// <summary>
        /// 
        /// </summary>
		public CategoryInfo()
		{
		}
        
		#region Public Property
        
		public System.Int32 Id
		{
			get{return this._id;}
			set{this._id = value;}
		}
		public System.String CateName
		{
			get{return this._cateName;}
			set{this._cateName = value;}
		}
		public System.Int32 ParentID
		{
			get{return this._parentID;}
			set{this._parentID = value;}
		}
		public System.Int32 LevelID
		{
			get{return this._levelID;}
			set{this._levelID = value;}
		}
		public System.Int32 OrderID
		{
			get{return this._orderID;}
			set{this._orderID = value;}
		}
		public System.String FullPath
		{
			get{return this._fullPath;}
			set{this._fullPath = value;}
		}
		public System.String PageUrl
		{
			get{return this._pageUrl;}
			set{this._pageUrl = value;}
		}
		#endregion
        
        #region Public Method
        /// <summary>
        /// Convert IDataReader To CategoryInfo
        /// </summary>
        /// <param name="reader"></param>
        /// <returns></returns>
		public static CategoryInfo SetValue(IDataReader reader)
		{
			CategoryInfo info = new CategoryInfo();
            
			int idIndex = reader.GetOrdinal("ID");
			int cateNameIndex = reader.GetOrdinal("CateName");
			int parentIDIndex = reader.GetOrdinal("ParentID");
			int levelIDIndex = reader.GetOrdinal("LevelID");
			int orderIDIndex = reader.GetOrdinal("OrderID");
			int fullPathIndex = reader.GetOrdinal("FullPath");
			int pageUrlIndex = reader.GetOrdinal("PageUrl");
            
			info.Id = reader.GetInt32(idIndex);
			info.CateName = reader.GetString(cateNameIndex);
			info.ParentID = reader.GetInt32(parentIDIndex);
			info.LevelID = reader.GetInt32(levelIDIndex);
			info.OrderID = reader.GetInt32(orderIDIndex);
			info.FullPath = reader.GetString(fullPathIndex);
			if(!reader.IsDBNull(pageUrlIndex))
			info.PageUrl = reader.GetString(pageUrlIndex);
            
			return info;
		}
        #endregion
	}
}
