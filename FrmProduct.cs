using ClassLibrary1C_EgitimKamp_301_BusinessLayer.Abstract;
using ClassLibrary1C_EgitimKamp_301_BusinessLayer.concrete;
using ClassLibrary1C_EgitimKamp_301_DataAccessLayer.Abstract;
using ClassLibrary1C_EgitimKamp_301_DataAccessLayer.EntityFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C_EgitimKamp_301.PresentionalLayers
{
    public partial class FrmProduct : Form
    { //ProductManager ProductManager = new ProductManager(new EfProductDal());
        private readonly IProductService _productService;

        public FrmProduct()
        {
            _productService = new ProductManager(new EfProductDal());
            InitializeComponent();
        }

   private void btnList_Click(object sender, EventArgs e)
        {
            var values = _productService.TGetAll();
            dataGridView1.DataSource = values;
        }
    }
}
