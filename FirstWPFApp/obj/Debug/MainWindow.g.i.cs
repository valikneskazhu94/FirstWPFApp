﻿#pragma checksum "..\..\MainWindow.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "658807BF5CE2DAA2C736444D98AEC47B"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using FirstWPFApp;
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


namespace FirstWPFApp {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 15 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_cut;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_copy;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_paste;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textBox1;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_1;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_2;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_3;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textBox2;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_4;
        
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
            System.Uri resourceLocater = new System.Uri("/FirstWPFApp;component/mainwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\MainWindow.xaml"
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
            this.btn_cut = ((System.Windows.Controls.Button)(target));
            
            #line 15 "..\..\MainWindow.xaml"
            this.btn_cut.Click += new System.Windows.RoutedEventHandler(this.cut_click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.btn_copy = ((System.Windows.Controls.Button)(target));
            
            #line 16 "..\..\MainWindow.xaml"
            this.btn_copy.Click += new System.Windows.RoutedEventHandler(this.copy_click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.btn_paste = ((System.Windows.Controls.Button)(target));
            
            #line 17 "..\..\MainWindow.xaml"
            this.btn_paste.Click += new System.Windows.RoutedEventHandler(this.paste_click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.textBox1 = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.btn_1 = ((System.Windows.Controls.Button)(target));
            
            #line 23 "..\..\MainWindow.xaml"
            this.btn_1.Click += new System.Windows.RoutedEventHandler(this.btn_1_click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.btn_2 = ((System.Windows.Controls.Button)(target));
            
            #line 24 "..\..\MainWindow.xaml"
            this.btn_2.Click += new System.Windows.RoutedEventHandler(this.btn_2_click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.btn_3 = ((System.Windows.Controls.Button)(target));
            
            #line 25 "..\..\MainWindow.xaml"
            this.btn_3.Click += new System.Windows.RoutedEventHandler(this.btn_3_click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.textBox2 = ((System.Windows.Controls.TextBox)(target));
            return;
            case 9:
            this.btn_4 = ((System.Windows.Controls.Button)(target));
            
            #line 31 "..\..\MainWindow.xaml"
            this.btn_4.MouseMove += new System.Windows.Input.MouseEventHandler(this.Move_mouse);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

