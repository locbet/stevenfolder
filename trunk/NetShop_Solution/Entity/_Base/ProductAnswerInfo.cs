
using System;
using System.Data;

namespace Entity
{
	/// <summary>
	/// Class:ProductAnswerInfo
	/// Author:Steven
    /// Create:2009/11/29 11:32:28
	/// </summary>
	public class ProductAnswerInfo
	{
		#region Private Column
        
		private System.Int32 _id;
		private System.String _productNO;
		private System.Int32 _serviceType;
		private System.String _ask;
		private System.String _answer;
		private System.Int32 _yesCount;
		private System.Int32 _noCount;
        
		#endregion
		
        /// <summary>
        /// 
        /// </summary>
		public ProductAnswerInfo()
		{
		}
        
		#region Public Property
        
		public System.Int32 Id
		{
			get{return this._id;}
			set{this._id = value;}
		}
		public System.String ProductNO
		{
			get{return this._productNO;}
			set{this._productNO = value;}
		}
		public System.Int32 ServiceType
		{
			get{return this._serviceType;}
			set{this._serviceType = value;}
		}
		public System.String Ask
		{
			get{return this._ask;}
			set{this._ask = value;}
		}
		public System.String Answer
		{
			get{return this._answer;}
			set{this._answer = value;}
		}
		public System.Int32 YesCount
		{
			get{return this._yesCount;}
			set{this._yesCount = value;}
		}
		public System.Int32 NoCount
		{
			get{return this._noCount;}
			set{this._noCount = value;}
		}
		#endregion
        
        #region Public Method
        /// <summary>
        /// Convert IDataReader To ProductAnswerInfo
        /// </summary>
        /// <param name="reader"></param>
        /// <returns></returns>
		public static ProductAnswerInfo SetValue(IDataReader reader)
		{
			ProductAnswerInfo info = new ProductAnswerInfo();
            
			int idIndex = reader.GetOrdinal("ID");
			int productNOIndex = reader.GetOrdinal("ProductNO");
			int serviceTypeIndex = reader.GetOrdinal("ServiceType");
			int askIndex = reader.GetOrdinal("Ask");
			int answerIndex = reader.GetOrdinal("Answer");
			int yesCountIndex = reader.GetOrdinal("YesCount");
			int noCountIndex = reader.GetOrdinal("NoCount");
            
			info.Id = reader.GetInt32(idIndex);
			info.ProductNO = reader.GetString(productNOIndex);
			info.ServiceType = reader.GetInt32(serviceTypeIndex);
			info.Ask = reader.GetString(askIndex);
			info.Answer = reader.GetString(answerIndex);
			info.YesCount = reader.GetInt32(yesCountIndex);
			info.NoCount = reader.GetInt32(noCountIndex);
            
			return info;
		}
        #endregion
	}
}
