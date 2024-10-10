using Proyecto1Avanzada.DTO;
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
    public partial class Crear_Suplidor : Form
    {
        private readonly ISuppliersServices _suppliersServices;
        public Crear_Suplidor(ISuppliersServices suppliersServices)
        {
            _suppliersServices = suppliersServices;
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Crear_Suplidor_Load(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            var suppliers = new SupplierDTO
            {
                CompanyName = txtNombreCompañia.Text,
                ContactName = txtNombreConctato.Text,
                ContactTitle = txtTituloConctato.Text,
                City = txtCiudadS.Text,
                Address = txtDIreccionS.Text,
                Country = txtPaisS.Text,
                Phone = txtTelefonoS.Text
            };
            if (suppliers != null)
            { 
                _suppliersServices.Add(suppliers);
            }
            this.Close();
        }
    }
}
