// <fileinfo name="Entity\ProductExInfo.cs">
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
	/// The base class for <see cref="ProductExRow"/> that 
	/// represents a record in the <c>Tbl_ProductEx</c> table.
	/// </summary>
	/// <remarks>
	/// Do not change this source code manually. Update the <see cref="ProductExRow"/>
	/// class if you need to add or change some functionality.
	/// </remarks>
	public class ProductExInfo
	{
		private string _productNO;
		private string _intro;
		private string _standards;
		private string _packing;
		private string _service;

		/// <summary>
		/// Initializes a new instance of the <see cref="ProductExInfo"/> class.
		/// </summary>
		public ProductExInfo()
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
		/// Gets or sets the <c>Intro</c> column value.
		/// </summary>
		/// <value>The <c>Intro</c> column value.</value>
		public string Intro
		{
			get { return _intro; }
			set { _intro = value; }
		}

		/// <summary>
		/// Gets or sets the <c>Standards</c> column value.
		/// </summary>
		/// <value>The <c>Standards</c> column value.</value>
		public string Standards
		{
			get { return _standards; }
			set { _standards = value; }
		}

		/// <summary>
		/// Gets or sets the <c>Packing</c> column value.
		/// </summary>
		/// <value>The <c>Packing</c> column value.</value>
		public string Packing
		{
			get { return _packing; }
			set { _packing = value; }
		}

		/// <summary>
		/// Gets or sets the <c>Service</c> column value.
		/// </summary>
		/// <value>The <c>Service</c> column value.</value>
		public string Service
		{
			get { return _service; }
			set { _service = value; }
		}

		/// <summary>
		/// Returns ProductExInfo of this instance.
		/// </summary>
		/// <returns>ProductExInfo of this instance.</returns>
		public static ProductExInfo SetValue(IDataReader reader)
		{
			ProductExInfo info = new ProductExInfo();
			if (reader != null && !reader.IsClosed)
			{	int productNOColumnIndex = reader.GetOrdinal("ProductNO");
				int introColumnIndex = reader.GetOrdinal("Intro");
				int standardsColumnIndex = reader.GetOrdinal("Standards");
				int packingColumnIndex = reader.GetOrdinal("Packing");
				int serviceColumnIndex = reader.GetOrdinal("Service");
						
				info.ProductNO = Convert.ToString(reader.GetValue(productNOColumnIndex));
				info.Intro = Convert.ToString(reader.GetValue(introColumnIndex));
				info.Standards = Convert.ToString(reader.GetValue(standardsColumnIndex));
				info.Packing = Convert.ToString(reader.GetValue(packingColumnIndex));
				info.Service = Convert.ToString(reader.GetValue(serviceColumnIndex));
			}
			return info;
		}
	} // End of ProductExInfo class
} // End of namespace
