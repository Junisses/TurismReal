﻿#pragma checksum "..\..\..\..\Vistas\VistasAdmin\CRUDtipoGasto.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "1CF2C37CD84864DF72CE14B50B5D7550BE9CD3525F4FA25A37D6FD58F675DA35"
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

using Microsoft.Windows.Themes;
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
using TurismoReal.Vistas.VistasAdmin;


namespace TurismoReal.Vistas.VistasAdmin {
    
    
    /// <summary>
    /// CRUDtipoGasto
    /// </summary>
    public partial class CRUDtipoGasto : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector, System.Windows.Markup.IStyleConnector {
        
        
        #line 697 "..\..\..\..\Vistas\VistasAdmin\CRUDtipoGasto.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnRegresar;
        
        #line default
        #line hidden
        
        
        #line 708 "..\..\..\..\Vistas\VistasAdmin\CRUDtipoGasto.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnCrear;
        
        #line default
        #line hidden
        
        
        #line 720 "..\..\..\..\Vistas\VistasAdmin\CRUDtipoGasto.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnActualizar;
        
        #line default
        #line hidden
        
        
        #line 735 "..\..\..\..\Vistas\VistasAdmin\CRUDtipoGasto.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnLimpiar;
        
        #line default
        #line hidden
        
        
        #line 758 "..\..\..\..\Vistas\VistasAdmin\CRUDtipoGasto.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbTipoGasto;
        
        #line default
        #line hidden
        
        
        #line 786 "..\..\..\..\Vistas\VistasAdmin\CRUDtipoGasto.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbID;
        
        #line default
        #line hidden
        
        
        #line 790 "..\..\..\..\Vistas\VistasAdmin\CRUDtipoGasto.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock Titulo;
        
        #line default
        #line hidden
        
        
        #line 801 "..\..\..\..\Vistas\VistasAdmin\CRUDtipoGasto.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid GridDatos;
        
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
            System.Uri resourceLocater = new System.Uri("/TurismoReal;component/vistas/vistasadmin/crudtipogasto.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Vistas\VistasAdmin\CRUDtipoGasto.xaml"
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
            this.BtnRegresar = ((System.Windows.Controls.Button)(target));
            
            #line 705 "..\..\..\..\Vistas\VistasAdmin\CRUDtipoGasto.xaml"
            this.BtnRegresar.Click += new System.Windows.RoutedEventHandler(this.Regresar);
            
            #line default
            #line hidden
            return;
            case 2:
            this.BtnCrear = ((System.Windows.Controls.Button)(target));
            
            #line 716 "..\..\..\..\Vistas\VistasAdmin\CRUDtipoGasto.xaml"
            this.BtnCrear.Click += new System.Windows.RoutedEventHandler(this.Crear);
            
            #line default
            #line hidden
            return;
            case 3:
            this.BtnActualizar = ((System.Windows.Controls.Button)(target));
            
            #line 729 "..\..\..\..\Vistas\VistasAdmin\CRUDtipoGasto.xaml"
            this.BtnActualizar.Click += new System.Windows.RoutedEventHandler(this.Actualizar);
            
            #line default
            #line hidden
            return;
            case 4:
            this.BtnLimpiar = ((System.Windows.Controls.Button)(target));
            
            #line 743 "..\..\..\..\Vistas\VistasAdmin\CRUDtipoGasto.xaml"
            this.BtnLimpiar.Click += new System.Windows.RoutedEventHandler(this.Limpiar);
            
            #line default
            #line hidden
            return;
            case 5:
            this.tbTipoGasto = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.tbID = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.Titulo = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 8:
            this.GridDatos = ((System.Windows.Controls.DataGrid)(target));
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
            case 9:
            
            #line 828 "..\..\..\..\Vistas\VistasAdmin\CRUDtipoGasto.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Consultar);
            
            #line default
            #line hidden
            break;
            case 10:
            
            #line 839 "..\..\..\..\Vistas\VistasAdmin\CRUDtipoGasto.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.ActualizarC);
            
            #line default
            #line hidden
            break;
            case 11:
            
            #line 850 "..\..\..\..\Vistas\VistasAdmin\CRUDtipoGasto.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Eliminar);
            
            #line default
            #line hidden
            break;
            }
        }
    }
}

