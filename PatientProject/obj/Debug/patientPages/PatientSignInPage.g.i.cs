﻿#pragma checksum "..\..\..\PatientPages\PatientSignInPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "3AFA35881F8B245BD2862BF3C61B787E18C5376392DAEBFC26EDB0E62E9999EE"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using HCZdravo;
using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Converters;
using MaterialDesignThemes.Wpf.Transitions;
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


namespace HCZdravo {
    
    
    /// <summary>
    /// PatientSignInPage
    /// </summary>
    public partial class PatientSignInPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 52 "..\..\..\PatientPages\PatientSignInPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox user;
        
        #line default
        #line hidden
        
        
        #line 55 "..\..\..\PatientPages\PatientSignInPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox pwd;
        
        #line default
        #line hidden
        
        
        #line 62 "..\..\..\PatientPages\PatientSignInPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock errormessage;
        
        #line default
        #line hidden
        
        
        #line 63 "..\..\..\PatientPages\PatientSignInPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock errorWrongInput;
        
        #line default
        #line hidden
        
        
        #line 65 "..\..\..\PatientPages\PatientSignInPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button signIn;
        
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
            System.Uri resourceLocater = new System.Uri("/PatientProject;component/patientpages/patientsigninpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\PatientPages\PatientSignInPage.xaml"
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
            this.user = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.pwd = ((System.Windows.Controls.PasswordBox)(target));
            return;
            case 3:
            
            #line 60 "..\..\..\PatientPages\PatientSignInPage.xaml"
            ((System.Windows.Controls.TextBlock)(target)).MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.forgotenPassword_MouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            case 4:
            this.errormessage = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 5:
            this.errorWrongInput = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 6:
            this.signIn = ((System.Windows.Controls.Button)(target));
            
            #line 65 "..\..\..\PatientPages\PatientSignInPage.xaml"
            this.signIn.Click += new System.Windows.RoutedEventHandler(this.signIn_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 102 "..\..\..\PatientPages\PatientSignInPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Register_Button_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

