//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Nequeo.DataAccess.ApplicationLogin.Data.Extended
{
    using System;
    using System.Linq;
    using System.Text;
    using System.Data;
    using System.Threading;
    using System.Diagnostics;
    using System.Data.SqlClient;
    using System.Data.OleDb;
    using System.Data.Odbc;
    using System.Collections;
    using System.Reflection;
    using System.Collections.Generic;
    using System.Xml.Serialization;
    using System.Runtime.Serialization;
    using System.ComponentModel;
    using Nequeo.Data.DataType;
    using Nequeo.Data;
    using Nequeo.Data.Linq;
    using Nequeo.Data.Control;
    using Nequeo.Data.Custom;
    using Nequeo.Data.LinqToSql;
    using Nequeo.Data.DataSet;
    using Nequeo.Data.Edm;
    using Nequeo.ComponentModel;
    
    
    #region LanguageList Data Type
    /// <summary>
    /// The languagelist data object class.
    /// </summary>
    [DataContractAttribute(Name = "LanguageList", IsReference = true)]
    [SerializableAttribute()]
    [KnownTypeAttribute(typeof(DataBase))]
    public partial class LanguageList : DataBase
    {
        
        private long _LanguageID;
        
        private string _LanguageName;
        
        private string _LanguageCode;
        
        private string _LanguageCountryCode;
        
        private string _CountryName;
        
        #region Extensibility Method Definitions
        /// <summary>
        /// On create data entity.
        /// </summary>
		partial void OnCreated();

        /// <summary>
        /// On load data entity.
        /// </summary>
		partial void OnLoaded();

		#endregion
        
        /// <summary>
        /// Default constructor.
        /// </summary>
        public LanguageList()
        {
            OnCreated();
        }
        
        /// <summary>
        /// Gets sets, the languageid property for the object.
        /// </summary>
        [CategoryAttribute("Column")]
        [DescriptionAttribute("Gets sets, the languageid property for the object.")]
        [DataMemberAttribute(Name = "LanguageID")]
        [XmlElementAttribute(ElementName = "LanguageID", IsNullable = false)]
        [SoapElementAttribute(IsNullable = false)]
        public long LanguageID
        {
            get
            {
                return this._LanguageID;
            }
            set
            {
                if ((this._LanguageID != value))
                {
                    this._LanguageID = value;
                }
            }
        }
        
        /// <summary>
        /// Gets sets, the languagename property for the object.
        /// </summary>
        [CategoryAttribute("Column")]
        [DescriptionAttribute("Gets sets, the languagename property for the object.")]
        [DataMemberAttribute(Name = "LanguageName")]
        [XmlElementAttribute(ElementName = "LanguageName", IsNullable = false)]
        [SoapElementAttribute(IsNullable = false)]
        public string LanguageName
        {
            get
            {
                return this._LanguageName;
            }
            set
            {
                if ((this._LanguageName != value))
                {
                    this._LanguageName = value;
                }
            }
        }
        
        /// <summary>
        /// Gets sets, the languagecode property for the object.
        /// </summary>
        [CategoryAttribute("Column")]
        [DescriptionAttribute("Gets sets, the languagecode property for the object.")]
        [DataMemberAttribute(Name = "LanguageCode")]
        [XmlElementAttribute(ElementName = "LanguageCode", IsNullable = false)]
        [SoapElementAttribute(IsNullable = false)]
        public string LanguageCode
        {
            get
            {
                return this._LanguageCode;
            }
            set
            {
                if ((this._LanguageCode != value))
                {
                    this._LanguageCode = value;
                }
            }
        }
        
        /// <summary>
        /// Gets sets, the languagecountrycode property for the object.
        /// </summary>
        [CategoryAttribute("Column")]
        [DescriptionAttribute("Gets sets, the languagecountrycode property for the object.")]
        [DataMemberAttribute(Name = "LanguageCountryCode")]
        [XmlElementAttribute(ElementName = "LanguageCountryCode", IsNullable = false)]
        [SoapElementAttribute(IsNullable = false)]
        public string LanguageCountryCode
        {
            get
            {
                return this._LanguageCountryCode;
            }
            set
            {
                if ((this._LanguageCountryCode != value))
                {
                    this._LanguageCountryCode = value;
                }
            }
        }
        
        /// <summary>
        /// Gets sets, the countryname property for the object.
        /// </summary>
        [CategoryAttribute("Column")]
        [DescriptionAttribute("Gets sets, the countryname property for the object.")]
        [DataMemberAttribute(Name = "CountryName")]
        [XmlElementAttribute(ElementName = "CountryName", IsNullable = false)]
        [SoapElementAttribute(IsNullable = false)]
        public string CountryName
        {
            get
            {
                return this._CountryName;
            }
            set
            {
                if ((this._CountryName != value))
                {
                    this._CountryName = value;
                }
            }
        }
        
        /// <summary>
        /// Create a new languagelist data entity.
        /// </summary>
        /// <param name="languageID">Initial value of LanguageID.</param>
        /// <param name="languageName">Initial value of LanguageName.</param>
        /// <param name="languageCode">Initial value of LanguageCode.</param>
        /// <param name="languageCountryCode">Initial value of LanguageCountryCode.</param>
        /// <param name="countryName">Initial value of CountryName.</param>
        /// <returns>The Data.Extended.LanguageList entity.</returns>
        public static Data.Extended.LanguageList CreateLanguageList(long languageID, string languageName, string languageCode, string languageCountryCode, string countryName)
        {
            Data.Extended.LanguageList languageList = new Data.Extended.LanguageList();
            languageList.LanguageID = languageID;
            languageList.LanguageName = languageName;
            languageList.LanguageCode = languageCode;
            languageList.LanguageCountryCode = languageCountryCode;
            languageList.CountryName = countryName;
            return languageList;
        }
    }
    #endregion
}