using Microsoft.Extensions.DependencyInjection;
using Proyecto1Avanzada.Repositories;
using Proyecto1Avanzada.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto1Avanzada
{
    public partial class Categories : Form
    {
        private readonly ICategoriesServices _categoriesServices;
        private readonly IServiceProvider _serviceProvider;
        public Categories(ICategoriesServices categoriesServices, IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
            _categoriesServices = categoriesServices;
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            var NCategias = _serviceProvider.GetRequiredService<Crear_Categorias>();
            NCategias.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Categories_Load(object sender, EventArgs e)
        {
            var categories= _categoriesServices.GetAllCategories();
            dataGridView1.DataSource = categories;
        }
    }
}
