﻿#pragma checksum "..\..\..\CancelMadeUnmadeControl.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "70AF2257E84BFE4E3DABD0234DDC73DCE3372A9CC3B383F8FC68354E4F10D93E"
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
using System.Windows.Forms.Integration;
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
using TemPOS;
using TemPOS.Types;


namespace TemPOS {
    
    
    /// <summary>
    /// CancelMadeUnmadeControl
    /// </summary>
    public partial class CancelMadeUnmadeControl : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 11 "..\..\..\CancelMadeUnmadeControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DockPanel mainPane;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\..\CancelMadeUnmadeControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal PosControls.ConfigurationManager Configuration;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\CancelMadeUnmadeControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal PosControls.TextBlockButton buttonReopen;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\CancelMadeUnmadeControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal PosControls.TextBlockButton buttonMade;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\CancelMadeUnmadeControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal PosControls.TextBlockButton buttonUnmade;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\CancelMadeUnmadeControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal PosControls.TextBlockButton buttonVoid;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\CancelMadeUnmadeControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal PosControls.TextBlockButton buttonDontCancel;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\CancelMadeUnmadeControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal PosControls.TextBlockButton buttonDontRefund;
        
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
            System.Uri resourceLocater = new System.Uri("/TemPOS;component/cancelmadeunmadecontrol.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\CancelMadeUnmadeControl.xaml"
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
            this.buttonReopen = ((PosControls.TextBlockButton)(target));
            
            #line 18 "..\..\..\CancelMadeUnmadeControl.xaml"
            this.buttonReopen.Click += new System.Windows.RoutedEventHandler(this.buttonReopen_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.buttonMade = ((PosControls.TextBlockButton)(target));
            
            #line 19 "..\..\..\CancelMadeUnmadeControl.xaml"
            this.buttonMade.Click += new System.Windows.RoutedEventHandler(this.buttonMade_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.buttonUnmade = ((PosControls.TextBlockButton)(target));
            
            #line 20 "..\..\..\CancelMadeUnmadeControl.xaml"
            this.buttonUnmade.Click += new System.Windows.RoutedEventHandler(this.buttonUnmade_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.buttonVoid = ((PosControls.TextBlockButton)(target));
            
            #line 21 "..\..\..\CancelMadeUnmadeControl.xaml"
            this.buttonVoid.Click += new System.Windows.RoutedEventHandler(this.buttonVoid_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.buttonDontCancel = ((PosControls.TextBlockButton)(target));
            
            #line 22 "..\..\..\CancelMadeUnmadeControl.xaml"
            this.buttonDontCancel.Click += new System.Windows.RoutedEventHandler(this.buttonDontCancel_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.buttonDontRefund = ((PosControls.TextBlockButton)(target));
            
            #line 23 "..\..\..\CancelMadeUnmadeControl.xaml"
            this.buttonDontRefund.Click += new System.Windows.RoutedEventHandler(this.buttonDontCancel_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

