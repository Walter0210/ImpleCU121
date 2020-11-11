using CU121.FabricacionPura;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CU121.Interfaz
{
    public partial class GestorRestaurante : Form

    {
        private GestorInformeProducto gestor;
        private List<EstructuraCarta> todasCartas;
        private List<EstructuraCarta> cartasVigentes;
        private List<EstructuraCarta> categoriasSeleccionadas;
        private List<EstructuraCarta> SubcategoriasSeleccionadas;


        public GestorRestaurante()
        {
            InitializeComponent();
        }

        private void btbBuscarCartas_Click(object sender, EventArgs e)
        {
            DateTime fechaInicio = dtpFechaDesde.Value;
            DateTime fechaFin = dtpFechaHasta.Value;

            if (fechaFin > fechaInicio)
            {
                cartasVigentes = gestor.buscarCartasVigentes(fechaInicio, fechaFin, todasCartas);
                dgvCategorias.DataSource = gestor.obtenerHijos(cartasVigentes);
            }
            else
            {
                MessageBox.Show("Periodo invalido!");
            }

        }

        private void GestorRestaurante_Load(object sender, EventArgs e)
        {
            //desabilitar todo e ir habilitando de a poco.
            gestor = new GestorInformeProducto();
            todasCartas = new List<EstructuraCarta>();

            //hay que armar todos los objetos de carta y producto.
            //Subcategorias
            EstructuraCarta subcategoriaCarnes1 = new EstructuraCarta("Rojas");
            EstructuraCarta subcategoriaCarnes2 = new EstructuraCarta("Blancas");
            EstructuraCarta subcategoriaPastas1 = new EstructuraCarta("Largas");
            EstructuraCarta subcategoriaPastas2 = new EstructuraCarta("Cortas");
            EstructuraCarta subcategoriaPastas3 = new EstructuraCarta("Rellenas");
            EstructuraCarta subcategoriaBebidas1 = new EstructuraCarta("Sin alcohol");
            EstructuraCarta subcategoriaBebidas2 = new EstructuraCarta("Con alcohol");
            EstructuraCarta subcategoriaPostres1 = new EstructuraCarta("Tortas");
            EstructuraCarta subcategoriaPostres2 = new EstructuraCarta("Helados");
            EstructuraCarta subcategoriaMenus1 = new EstructuraCarta("Diario");
            EstructuraCarta subcategoriaMenus2 = new EstructuraCarta("Vegetariano");
            EstructuraCarta subcategoriaMenus3 = new EstructuraCarta("Infantil");

            //Conjunto de subcategorias
            List<EstructuraCarta> sc = new List<EstructuraCarta>();
            List<EstructuraCarta> sp = new List<EstructuraCarta>();
            List<EstructuraCarta> sb = new List<EstructuraCarta>();
            List<EstructuraCarta> spo = new List<EstructuraCarta>();
            List<EstructuraCarta> sm = new List<EstructuraCarta>();
            sc.Add(subcategoriaCarnes1); sc.Add(subcategoriaCarnes2);
            sp.Add(subcategoriaPastas1); sp.Add(subcategoriaPastas2); sp.Add(subcategoriaPastas3);
            sb.Add(subcategoriaBebidas1); sb.Add(subcategoriaBebidas2);
            spo.Add(subcategoriaPostres1); spo.Add(subcategoriaPostres2);
            sm.Add(subcategoriaMenus1); sm.Add(subcategoriaMenus2); sm.Add(subcategoriaMenus3);


            //Categorias
            EstructuraCarta categoriaCarnes = new EstructuraCarta(sc, "Carnes");
            EstructuraCarta categoriaBebidas = new EstructuraCarta(sb, "Bebidas");
            EstructuraCarta categoriaPastas = new EstructuraCarta(sp, "Pastas");
            EstructuraCarta categoriaPostres = new EstructuraCarta(spo, "Postres");
            EstructuraCarta categoriaMenus = new EstructuraCarta(sm, "Menus");



            //Conjunto de categorias
            List<EstructuraCarta> c1 = new List<EstructuraCarta>();
            List<EstructuraCarta> c2 = new List<EstructuraCarta>();
            List<EstructuraCarta> c3 = new List<EstructuraCarta>();

            c2.Add(categoriaCarnes); c2.Add(categoriaBebidas);
            c1.Add(categoriaCarnes); c1.Add(categoriaMenus); c1.Add(categoriaPastas);
            c3.Add(categoriaMenus); c3.Add(categoriaPostres);

            //Cartas
            EstructuraCarta carta1 = new EstructuraCarta("carta1", true, c1, Convert.ToDateTime("1/11/2020"), Convert.ToDateTime("9/11/2020"), Convert.ToDateTime("10/11/2021"), "primerCarta", 1.43f, null, "waltersito");
            EstructuraCarta carta2 = new EstructuraCarta("carta2", true, c2, Convert.ToDateTime("9/11/2020"), Convert.ToDateTime("9/11/2020"), Convert.ToDateTime("10/11/2021"), "segundaCarta", 1.43f, null, "waltersito");
            EstructuraCarta carta3 = new EstructuraCarta("carta3", true, c3, Convert.ToDateTime("8/11/2020"), Convert.ToDateTime("9/11/2020"), Convert.ToDateTime("10/11/2021"), "tercerCarta", 1.43f, null, "lautarito");
            EstructuraCarta carta4 = new EstructuraCarta("carta4", true, c2, Convert.ToDateTime("1/11/2020"), Convert.ToDateTime("9/11/2020"), Convert.ToDateTime("10/11/2021"), "cuartaCarta", 1.43f, null, "lautarito");
            EstructuraCarta carta5 = new EstructuraCarta("carta5", true, c3, Convert.ToDateTime("1/11/2020"), Convert.ToDateTime("9/11/2020"), Convert.ToDateTime("10/11/2021"), "quintaCarta", 1.43f, null, "lautarito");

            todasCartas.Add(carta1); todasCartas.Add(carta2); todasCartas.Add(carta3); todasCartas.Add(carta4); todasCartas.Add(carta5);
        }

        private void btnBuscarSubCategorias_Click(object sender, EventArgs e)
        {
            categoriasSeleccionadas = new List<EstructuraCarta>();
            foreach (DataGridViewRow row in this.dgvCategorias.SelectedRows)
            {
                EstructuraCarta categoriaSel = row.DataBoundItem as EstructuraCarta;
                categoriasSeleccionadas.Add(categoriaSel);
            }
            dgvSubCategorias.DataSource = gestor.obtenerHijos(categoriasSeleccionadas);
        }

        private void btnMostrarProductos_Click(object sender, EventArgs e)
        {
            SubcategoriasSeleccionadas = new List<EstructuraCarta>();
            foreach (DataGridViewRow row in this.dgvSubCategorias.SelectedRows)
            {
                EstructuraCarta subCategoriaSel = row.DataBoundItem as EstructuraCarta;
                SubcategoriasSeleccionadas.Add(subCategoriaSel);
            }
            dgvProductos.DataSource = gestor.obtenerHijos(SubcategoriasSeleccionadas);
        }
    }
}
