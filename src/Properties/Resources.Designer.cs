﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Kros.KORM.Extensions.Asp.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Kros.KORM.Extensions.Asp.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Connection string contains only KORM keys. These are removed and so connection string is empty..
        /// </summary>
        internal static string ConnectionStringContainsOnlyKormKeys {
            get {
                return ResourceManager.GetString("ConnectionStringContainsOnlyKormKeys", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Database with name &quot;{0}&quot; was already added..
        /// </summary>
        internal static string DuplicateDatabaseName {
            get {
                return ResourceManager.GetString("DuplicateDatabaseName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Connection string in connection settings is empty..
        /// </summary>
        internal static string EmptyConnectionStringInSettings {
            get {
                return ResourceManager.GetString("EmptyConnectionStringInSettings", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Connection strings section does not contain a connection string with name &apos;{0}&apos;..
        /// </summary>
        internal static string InvalidConnectionStringName {
            get {
                return ResourceManager.GetString("InvalidConnectionStringName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Database with name &quot;{0}&quot; does not exist. Use &quot;{1}&quot; extension method to add it..
        /// </summary>
        internal static string InvalidDatabaseName {
            get {
                return ResourceManager.GetString("InvalidDatabaseName", resourceCulture);
            }
        }
    }
}
