﻿#pragma checksum "..\..\..\..\Vistas\VistasFuncionario\CheckList.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "08F242A73F2684449ADF99B78E3A0A076CF609DCF289587C9FB507E9E5A320B1"
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
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
using TurismoReal.Vistas.VistasFuncionario;


namespace TurismoReal.Vistas.VistasFuncionario {
    
    
    /// <summary>
    /// CheckList
    /// </summary>
    public partial class CheckList : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector, System.Windows.Markup.IStyleConnector {
        
        
        #line 225 "..\..\..\..\Vistas\VistasFuncionario\CheckList.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid GridInventario;
        
        #line default
        #line hidden
        
        
        #line 227 "..\..\..\..\Vistas\VistasFuncionario\CheckList.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid Contenido;
        
        #line default
        #line hidden
        
        
        #line 291 "..\..\..\..\Vistas\VistasFuncionario\CheckList.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnBuscar;
        
        #line default
        #line hidden
        
        
        #line 307 "..\..\..\..\Vistas\VistasFuncionario\CheckList.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnAgregarArtefacto;
        
        #line default
        #line hidden
        
        
        #line 322 "..\..\..\..\Vistas\VistasFuncionario\CheckList.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnAñadirInventario;
        
        #line default
        #line hidden
        
        
        #line 339 "..\..\..\..\Vistas\VistasFuncionario\CheckList.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid GridDatos;
        
        #line default
        #line hidden
        
        
        #line 412 "..\..\..\..\Vistas\VistasFuncionario\CheckList.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Frame FrameInventario;
        
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
            System.Uri resourceLocater = new System.Uri("/TurismoReal;component/vistas/vistasfuncionario/checklist.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Vistas\VistasFuncionario\CheckList.xaml"
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
            this.GridInventario = ((System.Windows.Controls.Grid)(target));
            return;
            case 2:
            this.Contenido = ((System.Windows.Controls.Grid)(target));
            return;
            case 3:
            this.BtnBuscar = ((System.Windows.Controls.Button)(target));
            return;
            case 4:
            this.BtnAgregarArtefacto = ((System.Windows.Controls.Button)(target));
            
            #line 309 "..\..\..\..\Vistas\VistasFuncionario\CheckList.xaml"
            this.BtnAgregarArtefacto.Click += new System.Windows.RoutedEventHandler(this.BtnAgregarArtefacto_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.BtnAñadirInventario = ((System.Windows.Controls.Button)(target));
            
            #line 324 "..\..\..\..\Vistas\VistasFuncionario\CheckList.xaml"
            this.BtnAñadirInventario.Click += new System.Windows.RoutedEventHandler(this.BtnInventario_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.GridDatos = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 10:
            this.FrameInventario = ((System.Windows.Controls.Frame)(target));
            return;
            }
            this._contentLoaded = true;
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        void System.Windows.Markup.IStyleConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 7:
            
            #line 365 "..\..\..\..\Vistas\VistasFuncionario\CheckList.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Consultar);
            
            #line default
            #line hidden
            break;
            case 8:
            
            #line 377 "..\..\..\..\Vistas\VistasFuncionario\CheckList.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Actualizar);
            
            #line default
            #line hidden
            break;
            case 9:
            
            #line 387 "..\..\..\..\Vistas\VistasFuncionario\CheckList.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Eliminar);
            
            #line default
            #line hidden
            break;
            }
        }
    }
}

