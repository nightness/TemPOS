﻿#pragma checksum "..\..\..\CustomerDetailsControl.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "E74004A95FFFAE4A541688DF9BA082819DC810D656E2D5E5E58ECE33F4AC963C"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using PosControls;
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
using TemposClientAdministration;


namespace TemposClientAdministration {
    
    
    /// <summary>
    /// CustomerDetailsControl
    /// </summary>
    public partial class CustomerDetailsControl : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\..\CustomerDetailsControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DockPanel mainPane;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\..\CustomerDetailsControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal PosControls.ConfigurationManager Configuration;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\CustomerDetailsControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal PosControls.CustomTextBox textBoxBusinessName;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\..\CustomerDetailsControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal PosControls.CustomTextBox textBoxContactsName;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\..\CustomerDetailsControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal PosControls.CustomTextBox textBoxAddress;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\..\CustomerDetailsControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal PosControls.CustomTextBox textBoxCity;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\..\CustomerDetailsControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal PosControls.CustomTextBox textBoxState;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\..\CustomerDetailsControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal PosControls.CustomTextBox textBoxZip;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\..\CustomerDetailsControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal PosControls.CustomTextBox textBoxPhone1;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\..\CustomerDetailsControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal PosControls.CustomTextBox textBoxPhone2;
        
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
            System.Uri resourceLocater = new System.Uri("/TemposClientAdministration;component/customerdetailscontrol.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\CustomerDetailsControl.xaml"
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
            this.mainPane = ((System.Windows.Controls.DockPanel)(target));
            return;
            case 2:
            this.Configuration = ((PosControls.ConfigurationManager)(target));
            return;
            case 3:
            this.textBoxBusinessName = ((PosControls.CustomTextBox)(target));
            
            #line 39 "..\..\..\CustomerDetailsControl.xaml"
            this.textBoxBusinessName.TextChanged += new System.Windows.RoutedEventHandler(this.textBoxBusinessName_TextChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.textBoxContactsName = ((PosControls.CustomTextBox)(target));
            
            #line 40 "..\..\..\CustomerDetailsControl.xaml"
            this.textBoxContactsName.TextChanged += new System.Windows.RoutedEventHandler(this.textBoxContactsName_TextChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.textBoxAddress = ((PosControls.CustomTextBox)(target));
            
            #line 41 "..\..\..\CustomerDetailsControl.xaml"
            this.textBoxAddress.TextChanged += new System.Windows.RoutedEventHandler(this.textBoxAddress_TextChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            this.textBoxCity = ((PosControls.CustomTextBox)(target));
            
            #line 42 "..\..\..\CustomerDetailsControl.xaml"
            this.textBoxCity.TextChanged += new System.Windows.RoutedEventHandler(this.textBoxCity_TextChanged);
            
            #line default
            #line hidden
            return;
            case 7:
            this.textBoxState = ((PosControls.CustomTextBox)(target));
            
            #line 43 "..\..\..\CustomerDetailsControl.xaml"
            this.textBoxState.TextChanged += new System.Windows.RoutedEventHandler(this.textBoxState_TextChanged);
            
            #line default
            #line hidden
            return;
            case 8:
            this.textBoxZip = ((PosControls.CustomTextBox)(target));
            
            #line 44 "..\..\..\CustomerDetailsControl.xaml"
            this.textBoxZip.TextChanged += new System.Windows.RoutedEventHandler(this.textBoxZip_TextChanged);
            
            #line default
            #line hidden
            return;
            case 9:
            this.textBoxPhone1 = ((PosControls.CustomTextBox)(target));
            
            #line 45 "..\..\..\CustomerDetailsControl.xaml"
            this.textBoxPhone1.TextChanged += new System.Windows.RoutedEventHandler(this.textBoxPhone1_TextChanged);
            
            #line default
            #line hidden
            return;
            case 10:
            this.textBoxPhone2 = ((PosControls.CustomTextBox)(target));
            
            #line 46 "..\..\..\CustomerDetailsControl.xaml"
            this.textBoxPhone2.TextChanged += new System.Windows.RoutedEventHandler(this.textBoxPhone2_TextChanged);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

