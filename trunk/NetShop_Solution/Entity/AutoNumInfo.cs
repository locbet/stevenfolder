// <fileinfo name="Entity\AutoNumInfo.cs">
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
	/// The base class for <see cref="AutoNumRow"/> that 
	/// represents a record in the <c>AutoNum</c> table.
	/// </summary>
	/// <remarks>
	/// Do not change this source code manually. Update the <see cref="AutoNumRow"/>
	/// class if you need to add or change some functionality.
	/// </remarks>
	public class AutoNumInfo
	{
		private int _keyID;
		private int _seed;
		private System.DateTime _seedDate;
		private string _prefix;
		private string _summary;

		/// <summary>
		/// Initializes a new instance of the <see cref="AutoNumInfo"/> class.
		/// </summary>
		public AutoNumInfo()
		{
			// EMPTY
		}

		/// <summary>
		/// Gets or sets the <c>KeyID</c> column value.
		/// </summary>
		/// <value>The <c>KeyID</c> column value.</value>
		public int KeyID
		{
			get { return _keyID; }
			set { _keyID = value; }
		}

		/// <summary>
		/// Gets or sets the <c>Seed</c> column value.
		/// </summary>
		/// <value>The <c>Seed</c> column value.</value>
		public int Seed
		{
			get { return _seed; }
			set { _seed = value; }
		}

		/// <summary>
		/// Gets or sets the <c>SeedDate</c> column value.
		/// </summary>
		/// <value>The <c>SeedDate</c> column value.</value>
		public System.DateTime SeedDate
		{
			get { return _seedDate; }
			set { _seedDate = value; }
		}

		/// <summary>
		/// Gets or sets the <c>Prefix</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Prefix</c> column value.</value>
		public string Prefix
		{
			get { return _prefix; }
			set { _prefix = value; }
		}

		/// <summary>
		/// Gets or sets the <c>Summary</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Summary</c> column value.</value>
		public string Summary
		{
			get { return _summary; }
			set { _summary = value; }
		}

		/// <summary>
		/// Returns AutoNumInfo of this instance.
		/// </summary>
		/// <returns>AutoNumInfo of this instance.</returns>
		public static AutoNumInfo SetValue(IDataReader reader)
		{
			AutoNumInfo info = new AutoNumInfo();
			if (reader != null && !reader.IsClosed)
			{	int keyIDColumnIndex = reader.GetOrdinal("KeyID");
				int seedColumnIndex = reader.GetOrdinal("Seed");
				int seedDateColumnIndex = reader.GetOrdinal("SeedDate");
				int prefixColumnIndex = reader.GetOrdinal("Prefix");
				int summaryColumnIndex = reader.GetOrdinal("Summary");
						
				info.KeyID = Convert.ToInt32(reader.GetValue(keyIDColumnIndex));
				info.Seed = Convert.ToInt32(reader.GetValue(seedColumnIndex));
				info.SeedDate = Convert.ToDateTime(reader.GetValue(seedDateColumnIndex));
				if(!reader.IsDBNull(prefixColumnIndex))
				info.Prefix = Convert.ToString(reader.GetValue(prefixColumnIndex));
				if(!reader.IsDBNull(summaryColumnIndex))
				info.Summary = Convert.ToString(reader.GetValue(summaryColumnIndex));
			}
			return info;
		}
	} // End of AutoNumInfo class
} // End of namespace
