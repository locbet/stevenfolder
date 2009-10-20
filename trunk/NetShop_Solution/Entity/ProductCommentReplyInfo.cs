// <fileinfo name="Entity\ProductCommentReplyInfo.cs">
//		<copyright>
//			All rights reserved.
//		</copyright>
//		<remarks>
//			Do not change this source code manually. Changes to this file may 
//			cause incorrect behavior and will be lost if the code is regenerated.
//		</remarks>
//		<generator rewritefile="True">Steven</generator>
// </fileinfo>

using System;
using System.Data;

namespace Entity
{
	/// <summary>
	/// The base class for <see cref="ProductCommentReplyRow"/> that 
	/// represents a record in the <c>Tbl_ProductCommentReply</c> table.
	/// </summary>
	/// <remarks>
	/// Do not change this source code manually. Update the <see cref="ProductCommentReplyRow"/>
	/// class if you need to add or change some functionality.
	/// </remarks>
	public class ProductCommentReplyInfo
	{
		private int _id;
		private int _commentID;
		private string _summary;

		/// <summary>
		/// Initializes a new instance of the <see cref="ProductCommentReplyInfo"/> class.
		/// </summary>
		public ProductCommentReplyInfo()
		{
			// EMPTY
		}

		/// <summary>
		/// Gets or sets the <c>ID</c> column value.
		/// </summary>
		/// <value>The <c>ID</c> column value.</value>
		public int ID
		{
			get { return _id; }
			set { _id = value; }
		}

		/// <summary>
		/// Gets or sets the <c>CommentID</c> column value.
		/// </summary>
		/// <value>The <c>CommentID</c> column value.</value>
		public int CommentID
		{
			get { return _commentID; }
			set { _commentID = value; }
		}

		/// <summary>
		/// Gets or sets the <c>Summary</c> column value.
		/// </summary>
		/// <value>The <c>Summary</c> column value.</value>
		public string Summary
		{
			get { return _summary; }
			set { _summary = value; }
		}

		/// <summary>
		/// Returns ProductCommentReplyInfo of this instance.
		/// </summary>
		/// <returns>ProductCommentReplyInfo of this instance.</returns>
		public static ProductCommentReplyInfo SetValue(IDataReader reader)
		{
			ProductCommentReplyInfo info = new ProductCommentReplyInfo();
			if (reader != null && !reader.IsClosed)
			{	int idColumnIndex = reader.GetOrdinal("ID");
				int commentIDColumnIndex = reader.GetOrdinal("CommentID");
				int summaryColumnIndex = reader.GetOrdinal("Summary");
						
				info.ID = Convert.ToInt32(reader.GetValue(idColumnIndex));
				info.CommentID = Convert.ToInt32(reader.GetValue(commentIDColumnIndex));
				info.Summary = Convert.ToString(reader.GetValue(summaryColumnIndex));
			}
			return info;
		}
	} // End of ProductCommentReplyInfo class
} // End of namespace
