﻿#pragma checksum "..\..\..\Pages\WaitingEventList.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "066D04C03FDD628A59582191B2EEADD5DB11CDDA9FAF29B430EC3838CB1F3E41"
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
    /// WaitingEventList
    /// </summary>
    public partial class WaitingEventList : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 18 "..\..\..\Pages\WaitingEventList.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BApprove;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\Pages\WaitingEventList.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BNotApprove;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\Pages\WaitingEventList.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TBSearch;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\..\Pages\WaitingEventList.xaml"
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
            System.Uri resourceLocater = new System.Uri("/Mediateka;component/pages/waitingeventlist.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Pages\WaitingEventList.xaml"
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
            
            #line 10 "..\..\..\Pages\WaitingEventList.xaml"
            ((Mediateka.Pages.WaitingEventList)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Page_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.BApprove = ((System.Windows.Controls.Button)(target));
            
            #line 19 "..\..\..\Pages\WaitingEventList.xaml"
            this.BApprove.Click += new System.Windows.RoutedEventHandler(this.BApprove_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.BNotApprove = ((System.Windows.Controls.Button)(target));
            
            #line 23 "..\..\..\Pages\WaitingEventList.xaml"
            this.BNotApprove.Click += new System.Windows.RoutedEventHandler(this.BNotApprove_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.TBSearch = ((System.Windows.Controls.TextBox)(target));
            
            #line 32 "..\..\..\Pages\WaitingEventList.xaml"
            this.TBSearch.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TBSearch_TextChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.LVEvents = ((System.Windows.Controls.ListView)(target));
            
            #line 47 "..\..\..\Pages\WaitingEventList.xaml"
            this.LVEvents.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.LVEvents_SelectionChanged);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

