namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: UsrYachtEventsSchema

	/// <exclude/>
	public class UsrYachtEventsSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public UsrYachtEventsSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public UsrYachtEventsSchema(UsrYachtEventsSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("8f6ac39e-4a01-4db9-a7cc-99cd9b9e2eed");
			Name = "UsrYachtEvents";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("e90a136e-6038-481b-9e29-194c764113d0");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,82,81,107,219,48,16,126,55,236,63,220,252,100,67,208,218,215,102,43,44,89,54,10,165,29,179,51,24,165,15,138,124,113,52,100,201,72,114,178,172,228,191,247,36,167,89,156,116,108,31,24,124,167,79,223,221,119,58,205,27,116,45,23,8,37,90,203,157,89,122,54,53,122,41,235,206,114,47,141,78,158,18,32,116,78,234,26,138,173,243,216,140,143,50,199,183,154,198,232,191,157,89,100,51,237,165,151,232,254,131,194,102,107,212,126,207,124,136,217,109,76,221,74,106,64,163,205,10,177,194,134,223,81,247,240,1,210,185,179,63,184,88,249,52,127,140,87,218,110,161,164,0,161,184,115,16,79,94,209,128,43,152,112,135,175,156,68,141,222,247,145,154,89,83,179,178,66,88,27,89,193,189,46,248,154,44,100,102,241,19,133,7,135,186,66,59,130,94,110,130,75,242,19,69,63,218,218,1,230,7,181,63,186,1,11,234,128,29,180,94,68,48,31,15,88,189,40,108,131,19,242,155,245,113,222,211,135,212,10,133,108,184,130,214,74,17,102,19,239,176,47,232,203,109,139,213,212,168,174,209,223,185,234,240,253,158,121,157,133,241,125,13,244,244,164,172,92,66,214,235,92,195,229,69,68,62,32,12,189,4,32,187,113,83,174,5,42,172,168,186,183,29,142,147,51,150,243,54,188,62,173,158,227,53,150,216,180,138,251,208,173,198,13,220,26,193,149,252,205,23,10,139,200,203,122,15,115,135,150,86,83,211,180,105,47,217,55,116,166,179,130,56,198,146,200,232,205,89,149,128,195,106,244,27,149,142,32,61,211,119,44,14,228,198,149,198,76,100,221,71,105,206,74,179,175,159,255,211,2,181,222,39,216,103,99,27,238,179,19,107,84,246,18,104,124,241,155,23,159,78,39,29,224,87,214,108,226,4,102,191,4,182,193,228,139,204,9,123,151,12,255,118,201,46,73,146,119,123,192,221,125,57,123,27,64,169,35,179,251,14,175,2,115,96,152,226,248,252,14,26,90,90,234,131,107,120,186,216,1,167,64,27,15,92,41,179,193,138,61,3,84,178,194,216,44,4,0,0 };
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateValueIsTooBigLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateValueIsTooBigLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("7a7e0f6d-bf0e-03ea-ca69-92c377cbd0e0"),
				Name = "ValueIsTooBig",
				CreatedInPackageId = new Guid("e90a136e-6038-481b-9e29-194c764113d0"),
				CreatedInSchemaUId = new Guid("8f6ac39e-4a01-4db9-a7cc-99cd9b9e2eed"),
				ModifiedInSchemaUId = new Guid("8f6ac39e-4a01-4db9-a7cc-99cd9b9e2eed")
			};
			return localizableString;
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("8f6ac39e-4a01-4db9-a7cc-99cd9b9e2eed"));
		}

		#endregion

	}

	#endregion

}

