﻿#pragma checksum "..\..\..\..\Pages\EvenPlanner\ListEventPlanner.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "DA7C2787A6A77B22A98BEE6A3E7F564C9F03A9415EDF80F962B2EF0B1735924F"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Converters;
using MaterialDesignThemes.Wpf.Transitions;
using Mediateka.Pages;
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


namespace Mediateka.Pages {
    
    
    /// <summary>
    /// ListEventPlanner
    /// </summary>
    public partial class ListEventPlanner : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector, System.Windows.Markup.IStyleConnector {
        
        
        #line 20 "..\..\..\..\Pages\EvenPlanner\ListEventPlanner.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BAddEvent;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\..\Pages\EvenPlanner\ListEventPlanner.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BEdit;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\..\Pages\EvenPlanner\ListEventPlanner.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TBSearch;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\..\..\Pages\EvenPlanner\ListEventPlanner.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView LVEvents;
        
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
            System.Uri resourceLocater = new System.Uri("/Mediateka;component/pages/evenplanner/listeventplanner.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Pages\EvenPlanner\ListEventPlanner.xaml"
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
            
            #line 11 "..\..\..\..\Pages\EvenPlanner\ListEventPlanner.xaml"
            ((Mediateka.Pages.ListEventPlanner)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Page_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.BAddEvent = ((System.Windows.Controls.Button)(target));
            
            #line 21 "..\..\..\..\Pages\EvenPlanner\ListEventPlanner.xaml"
            this.BAddEvent.Click += new System.Windows.RoutedEventHandler(this.BAddEvent_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.BEdit = ((System.Windows.Controls.Button)(target));
            
            #line 24 "..\..\..\..\Pages\EvenPlanner\ListEventPlanner.xaml"
            this.BEdit.Click += new System.Windows.RoutedEventHandler(this.BEdit_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.TBSearch = ((System.Windows.Controls.TextBox)(target));
            
            #line 35 "..\..\..\..\Pages\EvenPlanner\ListEventPlanner.xaml"
            this.TBSearch.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TBSearch_TextChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.LVEvents = ((System.Windows.Controls.ListView)(target));
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
            case 6:
            
            #line 69 "..\..\..\..\Pages\EvenPlanner\ListEventPlanner.xaml"
            ((System.Windows.Controls.DataGrid)(target)).MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.DGExecutors_MouseDoubleClick);
            
            #line default
            #line hidden
            break;
            case 7:
            
            #line 96 "..\..\..\..\Pages\EvenPlanner\ListEventPlanner.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.BHire_Click);
            
            #line default
            #line hidden
            break;
            case 8:
            
            #line 100 "..\..\..\..\Pages\EvenPlanner\ListEventPlanner.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.BRefusal_Click);
            
            #line default
            #line hidden
            break;
            case 9:
            
            #line 115 "..\..\..\..\Pages\EvenPlanner\ListEventPlanner.xaml"
            ((System.Windows.Controls.DataGrid)(target)).MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.DGExecutors_MouseDoubleClick);
            
            #line default
            #line hidden
            break;
            case 10:
            
            #line 142 "..\..\..\..\Pages\EvenPlanner\ListEventPlanner.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.BHire_Click);
            
            #line default
            #line hidden
            break;
            case 11:
            
            #line 146 "..\..\..\..\Pages\EvenPlanner\ListEventPlanner.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.BRefusal_Click);
            
            #line default
            #line hidden
            break;
            case 12:
            
            #line 194 "..\..\..\..\Pages\EvenPlanner\ListEventPlanner.xaml"
            ((System.Windows.Documents.Hyperlink)(target)).Click += new System.Windows.RoutedEventHandler(this.BInstall_Click);
            
            #line default
            #line hidden
            break;
            }
        }
    }
}

