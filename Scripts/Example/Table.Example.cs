﻿// =======================================================================================
// Wovencore
// by Weaver (Fhiz)
// MIT licensed
// =======================================================================================

using Wovencode;
using Wovencode.Database;
using System;
using SQLite;

namespace Wovencode.Database
{

	// ===================================================================================
	// DatabaseManager
	// ===================================================================================
	public partial class DatabaseManager
	{
	
		// -------------------------------------------------------------------------------
		// TableExample
		// -------------------------------------------------------------------------------
		partial class TableExample
		{
			public string 	owner 	{ get; set; }
			public string 	name 	{ get; set; }
			public long 	amount 	{ get; set; }
		}
	
	}
		
	// -----------------------------------------------------------------------------------
	
}

// =======================================================================================