// <fileinfo name="Entity\PriceLevelInfo.cs">
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
	/// The base class for <see cref="PriceLevelRow"/> that 
	/// represents a record in the <c>Tbl_PriceLevel</c> table.
	/// </summary>
	/// <remarks>
	/// Do not change this source code manually. Update the <see cref="PriceLevelRow"/>
	/// class if you need to add or change some functionality.
	/// </remarks>
	public class PriceLevelInfo
	{
		private int _id;
		private int _cateID;
		private string _nickName;
		private int _startPrice;
		private int _endPrice;
		private int _orderID;

		/// <summary>
		/// Initializes a new instance of the <see cref="PriceLevelInfo"/> class.
		/// </summary>
		public PriceLevelInfo()
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
		/// Gets or sets the <c>StartPrice</c> column value.
		/// </summary>
		/// <value>The <c>StartPrice</c> column value.</value>
		public int StartPrice
		{
			get { return _startPrice; }
			set { _startPrice = value; }
		}

		/// <summary>
		/// Gets or sets the <c>EndPrice</c> column value.
		/// </summary>
		/// <value>The <c>EndPrice</c> column value.</value>
		public int EndPrice
		{
			get { return _endPrice; }
			set { _endPrice = value; }
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
		/// Returns PriceLevelInfo of this instance.
		/// </summary>
		/// <returns>PriceLevelInfo of this instance.</returns>
		public static PriceLevelInfo SetValue(IDataReader reader)
		{
			PriceLevelInfo info = new PriceLevelInfo();
			if (reader != null && !reader.IsClosed)
			{	int idColumnIndex = reader.GetOrdinal("ID");
				int cateIDColumnIndex = reader.GetOrdinal("CateID");
				int nickNameColumnIndex = reader.GetOrdinal("NickName");
				int startPriceColumnIndex = reader.GetOrdinal("StartPrice");
				int endPriceColumnIndex = reader.GetOrdinal("EndPrice");
				int orderIDColumnIndex = reader.GetOrdinal("OrderID");
						
				info.ID = Convert.ToInt32(reader.GetValue(idColumnIndex));
				info.CateID = Convert.ToInt32(reader.GetValue(cateIDColumnIndex));
				info.NickName = Convert.ToString(reader.GetValue(nickNameColumnIndex));
				info.StartPrice = Convert.ToInt32(reader.GetValue(startPriceColumnIndex));
				info.EndPrice = Convert.ToInt32(reader.GetValue(endPriceColumnIndex));
				info.OrderID = Convert.ToInt32(reader.GetValue(orderIDColumnIndex));
			}
			return info;
		}
	} // End of PriceLevelInfo class
} // End of namespace
