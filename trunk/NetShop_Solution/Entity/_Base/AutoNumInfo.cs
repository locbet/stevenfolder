
using System;
using System.Data;

namespace Entity
{
	/// <summary>
	/// Class:AutoNumInfo
	/// Author:Steven
    /// Create:2009/11/29 11:32:27
	/// </summary>
	public class AutoNumInfo
	{
		#region Private Column
        
		private System.Int32 _keyID;
		private System.Int32 _seed;
		private System.DateTime _seedDate;
		private System.String _prefix;
		private System.String _summary;
        
		#endregion
		
        /// <summary>
        /// 
        /// </summary>
		public AutoNumInfo()
		{
		}
        
		#region Public Property
        
		public System.Int32 KeyID
		{
			get{return this._keyID;}
			set{this._keyID = value;}
		}
		public System.Int32 Seed
		{
			get{return this._seed;}
			set{this._seed = value;}
		}
		public System.DateTime SeedDate
		{
			get{return this._seedDate;}
			set{this._seedDate = value;}
		}
		public System.String Prefix
		{
			get{return this._prefix;}
			set{this._prefix = value;}
		}
		public System.String Summary
		{
			get{return this._summary;}
			set{this._summary = value;}
		}
		#endregion
        
        #region Public Method
        /// <summary>
        /// Convert IDataReader To AutoNumInfo
        /// </summary>
        /// <param name="reader"></param>
        /// <returns></returns>
		public static AutoNumInfo SetValue(IDataReader reader)
		{
			AutoNumInfo info = new AutoNumInfo();
            
			int keyIDIndex = reader.GetOrdinal("KeyID");
			int seedIndex = reader.GetOrdinal("Seed");
			int seedDateIndex = reader.GetOrdinal("SeedDate");
			int prefixIndex = reader.GetOrdinal("Prefix");
			int summaryIndex = reader.GetOrdinal("Summary");
            
			info.KeyID = reader.GetInt32(keyIDIndex);
			info.Seed = reader.GetInt32(seedIndex);
			info.SeedDate = reader.GetDateTime(seedDateIndex);
			if(!reader.IsDBNull(prefixIndex))
			info.Prefix = reader.GetString(prefixIndex);
			if(!reader.IsDBNull(summaryIndex))
			info.Summary = reader.GetString(summaryIndex);
            
			return info;
		}
        #endregion
	}
}
