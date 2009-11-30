
using System;
using System.Data;

namespace Entity
{
	/// <summary>
	/// Class:ProductCommentInfo
	/// Author:Steven
    /// Create:2009/11/29 11:32:28
	/// </summary>
	public class ProductCommentInfo
	{
		#region Private Column
        
		private System.Int32 _id;
		private System.String _productNO;
		private System.String _title;
		private System.String _merits;
		private System.String _demerits;
		private System.String _summary;
		private System.Int32 _star;
		private System.Int32 _replyCount;
        
		#endregion
		
        /// <summary>
        /// 
        /// </summary>
		public ProductCommentInfo()
		{
		}
        
		#region Public Property
        
		public System.Int32 Id
		{
			get{return this._id;}
			set{this._id = value;}
		}
		public System.String ProductNO
		{
			get{return this._productNO;}
			set{this._productNO = value;}
		}
		public System.String Title
		{
			get{return this._title;}
			set{this._title = value;}
		}
		public System.String Merits
		{
			get{return this._merits;}
			set{this._merits = value;}
		}
		public System.String Demerits
		{
			get{return this._demerits;}
			set{this._demerits = value;}
		}
		public System.String Summary
		{
			get{return this._summary;}
			set{this._summary = value;}
		}
		public System.Int32 Star
		{
			get{return this._star;}
			set{this._star = value;}
		}
		public System.Int32 ReplyCount
		{
			get{return this._replyCount;}
			set{this._replyCount = value;}
		}
		#endregion
        
        #region Public Method
        /// <summary>
        /// Convert IDataReader To ProductCommentInfo
        /// </summary>
        /// <param name="reader"></param>
        /// <returns></returns>
		public static ProductCommentInfo SetValue(IDataReader reader)
		{
			ProductCommentInfo info = new ProductCommentInfo();
            
			int idIndex = reader.GetOrdinal("ID");
			int productNOIndex = reader.GetOrdinal("ProductNO");
			int titleIndex = reader.GetOrdinal("Title");
			int meritsIndex = reader.GetOrdinal("Merits");
			int demeritsIndex = reader.GetOrdinal("Demerits");
			int summaryIndex = reader.GetOrdinal("Summary");
			int starIndex = reader.GetOrdinal("Star");
			int replyCountIndex = reader.GetOrdinal("ReplyCount");
            
			info.Id = reader.GetInt32(idIndex);
			info.ProductNO = reader.GetString(productNOIndex);
			info.Title = reader.GetString(titleIndex);
			info.Merits = reader.GetString(meritsIndex);
			info.Demerits = reader.GetString(demeritsIndex);
			info.Summary = reader.GetString(summaryIndex);
			info.Star = reader.GetInt32(starIndex);
			info.ReplyCount = reader.GetInt32(replyCountIndex);
            
			return info;
		}
        #endregion
	}
}
