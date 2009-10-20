// <fileinfo name="Entity\ProductInfo.cs">
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
	/// The base class for <see cref="ProductRow"/> that 
	/// represents a record in the <c>Tbl_Product</c> table.
	/// </summary>
	/// <remarks>
	/// Do not change this source code manually. Update the <see cref="ProductRow"/>
	/// class if you need to add or change some functionality.
	/// </remarks>
	public class ProductInfo
	{
		private string _productNO;
		private int _cateID0;
		private int _cateID1;
		private int _cateID2;
		private string _nickName;
		private string _productName;
		private decimal _marketPrice;
		private decimal _innerPrice;
		private int _brandID;
		private string _brandName;

		/// <summary>
		/// Initializes a new instance of the <see cref="ProductInfo"/> class.
		/// </summary>
		public ProductInfo()
		{
			// EMPTY
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
		/// Gets or sets the <c>CateID0</c> column value.
		/// </summary>
		/// <value>The <c>CateID0</c> column value.</value>
		public int CateID0
		{
			get { return _cateID0; }
			set { _cateID0 = value; }
		}

		/// <summary>
		/// Gets or sets the <c>CateID1</c> column value.
		/// </summary>
		/// <value>The <c>CateID1</c> column value.</value>
		public int CateID1
		{
			get { return _cateID1; }
			set { _cateID1 = value; }
		}

		/// <summary>
		/// Gets or sets the <c>CateID2</c> column value.
		/// </summary>
		/// <value>The <c>CateID2</c> column value.</value>
		public int CateID2
		{
			get { return _cateID2; }
			set { _cateID2 = value; }
		}

		/// <summary>
		/// Gets or sets the <c>NickName</c> column value.
		/// </summary>
		/// <value>The <c>NickName</c> column value.</value>
		public string NickName
		{
			get { return _nickName; }
			set { _nickName = value; }
		}

		/// <summary>
		/// Gets or sets the <c>ProductName</c> column value.
		/// </summary>
		/// <value>The <c>ProductName</c> column value.</value>
		public string ProductName
		{
			get { return _productName; }
			set { _productName = value; }
		}

		/// <summary>
		/// Gets or sets the <c>MarketPrice</c> column value.
		/// </summary>
		/// <value>The <c>MarketPrice</c> column value.</value>
		public decimal MarketPrice
		{
			get { return _marketPrice; }
			set { _marketPrice = value; }
		}

		/// <summary>
		/// Gets or sets the <c>InnerPrice</c> column value.
		/// </summary>
		/// <value>The <c>InnerPrice</c> column value.</value>
		public decimal InnerPrice
		{
			get { return _innerPrice; }
			set { _innerPrice = value; }
		}

		/// <summary>
		/// Gets or sets the <c>BrandID</c> column value.
		/// </summary>
		/// <value>The <c>BrandID</c> column value.</value>
		public int BrandID
		{
			get { return _brandID; }
			set { _brandID = value; }
		}

		/// <summary>
		/// Gets or sets the <c>BrandName</c> column value.
		/// </summary>
		/// <value>The <c>BrandName</c> column value.</value>
		public string BrandName
		{
			get { return _brandName; }
			set { _brandName = value; }
		}

		/// <summary>
		/// Returns ProductInfo of this instance.
		/// </summary>
		/// <returns>ProductInfo of this instance.</returns>
		public static ProductInfo SetValue(IDataReader reader)
		{
			ProductInfo info = new ProductInfo();
			if (reader != null && !reader.IsClosed)
			{	int productNOColumnIndex = reader.GetOrdinal("ProductNO");
				int cateID0ColumnIndex = reader.GetOrdinal("CateID0");
				int cateID1ColumnIndex = reader.GetOrdinal("CateID1");
				int cateID2ColumnIndex = reader.GetOrdinal("CateID2");
				int nickNameColumnIndex = reader.GetOrdinal("NickName");
				int productNameColumnIndex = reader.GetOrdinal("ProductName");
				int marketPriceColumnIndex = reader.GetOrdinal("MarketPrice");
				int innerPriceColumnIndex = reader.GetOrdinal("InnerPrice");
				int brandIDColumnIndex = reader.GetOrdinal("BrandID");
				int brandNameColumnIndex = reader.GetOrdinal("BrandName");
						
				info.ProductNO = Convert.ToString(reader.GetValue(productNOColumnIndex));
				info.CateID0 = Convert.ToInt32(reader.GetValue(cateID0ColumnIndex));
				info.CateID1 = Convert.ToInt32(reader.GetValue(cateID1ColumnIndex));
				info.CateID2 = Convert.ToInt32(reader.GetValue(cateID2ColumnIndex));
				info.NickName = Convert.ToString(reader.GetValue(nickNameColumnIndex));
				info.ProductName = Convert.ToString(reader.GetValue(productNameColumnIndex));
				info.MarketPrice = Convert.ToDecimal(reader.GetValue(marketPriceColumnIndex));
				info.InnerPrice = Convert.ToDecimal(reader.GetValue(innerPriceColumnIndex));
				info.BrandID = Convert.ToInt32(reader.GetValue(brandIDColumnIndex));
				info.BrandName = Convert.ToString(reader.GetValue(brandNameColumnIndex));
			}
			return info;
		}
	} // End of ProductInfo class
} // End of namespace
