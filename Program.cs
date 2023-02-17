using System;
using System.Text;

namespace N_25_Exam_Verveiko
{
    class Program
    {
        static void Main(string[] args)
        {
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.GetEncoding(1251);


            
            Car prot1 = new Car(7, 6 , 10);
            Car prot2 = new Car(4, 4, 7);
            Car prot3 = new Car(8, 6, 12);
            Car prot4 = new Car(4, 4, 8);

            Console.WriteLine(prot1);
            Console.WriteLine(prot2);
            Console.WriteLine(prot3);
            Console.WriteLine(prot4);
            Console.WriteLine();

            VehiclyList Sprot = new VehiclyList(4,5);
            VehiclyList Sprot2 = new VehiclyList(4,6);
            VehiclyList Sprot3 = new VehiclyList(8,2);
            VehiclyList Sprot4 = new VehiclyList(6,5);




            Sprot.AddVehicly(Sprot);
            Sprot2.AddVehicly(Sprot2);
            Sprot3.AddVehicly(Sprot3);
            Sprot4.AddVehicly(Sprot4);


            Console.WriteLine(Sprot);
            Console.WriteLine(Sprot2);
            Console.WriteLine(Sprot3);
            Console.WriteLine(Sprot4);



            Console.ReadKey();
        }
    }
}
