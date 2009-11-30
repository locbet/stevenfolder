
using System;
using System.Data;

namespace Entity
{
	/// <summary>
	/// Class:ProductInfo
	/// Author:Steven
    /// Create:2009/11/29 11:32:27
	/// </summary>
	public class ProductInfo
	{
		#region Private Column
        
		private System.String _productNO;
		private System.String _cateIDPath;
		private System.String _nickName;
		private System.String _productName;
		private System.Decimal _marketPrice;
		private System.Decimal _innerPrice;
		private System.Int32 _brandID;
		private System.String _brandName;
        
		#endregion
		
        /// <summary>
        /// 
        /// </summary>
		public ProductInfo()
		{
		}
        
		#region Public Property
        
		public System.String ProductNO
		{
			get{return this._productNO;}
			set{this._productNO = value;}
		}
		public System.String CateIDPath
		{
			get{return this._cateIDPath;}
			set{this._cateIDPath = value;}
		}
		public System.String NickName
		{
			get{return this._nickName;}
			set{this._nickName = value;}
		}
		public System.String ProductName
		{
			get{return this._productName;}
			set{this._productName = value;}
		}
		public System.Decimal MarketPrice
		{
			get{return this._marketPrice;}
			set{this._marketPrice = value;}
		}
		public System.Decimal InnerPrice
		{
			get{return this._innerPrice;}
			set{this._innerPrice = value;}
		}
		public System.Int32 BrandID
		{
			get{return this._brandID;}
			set{this._brandID = value;}
		}
		public System.String BrandName
		{
			get{return this._brandName;}
			set{this._brandName = value;}
		}
		#endregion
        
        #region Public Method
        /// <summary>
        /// Convert IDataReader To ProductInfo
        /// </summary>
        /// <param name="reader"></param>
        /// <returns></returns>
		public static ProductInfo SetValue(IDataReader reader)
		{
			ProductInfo info = new ProductInfo();
            
			int productNOIndex = reader.GetOrdinal("ProductNO");
			int cateIDPathIndex = reader.GetOrdinal("CateIDPath");
			int nickNameIndex = reader.GetOrdinal("NickName");
			int productNameIndex = reader.GetOrdinal("ProductName");
			int marketPriceIndex = reader.GetOrdinal("MarketPrice");
			int innerPriceIndex = reader.GetOrdinal("InnerPrice");
			int brandIDIndex = reader.GetOrdinal("BrandID");
			int brandNameIndex = reader.GetOrdinal("BrandName");
            
			info.ProductNO = reader.GetString(productNOIndex);
			info.CateIDPath = reader.GetString(cateIDPathIndex);
			info.NickName = reader.GetString(nickNameIndex);
			info.ProductName = reader.GetString(productNameIndex);
			info.MarketPrice = reader.GetDecimal(marketPriceIndex);
			info.InnerPrice = reader.GetDecimal(innerPriceIndex);
			info.BrandID = reader.GetInt32(brandIDIndex);
			info.BrandName = reader.GetString(brandNameIndex);
            
			return info;
		}
        #endregion
	}
}
