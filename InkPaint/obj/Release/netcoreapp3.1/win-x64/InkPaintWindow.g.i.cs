﻿#pragma checksum "..\..\..\..\InkPaintWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "C4B4C2017B1A9D7F55C62890881B7A2B076A3414"
//------------------------------------------------------------------------------
// <auto-generated>
//     Il codice è stato generato da uno strumento.
//     Versione runtime:4.0.30319.42000
//
//     Le modifiche apportate a questo file possono provocare un comportamento non corretto e andranno perse se
//     il codice viene rigenerato.
// </auto-generated>
//------------------------------------------------------------------------------

using Fluent;
using Fluent.Converters;
using Fluent.Metro.Behaviours;
using Fluent.TemplateSelectors;
using Fluent.Theming;
using InkPaint;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
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


namespace InkPaint {
    
    
    /// <summary>
    /// InkPaintWindow
    /// </summary>
    public partial class InkPaintWindow : Fluent.RibbonWindow, System.Windows.Markup.IComponentConnector {
        
        
        #line 16 "..\..\..\..\InkPaintWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image Quadretti;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\..\..\InkPaintWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image Righe;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\..\InkPaintWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image Sfondo;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\..\InkPaintWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.InkCanvas InkPanel;
        
        #line default
        #line hidden
        
        /// <summary>
        /// FRibbon Name Field
        /// </summary>
        
        #line 22 "..\..\..\..\InkPaintWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        public Fluent.Ribbon FRibbon;
        
        #line default
        #line hidden
        
        
        #line 78 "..\..\..\..\InkPaintWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBoxItem Thickness15Item;
        
        #line default
        #line hidden
        
        
        #line 139 "..\..\..\..\InkPaintWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox LatestEvent;
        
        #line default
        #line hidden
        
        
        #line 140 "..\..\..\..\InkPaintWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox LatestEventTime;
        
        #line default
        #line hidden
        
        
        #line 141 "..\..\..\..\InkPaintWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BackgroundPath;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/InkPaint;component/inkpaintwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\InkPaintWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.Quadretti = ((System.Windows.Controls.Image)(target));
            return;
            case 2:
            this.Righe = ((System.Windows.Controls.Image)(target));
            return;
            case 3:
            this.Sfondo = ((System.Windows.Controls.Image)(target));
            return;
            case 4:
            this.InkPanel = ((System.Windows.Controls.InkCanvas)(target));
            return;
            case 5:
            this.FRibbon = ((Fluent.Ribbon)(target));
            return;
            case 6:
            
