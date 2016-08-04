// =====================================================================
//
//  This file is part of the Microsoft Dynamics CRM SDK code samples.
//
//  Copyright (C) Microsoft Corporation.  All rights reserved.
//
//  This source code is intended only as a supplement to Microsoft
//  Development Tools and/or on-line documentation.  See these other
//  materials for detailed information regarding Microsoft code samples.
//
//  THIS CODE AND INFORMATION ARE PROVIDED "AS IS" WITHOUT WARRANTY OF ANY
//  KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE
//  IMPLIED WARRANTIES OF MERCHANTABILITY AND/OR FITNESS FOR A
//  PARTICULAR PURPOSE.
//
// =====================================================================

namespace Xrm.Sdk.PluginRegistration
{
    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.IO;
    using System.Reflection;

    internal static class AssemblyResolver
    {
        /// <summary>
        /// Subdirectories that may contain an assembly (if it can't be located).
        /// </summary>
        /// <remarks>
        /// This is useful for architecture specific assemblies that may be different depending on the process architecture
        /// of the current assembly.
        /// </remarks>
        private static readonly string[] AssemblyProbeSubdirectories = new string[] { string.Empty, "amd64", "i386", @"..\..\..\..\..\private\lib" };

        /// <summary>
        /// Contains a list of the assemblies that were resolved via the custom assembly resolve event
        /// </summary>
        private static Dictionary<string, Assembly> _resolvedAssemblies = new Dictionary<string, Assembly>();

        /// <summary>
        /// List of base directories that should be checked
        /// </summary>
        private static Collection<string> _baseDirectories = new Collection<string>();

        /// <summary>
        /// Attaches the resolver to the current app domain
        /// </summary>
        internal static void AttachResolver()
        {
            AttachResolver(AppDomain.CurrentDomain);
        }

        /// <summary>
        /// Attaches the resolver to the current app domain
        /// </summary>
        internal static void AttachResolver(AppDomain domain)
        {
            if (null == domain)
            {
                throw new ArgumentNullException("domain");
            }

            domain.AssemblyResolve += new ResolveEventHandler(ResolveAssembly);
        }

        private static Assembly ResolveAssembly(object sender, ResolveEventArgs args)
        {
            //Check if the assembly has already been resolved
            Assembly resolvedAssembly;
            if (_resolvedAssemblies.TryGetValue(args.Name, out resolvedAssembly))
            {
                return resolvedAssembly;
            }

            //Check if the base directories have been initialized
            if (_baseDirectories.Count == 0)
            {
                _baseDirectories.Add(Path.GetDirectoryName(AppDomain.CurrentDomain.BaseDirectory).ToUpperInvariant());

                string currentDirectory = Path.GetDirectoryName(Environment.CurrentDirectory);
                if (!_baseDirectories.Contains(currentDirectory))
                {
                    _baseDirectories.Add(currentDirectory);
                }
            }

            //Create an AssemblyName from the event arguments so that the name can be retrieved
            AssemblyName name = new AssemblyName(args.Name);

            //Create a file name for the assembly to start probing for a location
            string fileName = name.Name + ".dll";

            //Loop through the probing subdirectories to see if the assembly exists
            foreach (string baseDirectory in _baseDirectories)
            {
                foreach (string subdirectory in AssemblyProbeSubdirectories)
                {
                    //Create the file path to the assembly
                    string assemblyPath = Path.Combine(Path.Combine(baseDirectory, subdirectory), fileName);

                    //Check if the file path exists
                    if (File.Exists(assemblyPath))
                    {
                        //Load the assembly and return it
                        try
                        {
                            Assembly assembly = Assembly.Load(AssemblyName.GetAssemblyName(assemblyPath));
                            _resolvedAssemblies[args.Name] = assembly;
                            return assembly;
                        }
                        catch (BadImageFormatException)
                        {
                            //Ignore this assembly, because it will not work for the current assembly
                        }
                    }
                }
            }

            _resolvedAssemblies[args.Name] = null;
            return null;
        }
    }
}
