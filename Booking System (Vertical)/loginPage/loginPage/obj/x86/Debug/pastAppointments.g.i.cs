﻿#pragma checksum "..\..\..\pastAppointments.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "76C1552A2E51A5B9F85F70F0CF053B68"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.1008
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


namespace loginPage {
    
    
    /// <summary>
    /// pastAppointments
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
    public partial class pastAppointments : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 2 "..\..\..\pastAppointments.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal loginPage.pastAppointments pastAppointmentBox;
        
        #line default
        #line hidden
        
        
        #line 3 "..\..\..\pastAppointments.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid viewPast;
        
        #line default
        #line hidden
        
        
        #line 5 "..\..\..\pastAppointments.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button pastCloseButton;
        
        #line default
        #line hidden
        
        
        #line 6 "..\..\..\pastAppointments.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock pastPatientName;
        
        #line default
        #line hidden
        
        
        #line 7 "..\..\..\pastAppointments.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button pastSelectButton;
        
        #line default
        #line hidden
        
        
        #line 8 "..\..\..\pastAppointments.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid searchDataGrid;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\..\pastAppointments.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox pastApptLB;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/loginPage;component/pastappointments.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\pastAppointments.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.pastAppointmentBox = ((loginPage.pastAppointments)(target));
            
            #line 2 "..\..\..\pastAppointments.xaml"
            this.pastAppointmentBox.Closing += new System.ComponentModel.CancelEventHandler(this.pastAppointmentBox_Closing);
            
            #line default
            #line hidden
            return;
            case 2:
            this.viewPast = ((System.Windows.Controls.Grid)(target));
            return;
            case 3:
            this.pastCloseButton = ((System.Windows.Controls.Button)(target));
            
            #line 5 "..\..\..\pastAppointments.xaml"
            this.pastCloseButton.Click += new System.Windows.RoutedEventHandler(this.pastCloseButton_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.pastPatientName = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 5:
            this.pastSelectButton = ((System.Windows.Controls.Button)(target));
            
            #line 7 "..\..\..\pastAppointments.xaml"
            this.pastSelectButton.Click += new System.Windows.RoutedEventHandler(this.pastSelectButton_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.searchDataGrid = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 7:
            this.pastApptLB = ((System.Windows.Controls.ListBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

