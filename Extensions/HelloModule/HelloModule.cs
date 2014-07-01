﻿// -----------------------------------------------------------------------------
//  <copyright file="Hello.cs" company="Zack Loveless">
//      Copyright (c) Zack Loveless.  All rights reserved.
//  </copyright>
// -----------------------------------------------------------------------------

namespace Hello
{
    using System;
    using Atlantis.Net.Irc;
    using Lantea.Common.Extensibility;
    using Lantea.Common.IO;

    [Module(ConfigBlock = "hello")]
	public class HelloModule : IModule
    {
        #region Implementation of IModule

        public string Author
        {
            get { return "Zack Loveless"; }
        }

        public string Description
        {
            get { return "An example module for Lantea."; }
        }

        public string Name
        {
            get { return "Hello"; }
        }

        public string Version
        {
            get { return "1.2"; }
        }

        public void Dispose()
        {
        }

        public void Initialize(Block config, IrcClient client)
        {
            Console.WriteLine("Hello World");
        }

        #endregion
	}
}
