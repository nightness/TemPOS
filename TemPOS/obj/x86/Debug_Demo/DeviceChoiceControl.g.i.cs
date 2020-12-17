﻿#pragma checksum "..\..\..\DeviceChoiceControl.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "73F0A9E7C8A6B49D645D8D9DFF650FECDB5F4AE49D8AE2FF134DA3773A05BEFD"
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
    /// DeviceChoiceControl
    /// </summary>
    public partial class DeviceChoiceControl : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 2 "..\..\..\DeviceChoiceControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DockPanel mainPane;
        
        #line default
        #line hidden
        
        
        #line 3 "..\..\..\DeviceChoiceControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal PosControls.ConfigurationManager Configuration;
        
        #line default
        #line hidden
        
        
        #line 8 "..\..\..\DeviceChoiceControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid gridDemo;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\..\DeviceChoiceControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid gridPosPrinter;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\..\DeviceChoiceControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal PosControls.PushComboBox comboBoxPrinterOutput;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\DeviceChoiceControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid gridCashDrawer;
        
        #line default
        #line hidden
        
        
        #line 66 "..\..\..\DeviceChoiceControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid gridScanner;
        
        #line default
        #line hidden
        
        
        #line 93 "..\..\..\DeviceChoiceControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid gridCoinDispenser;
        
        #line default
        #line hidden
        
        
        #line 120 "..\..\..\DeviceChoiceControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid gridBumpBar;
        
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
            System.Uri resourceLocater = new System.Uri("/TemPOS;component/devicechoicecontrol.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\DeviceChoiceControl.xaml"
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
            this.gridDemo = ((System.Windows.Controls.Grid)(target));
            return;
            case 4:
            this.gridPosPrinter = ((System.Windows.Controls.Grid)(target));
            return;
            case 5:
            this.comboBoxPrinterOutput = ((PosControls.PushComboBox)(target));
            
            #line 37 "..\..\..\DeviceChoiceControl.xaml"
            this.comboBoxPrinterOutput.SelectedIndexChanged += new System.EventHandler(this.comboBoxPrinterOutput_SelectedIndexChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            this.gridCashDrawer = ((System.Windows.Controls.Grid)(target));
            return;
            case 7:
            this.gridScanner = ((System.Windows.Controls.Grid)(target));
            return;
            case 8:
            this.gridCoinDispenser = ((System.Windows.Controls.Grid)(target));
            return;
            case 9:
            this.gridBumpBar = ((System.Windows.Controls.Grid)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

