﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace installmentsApp {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "16.4.0.0")]
    internal sealed partial class DatabaseSetting : global::System.Configuration.ApplicationSettingsBase {
        
        private static DatabaseSetting defaultInstance = ((DatabaseSetting)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new DatabaseSetting())));
        
        public static DatabaseSetting Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string SerVer {
            get {
                return ((string)(this["SerVer"]));
            }
            set {
                this["SerVer"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string DataBase {
            get {
                return ((string)(this["DataBase"]));
            }
            set {
                this["DataBase"] = value;
            }
        }
    }
}
