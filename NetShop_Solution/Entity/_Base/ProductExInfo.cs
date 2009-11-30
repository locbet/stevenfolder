
using System;
using System.Data;

namespace Entity
{
	/// <summary>
	/// Class:ProductExInfo
	/// Author:Steven
    /// Create:2009/11/29 11:32:28
	/// </summary>
	public class ProductExInfo
	{
		#region Private Column
        
		private System.String _productNO;
		private System.String _intro;
		private System.String _standards;
		private System.String _packing;
		private System.String _service;
        
		#endregion
		
        /// <summary>
        /// 
        /// </summary>
		public ProductExInfo()
		{
		}
        
		#region Public Property
        
		public System.String ProductNO
		{
			get{return this._productNO;}
			set{this._productNO = value;}
		}
		public System.String Intro
		{
			get{return this._intro;}
			set{this._intro = value;}
		}
		public System.String Standards
		{
			get{return this._standards;}
			set{this._standards = value;}
		}
		public System.String Packing
		{
			get{return this._packing;}
			set{this._packing = value;}
		}
		public System.String Service
		{
			get{return this._service;}
			set{this._service = value;}
		}
		#endregion
        
        #region Public Method
        /// <summary>
        /// Convert IDataReader To ProductExInfo
        /// </summary>
        /// <param name="reader"></param>
        /// <returns></returns>
		public static ProductExInfo SetValue(IDataReader reader)
		{
			ProductExInfo info = new ProductExInfo();
            
			int productNOIndex = reader.GetOrdinal("ProductNO");
			int introIndex = reader.GetOrdinal("Intro");
			int standardsIndex = reader.GetOrdinal("Standards");
			int packingIndex = reader.GetOrdinal("Packing");
			int serviceIndex = reader.GetOrdinal("Service");
            
			info.ProductNO = reader.GetString(productNOIndex);
			info.Intro = reader.GetString(introIndex);
			info.Standards = reader.GetString(standardsIndex);
			info.Packing = reader.GetString(packingIndex);
			info.Service = reader.GetString(serviceIndex);
            
			return info;
		}
        #endregion
	}
}
