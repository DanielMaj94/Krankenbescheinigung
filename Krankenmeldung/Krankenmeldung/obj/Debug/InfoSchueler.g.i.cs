﻿#pragma checksum "..\..\InfoSchueler.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "E330E7A0FBAB1641877DDC88AA8726E3"
//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:4.0.30319.18444
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
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


namespace Krankenmeldung {
    
    
    /// <summary>
    /// InfoSchueler
    /// </summary>
    public partial class InfoSchueler : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 15 "..\..\InfoSchueler.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox vorname;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\InfoSchueler.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox nachname;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\InfoSchueler.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox klasse;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\InfoSchueler.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox alter;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\InfoSchueler.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox strasse;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\InfoSchueler.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox plz;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\InfoSchueler.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox ort;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\InfoSchueler.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox firma;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\InfoSchueler.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox email;
        
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
            System.Uri resourceLocater = new System.Uri("/Krankenmeldung;component/infoschueler.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\InfoSchueler.xaml"
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
            this.vorname = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.nachname = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.klasse = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.alter = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.strasse = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.plz = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.ort = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.firma = ((System.Windows.Controls.TextBox)(target));
            return;
            case 9:
            this.email = ((System.Windows.Controls.TextBox)(target));
            return;
            case 10:
            
            #line 24 "..\..\InfoSchueler.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.btnOK);
            
            #line default
            #line hidden
            return;
            case 11:
            
            #line 25 "..\..\InfoSchueler.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.btnEdit);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
