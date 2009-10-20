// <fileinfo name="Entity\CategoryInfo.cs">
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
	/// The base class for <see cref="CategoryRow"/> that 
	/// represents a record in the <c>Tbl_Category</c> table.
	/// </summary>
	/// <remarks>
	/// Do not change this source code manually. Update the <see cref="CategoryRow"/>
	/// class if you need to add or change some functionality.
	/// </remarks>
	public class CategoryInfo
	{
		private int _id;
		private string _cateName;
		private int _parentID;
		private int _levelID;
		private string _pageUrl;

		/// <summary>
		/// Initializes a new instance of the <see cref="CategoryInfo"/> class.
		/// </summary>
		public CategoryInfo()
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
		/// Gets or sets the <c>CateName</c> column value.
		/// </summary>
		/// <value>The <c>CateName</c> column value.</value>
		public string CateName
		{
			get { return _cateName; }
			set { _cateName = value; }
		}

		/// <summary>
		/// Gets or sets the <c>ParentID</c> column value.
		/// </summary>
		/// <value>The <c>ParentID</c> column value.</value>
		public int ParentID
		{
			get { return _parentID; }
			set { _parentID = value; }
		}

		/// <summary>
		/// Gets or sets the <c>LevelID</c> column value.
		/// </summary>
		/// <value>The <c>LevelID</c> column value.</value>
		public int LevelID
		{
			get { return _levelID; }
			set { _levelID = value; }
		}

		/// <summary>
		/// Gets or sets the <c>PageUrl</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>PageUrl</c> column value.</value>
		public string PageUrl
		{
			get { return _pageUrl; }
			set { _pageUrl = value; }
		}

		/// <summary>
		/// Returns CategoryInfo of this instance.
		/// </summary>
		/// <returns>CategoryInfo of this instance.</returns>
		public static CategoryInfo SetValue(IDataReader reader)
		{
			CategoryInfo info = new CategoryInfo();
			if (reader != null && !reader.IsClosed)
			{	int idColumnIndex = reader.GetOrdinal("ID");
				int cateNameColumnIndex = reader.GetOrdinal("CateName");
				int parentIDColumnIndex = reader.GetOrdinal("ParentID");
				int levelIDColumnIndex = reader.GetOrdinal("LevelID");
				int pageUrlColumnIndex = reader.GetOrdinal("PageUrl");
						
				info.ID = Convert.ToInt32(reader.GetValue(idColumnIndex));
				info.CateName = Convert.ToString(reader.GetValue(cateNameColumnIndex));
				info.ParentID = Convert.ToInt32(reader.GetValue(parentIDColumnIndex));
				info.LevelID = Convert.ToInt32(reader.GetValue(levelIDColumnIndex));
				if(!reader.IsDBNull(pageUrlColumnIndex))
				info.PageUrl = Convert.ToString(reader.GetValue(pageUrlColumnIndex));
			}
			return info;
		}
	} // End of CategoryInfo class
} // End of namespace
