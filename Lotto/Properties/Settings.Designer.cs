﻿//------------------------------------------------------------------------------
// <auto-generated>
//     이 코드는 도구를 사용하여 생성되었습니다.
//     런타임 버전:4.0.30319.42000
//
//     파일 내용을 변경하면 잘못된 동작이 발생할 수 있으며, 코드를 다시 생성하면
//     이러한 변경 내용이 손실됩니다.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Lotto.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "16.8.1.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("http://www.nlotto.co.kr/common.do?method=getLottoNumber&drwNo=")]
        public string LottoApiUrl {
            get {
                return ((string)(this["LottoApiUrl"]));
            }
            set {
                this["LottoApiUrl"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("https://search.naver.com/search.naver?where=nexearch&sm=top_hty&fbm=1&ie=utf8&que" +
            "ry=")]
        public string SearchLottoWinUrl {
            get {
                return ((string)(this["SearchLottoWinUrl"]));
            }
            set {
                this["SearchLottoWinUrl"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("45")]
        public int DefaultLottoCount {
            get {
                return ((int)(this["DefaultLottoCount"]));
            }
            set {
                this["DefaultLottoCount"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("6")]
        public int DefaultWinCount {
            get {
                return ((int)(this["DefaultWinCount"]));
            }
            set {
                this["DefaultWinCount"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("https://dhlottery.co.kr/gameResult.do?method=byWin&drwNo=")]
        public string LottoPasingUrl {
            get {
                return ((string)(this["LottoPasingUrl"]));
            }
            set {
                this["LottoPasingUrl"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("https://dhlottery.co.kr/common.do?method=getLottoNumber&drwNo=")]
        public string LottoApiUrl2 {
            get {
                return ((string)(this["LottoApiUrl2"]));
            }
            set {
                this["LottoApiUrl2"] = value;
            }
        }
    }
}