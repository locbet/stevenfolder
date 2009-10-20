// <fileinfo name="Entity\BrandInfo.cs">
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
	/// The base class for <see cref="BrandRow"/> that 
	/// represents a record in the <c>Tbl_Brand</c> table.
	/// </summary>
	/// <remarks>
	/// Do not change this source code manually. Update the <see cref="BrandRow"/>
	/// class if you need to add or change some functionality.
	/// </remarks>
	public class BrandInfo
	{
		private int _id;
		private int _cateID;
		private string _nickName;
		private string _brandName;

		/// <summary>
		/// Initializes a new instance of the <see cref="BrandInfo"/> class.
		/// </summary>
		public BrandInfo()
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
		/// Gets or sets the <c>CateID</c> column value.
		/// </summary>
		/// <value>The <c>CateID</c> column value.</value>
		public int CateID
		{
			get { return _cateID; }
			set { _cateID = value; }
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
		/// Gets or sets the <c>BrandName</c> column value.
		/// </summary>
		/// <value>The <c>BrandName</c> column value.</value>
		public string BrandName
		{
			get { return _brandName; }
			set { _brandName = value; }
		}

		/// <summary>
		/// Returns BrandInfo of this instance.
		/// </summary>
		/// <returns>BrandInfo of this instance.</returns>
		public static BrandInfo SetValue(IDataReader reader)
		{
			BrandInfo info = new BrandInfo();
			if (reader != null && !reader.IsClosed)
			{	int idColumnIndex = reader.GetOrdinal("ID");
				int cateIDColumnIndex = reader.GetOrdinal("CateID");
				int nickNameColumnIndex = reader.GetOrdinal("NickName");
				int brandNameColumnIndex = reader.GetOrdinal("BrandName");
						
				info.ID = Convert.ToInt32(reader.GetValue(idColumnIndex));
				info.CateID = Convert.ToInt32(reader.GetValue(cateIDColumnIndex));
				info.NickName = Convert.ToString(reader.GetValue(nickNameColumnIndex));
				info.BrandName = Convert.ToString(reader.GetValue(brandNameColumnIndex));
			}
			return info;
		}
	} // End of BrandInfo class
} // End of namespace
