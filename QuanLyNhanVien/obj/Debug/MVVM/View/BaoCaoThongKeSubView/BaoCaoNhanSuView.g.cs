﻿#pragma checksum "..\..\..\..\..\MVVM\View\BaoCaoThongKeSubView\BaoCaoNhanSuView.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "49B7C7DA8A16F849933EDE3615D01D338EC5E9EE2319DD52522C3B81F07CBD42"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using LiveCharts.Wpf;
using QuanLyNhanVien.MVVM.View;
using QuanLyNhanVien.MVVM.ViewModel.BaoCaoThongKeSubViewModel;
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


namespace QuanLyNhanVien.MVVM.View.BaoCaoThongKeSubView {
    
    
    /// <summary>
    /// BaoCaoNhanSuView
    /// </summary>
    public partial class BaoCaoNhanSuView : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 32 "..\..\..\..\..\MVVM\View\BaoCaoThongKeSubView\BaoCaoNhanSuView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox thangCbx;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\..\..\MVVM\View\BaoCaoThongKeSubView\BaoCaoNhanSuView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox namCbx;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\..\..\..\MVVM\View\BaoCaoThongKeSubView\BaoCaoNhanSuView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button timKiemBtn;
        
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
            System.Uri resourceLocater = new System.Uri("/QuanLyNhanVien;component/mvvm/view/baocaothongkesubview/baocaonhansuview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\MVVM\View\BaoCaoThongKeSubView\BaoCaoNhanSuView.xaml"
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
            this.thangCbx = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 2:
            this.namCbx = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 3:
            this.timKiemBtn = ((System.Windows.Controls.Button)(target));
            
            #line 37 "..\..\..\..\..\MVVM\View\BaoCaoThongKeSubView\BaoCaoNhanSuView.xaml"
            this.timKiemBtn.Click += new System.Windows.RoutedEventHandler(this.timKiemBtn_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

