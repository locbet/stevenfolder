// <fileinfo name="Entity\ProductAttrInfo.cs">
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
	/// The base class for <see cref="ProductAttrRow"/> that 
	/// represents a record in the <c>Tbl_ProductAttr</c> table.
	/// </summary>
	/// <remarks>
	/// Do not change this source code manually. Update the <see cref="ProductAttrRow"/>
	/// class if you need to add or change some functionality.
	/// </remarks>
	public class ProductAttrInfo
	{
		private int _attrID;
		private int _cateID;
		private string _attrName;

		/// <summary>
		/// Initializes a new instance of the <see cref="ProductAttrInfo"/> class.
		/// </summary>
		public ProductAttrInfo()
		{
			// EMPTY
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
		/// Gets or sets the <c>CateID</c> column value.
		/// </summary>
		/// <value>The <c>CateID</c> column value.</value>
		public int CateID
		{
			get { return _cateID; }
			set { _cateID = value; }
		}

		/// <summary>
		/// Gets or sets the <c>AttrName</c> column value.
		/// </summary>
		/// <value>The <c>AttrName</c> column value.</value>
		public string AttrName
		{
			get { return _attrName; }
			set { _attrName = value; }
		}

		/// <summary>
		/// Returns ProductAttrInfo of this instance.
		/// </summary>
		/// <returns>ProductAttrInfo of this instance.</returns>
		public static ProductAttrInfo SetValue(IDataReader reader)
		{
			ProductAttrInfo info = new ProductAttrInfo();
			if (reader != null && !reader.IsClosed)
			{	int attrIDColumnIndex = reader.GetOrdinal("AttrID");
				int cateIDColumnIndex = reader.GetOrdinal("CateID");
				int attrNameColumnIndex = reader.GetOrdinal("AttrName");
						
				info.AttrID = Convert.ToInt32(reader.GetValue(attrIDColumnIndex));
				info.CateID = Convert.ToInt32(reader.GetValue(cateIDColumnIndex));
				info.AttrName = Convert.ToString(reader.GetValue(attrNameColumnIndex));
			}
			return info;
		}
	} // End of ProductAttrInfo class
} // End of namespace
