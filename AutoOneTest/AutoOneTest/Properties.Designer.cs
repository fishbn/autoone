﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AutoOneTest {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "15.5.0.0")]
    internal sealed partial class Properties : global::System.Configuration.ApplicationSettingsBase {
        
        private static Properties defaultInstance = ((Properties)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Properties())));
        
        public static Properties Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("https://www.autohero.com/de/search/")]
        public string baseUrl {
            get {
                return ((string)(this["baseUrl"]));
            }
            set {
                this["baseUrl"] = value;
            }
        }
    }
}
