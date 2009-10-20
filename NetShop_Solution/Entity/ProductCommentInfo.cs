// <fileinfo name="Entity\ProductCommentInfo.cs">
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
	/// The base class for <see cref="ProductCommentRow"/> that 
	/// represents a record in the <c>Tbl_ProductComment</c> table.
	/// </summary>
	/// <remarks>
	/// Do not change this source code manually. Update the <see cref="ProductCommentRow"/>
	/// class if you need to add or change some functionality.
	/// </remarks>
	public class ProductCommentInfo
	{
		private int _id;
		private string _productNO;
		private string _title;
		private string _merits;
		private string _demerits;
		private string _summary;
		private int _star;
		private int _replyCount;

		/// <summary>
		/// Initializes a new instance of the <see cref="ProductCommentInfo"/> class.
		/// </summary>
		public ProductCommentInfo()
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
		/// Gets or sets the <c>ProductNO</c> column value.
		/// </summary>
		/// <value>The <c>ProductNO</c> column value.</value>
		public string ProductNO
		{
			get { return _productNO; }
			set { _productNO = value; }
		}

		/// <summary>
		/// Gets or sets the <c>Title</c> column value.
		/// </summary>
		/// <value>The <c>Title</c> column value.</value>
		public string Title
		{
			get { return _title; }
			set { _title = value; }
		}

		/// <summary>
		/// Gets or sets the <c>Merits</c> column value.
		/// </summary>
		/// <value>The <c>Merits</c> column value.</value>
		public string Merits
		{
			get { return _merits; }
			set { _merits = value; }
		}

		/// <summary>
		/// Gets or sets the <c>Demerits</c> column value.
		/// </summary>
		/// <value>The <c>Demerits</c> column value.</value>
		public string Demerits
		{
			get { return _demerits; }
			set { _demerits = value; }
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
		/// Gets or sets the <c>Star</c> column value.
		/// </summary>
		/// <value>The <c>Star</c> column value.</value>
		public int Star
		{
			get { return _star; }
			set { _star = value; }
		}

		/// <summary>
		/// Gets or sets the <c>ReplyCount</c> column value.
		/// </summary>
		/// <value>The <c>ReplyCount</c> column value.</value>
		public int ReplyCount
		{
			get { return _replyCount; }
			set { _replyCount = value; }
		}

		/// <summary>
		/// Returns ProductCommentInfo of this instance.
		/// </summary>
		/// <returns>ProductCommentInfo of this instance.</returns>
		public static ProductCommentInfo SetValue(IDataReader reader)
		{
			ProductCommentInfo info = new ProductCommentInfo();
			if (reader != null && !reader.IsClosed)
			{	int idColumnIndex = reader.GetOrdinal("ID");
				int productNOColumnIndex = reader.GetOrdinal("ProductNO");
				int titleColumnIndex = reader.GetOrdinal("Title");
				int meritsColumnIndex = reader.GetOrdinal("Merits");
				int demeritsColumnIndex = reader.GetOrdinal("Demerits");
				int summaryColumnIndex = reader.GetOrdinal("Summary");
				int starColumnIndex = reader.GetOrdinal("Star");
				int replyCountColumnIndex = reader.GetOrdinal("ReplyCount");
						
				info.ID = Convert.ToInt32(reader.GetValue(idColumnIndex));
				info.ProductNO = Convert.ToString(reader.GetValue(productNOColumnIndex));
				info.Title = Convert.ToString(reader.GetValue(titleColumnIndex));
				info.Merits = Convert.ToString(reader.GetValue(meritsColumnIndex));
				info.Demerits = Convert.ToString(reader.GetValue(demeritsColumnIndex));
				info.Summary = Convert.ToString(reader.GetValue(summaryColumnIndex));
				info.Star = Convert.ToInt32(reader.GetValue(starColumnIndex));
				info.ReplyCount = Convert.ToInt32(reader.GetValue(replyCountColumnIndex));
			}
			return info;
		}
	} // End of ProductCommentInfo class
} // End of namespace
