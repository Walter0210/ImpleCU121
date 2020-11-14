using CU121.Dominio;
using CU121.FabricacionPura;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

                dgvCategorias.SelectAll();
                btnBuscarSubCategorias.Enabled = true;

                //dgvCategorias.Sort(DataGridViewColumn("ColumnaProductos"), ListSortDirection.Ascending);
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

            Producto producto1 = new Producto(Convert.ToDateTime("10/11/2020"), 1, "Costeleta", 300.50f);
            Producto producto2 = new Producto(Convert.ToDateTime("10/11/2020"), 2, "Bife", 5300.50f);
            Producto producto3 = new Producto(Convert.ToDateTime("10/11/2020"), 3, "Salmon", 4300.50f);
            Producto producto4 = new Producto(Convert.ToDateTime("10/11/2020"), 4, "Pollo asado", 3300.50f);
            Producto producto5 = new Producto(Convert.ToDateTime("10/11/2020"), 5, "Espageti", 2300.50f);
            Producto producto6 = new Producto(Convert.ToDateTime("10/11/2020"), 6, "Tallarines", 1300.50f);
            Producto producto7 = new Producto(Convert.ToDateTime("10/11/2020"), 6, "Ñoquis", 130.50f);
            Producto producto8 = new Producto(Convert.ToDateTime("10/11/2020"), 6, "Moñitos", 1300.55f);
            Producto producto9 = new Producto(Convert.ToDateTime("10/11/2020"), 6, "Tallarines", 1300.70f);
            Producto producto10 = new Producto(Convert.ToDateTime("10/11/2020"), 6, "Ravioles", 350.50f);
            Producto producto11 = new Producto(Convert.ToDateTime("10/11/2020"), 6, "Canelones", 130.50f);
            Producto producto12 = new Producto(Convert.ToDateTime("10/11/2020"), 6, "Agua", 300.50f);
            Producto producto13 = new Producto(Convert.ToDateTime("10/11/2020"), 6, "Vino", 100.50f);
            Producto producto14 = new Producto(Convert.ToDateTime("10/11/2020"), 6, "Cerveza", 110.50f);
            Producto producto15 = new Producto(Convert.ToDateTime("10/11/2020"), 6, "Tiramisu", 100.50f);

            //Subconjuntos de productos
            EstructuraCarta productodeCarta1 = new EstructuraCarta(true, Convert.ToDateTime("10/11/2020"), "Costeleta"  , producto1);
            EstructuraCarta productodeCarta2 = new EstructuraCarta(true, Convert.ToDateTime("10/11/2020"), "Bife"       , producto2);
            EstructuraCarta productodeCarta3 = new EstructuraCarta(true, Convert.ToDateTime("10/11/2020"), "Salmon", producto3);
            EstructuraCarta productodeCarta4 = new EstructuraCarta(true, Convert.ToDateTime("10/11/2020"), "Pollo asado", producto4);
            EstructuraCarta productodeCarta5 = new EstructuraCarta(true, Convert.ToDateTime("10/11/2020"), "Espageti", producto5);
            EstructuraCarta productodeCarta6 = new EstructuraCarta(true, Convert.ToDateTime("10/11/2020"), "Tallarines", producto6);
            EstructuraCarta productodeCarta7 = new EstructuraCarta(true, Convert.ToDateTime("10/11/2020"), "Ñoquis", producto7);
            EstructuraCarta productodeCarta8 = new EstructuraCarta(true, Convert.ToDateTime("10/11/2020"), "Moñitos", producto8);
            EstructuraCarta productodeCarta9 = new EstructuraCarta(true, Convert.ToDateTime("10/11/2020"), "Ravioles", producto9);
            EstructuraCarta productodeCarta10 = new EstructuraCarta(true, Convert.ToDateTime("10/11/2020"), "Canelones", producto10);
            EstructuraCarta productodeCarta11 = new EstructuraCarta(true, Convert.ToDateTime("10/11/2020"), "Agua", producto11);
            EstructuraCarta productodeCarta12 = new EstructuraCarta(true, Convert.ToDateTime("10/11/2020"), "Gaseosa 500ml", producto12);
            EstructuraCarta productodeCarta13 = new EstructuraCarta(true, Convert.ToDateTime("10/11/2020"), "Vino", producto13);
            EstructuraCarta productodeCarta14 = new EstructuraCarta(true, Convert.ToDateTime("10/11/2020"), "Cerveza", producto14);
            EstructuraCarta productodeCarta15 = new EstructuraCarta(true, Convert.ToDateTime("10/11/2020"), "Tiramisu", producto15);
            EstructuraCarta productodeCarta16 = new EstructuraCarta(true, Convert.ToDateTime("10/11/2020"), "Chocotorta", null);
            EstructuraCarta productodeCarta17 = new EstructuraCarta(true, Convert.ToDateTime("10/11/2020"), "Escoses", null);
            EstructuraCarta productodeCarta18 = new EstructuraCarta(true, Convert.ToDateTime("10/11/2020"), "Americano", null);
            EstructuraCarta productodeCarta19 = new EstructuraCarta(true, Convert.ToDateTime("10/11/2020"), "Milanesa con ensalada", null);
            EstructuraCarta productodeCarta20 = new EstructuraCarta(true, Convert.ToDateTime("10/11/2020"), "Bife Pollo con pure", null);
            EstructuraCarta productodeCarta21 = new EstructuraCarta(true, Convert.ToDateTime("10/11/2020"), "Hamburguesas de garvenzos con pure", null);
            EstructuraCarta productodeCarta22 = new EstructuraCarta(true, Convert.ToDateTime("10/11/2020"), "Ensalada gohun", null);
            EstructuraCarta productodeCarta23 = new EstructuraCarta(true, Convert.ToDateTime("10/11/2020"), "Hamburgesa", null);
            EstructuraCarta productodeCarta24 = new EstructuraCarta(true, Convert.ToDateTime("10/11/2020"), "Pizza", null);

            DetallePedido detallePedido1 = new DetallePedido(2, Convert.ToDateTime("10/11/2020"), 0, productodeCarta1);
            DetallePedido detallePedido2 = new DetallePedido(1, Convert.ToDateTime("10/11/2020"), 0, productodeCarta2);
            DetallePedido detallePedido3 = new DetallePedido(4, Convert.ToDateTime("10/11/2020"), 0, productodeCarta3);
            DetallePedido detallePedido4 = new DetallePedido(2, Convert.ToDateTime("9/11/2020"), 0, productodeCarta4);
            DetallePedido detallePedido5 = new DetallePedido(5, Convert.ToDateTime("9/11/2020"), 0, productodeCarta5);
            DetallePedido detallePedido6 = new DetallePedido(3, Convert.ToDateTime("1/11/2020"), 0, productodeCarta7);
            DetallePedido detallePedido7 = new DetallePedido(10, Convert.ToDateTime("1/11/2020"), 0, productodeCarta8);
            DetallePedido detallePedido8 = new DetallePedido(2, Convert.ToDateTime("1/11/2020"), 0, productodeCarta9);
            DetallePedido detallePedido9 = new DetallePedido(3, Convert.ToDateTime("1/11/2020"), 0, productodeCarta10);
            DetallePedido detallePedido10 = new DetallePedido(8, Convert.ToDateTime("1/11/2020"), 0, productodeCarta11);


            Pedido pedido = new Pedido(1, Convert.ToDateTime("10/11/2020"), 10001, detallePedido1);
            Pedido pedido2 = new Pedido(2, Convert.ToDateTime("10/11/2020"), 10002, detallePedido2);
            Pedido pedido3 = new Pedido(3, Convert.ToDateTime("10/11/2020"), 10003, detallePedido3);
            Pedido pedido4 = new Pedido(4, Convert.ToDateTime("9/11/2020"), 10004, detallePedido4);
            Pedido pedido5 = new Pedido(5, Convert.ToDateTime("9/11/2020"), 10005, detallePedido5);
            Pedido pedido6 = new Pedido(5, Convert.ToDateTime("1/11/2020"), 10006, detallePedido6);
            Pedido pedido7 = new Pedido(5, Convert.ToDateTime("1/11/2020"), 10007, detallePedido7);
            Pedido pedido8 = new Pedido(5, Convert.ToDateTime("1/11/2020"), 10008, detallePedido8);
            Pedido pedido9 = new Pedido(5, Convert.ToDateTime("1/11/2020"), 10009, detallePedido9);
            Pedido pedido10 = new Pedido(5, Convert.ToDateTime("1/11/2020"), 10010, detallePedido10);

            todosDetalles = new List<DetallePedido>();
            todosPedidos = new List<Pedido>();

            todosDetalles.Add(detallePedido1); todosDetalles.Add(detallePedido2);
            todosDetalles.Add(detallePedido3); todosDetalles.Add(detallePedido4);
            todosDetalles.Add(detallePedido5); todosDetalles.Add(detallePedido6);

            todosPedidos.Add(pedido); todosPedidos.Add(pedido2);
            todosPedidos.Add(pedido3); todosPedidos.Add(pedido4);
            todosPedidos.Add(pedido5); todosPedidos.Add(pedido6);
            
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
            pb1.Add(productodeCarta11);    pb1.Add(productodeCarta12);
            pb2.Add(productodeCarta13);    pb2.Add(productodeCarta14);
            ppo1.Add(productodeCarta15);   ppo1.Add(productodeCarta16);
            ppo2.Add(productodeCarta17);   pc1.Add(productodeCarta18);
            pm1.Add(productodeCarta19);    pc1.Add(productodeCarta20);
            pm2.Add(productodeCarta21);    pm2.Add(productodeCarta22);
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

            sc.Add(subcategoriaCarnes1);    sc.Add(subcategoriaCarnes2);
            sp.Add(subcategoriaPastas1);    sp.Add(subcategoriaPastas2);    sp.Add(subcategoriaPastas3);
            sb.Add(subcategoriaBebidas1);   sb.Add(subcategoriaBebidas2);
            spo.Add(subcategoriaPostres1);  spo.Add(subcategoriaPostres2);
            sm.Add(subcategoriaMenus1);     sm.Add(subcategoriaMenus2);     sm.Add(subcategoriaMenus3);


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

            c2.Add(categoriaCarnes);    c2.Add(categoriaBebidas);
            c1.Add(categoriaCarnes);    c1.Add(categoriaMenus);     c1.Add(categoriaPastas);
            c3.Add(categoriaMenus);     c3.Add(categoriaPostres);

            //Cartas
            EstructuraCarta carta1 = new EstructuraCarta(Convert.ToDateTime("1/11/2020"), Convert.ToDateTime("9/11/2020"), Convert.ToDateTime("10/11/2021"), "primerCarta", "waltersito");
            EstructuraCarta carta2 = new EstructuraCarta(Convert.ToDateTime("9/11/2020"), Convert.ToDateTime("9/11/2020"), Convert.ToDateTime("10/11/2021"), "segundaCarta", "waltersito");
            EstructuraCarta carta3 = new EstructuraCarta(Convert.ToDateTime("8/11/2020"), Convert.ToDateTime("9/11/2020"), Convert.ToDateTime("9/11/2021"), "tercerCarta", "lautarito");
            EstructuraCarta carta4 = new EstructuraCarta(Convert.ToDateTime("1/11/2020"), Convert.ToDateTime("9/11/2020"), Convert.ToDateTime("9/11/2021"), "cuartaCarta", "lautarito");
            EstructuraCarta carta5 = new EstructuraCarta(Convert.ToDateTime("1/11/2020"), Convert.ToDateTime("9/11/2020"), Convert.ToDateTime("1/11/2021"), "quintaCarta", "lautarito");

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
            dgvSubCategorias.SelectAll();
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
            dgvProductos.SelectAll();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Desea generar el Reporte?", "Confime la Acción", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {


                List<IEstructuraCarta> prdCartaSeleccionados = new List<IEstructuraCarta>();
                foreach (DataGridViewRow row in this.dgvProductos.SelectedRows)
                {
                    EstructuraCarta prodCarta = row.DataBoundItem as EstructuraCarta;
                    prdCartaSeleccionados.Add(prodCarta);
                }
                
                DataTable tabla = gestor.buscarPedidosCumplenFiltros(fechaInicio, fechaFin, todosPedidos, prdCartaSeleccionados);
                
                FormaVisualizacion fomvis = new FormaVisualizacion(tabla, fechaInicio, fechaFin);
                fomvis.Show();
            }
        }
    }
}
