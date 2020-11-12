using CU121.Dominio;
using CU121.FabricacionPura;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace CU121.Interfaz
{
    public partial class PantallaGenReporte : Form

    {
        private GestorInformeProducto gestor;
        private List<EstructuraCarta> todasCartas;
        private List<Pedido> todosPedidos;
        private List<DetallePedido> todosDetalles;

        private BindingList<EstructuraCarta> cartasVigentes;
        private BindingList<IEstructuraCarta> categoriasSeleccionadas;
        private BindingList<EstructuraCarta> SubcategoriasSeleccionadas;
        private BindingList<EstructuraCarta> PrductosSeleccionados;
        private bool seleccionoAlguna = false;




        public PantallaGenReporte()
        {
            InitializeComponent();
        }

        private void btbBuscarCartas_Click(object sender, EventArgs e)
        {
            DateTime fechaInicio = dtpFechaDesde.Value;
            DateTime fechaFin = dtpFechaHasta.Value;

            if (fechaFin > fechaInicio)
            {
                gestor.buscarCartasVigentes(fechaInicio, fechaFin, todasCartas);
                dgvCategorias.DataSource = gestor.buscarCategorias();
                btnBuscarSubCategorias.Enabled = true;
            }
            else
            {
                MessageBox.Show("Periodo invalido!");
            }

        }

        private void GestorRestaurante_Load(object sender, EventArgs e)
        {
            dgvCategorias.AutoGenerateColumns = false;
            dgvSubCategorias.AutoGenerateColumns = false;
            dgvProductos.AutoGenerateColumns = false;

            btnBuscarSubCategorias.Enabled = false;
            btnMostrarProductos.Enabled = false;
            btnGenerar.Enabled = false;

            gestor = new GestorInformeProducto();
            todasCartas = new List<EstructuraCarta>();




            //Subconjuntos de productos


            EstructuraCarta producto1 = new EstructuraCarta(true, Convert.ToDateTime("10/11/2020"), "Costeleta", null);
            EstructuraCarta producto2 = new EstructuraCarta(true, Convert.ToDateTime("10/11/2020"), "Bife", null);
            EstructuraCarta producto3 = new EstructuraCarta(true, Convert.ToDateTime("10/11/2020"), "Salmon", null);
            EstructuraCarta producto4 = new EstructuraCarta(true, Convert.ToDateTime("10/11/2020"), "Pollo asado", null);
            EstructuraCarta producto5 = new EstructuraCarta(true, Convert.ToDateTime("10/11/2020"), "Espageti", null);
            EstructuraCarta producto6 = new EstructuraCarta(true, Convert.ToDateTime("10/11/2020"), "Tallarines", null);
            EstructuraCarta producto7 = new EstructuraCarta(true, Convert.ToDateTime("10/11/2020"), "Ñoquis", null);
            EstructuraCarta producto8 = new EstructuraCarta(true, Convert.ToDateTime("10/11/2020"), "Moñitos", null);
            EstructuraCarta producto9 = new EstructuraCarta(true, Convert.ToDateTime("10/11/2020"), "Ravioles", null);
            EstructuraCarta producto10 = new EstructuraCarta(true, Convert.ToDateTime("10/11/2020"), "Canelones", null);
            EstructuraCarta producto11 = new EstructuraCarta(true, Convert.ToDateTime("10/11/2020"), "Agua", null);
            EstructuraCarta producto12 = new EstructuraCarta(true, Convert.ToDateTime("10/11/2020"), "Gaseosa 500ml", null);
            EstructuraCarta producto13 = new EstructuraCarta(true, Convert.ToDateTime("10/11/2020"), "Vino", null);
            EstructuraCarta producto14 = new EstructuraCarta(true, Convert.ToDateTime("10/11/2020"), "Cerveza", null);
            EstructuraCarta producto15 = new EstructuraCarta(true, Convert.ToDateTime("10/11/2020"), "Tiramisu", null);
            EstructuraCarta producto16 = new EstructuraCarta(true, Convert.ToDateTime("10/11/2020"), "Chocotorta", null);
            EstructuraCarta producto17 = new EstructuraCarta(true, Convert.ToDateTime("10/11/2020"), "Escoses", null);
            EstructuraCarta producto18 = new EstructuraCarta(true, Convert.ToDateTime("10/11/2020"), "Americano", null);
            EstructuraCarta producto19 = new EstructuraCarta(true, Convert.ToDateTime("10/11/2020"), "Milanesa con ensalada", null);
            EstructuraCarta producto20 = new EstructuraCarta(true, Convert.ToDateTime("10/11/2020"), "Bife Pollo con pure", null);
            EstructuraCarta producto21 = new EstructuraCarta(true, Convert.ToDateTime("10/11/2020"), "Hamburguesas de garvenzos con pure", null);
            EstructuraCarta producto22 = new EstructuraCarta(true, Convert.ToDateTime("10/11/2020"), "Ensalada gohun", null);
            EstructuraCarta producto23 = new EstructuraCarta(true, Convert.ToDateTime("10/11/2020"), "Hamburgesa", null);
            EstructuraCarta producto24 = new EstructuraCarta(true, Convert.ToDateTime("10/11/2020"), "Pizza", null);

            DetallePedido detallePedido1 = new DetallePedido(1, Convert.ToDateTime("10/11/2020"), 50, producto1);
            DetallePedido detallePedido2 = new DetallePedido(1, Convert.ToDateTime("10/11/2020"), 50, producto2);
            DetallePedido detallePedido3 = new DetallePedido(1, Convert.ToDateTime("10/11/2020"), 50, producto3);
            DetallePedido detallePedido4 = new DetallePedido(1, Convert.ToDateTime("10/11/2020"), 50, producto4);
            DetallePedido detallePedido5 = new DetallePedido(1, Convert.ToDateTime("10/11/2020"), 50, producto5);

            Pedido pedido = new Pedido(1, Convert.ToDateTime("10/11/2020"), 1, detallePedido1);
            Pedido pedido2 = new Pedido(2, Convert.ToDateTime("10/11/2020"), 1, detallePedido2);
            Pedido pedido3 = new Pedido(3, Convert.ToDateTime("10/11/2020"), 1, detallePedido3);
            Pedido pedido4 = new Pedido(4, Convert.ToDateTime("10/11/2020"), 1, detallePedido4);
            Pedido pedido5 = new Pedido(5, Convert.ToDateTime("10/11/2020"), 1, detallePedido5);

            todosDetalles = new List<DetallePedido>();
            todosPedidos = new List<Pedido>();

            todosDetalles.Add(detallePedido1); todosDetalles.Add(detallePedido2);
            todosDetalles.Add(detallePedido3); todosDetalles.Add(detallePedido4);
            todosDetalles.Add(detallePedido5);

            todosPedidos.Add(pedido); todosPedidos.Add(pedido2);
            todosPedidos.Add(pedido3); todosPedidos.Add(pedido4);
            todosPedidos.Add(pedido5);
            //Conjuntos de productos


            List<IEstructuraCarta> pc1 = new List<IEstructuraCarta>();
            List<IEstructuraCarta> pc2 = new List<IEstructuraCarta>();
            List<IEstructuraCarta> pp1 = new List<IEstructuraCarta>();
            List<IEstructuraCarta> pp2 = new List<IEstructuraCarta>();
            List<IEstructuraCarta> pp3 = new List<IEstructuraCarta>();
            List<IEstructuraCarta> pb1 = new List<IEstructuraCarta>();
            List<IEstructuraCarta> pb2 = new List<IEstructuraCarta>();
            List<IEstructuraCarta> ppo1 = new List<IEstructuraCarta>();
            List<IEstructuraCarta> ppo2 = new List<IEstructuraCarta>();
            List<IEstructuraCarta> pm1 = new List<IEstructuraCarta>();
            List<IEstructuraCarta> pm2 = new List<IEstructuraCarta>();
            List<IEstructuraCarta> pm3 = new List<IEstructuraCarta>();

            pc1.Add(producto1); pc1.Add(producto2);
            pc2.Add(producto3); pc2.Add(producto4);
            pp1.Add(producto5); pp1.Add(producto6);
            pp2.Add(producto7); pp2.Add(producto8);
            pp3.Add(producto9); pp3.Add(producto10);
            pb1.Add(producto11); pc1.Add(producto12);
            pb2.Add(producto13); pc1.Add(producto14);
            ppo1.Add(producto15); pc1.Add(producto16);
            ppo2.Add(producto17); pc1.Add(producto18);
            pm1.Add(producto19); pc1.Add(producto20);
            pm2.Add(producto21); pc1.Add(producto22);
            pm3.Add(producto23); pm3.Add(producto24);

            //Subcategorias
            EstructuraCarta subcategoriaCarnes1 = new EstructuraCarta(pc1, "Rojas");
            EstructuraCarta subcategoriaCarnes2 = new EstructuraCarta(pc2, "Blancas");
            EstructuraCarta subcategoriaPastas1 = new EstructuraCarta(pp1, "Largas");
            EstructuraCarta subcategoriaPastas2 = new EstructuraCarta(pp2, "Cortas");
            EstructuraCarta subcategoriaPastas3 = new EstructuraCarta(pp3, "Rellenas");
            EstructuraCarta subcategoriaBebidas1 = new EstructuraCarta(pb1, "Sin alcohol");
            EstructuraCarta subcategoriaBebidas2 = new EstructuraCarta(pb2, "Con alcohol");
            EstructuraCarta subcategoriaPostres1 = new EstructuraCarta(ppo1, "Tortas");
            EstructuraCarta subcategoriaPostres2 = new EstructuraCarta(ppo2, "Helados");
            EstructuraCarta subcategoriaMenus1 = new EstructuraCarta(pm1, "Diario");
            EstructuraCarta subcategoriaMenus2 = new EstructuraCarta(pm2, "Vegetariano");
            EstructuraCarta subcategoriaMenus3 = new EstructuraCarta(pm3, "Infantil");

            //Conjunto de subcategorias
            List<IEstructuraCarta> sc = new List<IEstructuraCarta>();
            List<IEstructuraCarta> sp = new List<IEstructuraCarta>();
            List<IEstructuraCarta> sb = new List<IEstructuraCarta>();
            List<IEstructuraCarta> spo = new List<IEstructuraCarta>();
            List<IEstructuraCarta> sm = new List<IEstructuraCarta>();
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
            List<IEstructuraCarta> c1 = new List<IEstructuraCarta>();
            List<IEstructuraCarta> c2 = new List<IEstructuraCarta>();
            List<IEstructuraCarta> c3 = new List<IEstructuraCarta>();

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
            categoriasSeleccionadas = new BindingList<IEstructuraCarta>();

            foreach (DataGridViewRow row in this.dgvCategorias.SelectedRows)
            {
                EstructuraCarta categoriaSel = row.DataBoundItem as EstructuraCarta;
                categoriasSeleccionadas.Add(categoriaSel);
            }

            //dgvSubCategorias.DataSource = gestor.obtenerHijos(categoriasSeleccionadas);
            btnMostrarProductos.Enabled = true;
        }

        private void btnMostrarProductos_Click(object sender, EventArgs e)
        {
            SubcategoriasSeleccionadas = new BindingList<EstructuraCarta>();

            foreach (DataGridViewRow row in dgvSubCategorias.SelectedRows)
            {
                EstructuraCarta subCategoriaSel = row.DataBoundItem as EstructuraCarta;
                SubcategoriasSeleccionadas.Add(subCategoriaSel);
            }
            BindingList<EstructuraCarta> prodCarta = new BindingList<EstructuraCarta>();
            //prodCarta= gestor.obtenerHijos(SubcategoriasSeleccionadas);

            dgvProductos.DataSource = prodCarta;
            btnGenerar.Enabled = true;
        }

        private void dgvCategorias_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            seleccionoAlguna = true;
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Desea generar un informe?", "", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                FormaVisualizacion formVis = new FormaVisualizacion();

                foreach (DataGridViewRow row in dgvProductos.SelectedRows)
                {
                    EstructuraCarta prodSeleccionados = row.DataBoundItem as EstructuraCarta;
                    PrductosSeleccionados.Add(prodSeleccionados);
                }

                //String datos = gestor.buscarPedidosConProductos(dtpFechaDesde.Value, dtpFechaHasta.Value, PrductosSeleccionados, todosPedidos, todosDetalles);

                formVis.Show();
            }
        }

        private void btnOrdenarCate_Click(object sender, EventArgs e)
        {
            dgvCategorias.Sort(dgvCategorias.Columns["ColumnaCategorias"], ListSortDirection.Descending);
        }
    }
}
