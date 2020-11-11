using CU121.Dominio;
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
        private bool seleccionoAlguna = false;


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

            //hay que armar todos los objetos de carta y producto.
            //Productos
            //Producto producto1 = new Producto(Convert.ToDateTime("10/11/2020"), 1, "Costeleta", 200);
            //Producto producto2 = new Producto(Convert.ToDateTime("10/11/2020"), 1, "Bife", 200);
            //Producto producto3 = new Producto(Convert.ToDateTime("10/11/2020"), 1, "Salmon", 200);
            //Producto producto4 = new Producto(Convert.ToDateTime("10/11/2020"), 1, "Pollo asado", 200);
            //Producto producto5 = new Producto(Convert.ToDateTime("10/11/2020"), 1, "Espageti", 200);
            //Producto producto6 = new Producto(Convert.ToDateTime("10/11/2020"), 1, "Tallarines", 200);
            //Producto producto7 = new Producto(Convert.ToDateTime("10/11/2020"), 1, "Ñoquis", 200);
            //Producto producto8 = new Producto(Convert.ToDateTime("10/11/2020"), 1, "Moñitos", 200);
            //Producto producto9 = new Producto(Convert.ToDateTime("10/11/2020"), 1, "Ravioles", 200);
            //Producto producto10 = new Producto(Convert.ToDateTime("10/11/2020"), 1, "Canelones", 200);
            //Producto producto11 = new Producto(Convert.ToDateTime("10/11/2020"), 1, "Agua", 200);
            //Producto producto12 = new Producto(Convert.ToDateTime("10/11/2020"), 1, "Gaseosa 500ml", 200);
            //Producto producto13 = new Producto(Convert.ToDateTime("10/11/2020"), 1, "Vino", 200);
            //Producto producto14 = new Producto(Convert.ToDateTime("10/11/2020"), 1, "Cerveza", 200);
            //Producto producto15 = new Producto(Convert.ToDateTime("10/11/2020"), 1, "Tiramisu", 200);
            //Producto producto16 = new Producto(Convert.ToDateTime("10/11/2020"), 1, "Chocotorta", 200);
            //Producto producto17 = new Producto(Convert.ToDateTime("10/11/2020"), 1, "Escoses", 200);
            //Producto producto18 = new Producto(Convert.ToDateTime("10/11/2020"), 1, "Americano", 200);
            //Producto producto19 = new Producto(Convert.ToDateTime("10/11/2020"), 1, "Milanesa con ensalada", 200);
            //Producto producto20 = new Producto(Convert.ToDateTime("10/11/2020"), 1, "Bife Pollo con pure", 200);
            //Producto producto21 = new Producto(Convert.ToDateTime("10/11/2020"), 1, "Hamburguesas de garvenzos con pure", 200);
            //Producto producto22 = new Producto(Convert.ToDateTime("10/11/2020"), 1, "Ensalada gohun", 200);
            //Producto producto23 = new Producto(Convert.ToDateTime("10/11/2020"), 1, "Hamburgesa", 200);
            //Producto producto24 = new Producto(Convert.ToDateTime("10/11/2020"), 1, "Pizza", 200);



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


            //Conjuntos de productos


            List<EstructuraCarta> pc1 = new List<EstructuraCarta>();
            List<EstructuraCarta> pc2 = new List<EstructuraCarta>();
            List<EstructuraCarta> pp1 = new List<EstructuraCarta>();
            List<EstructuraCarta> pp2 = new List<EstructuraCarta>();
            List<EstructuraCarta> pp3 = new List<EstructuraCarta>();
            List<EstructuraCarta> pb1 = new List<EstructuraCarta>();
            List<EstructuraCarta> pb2 = new List<EstructuraCarta>();
            List<EstructuraCarta> ppo1 = new List<EstructuraCarta>();
            List<EstructuraCarta> ppo2 = new List<EstructuraCarta>();
            List<EstructuraCarta> pm1 = new List<EstructuraCarta>();
            List<EstructuraCarta> pm2 = new List<EstructuraCarta>();
            List<EstructuraCarta> pm3 = new List<EstructuraCarta>();

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

            if (seleccionoAlguna)
            {
                foreach (DataGridViewRow row in this.dgvCategorias.SelectedRows)
                {
                    EstructuraCarta categoriaSel = row.DataBoundItem as EstructuraCarta;
                    categoriasSeleccionadas.Add(categoriaSel);
                }  
            }
            else
            {
                foreach (DataGridViewRow row in dgvCategorias.Rows)
                {
                    EstructuraCarta categoriaSel = row.DataBoundItem as EstructuraCarta;
                    categoriasSeleccionadas.Add(categoriaSel);
                }
            }

            dgvSubCategorias.DataSource = gestor.obtenerHijos(categoriasSeleccionadas);
            btnMostrarProductos.Enabled = true;
        }

        private void btnMostrarProductos_Click(object sender, EventArgs e)
        {
            SubcategoriasSeleccionadas = new List<EstructuraCarta>();
            foreach (DataGridViewRow row in dgvSubCategorias.SelectedRows)
            {
                EstructuraCarta subCategoriaSel = row.DataBoundItem as EstructuraCarta;
                SubcategoriasSeleccionadas.Add(subCategoriaSel);
            }
            List<EstructuraCarta> prodCarta = new List<EstructuraCarta>();
            prodCarta= gestor.obtenerHijos(SubcategoriasSeleccionadas);

            dgvProductos.DataSource = prodCarta;

            btnGenerar.Enabled = true;
        }

        private void dgvCategorias_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            seleccionoAlguna = true;
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Generar???", "", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                FormaVisualizacion formVis = new FormaVisualizacion();
                formVis.Show();
            }
        }
    }
}
