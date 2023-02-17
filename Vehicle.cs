using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N_25_Exam_Verveiko
{
    class Vehicle  //базовый класс автомобилей для разных типов
    {
        protected int num_wheels;
        protected int range;

        public int Num_wheels { get { return num_wheels; } } //открыты для чтения!
        public int Range { get { return range; } }

        public Vehicle()   //конструктор
        {

            
        }
        public Vehicle(int num_wheels , int range)   
        {
            this.num_wheels = num_wheels;
            this.range = range;

        }


        public void Showv()
        {
            Console.WriteLine("Число колес:" + num_wheels);
            Console.WriteLine("Грузоподъемность"+ range);
        }


    }
    
    class Car : Vehicle //легковушка
    {
        protected int passengers;

        public Car()  //конструктор
        {

        }
        public Car(int passengers, int num_wheels, int range)  //конструктор
        {
            this.num_wheels = num_wheels;
            this.range = range;
            this.passengers = passengers;
        }


        public void Show()
        {
            Showv();
            Console.WriteLine("Пассажироемкость:" + passengers);
        }

        public override string ToString()
        {
            return ("Число колес: " + Num_wheels + " Пассажироемкость: " + passengers + " Грузоподъемность: " + Range);
        }




    }


}
