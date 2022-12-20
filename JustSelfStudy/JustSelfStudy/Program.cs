using System;

namespace JustSelfStudy
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var human3 = new Human("Necati", "Shahmaz");

            Console.WriteLine("human1Name:" + human3.Name);
            Console.WriteLine("human1Surname:" + human3.Surname);
            Console.WriteLine("human1Age:" + human3.Age);



            Student std1 = new Student("Rashad")
            {

                Surname = "Abbasov",
                Age = 24,
                GroupNo = "P232",
                AvgPoint = 65
            };
            Console.WriteLine(std1.Name + "    " + std1.Surname);



            var tch = new Teacher("Elchin", "Aghayev", "Programming");
            tch.Age = 55;
            Console.WriteLine(tch.Age);


            WarrantyStudent wrt = new WarrantyStudent("Rashad", "Abbasov", "P232");


            Car car1 = new Car(100,"BMW","M5",2020);


           


            Train trn = new Train();


            trn.Brand = "Kur";
            trn.Model = "T-100";
            trn.WagonCount = 6;
            trn.Year = 2009;


            HyibridCar hybrid1 = new HyibridCar(10);

            ElectroCar electro1 = new ElectroCar();


        }



    }
}
