// <fileinfo name="Entity\ProductAnswerInfo.cs">
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
	/// The base class for <see cref="ProductAnswerRow"/> that 
	/// represents a record in the <c>Tbl_ProductAnswer</c> table.
	/// </summary>
	/// <remarks>
	/// Do not change this source code manually. Update the <see cref="ProductAnswerRow"/>
	/// class if you need to add or change some functionality.
	/// </remarks>
	public class ProductAnswerInfo
	{
		private int _id;
		private string _productNO;
		private int _serviceType;
		private string _ask;
		private string _answer;
		private int _yesCount;
		private int _noCount;

		/// <summary>
		/// Initializes a new instance of the <see cref="ProductAnswerInfo"/> class.
		/// </summary>
		public ProductAnswerInfo()
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
		/// Gets or sets the <c>ServiceType</c> column value.
		/// </summary>
		/// <value>The <c>ServiceType</c> column value.</value>
		public int ServiceType
		{
			get { return _serviceType; }
			set { _serviceType = value; }
		}

		/// <summary>
		/// Gets or sets the <c>Ask</c> column value.
		/// </summary>
		/// <value>The <c>Ask</c> column value.</value>
		public string Ask
		{
			get { return _ask; }
			set { _ask = value; }
		}

		/// <summary>
		/// Gets or sets the <c>Answer</c> column value.
		/// </summary>
		/// <value>The <c>Answer</c> column value.</value>
		public string Answer
		{
			get { return _answer; }
			set { _answer = value; }
		}

		/// <summary>
		/// Gets or sets the <c>YesCount</c> column value.
		/// </summary>
		/// <value>The <c>YesCount</c> column value.</value>
		public int YesCount
		{
			get { return _yesCount; }
			set { _yesCount = value; }
		}

		/// <summary>
		/// Gets or sets the <c>NoCount</c> column value.
		/// </summary>
		/// <value>The <c>NoCount</c> column value.</value>
		public int NoCount
		{
			get { return _noCount; }
			set { _noCount = value; }
		}

		/// <summary>
		/// Returns ProductAnswerInfo of this instance.
		/// </summary>
		/// <returns>ProductAnswerInfo of this instance.</returns>
		public static ProductAnswerInfo SetValue(IDataReader reader)
		{
			ProductAnswerInfo info = new ProductAnswerInfo();
			if (reader != null && !reader.IsClosed)
			{	int idColumnIndex = reader.GetOrdinal("ID");
				int productNOColumnIndex = reader.GetOrdinal("ProductNO");
				int serviceTypeColumnIndex = reader.GetOrdinal("ServiceType");
				int askColumnIndex = reader.GetOrdinal("Ask");
				int answerColumnIndex = reader.GetOrdinal("Answer");
				int yesCountColumnIndex = reader.GetOrdinal("YesCount");
				int noCountColumnIndex = reader.GetOrdinal("NoCount");
						
				info.ID = Convert.ToInt32(reader.GetValue(idColumnIndex));
				info.ProductNO = Convert.ToString(reader.GetValue(productNOColumnIndex));
				info.ServiceType = Convert.ToInt32(reader.GetValue(serviceTypeColumnIndex));
				info.Ask = Convert.ToString(reader.GetValue(askColumnIndex));
				info.Answer = Convert.ToString(reader.GetValue(answerColumnIndex));
				info.YesCount = Convert.ToInt32(reader.GetValue(yesCountColumnIndex));
				info.NoCount = Convert.ToInt32(reader.GetValue(noCountColumnIndex));
			}
			return info;
		}
	} // End of ProductAnswerInfo class
} // End of namespace
