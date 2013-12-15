﻿// -----------------------------------------------------------------------------
//  <copyright file="IModule.cs" company="Zack Loveless">
//      Copyright (c) Zack Loveless.  All rights reserved.
//      
//      LICENSE TBA
//  </copyright>
// -----------------------------------------------------------------------------

namespace Lantea.Common.Modules
{
	public interface IModule : IModuleMeta
	{
		bool IsLoaded { get; }

		void Load();

		void Unload();
	}
}