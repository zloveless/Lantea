﻿// -----------------------------------------------------------------------------
//  <copyright file="ILog.cs" company="Zack Loveless">
//      Copyright (c) Zack Loveless.  All rights reserved.
//  </copyright>
// -----------------------------------------------------------------------------

namespace Atlantis.IO
{
	using System;

	public interface ILog : IDisposable
	{
		LogThreshold Threshold { get; set; }

		Boolean PrefixLog { get; set; }

		String Prefix { get; set; }

		void Debug(String message);

		void DebugFormat(String format, params Object[] args);

		void Error(String message);

		void ErrorFormat(String format, params Object[] args);

		void Fatal(String message);

		void FatalFormat(String format, params Object[] args);

		void Info(String message);

		void InfoFormat(String format, params Object[] args);

		void Warn(String message);

		void WarnFormat(String format, params Object[] args);
	}
}
