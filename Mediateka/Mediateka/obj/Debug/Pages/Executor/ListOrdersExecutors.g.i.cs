﻿#pragma checksum "..\..\..\..\Pages\Executor\ListOrdersExecutors.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "3A3DE63D3F7842A396F4C46876B9AA3081F32C6369BFFA47261D35E4DD9981AC"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

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
    /// ListOrdersExecutors
    /// </summary>
    public partial class ListOrdersExecutors : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector, System.Windows.Markup.IStyleConnector {
        
        
        #line 24 "..\..\..\..\Pages\Executor\ListOrdersExecutors.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TBSearch;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\..\..\Pages\Executor\ListOrdersExecutors.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView LVEvents;
        
        #line default
        #line hidden
        
        
        #line 93 "..\..\..\..\Pages\Executor\ListOrdersExecutors.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BUpload;
        
        #line default
        #line hidden
        
        
        #line 99 "..\..\..\..\Pages\Executor\ListOrdersExecutors.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView LVOrders;
        
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
            System.Uri resourceLocater = new System.Uri("/Mediateka;component/pages/executor/listordersexecutors.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Pages\Executor\ListOrdersExecutors.xaml"
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
            this.TBSearch = ((System.Windows.Controls.TextBox)(target));
            
            #line 27 "..\..\..\..\Pages\Executor\ListOrdersExecutors.xaml"
            this.TBSearch.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TBSearch_TextChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.LVEvents = ((System.Windows.Controls.ListView)(target));
            
            #line 42 "..\..\..\..\Pages\Executor\ListOrdersExecutors.xaml"
            this.LVEvents.MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.LVEvents_MouseDoubleClick);
            
            #line default
            #line hidden
            return;
            case 4:
            this.BUpload = ((System.Windows.Controls.Button)(target));
            
            #line 95 "..\..\..\..\Pages\Executor\ListOrdersExecutors.xaml"
            this.BUpload.Click += new System.Windows.RoutedEventHandler(this.BUpload_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.LVOrders = ((System.Windows.Controls.ListView)(target));
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
            case 3:
            
            #line 57 "..\..\..\..\Pages\Executor\ListOrdersExecutors.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.BResponse_Click);
            
            #line default
            #line hidden
            break;
            case 6:
            
            #line 123 "..\..\..\..\Pages\Executor\ListOrdersExecutors.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.BRemoveFile_Click);
            
            #line default
            #line hidden
            break;
            }
        }
    }
}

