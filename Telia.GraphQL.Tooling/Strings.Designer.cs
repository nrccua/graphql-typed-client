﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Telia.GraphQL.Tooling {
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
    public class Strings {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Strings() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Telia.GraphQL.Tooling.Strings", typeof(Strings).Assembly);
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
        ///   Looks up a localized string similar to This generator only supports &apos;Constant&apos; and &apos;Variable&apos; child nodes for a &apos;Class&apos; node. Found: {0}.
        /// </summary>
        public static string BadClassMemberName {
            get {
                return ResourceManager.GetString("BadClassMemberName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to For types, the access attribute must be &apos;public&apos; or &apos;internal&apos;. Found: {0}.
        /// </summary>
        public static string BadTypeAccess {
            get {
                return ResourceManager.GetString("BadTypeAccess", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to For &apos;Variable&apos; nodes, the &apos;access&apos; attribute must be &apos;public&apos;, &apos;protected&apos;, or &apos;private&apos;. Found: {0}.
        /// </summary>
        public static string BadVariableAccess {
            get {
                return ResourceManager.GetString("BadVariableAccess", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &apos;Constant&apos; and &apos;Variable&apos; child nodes of a &apos;Class&apos; node must have a &apos;name&apos; attribute.
        /// </summary>
        public static string ClassMemberNoName {
            get {
                return ResourceManager.GetString("ClassMemberNoName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &apos;Constant&apos; and &apos;Variable&apos; child nodes of a &apos;Class&apos; node must have a &apos;type&apos; attribute.
        /// </summary>
        public static string ClassMemberNoType {
            get {
                return ResourceManager.GetString("ClassMemberNoType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Each &apos;Class&apos; node must have a name attribute.
        /// </summary>
        public static string ClassNodeNoName {
            get {
                return ResourceManager.GetString("ClassNodeNoName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &apos;Constant&apos; nodes must have a &apos;value&apos; attribute.
        /// </summary>
        public static string ConstantNoValue {
            get {
                return ResourceManager.GetString("ConstantNoValue", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &apos;Enum&apos; nodes can only have &apos;EnumMember&apos; child nodes. Found: {0}.
        /// </summary>
        public static string EnumInvalidChild {
            get {
                return ResourceManager.GetString("EnumInvalidChild", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Each &apos;EnumMember&apos; node must have a name attribute.
        /// </summary>
        public static string EnumMemberNodeNoName {
            get {
                return ResourceManager.GetString("EnumMemberNodeNoName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to If &apos;Enum&apos; node has flagsAttribute=&quot;true&quot;, each &apos;EnumMember&apos; child must have a value attribute.
        /// </summary>
        public static string EnumMemberValueMissing {
            get {
                return ResourceManager.GetString("EnumMemberValueMissing", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Each &apos;Enum&apos; node must have a name attribute.
        /// </summary>
        public static string EnumNodeNoName {
            get {
                return ResourceManager.GetString("EnumNodeNoName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &apos;Enum&apos; nodes must have at least one &apos;EnumMember&apos; child node.
        /// </summary>
        public static string EnumNoMembers {
            get {
                return ResourceManager.GetString("EnumNoMembers", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The call to GetDefaultExtension() has failed due to the exception:.
        /// </summary>
        public static string GetDefaultExtensionFailed {
            get {
                return ResourceManager.GetString("GetDefaultExtensionFailed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Expected root element: &apos;Types&apos;. Found: {0}  .
        /// </summary>
        public static string InvalidRoot {
            get {
                return ResourceManager.GetString("InvalidRoot", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The &apos;Types&apos; root node should only contain &apos;Class&apos; or &apos;Enum&apos; child nodes. Found: {0}.
        /// </summary>
        public static string InvalidType {
            get {
                return ResourceManager.GetString("InvalidType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The &apos;Types&apos; root element must contain at least one &apos;Class&apos; or &apos;Enum&apos; child.
        /// </summary>
        public static string NoTypes {
            get {
                return ResourceManager.GetString("NoTypes", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &apos;Constant&apos; nodes can not have the &apos;static&apos; attribute.
        /// </summary>
        public static string StaticConstant {
            get {
                return ResourceManager.GetString("StaticConstant", resourceCulture);
            }
        }
    }
}
