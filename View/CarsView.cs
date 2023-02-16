using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Controller;
using WindowsFormsApp1.Model;

namespace WindowsFormsApp1.View
{
    public partial class CarsView : Form
    {
        CarController controller = new CarController();

        public CarsView()
        {
            InitializeComponent();
        }

        private void CarsView_Load(object sender, EventArgs e)
        {
            dgvCars.DataSource = controller.GetAll();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            Car car = new Car();
            car.Name = txtName.Text;
            car.Year = txtYear.Text;
            car.Model = txtModel.Text;
            controller.btnAdd(car);
            dgvCars.DataSource = controller.GetAll();

        }

        
    }
}
