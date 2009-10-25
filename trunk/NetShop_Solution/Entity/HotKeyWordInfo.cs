// <fileinfo name="Entity\Tbl_HotKeyWordInfo.cs">
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
    /// The base class for <see cref="Tbl_HotKeyWordRow"/> that 
    /// represents a record in the <c>Tbl_HotKeyWord</c> table.
    /// </summary>
    /// <remarks>
    /// Do not change this source code manually. Update the <see cref="Tbl_HotKeyWordRow"/>
    /// class if you need to add or change some functionality.
    /// </remarks>
    public class HotKeyWordInfo
    {
        private string _keyWord;
        private int _cateID;
        private int _orderID;

        /// <summary>
        /// Initializes a new instance of the <see cref="Tbl_HotKeyWordInfo"/> class.
        /// </summary>
        public HotKeyWordInfo()
        {
            // EMPTY
        }

        /// <summary>
        /// Gets or sets the <c>KeyWord</c> column value.
        /// </summary>
        /// <value>The <c>KeyWord</c> column value.</value>
        public string KeyWord
        {
            get { return _keyWord; }
            set { _keyWord = value; }
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
        /// Gets or sets the <c>OrderID</c> column value.
        /// </summary>
        /// <value>The <c>OrderID</c> column value.</value>
        public int OrderID
        {
            get { return _orderID; }
            set { _orderID = value; }
        }

        /// <summary>
        /// Returns Tbl_HotKeyWordInfo of this instance.
        /// </summary>
        /// <returns>Tbl_HotKeyWordInfo of this instance.</returns>
        public static HotKeyWordInfo SetValue(IDataReader reader)
        {
            HotKeyWordInfo info = new HotKeyWordInfo();
            if (reader != null && !reader.IsClosed)
            {
                int keyWordColumnIndex = reader.GetOrdinal("KeyWord");
                int cateIDColumnIndex = reader.GetOrdinal("CateID");
                int orderIDColumnIndex = reader.GetOrdinal("OrderID");

                info.KeyWord = Convert.ToString(reader.GetValue(keyWordColumnIndex));
                info.CateID = Convert.ToInt32(reader.GetValue(cateIDColumnIndex));
                info.OrderID = Convert.ToInt32(reader.GetValue(orderIDColumnIndex));
            }
            return info;
        }
    } // End of Tbl_HotKeyWordInfo class
} // End of namespace
