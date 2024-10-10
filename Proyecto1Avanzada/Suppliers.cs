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
    public partial class Suppliers : Form
    {
        private readonly ISuppliersRepository _suppliersRepository;
        private readonly IServiceProvider _serviceProvider;
        public Suppliers(ISuppliersRepository suppliersRepository, IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
            _suppliersRepository = suppliersRepository;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var suplidor = _serviceProvider.GetRequiredService<Crear_Suplidor>();
            suplidor.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Suppliers_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = _suppliersRepository.GetAllSuppliers();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = _suppliersRepository.GetAllSuppliers();
        }
    }
}
