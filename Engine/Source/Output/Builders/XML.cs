﻿/* 
 * Class: GregValure.NaturalDocs.Engine.Output.Builders.XML
 * ____________________________________________________________________________
 * 
 * An output builder for XML.
 */

// This file is part of Natural Docs, which is Copyright © 2003-2013 Greg Valure.
// Natural Docs is licensed under version 3 of the GNU Affero General Public License (AGPL)
// Refer to License.txt for the complete details


using System;
using GregValure.NaturalDocs.Engine.Links;
using GregValure.NaturalDocs.Engine.Topics;


namespace GregValure.NaturalDocs.Engine.Output.Builders
	{
	public class XML : Builder
		{
		
		// Group: Functions
		// __________________________________________________________________________
		
		
		public XML (Config.Entries.XMLOutputFolder configEntry) : base ()
			{
			config = configEntry;
			}

		
		public override bool Start (Errors.ErrorList errorList)
			{  
			if (System.IO.Directory.Exists(config.Folder) == false)
				{
				errorList.Add( Locale.Get("NaturalDocs.Engine", "Error.FolderDoesntExist(type, name)", "output", config.Folder) );
				return false;
				}
			
			return true;
			}

	
		public override void WorkOnUpdatingOutput (CancelDelegate cancelDelegate)
			{
			}


		public override long UnitsOfWorkRemaining ()
			{
			return 0;
			}
			
			
		
		// Group: Variables
		// __________________________________________________________________________

		protected Config.Entries.XMLOutputFolder config;

		}
	}