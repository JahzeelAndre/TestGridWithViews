using DevExpress.XtraEditors;
using System.Collections.Generic;
using System.Linq;
using TestGridWithViews.Datos;
using TestGridWithViews.Modelos;

namespace TestGridWithViews.Vistas
{
    public partial class MenuPersonas : DevExpress.XtraEditors.XtraForm
    {
        #region Global Variables...
        private List<Personas> _ListaPersonas;
        #endregion
        
        #region Contructors...
        public MenuPersonas()
        {
            InitializeComponent();
            _ListaPersonas = OrigenDatosPersonas.ListaPersonas;
            IniciarComponentes();
        }
        #endregion

        #region Methods...
        private void IniciarComponentes()
        {
            LlenarGrid();
        }
        private void LlenarGrid()
        {
            gridControl1.DataSource = _ListaPersonas;
            gridControl1.Refresh();
        }
        #endregion

        #region Events...
        private void tileBarItemClientes_ItemClick(object sender, TileItemEventArgs e)
        {
            _ListaPersonas = OrigenDatosPersonas.ListaPersonas.Where(personaItem => personaItem.Es == "Cliente").ToList();
            tileBarItemProveedores.Elements.ElementAt(1).Text = "0";
            tileBarItemClientes.Elements.ElementAt(1).Text = _ListaPersonas.Count.ToString();
            LlenarGrid();
        }
        private void tileBarItemProveedores_ItemClick(object sender, TileItemEventArgs e)
        {
            _ListaPersonas = OrigenDatosPersonas.ListaPersonas.Where(personaItem => personaItem.Es == "Proveedor").ToList();
            tileBarItemClientes.Elements.ElementAt(1).Text = "0";
            tileBarItemProveedores.Elements.ElementAt(1).Text = _ListaPersonas.Count.ToString();
            LlenarGrid();
        }
        #endregion
    }
}