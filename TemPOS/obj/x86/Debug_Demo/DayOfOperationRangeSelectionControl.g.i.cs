﻿#pragma checksum "..\..\..\DayOfOperationRangeSelectionControl.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "4B6592C70DDCEAD98A821DC11AEE96C16FC509C34F763CF878660B6553726EF8"
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
    /// DayOfOperationRangeSelectionControl
    /// </summary>
    public partial class DayOfOperationRangeSelectionControl : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 11 "..\..\..\DayOfOperationRangeSelectionControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DockPanel mainPane;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\..\DayOfOperationRangeSelectionControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal PosControls.ConfigurationManager Configuration;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\DayOfOperationRangeSelectionControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal PosControls.DragScrollListBox listBoxStartRange;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\DayOfOperationRangeSelectionControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal PosControls.DragScrollListBox listBoxEndRange;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\..\DayOfOperationRangeSelectionControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal PosControls.TextBlockButton buttonSelectSpecified;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\DayOfOperationRangeSelectionControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal PosControls.TextBlockButton buttonAllThisYear;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\..\DayOfOperationRangeSelectionControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal PosControls.TextBlockButton buttonAll;
        
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
            System.Uri resourceLocater = new System.Uri("/TemPOS;component/dayofoperationrangeselectioncontrol.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\DayOfOperationRangeSelectionControl.xaml"
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
            this.listBoxStartRange = ((PosControls.DragScrollListBox)(target));
            
            #line 29 "..\..\..\DayOfOperationRangeSelectionControl.xaml"
            this.listBoxStartRange.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.listBoxStartRange_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.listBoxEndRange = ((PosControls.DragScrollListBox)(target));
            
            #line 32 "..\..\..\DayOfOperationRangeSelectionControl.xaml"
            this.listBoxEndRange.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.listBoxEndRange_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.buttonSelectSpecified = ((PosControls.TextBlockButton)(target));
            
            #line 35 "..\..\..\DayOfOperationRangeSelectionControl.xaml"
            this.buttonSelectSpecified.Click += new System.Windows.RoutedEventHandler(this.buttonSelectSpecified_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.buttonAllThisYear = ((PosControls.TextBlockButton)(target));
            
            #line 36 "..\..\..\DayOfOperationRangeSelectionControl.xaml"
            this.buttonAllThisYear.Click += new System.Windows.RoutedEventHandler(this.buttonAllThisYear_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.buttonAll = ((PosControls.TextBlockButton)(target));
            
            #line 37 "..\..\..\DayOfOperationRangeSelectionControl.xaml"
            this.buttonAll.Click += new System.Windows.RoutedEventHandler(this.buttonAll_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

