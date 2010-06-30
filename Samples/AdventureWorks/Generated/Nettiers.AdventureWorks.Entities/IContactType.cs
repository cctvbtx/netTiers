﻿using System;
using System.ComponentModel;

namespace Nettiers.AdventureWorks.Entities
{
	/// <summary>
	///		The data structure representation of the 'ContactType' table via interface.
	/// </summary>
	/// <remarks>
	/// 	This struct is generated by a tool and should never be modified.
	/// </remarks>
	public interface IContactType 
	{
		/// <summary>			
		/// ContactTypeID : Primary key for ContactType records.
		/// </summary>
		/// <remarks>Member of the primary key of the underlying table "ContactType"</remarks>
		System.Int32 ContactTypeId { get; set; }
				
		
		
		/// <summary>
		/// Name : Contact type description.
		/// </summary>
		System.String  Name  { get; set; }
		
		/// <summary>
		/// ModifiedDate : Date and time the record was last updated.
		/// </summary>
		System.DateTime  ModifiedDate  { get; set; }
			
		/// <summary>
		/// Creates a new object that is a copy of the current instance.
		/// </summary>
		/// <returns>A new object that is a copy of this instance.</returns>
		System.Object Clone();
		
		#region Data Properties


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _storeContactContactTypeId
		/// </summary>	
		TList<StoreContact> StoreContactCollection {  get;  set;}	


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _vendorContactContactTypeId
		/// </summary>	
		TList<VendorContact> VendorContactCollection {  get;  set;}	

		#endregion Data Properties

	}
}

