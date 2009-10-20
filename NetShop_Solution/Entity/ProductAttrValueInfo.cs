// <fileinfo name="Entity\ProductAttrValueInfo.cs">
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
	/// The base class for <see cref="ProductAttrValueRow"/> that 
	/// represents a record in the <c>Tbl_ProductAttrValue</c> table.
	/// </summary>
	/// <remarks>
	/// Do not change this source code manually. Update the <see cref="ProductAttrValueRow"/>
	/// class if you need to add or change some functionality.
	/// </remarks>
	public class ProductAttrValueInfo
	{
		private string _proID;
		private int _attrID;
		private string _attrValue;

		/// <summary>
		/// Initializes a new instance of the <see cref="ProductAttrValueInfo"/> class.
		/// </summary>
		public ProductAttrValueInfo()
		{
			// EMPTY
		}

		/// <summary>
		/// Gets or sets the <c>ProID</c> column value.
		/// </summary>
		/// <value>The <c>ProID</c> column value.</value>
		public string ProID
		{
			get { return _proID; }
			set { _proID = value; }
		}

		/// <summary>
		/// Gets or sets the <c>AttrID</c> column value.
		/// </summary>
		/// <value>The <c>AttrID</c> column value.</value>
		public int AttrID
		{
			get { return _attrID; }
			set { _attrID = value; }
		}

		/// <summary>
		/// Gets or sets the <c>AttrValue</c> column value.
		/// </summary>
		/// <value>The <c>AttrValue</c> column value.</value>
		public string AttrValue
		{
			get { return _attrValue; }
			set { _attrValue = value; }
		}

		/// <summary>
		/// Returns ProductAttrValueInfo of this instance.
		/// </summary>
		/// <returns>ProductAttrValueInfo of this instance.</returns>
		public static ProductAttrValueInfo SetValue(IDataReader reader)
		{
			ProductAttrValueInfo info = new ProductAttrValueInfo();
			if (reader != null && !reader.IsClosed)
			{	int proIDColumnIndex = reader.GetOrdinal("ProID");
				int attrIDColumnIndex = reader.GetOrdinal("AttrID");
				int attrValueColumnIndex = reader.GetOrdinal("AttrValue");
						
				info.ProID = Convert.ToString(reader.GetValue(proIDColumnIndex));
				info.AttrID = Convert.ToInt32(reader.GetValue(attrIDColumnIndex));
				info.AttrValue = Convert.ToString(reader.GetValue(attrValueColumnIndex));
			}
			return info;
		}
	} // End of ProductAttrValueInfo class
} // End of namespace
