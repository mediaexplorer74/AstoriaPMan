﻿#pragma checksum "C:\Users\Admin\source\repos\AstoriaPMan\Src\MainPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "0A97A2020A2D169DDD5B61842D0371E34FC919B1D964F7D15615CE93F75CA51F"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Astoria_Package_Manager
{
    partial class MainPage : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                {
                    global::Windows.UI.Xaml.Controls.Page element1 = (global::Windows.UI.Xaml.Controls.Page)(target);
                    #line 10 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Page)element1).Loaded += this.Page_Loaded;
                    #line default
                }
                break;
            case 2:
                {
                    this.APIPivot = (global::Windows.UI.Xaml.Controls.Pivot)(target);
                    #line 15 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Pivot)this.APIPivot).SelectionChanged += this.APIPivot_SelectionChanged;
                    #line default
                }
                break;
            case 3:
                {
                    this.ReadmeFrame = (global::Windows.UI.Xaml.Controls.Frame)(target);
                }
                break;
            case 4:
                {
                    this.InstallPackageBtn = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 473 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.InstallPackageBtn).Click += this.InstallPackageBtn_Click;
                    #line default
                }
                break;
            case 5:
                {
                    this.ReadMeScroll = (global::Windows.UI.Xaml.Controls.ScrollViewer)(target);
                }
                break;
            case 6:
                {
                    this.CloseReadme = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 460 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.CloseReadme).Click += this.CloseReadme_Click;
                    #line default
                }
                break;
            case 7:
                {
                    this.ReadmeBox = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 8:
                {
                    this.repo = (global::Windows.UI.Xaml.Controls.PivotItem)(target);
                }
                break;
            case 9:
                {
                    this.AboutText = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 10:
                {
                    this.TelegramLink = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 401 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.TelegramLink).Click += this.TelegramLink_Click;
                    #line default
                }
                break;
            case 11:
                {
                    this.GithubAStorageLnk = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 411 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.GithubAStorageLnk).Click += this.GithubAStorageLnk_Click;
                    #line default
                }
                break;
            case 12:
                {
                    this.ClearFirstRunData = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 422 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.ClearFirstRunData).Click += this.ClearFirstRunData_Click;
                    #line default
                }
                break;
            case 13:
                {
                    this.OutputText = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 14:
                {
                    this.progressRepo = (global::Windows.UI.Xaml.Controls.ProgressBar)(target);
                }
                break;
            case 15:
                {
                    this.LoadRepo = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 208 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.LoadRepo).Click += this.LoadRepo_Click;
                    #line default
                }
                break;
            case 16:
                {
                    this.RepoGrid = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 17:
                {
                    this.RepoRelPanel = (global::Windows.UI.Xaml.Controls.RelativePanel)(target);
                }
                break;
            case 18:
                {
                    this.RepoHome = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 228 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.RepoHome).Click += this.RepoHome_Click;
                    #line default
                }
                break;
            case 19:
                {
                    this.GamesButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 255 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.GamesButton).Click += this.GamesButton_Click;
                    #line default
                }
                break;
            case 20:
                {
                    this.Appsbutton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 264 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.Appsbutton).Click += this.Appsbutton_Click;
                    #line default
                }
                break;
            case 21:
                {
                    this.AudioVideo = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 275 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.AudioVideo).Click += this.AudioVideo_Click;
                    #line default
                }
                break;
            case 22:
                {
                    this.Browsers = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 285 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.Browsers).Click += this.Browsers_Click;
                    #line default
                }
                break;
            case 23:
                {
                    this.Emulation = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 295 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.Emulation).Click += this.Emulation_Click;
                    #line default
                }
                break;
            case 24:
                {
                    this.GApps = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 305 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.GApps).Click += this.GApps_Click;
                    #line default
                }
                break;
            case 25:
                {
                    this.Imaging = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 315 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.Imaging).Click += this.Imaging_Click;
                    #line default
                }
                break;
            case 26:
                {
                    this.Messaging = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 325 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.Messaging).Click += this.Messaging_Click;
                    #line default
                }
                break;
            case 27:
                {
                    this.Misc = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 335 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.Misc).Click += this.Misc_Click;
                    #line default
                }
                break;
            case 28:
                {
                    this.Readers = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 345 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.Readers).Click += this.Readers_Click;
                    #line default
                }
                break;
            case 29:
                {
                    this.SocialMedia = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 355 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.SocialMedia).Click += this.SocialMedia_Click;
                    #line default
                }
                break;
            case 30:
                {
                    this.TextEdit = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 365 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.TextEdit).Click += this.TextEdit_Click;
                    #line default
                }
                break;
            case 31:
                {
                    this.Tools = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 375 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.Tools).Click += this.Tools_Click;
                    #line default
                }
                break;
            case 32:
                {
                    this.GamesStack = (global::Windows.UI.Xaml.Controls.StackPanel)(target);
                }
                break;
            case 33:
                {
                    this.GridExtractor = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 34:
                {
                    this.progressBar = (global::Windows.UI.Xaml.Controls.ProgressBar)(target);
                }
                break;
            case 35:
                {
                    this.ProgRing = (global::Windows.UI.Xaml.Controls.ProgressRing)(target);
                }
                break;
            case 36:
                {
                    this.textscroll = (global::Windows.UI.Xaml.Controls.ScrollViewer)(target);
                }
                break;
            case 37:
                {
                    this.AppLogo = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            case 38:
                {
                    this.PermText = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 39:
                {
                    this.OutputBox = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 40:
                {
                    this.OpenArchiveHeader = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 41:
                {
                    this.OpenArchive = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 82 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.OpenArchive).Click += this.OpenArchive_Click;
                    #line default
                }
                break;
            case 42:
                {
                    this.ViewManifestBtn = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 97 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.ViewManifestBtn).Click += this.ViewManifestBtn_Click;
                    #line default
                }
                break;
            case 43:
                {
                    this.AddOBBData = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 110 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.AddOBBData).Click += this.AddOBBData_Click;
                    #line default
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}

