﻿#pragma checksum "C:\Users\garvj\documents\visual studio 2015\Projects\Heist\Heist\Downloads.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "CC326B9635C399359619C6ABBD29F54F"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Heist
{
    partial class Downloads : 
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
                    global::Windows.UI.Xaml.Controls.Grid element1 = (global::Windows.UI.Xaml.Controls.Grid)(target);
                    #line 19 "..\..\..\Downloads.xaml"
                    ((global::Windows.UI.Xaml.Controls.Grid)element1).Tapped += this.Grid_Tapped;
                    #line default
                }
                break;
            case 2:
                {
                    this.MySplitView = (global::Windows.UI.Xaml.Controls.SplitView)(target);
                }
                break;
            case 3:
                {
                    this.HamburgerButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 41 "..\..\..\Downloads.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.HamburgerButton).Click += this.HamburgerButton_Click;
                    #line default
                }
                break;
            case 4:
                {
                    this.MenuButton2 = (global::Windows.UI.Xaml.Controls.RadioButton)(target);
                    #line 45 "..\..\..\Downloads.xaml"
                    ((global::Windows.UI.Xaml.Controls.RadioButton)this.MenuButton2).Click += this.MenuButton2_Click;
                    #line default
                }
                break;
            case 5:
                {
                    this.MenuButton3 = (global::Windows.UI.Xaml.Controls.RadioButton)(target);
                    #line 48 "..\..\..\Downloads.xaml"
                    ((global::Windows.UI.Xaml.Controls.RadioButton)this.MenuButton3).Click += this.MenuButton3_Click;
                    #line default
                }
                break;
            case 6:
                {
                    this.MenuButton4 = (global::Windows.UI.Xaml.Controls.RadioButton)(target);
                    #line 51 "..\..\..\Downloads.xaml"
                    ((global::Windows.UI.Xaml.Controls.RadioButton)this.MenuButton4).Click += this.MenuButton4_Click;
                    #line default
                }
                break;
            case 7:
                {
                    global::Windows.UI.Xaml.Controls.RadioButton element7 = (global::Windows.UI.Xaml.Controls.RadioButton)(target);
                    #line 54 "..\..\..\Downloads.xaml"
                    ((global::Windows.UI.Xaml.Controls.RadioButton)element7).Click += this.MenuButton1_Click;
                    #line default
                }
                break;
            case 8:
                {
                    this.MenuButton5 = (global::Windows.UI.Xaml.Controls.RadioButton)(target);
                    #line 58 "..\..\..\Downloads.xaml"
                    ((global::Windows.UI.Xaml.Controls.RadioButton)this.MenuButton5).Click += this.MenuButton5_Click;
                    #line default
                }
                break;
            case 9:
                {
                    this.MenuButton6 = (global::Windows.UI.Xaml.Controls.RadioButton)(target);
                    #line 61 "..\..\..\Downloads.xaml"
                    ((global::Windows.UI.Xaml.Controls.RadioButton)this.MenuButton6).Click += this.MenuButton6_Click;
                    #line default
                }
                break;
            case 10:
                {
                    this.TitlBox = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 11:
                {
                    this.LoadingBar = (global::Windows.UI.Xaml.Controls.ProgressBar)(target);
                }
                break;
            case 12:
                {
                    this.event1 = (global::Windows.UI.Xaml.Controls.GridView)(target);
                }
                break;
            case 13:
                {
                    this.event2 = (global::Windows.UI.Xaml.Controls.GridView)(target);
                }
                break;
            case 14:
                {
                    this.PdfGrid = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 15:
                {
                    this.pdfViewer = (global::Syncfusion.Windows.PdfViewer.SfPdfViewerControl)(target);
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

