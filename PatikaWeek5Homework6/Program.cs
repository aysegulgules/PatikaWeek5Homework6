
using PatikaWeek5Homework6;


        List<Car> cars = new List<Car>();//Car tipinde liste tanımlanıyor.

        while (true)
        {
        carsGo: Console.WriteLine("\nYeni bir araba eklemek ister misiniz?(e/h)");
            var continueFilm = Console.ReadLine().ToLower();
            if (continueFilm == "h")
            {
                break;
            }
            else if (continueFilm != "e")
            {
             
                Console.WriteLine("Geçersiz giriş.");
                goto carsGo;
            }

          cars.Add(CarProduction());//CarProduction metodundan yeni araba bilgileri alınıyor ve listeye ekleniyor

        }

        Console.WriteLine("\nÜretilen araba listesi.....");
        foreach (var car in cars)
        {
            car.CarInfo();
        }


        ///<summary>
        ///Araba nesnesinin üretildiği metot.
        ///</summary>
        Car CarProduction()
        {
            Car car = new Car();
            Console.WriteLine("\nAraba seri numarasını giriniz..: ");
            car.SerialNumber = Console.ReadLine();
            Console.WriteLine("\nAraba markasını giriniz..: ");
            car.Brand = Console.ReadLine();
            Console.WriteLine("Araba modelini giriniz..:");
            car.Model = Console.ReadLine();
            Console.WriteLine("Araba rengini giriniz..:");
            car.Color = Console.ReadLine();

            Console.WriteLine("Arabanın kapı sayısını giriniz..:");
        doorsGo:
            try
            {
                car.NumberOfDoors = int.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Geçersiz giriş. Lütfen kapı sayısını giriniz.");
                goto doorsGo;
            }

            return car;
        }
    