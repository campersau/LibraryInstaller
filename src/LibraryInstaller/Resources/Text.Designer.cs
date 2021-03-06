﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LibraryInstaller.Resources {
    using System;
    using System.Reflection;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class Text {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Text() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("LibraryInstaller.Resources.Text", typeof(Text).GetTypeInfo().Assembly);
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
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} could not be written to disk. Make sure the file name is correct.
        /// </summary>
        public static string ErrorCouldNotWriteFile {
            get {
                return ResourceManager.GetString("ErrorCouldNotWriteFile", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The manifest file contains syntax errors.
        /// </summary>
        public static string ErrorManifestMalformed {
            get {
                return ResourceManager.GetString("ErrorManifestMalformed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The &quot;{0}&quot; provider could not be found.
        /// </summary>
        public static string ErrorProviderUnknown {
            get {
                return ResourceManager.GetString("ErrorProviderUnknown", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The &quot;{0}&quot; library could not be resolved by the &quot;{1}&quot; provider.
        /// </summary>
        public static string ErrorUnableToResolveSource {
            get {
                return ResourceManager.GetString("ErrorUnableToResolveSource", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An unknown exception occured.
        /// </summary>
        public static string ErrorUnknownException {
            get {
                return ResourceManager.GetString("ErrorUnknownException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} deleted.
        /// </summary>
        public static string FileDeleted {
            get {
                return ResourceManager.GetString("FileDeleted", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to delete {0}.
        /// </summary>
        public static string FileDeleteFail {
            get {
                return ResourceManager.GetString("FileDeleteFail", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} written to disk.
        /// </summary>
        public static string FileWrittenToDisk {
            get {
                return ResourceManager.GetString("FileWrittenToDisk", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} libraries restored in {1} seconds.
        /// </summary>
        public static string LibrariesRestored {
            get {
                return ResourceManager.GetString("LibrariesRestored", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Library restore has been cancelled.
        /// </summary>
        public static string RestoreCancelled {
            get {
                return ResourceManager.GetString("RestoreCancelled", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Library restore was unsuccessfull.
        /// </summary>
        public static string RestoreHasErrors {
            get {
                return ResourceManager.GetString("RestoreHasErrors", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Restoring libraries....
        /// </summary>
        public static string RestoringLibraries {
            get {
                return ResourceManager.GetString("RestoringLibraries", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Restoring {0}....
        /// </summary>
        public static string RestoringLibrary {
            get {
                return ResourceManager.GetString("RestoringLibrary", resourceCulture);
            }
        }
    }
}
