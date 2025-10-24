using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C_EgitimKamp_301.EfProject
{
    public partial class FrmLocation : Form
    {
        public FrmLocation()
        {
            InitializeComponent();
        }
        EğitimKampıEFTravelDbEntities2 db = new EğitimKampıEFTravelDbEntities2();
        private void btnList_Click(object sender, EventArgs e)
        {
            var values = db.Location.ToList();
            dataGridView1.DataSource = values;
        }

        private void FrmLocation_Load(object sender, EventArgs e)
        {
            var values = db.Guide.Select(x => new
            {
                FullName = x.GuideName + " " +x.GuideSurname,
            }).ToList();
            
            cmbGuideId.DisplayMember= "FullName";
            cmbGuideId.ValueMember= "GuideId";
            cmbGuideId.DataSource= values;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Location location= new Location();
            location.Capacity= byte.Parse(numCapacity.Value. ToString());
            location.City = txtCity.Text;
            location.Country = txtCountry.Text;
            location.Price= decimal.Parse(txtPrice.Text.ToString());
            location.DayNight=txtDayNight.Text;
            location.GuideId = int.Parse(cmbGuideId.SelectedValue.ToString());
            db.Location.Add(location);
            db.SaveChanges();
            MessageBox.Show("İşlem Başarıyla Eklendi.");

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            var DeleteValues = db.Location.Find(id);
            db.Location.Remove(DeleteValues);
            db.SaveChanges();
            MessageBox.Show("silme işlemi başarılı");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id =int.Parse(txtId.Text);
            var UpdateValues = db.Location.Find(id);
            UpdateValues.City= txtCity.Text;
            UpdateValues.Country= txtCountry.Text;
            UpdateValues.DayNight= txtDayNight.Text;
            UpdateValues.Price=decimal.Parse(txtPrice.Text.ToString());
            UpdateValues.GuideId= int.Parse(cmbGuideId.SelectedValue.ToString());
            UpdateValues.Capacity=byte.Parse(numCapacity.Value.ToString());
            db.SaveChanges();
            MessageBox.Show("Güncelleme Başarılı");

        }
    }
}
