//--------------------------------------------------------------------------------------------------
// <auto-generated>
//
//     This code was generated by code generator tool.
//
//     To customize the code use your own partial class. For more info about how to use and customize
//     the generated code see the documentation at https://docs.xperience.io/.
//
// </auto-generated>
//--------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using CMS;
using CMS.Base;
using CMS.Helpers;
using CMS.DataEngine;
using CMS.DocumentEngine;
using CMS.DocumentEngine.Types.MedioClinic;

[assembly: RegisterDocumentType(Company.CLASS_NAME, typeof(Company))]

namespace CMS.DocumentEngine.Types.MedioClinic
{
	/// <summary>
	/// Represents a content item of type Company.
	/// </summary>
	public partial class Company : TreeNode
	{
		#region "Constants and variables"

		/// <summary>
		/// The name of the data class.
		/// </summary>
		public const string CLASS_NAME = "MedioClinic.Company";


		/// <summary>
		/// The instance of the class that provides extended API for working with Company fields.
		/// </summary>
		private readonly CompanyFields mFields;

		#endregion


		#region "Properties"

		/// <summary>
		/// CompanyID.
		/// </summary>
		[DatabaseIDField]
		public int CompanyID
		{
			get
			{
				return ValidationHelper.GetInteger(GetValue("CompanyID"), 0);
			}
			set
			{
				SetValue("CompanyID", value);
			}
		}


		/// <summary>
		/// EmailAddress.
		/// </summary>
		[DatabaseField]
		public string EmailAddress
		{
			get
			{
				return ValidationHelper.GetString(GetValue("EmailAddress"), @"");
			}
			set
			{
				SetValue("EmailAddress", value);
			}
		}


		/// <summary>
		/// Street.
		/// </summary>
		[DatabaseField]
		public string Street
		{
			get
			{
				return ValidationHelper.GetString(GetValue("Street"), @"");
			}
			set
			{
				SetValue("Street", value);
			}
		}


		/// <summary>
		/// City.
		/// </summary>
		[DatabaseField]
		public string City
		{
			get
			{
				return ValidationHelper.GetString(GetValue("City"), @"");
			}
			set
			{
				SetValue("City", value);
			}
		}


		/// <summary>
		/// Country.
		/// </summary>
		[DatabaseField]
		public string Country
		{
			get
			{
				return ValidationHelper.GetString(GetValue("Country"), @"");
			}
			set
			{
				SetValue("Country", value);
			}
		}


		/// <summary>
		/// PostalCode.
		/// </summary>
		[DatabaseField]
		public string PostalCode
		{
			get
			{
				return ValidationHelper.GetString(GetValue("PostalCode"), @"");
			}
			set
			{
				SetValue("PostalCode", value);
			}
		}


		/// <summary>
		/// PhoneNumber.
		/// </summary>
		[DatabaseField]
		public string PhoneNumber
		{
			get
			{
				return ValidationHelper.GetString(GetValue("PhoneNumber"), @"");
			}
			set
			{
				SetValue("PhoneNumber", value);
			}
		}


		/// <summary>
		/// Gets an object that provides extended API for working with Company fields.
		/// </summary>
		[RegisterProperty]
		public CompanyFields Fields
		{
			get
			{
				return mFields;
			}
		}


		/// <summary>
		/// Provides extended API for working with Company fields.
		/// </summary>
		[RegisterAllProperties]
		public partial class CompanyFields : AbstractHierarchicalObject<CompanyFields>
		{
			/// <summary>
			/// The content item of type Company that is a target of the extended API.
			/// </summary>
			private readonly Company mInstance;


			/// <summary>
			/// Initializes a new instance of the <see cref="CompanyFields" /> class with the specified content item of type Company.
			/// </summary>
			/// <param name="instance">The content item of type Company that is a target of the extended API.</param>
			public CompanyFields(Company instance)
			{
				mInstance = instance;
			}


			/// <summary>
			/// CompanyID.
			/// </summary>
			public int ID
			{
				get
				{
					return mInstance.CompanyID;
				}
				set
				{
					mInstance.CompanyID = value;
				}
			}


			/// <summary>
			/// EmailAddress.
			/// </summary>
			public string EmailAddress
			{
				get
				{
					return mInstance.EmailAddress;
				}
				set
				{
					mInstance.EmailAddress = value;
				}
			}


			/// <summary>
			/// Street.
			/// </summary>
			public string Street
			{
				get
				{
					return mInstance.Street;
				}
				set
				{
					mInstance.Street = value;
				}
			}


			/// <summary>
			/// City.
			/// </summary>
			public string City
			{
				get
				{
					return mInstance.City;
				}
				set
				{
					mInstance.City = value;
				}
			}


			/// <summary>
			/// Country.
			/// </summary>
			public string Country
			{
				get
				{
					return mInstance.Country;
				}
				set
				{
					mInstance.Country = value;
				}
			}


			/// <summary>
			/// PostalCode.
			/// </summary>
			public string PostalCode
			{
				get
				{
					return mInstance.PostalCode;
				}
				set
				{
					mInstance.PostalCode = value;
				}
			}


			/// <summary>
			/// PhoneNumber.
			/// </summary>
			public string PhoneNumber
			{
				get
				{
					return mInstance.PhoneNumber;
				}
				set
				{
					mInstance.PhoneNumber = value;
				}
			}
		}

		#endregion


		#region "Constructors"

		/// <summary>
		/// Initializes a new instance of the <see cref="Company" /> class.
		/// </summary>
		public Company() : base(CLASS_NAME)
		{
			mFields = new CompanyFields(this);
		}

		#endregion
	}
}