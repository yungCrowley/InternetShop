﻿#pragma checksum "..\..\..\Pages\LimitedPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "F76D89E101F73D1056CC7AFF6684576F396EB411D6ECB2CB68E32470E14AD2CF"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using InternetShop.Pages;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace InternetShop.Pages {
    
    
    /// <summary>
    /// LimitedPage
    /// </summary>
    public partial class LimitedPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector, System.Windows.Markup.IStyleConnector {
        
        
        #line 18 "..\..\..\Pages\LimitedPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid DGBucket;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\Pages\LimitedPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button OrderBtn;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\Pages\LimitedPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BackBtn;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\..\Pages\LimitedPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button DeleteBtn;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\..\Pages\LimitedPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AddLimited;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\..\Pages\LimitedPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView LVLimited;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/InternetShop;component/pages/limitedpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Pages\LimitedPage.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 10 "..\..\..\Pages\LimitedPage.xaml"
            ((InternetShop.Pages.LimitedPage)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Page_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.DGBucket = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 3:
            this.OrderBtn = ((System.Windows.Controls.Button)(target));
            
            #line 31 "..\..\..\Pages\LimitedPage.xaml"
            this.OrderBtn.Click += new System.Windows.RoutedEventHandler(this.OrderBtn_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.BackBtn = ((System.Windows.Controls.Button)(target));
            
            #line 34 "..\..\..\Pages\LimitedPage.xaml"
            this.BackBtn.Click += new System.Windows.RoutedEventHandler(this.BackBtn_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.DeleteBtn = ((System.Windows.Controls.Button)(target));
            
            #line 37 "..\..\..\Pages\LimitedPage.xaml"
            this.DeleteBtn.Click += new System.Windows.RoutedEventHandler(this.DeleteBtn_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.AddLimited = ((System.Windows.Controls.Button)(target));
            
            #line 40 "..\..\..\Pages\LimitedPage.xaml"
            this.AddLimited.Click += new System.Windows.RoutedEventHandler(this.AddLimited_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.LVLimited = ((System.Windows.Controls.ListView)(target));
            return;
            }
            this._contentLoaded = true;
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        void System.Windows.Markup.IStyleConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 8:
            
            #line 82 "..\..\..\Pages\LimitedPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.AddToBucket_Click);
            
            #line default
            #line hidden
            break;
            }
        }
    }
}
