﻿#pragma checksum "..\..\..\DemoGridViewDataGrid.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "AB2184BE77CFEF27026045889CC9D57E4B24340F"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
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
using Topic1_WPF_Control;


namespace Topic1_WPF_Control {
    
    
    /// <summary>
    /// DemoGridViewDataGrid
    /// </summary>
    public partial class DemoGridViewDataGrid : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 11 "..\..\..\DemoGridViewDataGrid.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView MenList;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\DemoGridViewDataGrid.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtPerson;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\DemoGridViewDataGrid.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dbItems;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\..\DemoGridViewDataGrid.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGridComboBoxColumn cbbCity;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\..\DemoGridViewDataGrid.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGridCheckBoxColumn active;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\..\DemoGridViewDataGrid.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtCar;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.4.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Topic1_WPF_Control;component/demogridviewdatagrid.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\DemoGridViewDataGrid.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.4.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.MenList = ((System.Windows.Controls.ListView)(target));
            
            #line 10 "..\..\..\DemoGridViewDataGrid.xaml"
            this.MenList.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.gridSelectionChange);
            
            #line default
            #line hidden
            return;
            case 2:
            this.txtPerson = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.dbItems = ((System.Windows.Controls.DataGrid)(target));
            
            #line 30 "..\..\..\DemoGridViewDataGrid.xaml"
            this.dbItems.Loaded += new System.Windows.RoutedEventHandler(this.DemoDataGrid_Loaded);
            
            #line default
            #line hidden
            
            #line 30 "..\..\..\DemoGridViewDataGrid.xaml"
            this.dbItems.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.dbItems_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.cbbCity = ((System.Windows.Controls.DataGridComboBoxColumn)(target));
            return;
            case 5:
            this.active = ((System.Windows.Controls.DataGridCheckBoxColumn)(target));
            return;
            case 6:
            this.txtCar = ((System.Windows.Controls.TextBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
