using Microsoft.Extensions.DependencyInjection;
using Proyecto1Avanzada.DTO;
using Proyecto1Avanzada.Repositories;

namespace Proyecto1Avanzada
{
    public partial class Form1 : Form

    {
        private readonly IServiceProvider _serviceProvider;
        private readonly IProductsRepository _productsRepository;
        public Form1(IProductsRepository productsRepository, IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
            _productsRepository = productsRepository;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = _productsRepository.GetAllProducts();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var crear = _serviceProvider.GetRequiredService<Crear_Productos>();
            crear.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var suplidores = _serviceProvider.GetRequiredService<Suppliers>();
            suplidores.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var categoria = _serviceProvider.GetRequiredService<Categories>();
            categoria.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var filaSeleccionada = (ProductsDTO)dataGridView1.SelectedRows[0].DataBoundItem;
                var productsID = filaSeleccionada.ProductID;

                var crear = _serviceProvider.GetRequiredService<Crear_Productos>();
                crear.ObtenerProducto(productsID);
                crear.ShowDialog();

            }
        }
        private void button6_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = _productsRepository.GetAllProducts();
        }
    }
}
