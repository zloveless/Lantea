﻿// -----------------------------------------------------------------------------
//  <copyright file="ISettingsManager.cs" company="Zack Loveless">
//      Copyright (c) Zack Loveless.  All rights reserved.
//  </copyright>
// -----------------------------------------------------------------------------

namespace Lantea.Common.IO
{
	public interface ISettingsManager
	{
		string GetValue(string key);

		void Load();
	}
}