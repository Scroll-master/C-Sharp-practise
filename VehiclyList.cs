using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N_25_Exam_Verveiko
{
    class VehiclyList : Vehicle
    {
        List<Vehicle> list;


        public VehiclyList(int num_wheels, int range)
        {
            
            this.num_wheels = num_wheels;
            this.range = range;
            list = new List<Vehicle>();
        }

        public void AddVehicly(Vehicle obj)
        {
           list.Add(obj);
           //list.Add(obj);
           //list.Add(obj);
           //list.Add(obj);
        }

        public void AddCar(Car obj)
        {
            list.Add(obj);


        }
        public override string ToString()
        {
            return ("Число колес: " + Num_wheels  + " Грузоподъемность: " + Range);
        }

    }
}
