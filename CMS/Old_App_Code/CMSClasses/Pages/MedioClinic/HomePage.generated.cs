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

[assembly: RegisterDocumentType(HomePage.CLASS_NAME, typeof(HomePage))]

namespace CMS.DocumentEngine.Types.MedioClinic
{
	/// <summary>
	/// Represents a content item of type HomePage.
	/// </summary>
	public partial class HomePage : TreeNode
	{
		#region "Constants and variables"

		/// <summary>
		/// The name of the data class.
		/// </summary>
		public const string CLASS_NAME = "MedioClinic.HomePage";


		/// <summary>
		/// The instance of the class that provides extended API for working with HomePage fields.
		/// </summary>
		private readonly HomePageFields mFields;

		#endregion


		#region "Properties"

		/// <summary>
		/// HomePageID.
		/// </summary>
		[DatabaseIDField]
		public int HomePageID
		{
			get
			{
				return ValidationHelper.GetInteger(GetValue("HomePageID"), 0);
			}
			set
			{
				SetValue("HomePageID", value);
			}
		}


		/// <summary>
		/// DoctorsLinkButtonText.
		/// </summary>
		[DatabaseField]
		public string DoctorsLinkButtonText
		{
			get
			{
				return ValidationHelper.GetString(GetValue("DoctorsLinkButtonText"), @"");
			}
			set
			{
				SetValue("DoctorsLinkButtonText", value);
			}
		}


		/// <summary>
		/// ServicesLinkButtonText.
		/// </summary>
		[DatabaseField]
		public string ServicesLinkButtonText
		{
			get
			{
				return ValidationHelper.GetString(GetValue("ServicesLinkButtonText"), @"");
			}
			set
			{
				SetValue("ServicesLinkButtonText", value);
			}
		}


		/// <summary>
		/// Perex.
		/// </summary>
		[DatabaseField]
		public string Perex
		{
			get
			{
				return ValidationHelper.GetString(GetValue("Perex"), @"");
			}
			set
			{
				SetValue("Perex", value);
			}
		}


		/// <summary>
		/// Text.
		/// </summary>
		[DatabaseField]
		public string Text
		{
			get
			{
				return ValidationHelper.GetString(GetValue("Text"), @"");
			}
			set
			{
				SetValue("Text", value);
			}
		}


		/// <summary>
		/// Gets an object that provides extended API for working with HomePage fields.
		/// </summary>
		[RegisterProperty]
		public HomePageFields Fields
		{
			get
			{
				return mFields;
			}
		}


		/// <summary>
		/// Provides extended API for working with HomePage fields.
		/// </summary>
		[RegisterAllProperties]
		public partial class HomePageFields : AbstractHierarchicalObject<HomePageFields>
		{
			/// <summary>
			/// The content item of type HomePage that is a target of the extended API.
			/// </summary>
			private readonly HomePage mInstance;


			/// <summary>
			/// Initializes a new instance of the <see cref="HomePageFields" /> class with the specified content item of type HomePage.
			/// </summary>
			/// <param name="instance">The content item of type HomePage that is a target of the extended API.</param>
			public HomePageFields(HomePage instance)
			{
				mInstance = instance;
			}


			/// <summary>
			/// HomePageID.
			/// </summary>
			public int ID
			{
				get
				{
					return mInstance.HomePageID;
				}
				set
				{
					mInstance.HomePageID = value;
				}
			}


			/// <summary>
			/// DoctorsLinkButtonText.
			/// </summary>
			public string DoctorsLinkButtonText
			{
				get
				{
					return mInstance.DoctorsLinkButtonText;
				}
				set
				{
					mInstance.DoctorsLinkButtonText = value;
				}
			}


			/// <summary>
			/// ServicesLinkButtonText.
			/// </summary>
			public string ServicesLinkButtonText
			{
				get
				{
					return mInstance.ServicesLinkButtonText;
				}
				set
				{
					mInstance.ServicesLinkButtonText = value;
				}
			}


			/// <summary>
			/// Perex.
			/// </summary>
			public string Perex
			{
				get
				{
					return mInstance.Perex;
				}
				set
				{
					mInstance.Perex = value;
				}
			}


			/// <summary>
			/// Text.
			/// </summary>
			public string Text
			{
				get
				{
					return mInstance.Text;
				}
				set
				{
					mInstance.Text = value;
				}
			}
		}

		#endregion


		#region "Constructors"

		/// <summary>
		/// Initializes a new instance of the <see cref="HomePage" /> class.
		/// </summary>
		public HomePage() : base(CLASS_NAME)
		{
			mFields = new HomePageFields(this);
		}

		#endregion
	}
}