﻿#pragma checksum "..\..\..\..\..\..\..\..\..\WpfCaculatrice\MainWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "BA2CBC44A03A571205F7C80CF8583884363F0F6B"
//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
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
using WpfCaculatrice;


namespace WpfCaculatrice {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 11 "..\..\..\..\..\..\..\..\..\WpfCaculatrice\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonAddition;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\..\..\..\..\..\..\..\WpfCaculatrice\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonSoustraction;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\..\..\..\..\..\..\..\WpfCaculatrice\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonMultiplication;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\..\..\..\..\..\..\..\WpfCaculatrice\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonDivision;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.4.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/WpfCalculatrice;component/mainwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\..\..\..\..\WpfCaculatrice\MainWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.4.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.ButtonAddition = ((System.Windows.Controls.Button)(target));
            
            #line 11 "..\..\..\..\..\..\..\..\..\WpfCaculatrice\MainWindow.xaml"
            this.ButtonAddition.Click += new System.Windows.RoutedEventHandler(this.ButtonAddition_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.ButtonSoustraction = ((System.Windows.Controls.Button)(target));
            
            #line 12 "..\..\..\..\..\..\..\..\..\WpfCaculatrice\MainWindow.xaml"
            this.ButtonSoustraction.Click += new System.Windows.RoutedEventHandler(this.ButtonSoustraction_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.ButtonMultiplication = ((System.Windows.Controls.Button)(target));
            
            #line 13 "..\..\..\..\..\..\..\..\..\WpfCaculatrice\MainWindow.xaml"
            this.ButtonMultiplication.Click += new System.Windows.RoutedEventHandler(this.ButtonMultiplication_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.ButtonDivision = ((System.Windows.Controls.Button)(target));
            
            #line 14 "..\..\..\..\..\..\..\..\..\WpfCaculatrice\MainWindow.xaml"
            this.ButtonDivision.Click += new System.Windows.RoutedEventHandler(this.ButtonDivision_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

