﻿#pragma checksum "..\..\..\Windows\ExecutorProfile.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "3257545523277EF72AE9838CCA871DE6A667A75E683F7E26EE9B7C242AFAD779"
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
using Mediateka.UsersControls;
using Mediateka.Windows;
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


namespace Mediateka.Windows {
    
    
    /// <summary>
    /// ExecutorProfile
    /// </summary>
    public partial class ExecutorProfile : System.Windows.Window, System.Windows.Markup.IComponentConnector, System.Windows.Markup.IStyleConnector {
        
        
        #line 53 "..\..\..\Windows\ExecutorProfile.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel SPSkillsExecutor;
        
        #line default
        #line hidden
        
        
        #line 60 "..\..\..\Windows\ExecutorProfile.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox CCBSkils;
        
        #line default
        #line hidden
        
        
        #line 71 "..\..\..\Windows\ExecutorProfile.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView LBPortfolio;
        
        #line default
        #line hidden
        
        
        #line 108 "..\..\..\Windows\ExecutorProfile.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BAddComment;
        
        #line default
        #line hidden
        
        
        #line 161 "..\..\..\Windows\ExecutorProfile.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BHire;
        
        #line default
        #line hidden
        
        
        #line 165 "..\..\..\Windows\ExecutorProfile.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BBack;
        
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
            System.Uri resourceLocater = new System.Uri("/Mediateka;component/windows/executorprofile.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Windows\ExecutorProfile.xaml"
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
            this.SPSkillsExecutor = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 2:
            this.CCBSkils = ((System.Windows.Controls.ListBox)(target));
            return;
            case 3:
            this.LBPortfolio = ((System.Windows.Controls.ListView)(target));
            return;
            case 5:
            this.BAddComment = ((System.Windows.Controls.Button)(target));
            
            #line 109 "..\..\..\Windows\ExecutorProfile.xaml"
            this.BAddComment.Click += new System.Windows.RoutedEventHandler(this.BAddComment_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.BHire = ((System.Windows.Controls.Button)(target));
            
            #line 163 "..\..\..\Windows\ExecutorProfile.xaml"
            this.BHire.Click += new System.Windows.RoutedEventHandler(this.BHire_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.BBack = ((System.Windows.Controls.Button)(target));
            
            #line 166 "..\..\..\Windows\ExecutorProfile.xaml"
            this.BBack.Click += new System.Windows.RoutedEventHandler(this.BBack_Click);
            
            #line default
            #line hidden
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
            case 4:
            
            #line 83 "..\..\..\Windows\ExecutorProfile.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.BInstall_Click);
            
            #line default
            #line hidden
            break;
            }
        }
    }
}

