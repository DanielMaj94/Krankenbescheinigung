﻿#pragma checksum "..\..\Krankenmelden.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "F6F9575DEA0B984CC59918F0E9B1FD86"
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
    /// Krankenmelden
    /// </summary>
    public partial class Krankenmelden : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 6 "..\..\Krankenmelden.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbKlasse;
        
        #line default
        #line hidden
        
        
        #line 7 "..\..\Krankenmelden.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbSchueler;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\Krankenmelden.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbuhrzeitVon;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\Krankenmelden.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbuhrzeitBis;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\Krankenmelden.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbStatus;
        
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
            System.Uri resourceLocater = new System.Uri("/Krankenmeldung;component/krankenmelden.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Krankenmelden.xaml"
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
            this.cbKlasse = ((System.Windows.Controls.ComboBox)(target));
            
            #line 6 "..\..\Krankenmelden.xaml"
            this.cbKlasse.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.cbKlasse_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.cbSchueler = ((System.Windows.Controls.ComboBox)(target));
            
            #line 7 "..\..\Krankenmelden.xaml"
            this.cbSchueler.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.cbKlasse_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.tbuhrzeitVon = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.tbuhrzeitBis = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            
            #line 17 "..\..\Krankenmelden.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.cbStatus = ((System.Windows.Controls.ComboBox)(target));
            
            #line 18 "..\..\Krankenmelden.xaml"
            this.cbStatus.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.cbKlasse_SelectionChanged);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

