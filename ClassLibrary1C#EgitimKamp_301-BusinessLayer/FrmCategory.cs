using C_EgitimKamp_301_Entity_Layer.concrete;
using ClassLibrary1C_EgitimKamp_301_BusinessLayer.Abstract;
using ClassLibrary1C_EgitimKamp_301_BusinessLayer.concrete;
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

namespace ClassLibrary1C_EgitimKamp_301_BusinessLayer
{
    public partial class FrmCategory : Form
    {
        private readonly ICategoryService _categoryService;

        public FrmCategory()
        {
            _categoryService=new CategoryManager(new EfCategoryDal());
            
            InitializeComponent();
        }


        private void rdbPassive_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnList_Click(object sender, EventArgs e)
        {
            var categoryValues =_categoryService.TGetAll();
            dataGridView1.DataSource = categoryValues;

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Category category = new Category();
            category.CategoryName=txtCategoryName.Text;
            category.CategoryStatus = true;
            _categoryService.TInsert(category);
            MessageBox.Show("Ekleme Başarılı");
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtCategoryId.Text);
            var deleteValues=_categoryService.TGetById(id);
            _categoryService.TDelete(deleteValues);
            MessageBox.Show("Silme Başarılı");
        }

        private void btnGetBuyId_Click(object sender, EventArgs e)
        {
            int id =int.Parse(txtCategoryId.Text);
            var values=_categoryService.TGetById(id);
            dataGridView1 .DataSource = values;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //Category category=new Category();
            int updateId =int.Parse(txtCategoryId.Text);
            var updateValue = _categoryService.TGetById(updateId);
            updateValue.CategoryName = txtCategoryName.Text;
            updateValue.CategoryStatus = true;
            _categoryService.TUpdate(updateValue);
        }
    }
}
