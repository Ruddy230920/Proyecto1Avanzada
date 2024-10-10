using Proyecto1Avanzada.DTO;
using Proyecto1Avanzada.Models;
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
    public partial class Crear_Productos : Form
    {
        private int productsID;
        private readonly IProductsServices _productsService;
        private readonly ISuppliersServices _suppliersService;
        private readonly ICategoriesServices _categoriesService;
        public Crear_Productos(ICategoriesServices categoriesServices, ISuppliersServices suppliersServices, IProductsServices productsServices)
        {

            _productsService = productsServices;
            _categoriesService = categoriesServices;
            _suppliersService = suppliersServices;
            InitializeComponent();
        }

        private void Crear_Productos_Load(object sender, EventArgs e)
        {
            var categories = _categoriesService.GetAllCategories();
            var suppliers = _suppliersService.GetAllSuppliers();

            if (productsID > 0)
            {
                var products = _productsService.GetProductsById(productsID);
                txtNombreP.Text = products.ProductName;
                txtCantidadUnidad.Text = products.QuantityPerUnit;
                txtPrecioUnidad.Text = products.UnitPrice.ToString();
                txtUnidadPedido.Text = products.UnitsOnOrder.ToString();
                txtUnidadStock.Text = products.UnitsInStock.ToString();
                cmboxCategoriaP.Text = products.CategoryName;
                cmboxSuplidorP.Text = products.CompanyName;
                checkBox1.Checked = products.Discontinued;
                cmboxCategoriaP.Text = products.CategoryID.ToString();
                cmboxSuplidorP.Text = products.SupplierID.ToString();
            }


            if (categories != null && suppliers != null)
            {
                cmboxCategoriaP.DisplayMember = "CategoryName";
                cmboxCategoriaP.ValueMember = "CategoryID";
                cmboxCategoriaP.DataSource = categories;

                cmboxSuplidorP.DisplayMember = "CompanyName";
                cmboxSuplidorP.ValueMember = "SupplierID";
                cmboxSuplidorP.DataSource = suppliers;

            }

        }

        public void ObtenerProducto(int id)
        {
            productsID = id;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            
            
                var products = new ProductsDTO
                {
                    ProductID=this.productsID,
                    ProductName = txtNombreP.Text,
                    QuantityPerUnit = txtCantidadUnidad.Text,
                    UnitPrice = Convert.ToDecimal(txtPrecioUnidad.Text),
                    UnitsInStock = Convert.ToInt16(txtUnidadStock.Text),
                    UnitsOnOrder = Convert.ToInt16(txtUnidadPedido.Text),
                    CategoryName = cmboxCategoriaP.Text,
                    CategoryID = (int)(cmboxCategoriaP.SelectedValue),
                    SupplierID = (int)(cmboxSuplidorP.SelectedValue),
                    CompanyName = cmboxCategoriaP.Text,
                    Discontinued = checkBox1.Checked


                };

                if (products.ProductID == 0)
                
                    _productsService.Add(products);
                else

                    _productsService.Update(products);

               
            
                this.Close();
            }
         
          
        }
    }