            #line 36 "..\..\..\..\InkPaintWindow.xaml"
            ((Fluent.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.DeleteCanvas);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 37 "..\..\..\..\InkPaintWindow.xaml"
            ((Fluent.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.OpenCanvas);
            
            #line default
            #line hidden
            return;
            case 8:
            
            #line 38 "..\..\..\..\InkPaintWindow.xaml"
            ((Fluent.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Salva);
            
            #line default
            #line hidden
            return;
            case 9:
            
            #line 40 "..\..\..\..\InkPaintWindow.xaml"
            ((Fluent.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Salva);
            
            #line default
            #line hidden
            return;
            case 10:
            
            #line 44 "..\..\..\..\InkPaintWindow.xaml"
            ((Fluent.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Evidenzia);
            
            #line default
            #line hidden
            return;
            case 11:
            
            #line 59 "..\..\..\..\InkPaintWindow.xaml"
            ((Fluent.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.CaricaSfondo);
            
            #line default
            #line hidden
            return;
            case 12:
            
            #line 60 "..\..\..\..\InkPaintWindow.xaml"
            ((Fluent.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.RimuoviSfondo);
            
            #line default
            #line hidden
            return;
            case 13:
            
            #line 68 "..\..\..\..\InkPaintWindow.xaml"
            ((Fluent.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.AppShutdown);
            
            #line default
            #line hidden
            return;
            case 14:
            
            #line 77 "..\..\..\..\InkPaintWindow.xaml"
            ((System.Windows.Controls.ComboBoxItem)(target)).Selected += new System.Windows.RoutedEventHandler(this.Thickness10);
            
            #line default
            #line hidden
            return;
            case 15:
            this.Thickness15Item = ((System.Windows.Controls.ComboBoxItem)(target));
            
            #line 78 "..\..\..\..\InkPaintWindow.xaml"
            this.Thickness15Item.Selected += new System.Windows.RoutedEventHandler(this.Thickness15);
            
            #line default
            #line hidden
            return;
            case 16:
            
            #line 79 "..\..\..\..\InkPaintWindow.xaml"
            ((System.Windows.Controls.ComboBoxItem)(target)).Selected += new System.Windows.RoutedEventHandler(this.Thickness20);
            
            #line default
            #line hidden
            return;
            case 17:
            
            #line 80 "..\..\..\..\InkPaintWindow.xaml"
            ((System.Windows.Controls.ComboBoxItem)(target)).Selected += new System.Windows.RoutedEventHandler(this.Thickness25);
            
            #line default
            #line hidden
            return;
            case 18:
            
            #line 81 "..\..\..\..\InkPaintWindow.xaml"
            ((System.Windows.Controls.ComboBoxItem)(target)).Selected += new System.Windows.RoutedEventHandler(this.Thickness30);
            
            #line default
            #line hidden
            return;
            case 19:
            
            #line 82 "..\..\..\..\InkPaintWindow.xaml"
            ((System.Windows.Controls.ComboBoxItem)(target)).Selected += new System.Windows.RoutedEventHandler(this.Thickness35);
            
            #line default
            #line hidden
            return;
            case 20:
            
            #line 83 "..\..\..\..\InkPaintWindow.xaml"
            ((System.Windows.Controls.ComboBoxItem)(target)).Selected += new System.Windows.RoutedEventHandler(this.Thickness40);
            
            #line default
            #line hidden
            return;
            case 21:
            
            #line 84 "..\..\..\..\InkPaintWindow.xaml"
            ((System.Windows.Controls.ComboBoxItem)(target)).Selected += new System.Windows.RoutedEventHandler(this.Thickness45);
            
            #line default
            #line hidden
            return;
            case 22:
            
            #line 85 "..\..\..\..\InkPaintWindow.xaml"
            ((System.Windows.Controls.ComboBoxItem)(target)).Selected += new System.Windows.RoutedEventHandler(this.Thickness50);
            
            #line default
            #line hidden
            return;
            case 23:
            
            #line 86 "..\..\..\..\InkPaintWindow.xaml"
            ((System.Windows.Controls.ComboBoxItem)(target)).Selected += new System.Windows.RoutedEventHandler(this.Thickness55);
            
            #line default
            #line hidden
            return;
            case 24:
            
            #line 87 "..\..\..\..\InkPaintWindow.xaml"
            ((System.Windows.Controls.ComboBoxItem)(target)).Selected += new System.Windows.RoutedEventHandler(this.Thickness60);
            
            #line default
            #line hidden
            return;
            case 25:
            
            #line 88 "..\..\..\..\InkPaintWindow.xaml"
            ((System.Windows.Controls.ComboBoxItem)(target)).Selected += new System.Windows.RoutedEventHandler(this.Thickness65);
            
            #line default
            #line hidden
            return;
            case 26:
            
            #line 90 "..\..\..\..\InkPaintWindow.xaml"
            ((Fluent.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Thickness15D);
            
            #line default
            #line hidden
            return;
            case 27:
            
            #line 93 "..\..\..\..\InkPaintWindow.xaml"
            ((Fluent.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.ColoreNero);
            
            #line default
            #line hidden
            return;
            case 28:
            
            #line 94 "..\..\..\..\InkPaintWindow.xaml"
            ((Fluent.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.ColoreBlu);
            
            #line default
            #line hidden
            return;
            case 29:
            
            #line 95 "..\..\..\..\InkPaintWindow.xaml"
            ((Fluent.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.ColoreRosso);
            
            #line default
            #line hidden
            return;
            case 30:
            
            #line 96 "..\..\..\..\InkPaintWindow.xaml"
            ((Fluent.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.ColoreGiallo);
            
            #line default
            #line hidden
            return;
            case 31:
            
            #line 97 "..\..\..\..\InkPaintWindow.xaml"
            ((Fluent.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.ColoreVerde);
            
            #line default
            #line hidden
            return;
            case 32:
            
            #line 98 "..\..\..\..\InkPaintWindow.xaml"
            ((Fluent.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Gomma);
            
            #line default
            #line hidden
            return;
            case 33:
            
            #line 102 "..\..\..\..\InkPaintWindow.xaml"
            ((System.Windows.Controls.ListBoxItem)(target)).Selected += new System.Windows.RoutedEventHandler(this.Disegno);
            
            #line default
            #line hidden
            return;
            case 34:
            
            #line 103 "..\..\..\..\InkPaintWindow.xaml"
            ((System.Windows.Controls.ListBoxItem)(target)).Selected += new System.Windows.RoutedEventHandler(this.Seleziona);
            
            #line default
            #line hidden
            return;
            case 35:
            
            #line 104 "..\..\..\..\InkPaintWindow.xaml"
            ((System.Windows.Controls.ListBoxItem)(target)).Selected += new System.Windows.RoutedEventHandler(this.Elimina);
            
            #line default
            #line hidden
            return;
            case 36:
            
            #line 105 "..\..\..\..\InkPaintWindow.xaml"
            ((System.Windows.Controls.ListBoxItem)(target)).Selected += new System.Windows.RoutedEventHandler(this.EliminaTratto);
            
            #line default
            #line hidden
            return;
            case 37:
            
            #line 106 "..\..\..\..\InkPaintWindow.xaml"
            ((System.Windows.Controls.ListBoxItem)(target)).Selected += new System.Windows.RoutedEventHandler(this.SoloVisualizzazione);
            
            #line default
            #line hidden
            return;
            case 38:
            
            #line 112 "..\..\..\..\InkPaintWindow.xaml"
            ((Fluent.CheckBox)(target)).Checked += new System.Windows.RoutedEventHandler(this.Evidenzia);
            
            #line default
            #line hidden
            
            #line 112 "..\..\..\..\InkPaintWindow.xaml"
            ((Fluent.CheckBox)(target)).Unchecked += new System.Windows.RoutedEventHandler(this.NoEvidenzia);
            
            #line default
            #line hidden
            return;
            case 39:
            
            #line 117 "..\..\..\..\InkPaintWindow.xaml"
            ((Fluent.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.ZoomIn);
            
            #line default
            #line hidden
            return;
            case 40:
            
            #line 118 "..\..\..\..\InkPaintWindow.xaml"
            ((Fluent.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.ZoomOut);
            
            #line default
            #line hidden
            return;
            case 41:
            
            #line 122 "..\..\..\..\InkPaintWindow.xaml"
            ((System.Windows.Controls.ComboBoxItem)(target)).Selected += new System.Windows.RoutedEventHandler(this.NoGuide);
            
            #line default
            #line hidden
            return;
            case 42:
            
            #line 123 "..\..\..\..\InkPaintWindow.xaml"
            ((System.Windows.Controls.ComboBoxItem)(target)).Selected += new System.Windows.RoutedEventHandler(this.MostraQuadretti);
            
            #line default
            #line hidden
            return;
            case 43:
            
            #line 124 "..\..\..\..\InkPaintWindow.xaml"
            ((System.Windows.Controls.ComboBoxItem)(target)).Selected += new System.Windows.RoutedEventHandler(this.MostraRighe);
            
            #line default
            #line hidden
            return;
            case 44:
            
            #line 128 "..\..\..\..\InkPaintWindow.xaml"
            ((Fluent.CheckBox)(target)).Checked += new System.Windows.RoutedEventHandler(this.FullScreen);
            
            #line default
            #line hidden
            
            #line 128 "..\..\..\..\InkPaintWindow.xaml"
            ((Fluent.CheckBox)(target)).Unchecked += new System.Windows.RoutedEventHandler(this.NoFullScreen);
            
            #line default
            #line hidden
            return;
            case 45:
            
            #line 133 "..\..\..\..\InkPaintWindow.xaml"
            ((Fluent.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.CaricaSfondo);
            
            #line default
            #line hidden
            return;
            case 46:
            
            #line 134 "..\..\..\..\InkPaintWindow.xaml"
            ((Fluent.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.RimuoviSfondo);
            
            #line default
            #line hidden
            return;
            case 47:
            this.LatestEvent = ((System.Windows.Controls.TextBox)(target));
            return;
            case 48:
            this.LatestEventTime = ((System.Windows.Controls.TextBox)(target));
            return;
            case 49:
            this.BackgroundPath = ((System.Windows.Controls.Button)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

