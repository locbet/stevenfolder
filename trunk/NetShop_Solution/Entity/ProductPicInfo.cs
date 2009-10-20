// <fileinfo name="Entity\ProductPicInfo.cs">
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
	/// The base class for <see cref="ProductPicRow"/> that 
	/// represents a record in the <c>Tbl_ProductPic</c> table.
	/// </summary>
	/// <remarks>
	/// Do not change this source code manually. Update the <see cref="ProductPicRow"/>
	/// class if you need to add or change some functionality.
	/// </remarks>
	public class ProductPicInfo
	{
		private long _id;
		private string _productNO;
		private string _smallPic;
		private string _midPic;
		private string _bigPic;
		private int _orderID;

		/// <summary>
		/// Initializes a new instance of the <see cref="ProductPicInfo"/> class.
		/// </summary>
		public ProductPicInfo()
		{
			// EMPTY
		}

		/// <summary>
		/// Gets or sets the <c>ID</c> column value.
		/// </summary>
		/// <value>The <c>ID</c> column value.</value>
		public long ID
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
		/// Gets or sets the <c>SmallPic</c> column value.
		/// </summary>
		/// <value>The <c>SmallPic</c> column value.</value>
		public string SmallPic
		{
			get { return _smallPic; }
			set { _smallPic = value; }
		}

		/// <summary>
		/// Gets or sets the <c>MidPic</c> column value.
		/// </summary>
		/// <value>The <c>MidPic</c> column value.</value>
		public string MidPic
		{
			get { return _midPic; }
			set { _midPic = value; }
		}

		/// <summary>
		/// Gets or sets the <c>BigPic</c> column value.
		/// </summary>
		/// <value>The <c>BigPic</c> column value.</value>
		public string BigPic
		{
			get { return _bigPic; }
			set { _bigPic = value; }
		}

		/// <summary>
		/// Gets or sets the <c>OrderID</c> column value.
		/// </summary>
		/// <value>The <c>OrderID</c> column value.</value>
		public int OrderID
		{
			get { return _orderID; }
			set { _orderID = value; }
		}

		/// <summary>
		/// Returns ProductPicInfo of this instance.
		/// </summary>
		/// <returns>ProductPicInfo of this instance.</returns>
		public static ProductPicInfo SetValue(IDataReader reader)
		{
			ProductPicInfo info = new ProductPicInfo();
			if (reader != null && !reader.IsClosed)
			{	int idColumnIndex = reader.GetOrdinal("ID");				
                int productNOColumnIndex = reader.GetOrdinal("ProductNO");
                int orderIDColumnIndex = reader.GetOrdinal("OrderID");
                int smallPicColumnIndex = reader.GetOrdinal("SmallPic");
				int midPicColumnIndex = reader.GetOrdinal("MidPic");
				int bigPicColumnIndex = reader.GetOrdinal("BigPic");
				
						
				info.ID = Convert.ToInt64(reader.GetValue(idColumnIndex));
				info.ProductNO = Convert.ToString(reader.GetValue(productNOColumnIndex));
				info.SmallPic = Convert.ToString(reader.GetValue(smallPicColumnIndex));
				info.MidPic = Convert.ToString(reader.GetValue(midPicColumnIndex));
				info.BigPic = Convert.ToString(reader.GetValue(bigPicColumnIndex));
				info.OrderID = Convert.ToInt32(reader.GetValue(orderIDColumnIndex));
			}
			return info;
		}
	} // End of ProductPicInfo class
} // End of namespace
