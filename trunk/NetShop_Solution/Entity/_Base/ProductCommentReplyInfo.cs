
using System;
using System.Data;

namespace Entity
{
	/// <summary>
	/// Class:ProductCommentReplyInfo
	/// Author:Steven
    /// Create:2009/11/29 11:32:28
	/// </summary>
	public class ProductCommentReplyInfo
	{
		#region Private Column
        
		private System.Int32 _id;
		private System.Int32 _commentID;
		private System.String _summary;
        
		#endregion
		
        /// <summary>
        /// 
        /// </summary>
		public ProductCommentReplyInfo()
		{
		}
        
		#region Public Property
        
		public System.Int32 Id
		{
			get{return this._id;}
			set{this._id = value;}
		}
		public System.Int32 CommentID
		{
			get{return this._commentID;}
			set{this._commentID = value;}
		}
		public System.String Summary
		{
			get{return this._summary;}
			set{this._summary = value;}
		}
		#endregion
        
        #region Public Method
        /// <summary>
        /// Convert IDataReader To ProductCommentReplyInfo
        /// </summary>
        /// <param name="reader"></param>
        /// <returns></returns>
		public static ProductCommentReplyInfo SetValue(IDataReader reader)
		{
			ProductCommentReplyInfo info = new ProductCommentReplyInfo();
            
			int idIndex = reader.GetOrdinal("ID");
			int commentIDIndex = reader.GetOrdinal("CommentID");
			int summaryIndex = reader.GetOrdinal("Summary");
            
			info.Id = reader.GetInt32(idIndex);
			info.CommentID = reader.GetInt32(commentIDIndex);
			info.Summary = reader.GetString(summaryIndex);
            
			return info;
		}
        #endregion
	}
}
