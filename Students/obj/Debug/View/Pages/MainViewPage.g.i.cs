﻿#pragma checksum "..\..\..\..\View\Pages\MainViewPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "6F1F20EDC644B3B34E159C4A9759921C2F8CAFE71DEE5772689A1476588B91AF"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using Students.View.Pages;
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


namespace Students.View.Pages {
    
    
    /// <summary>
    /// MainViewPage
    /// </summary>
    public partial class MainViewPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 21 "..\..\..\..\View\Pages\MainViewPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BackBtn;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\..\View\Pages\MainViewPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox searchTxb;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\..\..\View\Pages\MainViewPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button clear_cmb;
        
        #line default
        #line hidden
        
        
        #line 54 "..\..\..\..\View\Pages\MainViewPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox filtrCmb;
        
        #line default
        #line hidden
        
        
        #line 64 "..\..\..\..\View\Pages\MainViewPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView listVieww;
        
        #line default
        #line hidden
        
        
        #line 102 "..\..\..\..\View\Pages\MainViewPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel AdminPanel;
        
        #line default
        #line hidden
        
        
        #line 105 "..\..\..\..\View\Pages\MainViewPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button addBtn;
        
        #line default
        #line hidden
        
        
        #line 110 "..\..\..\..\View\Pages\MainViewPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button editBtn;
        
        #line default
        #line hidden
        
        
        #line 115 "..\..\..\..\View\Pages\MainViewPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button deleteBtn;
        
        #line default
        #line hidden
        
        
        #line 124 "..\..\..\..\View\Pages\MainViewPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button PersonalAreaBtn;
        
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
            System.Uri resourceLocater = new System.Uri("/Students;component/view/pages/mainviewpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\View\Pages\MainViewPage.xaml"
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
            
            #line 7 "..\..\..\..\View\Pages\MainViewPage.xaml"
            ((Students.View.Pages.MainViewPage)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Page_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.BackBtn = ((System.Windows.Controls.Button)(target));
            
            #line 26 "..\..\..\..\View\Pages\MainViewPage.xaml"
            this.BackBtn.Click += new System.Windows.RoutedEventHandler(this.BackBtn_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.searchTxb = ((System.Windows.Controls.TextBox)(target));
            
            #line 38 "..\..\..\..\View\Pages\MainViewPage.xaml"
            this.searchTxb.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.searchTxb_TextChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.clear_cmb = ((System.Windows.Controls.Button)(target));
            
            #line 52 "..\..\..\..\View\Pages\MainViewPage.xaml"
            this.clear_cmb.Click += new System.Windows.RoutedEventHandler(this.clear_cmb_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.filtrCmb = ((System.Windows.Controls.ComboBox)(target));
            
            #line 58 "..\..\..\..\View\Pages\MainViewPage.xaml"
            this.filtrCmb.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.filtrCmb_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            this.listVieww = ((System.Windows.Controls.ListView)(target));
            return;
            case 7:
            this.AdminPanel = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 8:
            this.addBtn = ((System.Windows.Controls.Button)(target));
            
            #line 109 "..\..\..\..\View\Pages\MainViewPage.xaml"
            this.addBtn.Click += new System.Windows.RoutedEventHandler(this.addBtn_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.editBtn = ((System.Windows.Controls.Button)(target));
            
            #line 114 "..\..\..\..\View\Pages\MainViewPage.xaml"
            this.editBtn.Click += new System.Windows.RoutedEventHandler(this.editBtn_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.deleteBtn = ((System.Windows.Controls.Button)(target));
            
            #line 118 "..\..\..\..\View\Pages\MainViewPage.xaml"
            this.deleteBtn.Click += new System.Windows.RoutedEventHandler(this.deleteBtn_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            this.PersonalAreaBtn = ((System.Windows.Controls.Button)(target));
            
            #line 129 "..\..\..\..\View\Pages\MainViewPage.xaml"
            this.PersonalAreaBtn.Click += new System.Windows.RoutedEventHandler(this.PersonalAreaBtn_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
