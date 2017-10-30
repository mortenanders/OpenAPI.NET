﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Microsoft.OpenApi.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class SRResource {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal SRResource() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = 
                        new global::System.Resources.ResourceManager(typeof(SRResource).FullName, typeof(SRResource).Assembly);
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
        ///   Looks up a localized string similar to The argument &apos;{0}&apos; is null, empty or consists only of white-space..
        /// </summary>
        internal static string ArgumentNullOrWhiteSpace {
            get {
                return ResourceManager.GetString("ArgumentNullOrWhiteSpace", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The filed name of extension doesn&apos;t begin with x-..
        /// </summary>
        internal static string ExtensionFieldNameMustBeginWithXMinus {
            get {
                return ResourceManager.GetString("ExtensionFieldNameMustBeginWithXMinus", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An error occurred while processing the Open API document..
        /// </summary>
        internal static string OpenApiExceptionGeneralError {
            get {
                return ResourceManager.GetString("OpenApiExceptionGeneralError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The object element name &apos;{0}&apos; is required..
        /// </summary>
        internal static string OpenApiObjectElementIsRequired {
            get {
                return ResourceManager.GetString("OpenApiObjectElementIsRequired", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The OpenApi element &apos;{0}&apos; is already marked as reference object..
        /// </summary>
        internal static string OpenApiObjectMarkAsReference {
            get {
                return ResourceManager.GetString("OpenApiObjectMarkAsReference", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to If the parameter location is &quot;path&quot;, this property is REQUIRED and its value MUST be true.
        /// </summary>
        internal static string OpenApiParameterRequiredPropertyMandatory {
            get {
                return ResourceManager.GetString("OpenApiParameterRequiredPropertyMandatory", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The type &apos;{0}&apos; is not supported in Open API document..
        /// </summary>
        internal static string OpenApiUnsupportedValueType {
            get {
                return ResourceManager.GetString("OpenApiUnsupportedValueType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The active scope must be an object scope for name &apos;{0}&apos; to be written..
        /// </summary>
        internal static string OpenApiWriterMustBeObjectScope {
            get {
                return ResourceManager.GetString("OpenApiWriterMustBeObjectScope", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to There must be an active scope for name &apos;{0}&apos; to be written..
        /// </summary>
        internal static string OpenApiWriterMustHaveActiveScope {
            get {
                return ResourceManager.GetString("OpenApiWriterMustHaveActiveScope", resourceCulture);
            }
        }
    }
}
