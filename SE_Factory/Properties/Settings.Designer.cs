﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Il codice è stato generato da uno strumento.
//     Versione runtime:4.0.30319.42000
//
//     Le modifiche apportate a questo file possono provocare un comportamento non corretto e andranno perse se
//     il codice viene rigenerato.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SE_Factory.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "15.9.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\DB_Factory.md" +
            "f;Integrated Security=True")]
        public string DB_FactoryConnectionString {
            get {
                return ((string)(this["DB_FactoryConnectionString"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=SERVER08\\SQLEXPRESS;Initial Catalog=DYOPENG;Persist Security Info=Tru" +
            "e;User ID=sa;Password=aavesp19")]
        public string DYOPENGConnectionString {
            get {
                return ((string)(this["DYOPENGConnectionString"]));
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("192.168.000.107")]
        public string IP_Printer {
            get {
                return ((string)(this["IP_Printer"]));
            }
            set {
                this["IP_Printer"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string Path_URL_Documentazione {
            get {
                return ((string)(this["Path_URL_Documentazione"]));
            }
            set {
                this["Path_URL_Documentazione"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("\\\\192.168.0.8\\Firmware\\Motorola\\Ufficio Collaudi\\Sistemi")]
        public string Path_URL_Software {
            get {
                return ((string)(this["Path_URL_Software"]));
            }
            set {
                this["Path_URL_Software"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("D:\\VS2017 - Projects\\SE_Factory\\Products_Images")]
        public string Path_URL_Images {
            get {
                return ((string)(this["Path_URL_Images"]));
            }
            set {
                this["Path_URL_Images"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("C:\\Commander")]
        public string Path_URL_Commander {
            get {
                return ((string)(this["Path_URL_Commander"]));
            }
            set {
                this["Path_URL_Commander"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool IP_Printer_alwaysprint {
            get {
                return ((bool)(this["IP_Printer_alwaysprint"]));
            }
            set {
                this["IP_Printer_alwaysprint"] = value;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("server=34.65.242.38;user id=sa;password=aavesp19;persistsecurityinfo=True;databas" +
            "e=DB_Factory;certificatefile=C:\\Users\\albmi\\Desktop\\CoDiNg\\SE-Factory_MySql\\Cert" +
            "ificates\\client-cert.pfx")]
        public string DB_FactoryConnectionString1 {
            get {
                return ((string)(this["DB_FactoryConnectionString1"]));
            }
        }
    }
}
