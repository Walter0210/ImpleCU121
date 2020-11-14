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
        private DateTime fechaInicio;
        private DateTime fechaFin;

        public PantallaGenReporte()
        {
            InitializeComponent();
        }

        private void btbBuscarCartas_Click(object sender, EventArgs e)
        {
            fechaInicio = dtpFechaDesde.Value;
            fechaFin = dtpFechaHasta.Value;
            if (fechaFin > fechaInicio)
            {
                gestor.buscarCartasVigentes(fechaInicio, fechaFin, todasCartas);
                dgvCategorias.DataSource = gestor.buscarCategorias();
                btnBuscarSubCategorias.Enabled = true;
            }
            else
            {
                MessageBox.Show("Seleccione un periodo valido.");
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


            //Productos

            Producto producto1 = new Producto(Convert.ToDateTime("10/11/2020"), 2, "Costeleta", 300.50f);
            Producto producto2 = new Producto(Convert.ToDateTime("10/11/2020"), 2, "Bife", 5300.50f);
            Producto producto3 = new Producto(Convert.ToDateTime("10/11/2020"), 3, "Salmon", 4300.50f);
            Producto producto4 = new Producto(Convert.ToDateTime("10/11/2020"), 4, "Pollo asado", 3300.50f);
            Producto producto5 = new Producto(Convert.ToDateTime("10/11/2020"), 5, "Espageti", 2300.50f);
            Producto producto6 = new Producto(Convert.ToDateTime("10/11/2020"), 6, "Tallarines", 1300.50f);

            //Subconjuntos de productos
            EstructuraCarta productodeCarta1 = new EstructuraCarta(true, Convert.ToDateTime("10/11/2020"), "Costeleta", producto1);
            EstructuraCarta productodeCarta2 = new EstructuraCarta(true, Convert.ToDateTime("10/11/2020"), "Bife", producto2);
            EstructuraCarta productodeCarta3 = new EstructuraCarta(true, Convert.ToDateTime("10/11/2020"), "Salmon", producto3);
            EstructuraCarta productodeCarta4 = new EstructuraCarta(true, Convert.ToDateTime("10/11/2020"), "Pollo asado", producto4);
            EstructuraCarta productodeCarta5 = new EstructuraCarta(true, Convert.ToDateTime("10/11/2020"), "Espageti", producto5);
            EstructuraCarta productodeCarta6 = new EstructuraCarta(true, Convert.ToDateTime("10/11/2020"), "Tallarines", producto6);
            EstructuraCarta productodeCarta7 = new EstructuraCarta(true, Convert.ToDateTime("10/11/2020"), "Ñoquis", null);
            EstructuraCarta productodeCarta8 = new EstructuraCarta(true, Convert.ToDateTime("10/11/2020"), "Moñitos", null);
            EstructuraCarta productodeCarta9 = new EstructuraCarta(true, Convert.ToDateTime("10/11/2020"), "Ravioles", null);
            EstructuraCarta productodeCarta10 = new EstructuraCarta(true, Convert.ToDateTime("10/11/2020"), "Canelones", null);
            EstructuraCarta productodeCarta11 = new EstructuraCarta(true, Convert.ToDateTime("10/11/2020"), "Agua", null);
            EstructuraCarta productodeCarta12 = new EstructuraCarta(true, Convert.ToDateTime("10/11/2020"), "Gaseosa 500ml", null);
            EstructuraCarta productodeCarta13 = new EstructuraCarta(true, Convert.ToDateTime("10/11/2020"), "Vino", null);
            EstructuraCarta productodeCarta14 = new EstructuraCarta(true, Convert.ToDateTime("10/11/2020"), "Cerveza", null);
            EstructuraCarta productodeCarta15 = new EstructuraCarta(true, Convert.ToDateTime("10/11/2020"), "Tiramisu", null);
            EstructuraCarta productodeCarta16 = new EstructuraCarta(true, Convert.ToDateTime("10/11/2020"), "Chocotorta", null);
            EstructuraCarta productodeCarta17 = new EstructuraCarta(true, Convert.ToDateTime("10/11/2020"), "Escoses", null);
            EstructuraCarta productodeCarta18 = new EstructuraCarta(true, Convert.ToDateTime("10/11/2020"), "Americano", null);
            EstructuraCarta productodeCarta19 = new EstructuraCarta(true, Convert.ToDateTime("10/11/2020"), "Milanesa con ensalada", null);
            EstructuraCarta productodeCarta20 = new EstructuraCarta(true, Convert.ToDateTime("10/11/2020"), "Bife Pollo con pure", null);
            EstructuraCarta productodeCarta21 = new EstructuraCarta(true, Convert.ToDateTime("10/11/2020"), "Hamburguesas de garvenzos con pure", null);
            EstructuraCarta productodeCarta22 = new EstructuraCarta(true, Convert.ToDateTime("10/11/2020"), "Ensalada gohun", null);
            EstructuraCarta productodeCarta23 = new EstructuraCarta(true, Convert.ToDateTime("10/11/2020"), "Hamburgesa", null);
            EstructuraCarta productodeCarta24 = new EstructuraCarta(true, Convert.ToDateTime("10/11/2020"), "Pizza", null);

            DetallePedido detallePedido1 = new DetallePedido(2, Convert.ToDateTime("10/11/2020"), 53, productodeCarta1);
            DetallePedido detallePedido2 = new DetallePedido(1, Convert.ToDateTime("10/11/2020"), 50, productodeCarta2);
            DetallePedido detallePedido3 = new DetallePedido(4, Convert.ToDateTime("10/11/2020"), 50, productodeCarta3);
            DetallePedido detallePedido4 = new DetallePedido(2, Convert.ToDateTime("10/11/2020"), 50, productodeCarta4);
            DetallePedido detallePedido5 = new DetallePedido(5, Convert.ToDateTime("10/11/2020"), 50, productodeCarta5);
            DetallePedido detallePedido6 = new DetallePedido(5, Convert.ToDateTime("10/11/2020"), 50, productodeCarta6);

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

            pc1.Add(productodeCarta1);     pc1.Add(productodeCarta2);
            pc2.Add(productodeCarta3);     pc2.Add(productodeCarta4);
            pp1.Add(productodeCarta5);     pp1.Add(productodeCarta6);
            pp2.Add(productodeCarta7);     pp2.Add(productodeCarta8);
            pp3.Add(productodeCarta9);     pp3.Add(productodeCarta10);
            pb1.Add(productodeCarta11);    pc1.Add(productodeCarta12);
            pb2.Add(productodeCarta13);    pc1.Add(productodeCarta14);
            ppo1.Add(productodeCarta15);   pc1.Add(productodeCarta16);
            ppo2.Add(productodeCarta17);   pc1.Add(productodeCarta18);
            pm1.Add(productodeCarta19);    pc1.Add(productodeCarta20);
            pm2.Add(productodeCarta21);    pc1.Add(productodeCarta22);
            pm3.Add(productodeCarta23);    pm3.Add(productodeCarta24);

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

        private void btnMostrarSubCategorias_Click(object sender, EventArgs e)
        {
            BindingList<IEstructuraCarta> categoriasSeleccionadas = new BindingList<IEstructuraCarta>();

            foreach (DataGridViewRow row in this.dgvCategorias.SelectedRows)
            {
                EstructuraCarta categoriaSel = row.DataBoundItem as EstructuraCarta;
                categoriasSeleccionadas.Add(categoriaSel);
            }

            dgvSubCategorias.DataSource = gestor.buscarSubCategorias(categoriasSeleccionadas);
            btnMostrarProductos.Enabled = true;
            btnGenerar.Enabled = true;
        }

        private void btnMostrarProductos_Click(object sender, EventArgs e)
        {
            BindingList<IEstructuraCarta> subCatSelec = new BindingList<IEstructuraCarta>();
            foreach (DataGridViewRow row in this.dgvSubCategorias.SelectedRows)
            {
                EstructuraCarta subCategoriaSel = row.DataBoundItem as EstructuraCarta;
                subCatSelec.Add(subCategoriaSel);
            }

            dgvProductos.DataSource = gestor.buscarProductosCarta(subCatSelec);
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Desea generar el Reporte?", "Confime la Acción", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                FormaVisualizacion fomvis = new FormaVisualizacion();
                fomvis.Show();

                List<IEstructuraCarta> prdCartaSeleccionados = new List<IEstructuraCarta>();
                foreach (DataGridViewRow row in this.dgvProductos.SelectedRows)
                {
                    EstructuraCarta prodCarta = row.DataBoundItem as EstructuraCarta;
                    prdCartaSeleccionados.Add(prodCarta);
                }
                
                gestor.buscarPedidosCumplenFiltros(fechaInicio, fechaFin, todosPedidos, prdCartaSeleccionados);

            }
        }
    }
}
