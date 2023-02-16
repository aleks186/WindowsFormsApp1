using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Model;

namespace WindowsFormsApp1.Controller
{
    internal class CarController
    {
        public List <Car> GetAll()
        {
            using (dtbaseEntities db = new dtbaseEntities())
            {
                return db.Cars.ToList();
            }
        }
        public void btnAdd(Car car)
        {
            using (dtbaseEntities db= new dtbaseEntities())
            {
                car.Id = db.Cars.ToList().LastOrDefault().Id + 1;
                db.Cars.Add(car);
                db.SaveChanges();
            }
        }
    }
}
