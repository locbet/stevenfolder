// <fileinfo name="Entity\CustomerInfo.cs">
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
	/// The base class for <see cref="CustomerRow"/> that 
	/// represents a record in the <c>Tbl_Customer</c> table.
	/// </summary>
	/// <remarks>
	/// Do not change this source code manually. Update the <see cref="CustomerRow"/>
	/// class if you need to add or change some functionality.
	/// </remarks>
	public class CustomerInfo
	{
		private string _customerNO;
		private string _email;
		private string _password;
		private string _nickName;
		private string _telephone;
		private string _mobile;

		/// <summary>
		/// Initializes a new instance of the <see cref="CustomerInfo"/> class.
		/// </summary>
		public CustomerInfo()
		{
			// EMPTY
		}

		/// <summary>
		/// Gets or sets the <c>CustomerNO</c> column value.
		/// </summary>
		/// <value>The <c>CustomerNO</c> column value.</value>
		public string CustomerNO
		{
			get { return _customerNO; }
			set { _customerNO = value; }
		}

		/// <summary>
		/// Gets or sets the <c>Email</c> column value.
		/// </summary>
		/// <value>The <c>Email</c> column value.</value>
		public string Email
		{
			get { return _email; }
			set { _email = value; }
		}

		/// <summary>
		/// Gets or sets the <c>Password</c> column value.
		/// </summary>
		/// <value>The <c>Password</c> column value.</value>
		public string Password
		{
			get { return _password; }
			set { _password = value; }
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
		/// Gets or sets the <c>Telephone</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Telephone</c> column value.</value>
		public string Telephone
		{
			get { return _telephone; }
			set { _telephone = value; }
		}

		/// <summary>
		/// Gets or sets the <c>Mobile</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Mobile</c> column value.</value>
		public string Mobile
		{
			get { return _mobile; }
			set { _mobile = value; }
		}

		/// <summary>
		/// Returns CustomerInfo of this instance.
		/// </summary>
		/// <returns>CustomerInfo of this instance.</returns>
		public static CustomerInfo SetValue(IDataReader reader)
		{
			CustomerInfo info = new CustomerInfo();
			if (reader != null && !reader.IsClosed)
			{	int customerNOColumnIndex = reader.GetOrdinal("CustomerNO");
				int emailColumnIndex = reader.GetOrdinal("Email");
				int passwordColumnIndex = reader.GetOrdinal("Password");
				int nickNameColumnIndex = reader.GetOrdinal("NickName");
				int telephoneColumnIndex = reader.GetOrdinal("Telephone");
				int mobileColumnIndex = reader.GetOrdinal("Mobile");
						
				info.CustomerNO = Convert.ToString(reader.GetValue(customerNOColumnIndex));
				info.Email = Convert.ToString(reader.GetValue(emailColumnIndex));
				info.Password = Convert.ToString(reader.GetValue(passwordColumnIndex));
				info.NickName = Convert.ToString(reader.GetValue(nickNameColumnIndex));
				if(!reader.IsDBNull(telephoneColumnIndex))
				info.Telephone = Convert.ToString(reader.GetValue(telephoneColumnIndex));
				if(!reader.IsDBNull(mobileColumnIndex))
				info.Mobile = Convert.ToString(reader.GetValue(mobileColumnIndex));
			}
			return info;
		}
	} // End of CustomerInfo class
} // End of namespace
