using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C_EgitimKamp_301.EfProject
{
    public partial class Frmİstatistik : Form
    {
        public Frmİstatistik()
        {
            InitializeComponent();
        }
        
        EğitimKampıEFTravelDbEntities2 db= new EğitimKampıEFTravelDbEntities2();

        private void Frmİstatistik_Load(object sender, EventArgs e)
        {
            lblLocationCount.Text = db.Location.Count().ToString();
            lblSumCapacity.Text= db.Location.Sum(x=> x.Capacity).ToString();
            lblGuideCount.Text= db.Guide.Count().ToString();
            lblAvgCapacity.Text= db.Location.Average(x=> x.Capacity).ToString();
            decimal? avgPrice = db.Location.Average(y => y.Price);
            lblAvgPrice.Text = (avgPrice ?? 0).ToString("F2");

            int lastCountryId = db.Location.Max(x=> x.locationId);
            lblLastCount.Text= db.Location.Where(x=> x.locationId==lastCountryId).Select(y=> y.Country).
                FirstOrDefault();

            lblKapadokyaCapacity.Text=db.Location.Where(y=> y.City=="Kapadokya").Select(x=> x.Capacity).
                FirstOrDefault().ToString();

            lblTurkeyAvgCapacity.Text= db.Location.Where(x=> x.Country=="Türkiye").Average(y=> y.Capacity).ToString();



            var romeGuideId = db.Location.Where(x => x.City == "Roma").Select(y => y.GuideId).FirstOrDefault();
            lblRomeGuideName.Text= db.Guide.Where( y=> y.GuideId==romeGuideId).
                Select(x=> x.GuideName+" "+x.GuideSurname).FirstOrDefault().ToString();

            var maxCapacity= db.Location.Max(x=> x.Capacity);
            lblMaxCapacityLocaticon.Text = db.Location.Where(x => x.Capacity == maxCapacity).
                Select(y => y.City).FirstOrDefault().ToString();

            var maxPrice= db.Location.Max(y=> y.Price);
            lblMaxPriceLocation.Text = db.Location.Where(x => x.Price == maxPrice).Select(y => y.City).
                FirstOrDefault().ToString();

            var guideIdByNameAyseCınar = db.Guide.Where(x => x.GuideName == "Ayşe" && x.GuideSurname == "Çınar").
                Select(y => y.GuideId).FirstOrDefault();
            lblAyseCınarLocationCount.Text = db.Location.Where(x=> x.GuideId==guideIdByNameAyseCınar).
                Count().ToString();


        }

        private void lblSumCapacity_Click(object sender, EventArgs e)
        {

        }
    }
}
