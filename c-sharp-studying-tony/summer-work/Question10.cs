using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_studying_tony.summer_work
{
    public class Question10
    {

        public static void Demo()
        {
            Console.WriteLine("Test and Demonstrate Cars Info and cameras ");
            CarInfo carInfo1 = new CarInfo();
            carInfo1.SetSpeed(100);
            //carInfo1.speed = 200;//error since it's private
            carInfo1.SetId("111");
            carInfo1.SetIsPrivate(true);


            CarInfo carInfo2 = new CarInfo();
            carInfo2.SetSpeed(200);
           
            carInfo2.SetId("222");
            carInfo2.SetIsPrivate(false);


            Console.WriteLine("carInfo1 = " + carInfo1  );
            Console.WriteLine("carInfo2 = " + carInfo2);

            CameraInfo cameraInfo1 = new CameraInfo();
            cameraInfo1.SetCity(0);
            cameraInfo1.SetMaxSpeed(100);
            CarInfo[] lingarCars = new CarInfo[2];

            lingarCars[0] = carInfo1;
            lingarCars[1] = carInfo2;

            cameraInfo1.SetCars(lingarCars);

            Console.WriteLine("cameraInfo1 = " + cameraInfo1);
            Console.WriteLine(cameraInfo1.AllGood());

            CameraInfo[] cameras = new CameraInfo[3];

            CameraInfo cameraInfo2 = new CameraInfo();
            cameraInfo2.SetCity(1);
            cameraInfo2.SetMaxSpeed(70);

            CameraInfo cameraInfo3 = new CameraInfo();
            cameraInfo3.SetCity(2);
            cameraInfo3.SetMaxSpeed(130);
            CarInfo[] camera1Cars = new CarInfo[7];
            camera1Cars[0] = carInfo1;
            camera1Cars[1] = carInfo2;

            for (int i = 2; i < 7; i++)
            {
                CarInfo car = new CarInfo();
                car.SetSpeed(50 + (i - 2) * 10);
                car.SetId("ID" + (i + 1));
                car.SetIsPrivate((i - 2) % 2 == 0);
                camera1Cars[i] = car;
            }
            cameraInfo1.SetCars(camera1Cars);

            CarInfo[] camera2Cars = new CarInfo[5];
            for (int i = 0; i < 5; i++)
            {
                CarInfo car = new CarInfo();
                car.SetSpeed(150 + i * 10);
                car.SetId("ID" + (i + 7));
                car.SetIsPrivate(true);
                camera2Cars[i] = car;
            }
            cameraInfo2.SetCars(camera2Cars); 

            CarInfo[] camera3Cars = new CarInfo[5];
            for (int i = 0; i < 5; i++)
            {
                CarInfo car = new CarInfo();
                car.SetSpeed(70 + i * 10);
                car.SetId("ID" + (i + 12));
                car.SetIsPrivate(false);
                camera3Cars[i] = car;
            }
            cameraInfo3.SetCars(camera3Cars);

            Console.WriteLine("cameraInfo1 = " + cameraInfo1);
            Console.WriteLine(cameraInfo1.AllGood());
            Console.WriteLine("cameraInfo2 = " + cameraInfo2);
            Console.WriteLine(cameraInfo2.AllGood());
            Console.WriteLine("cameraInfo3 = " + cameraInfo3);
            Console.WriteLine(cameraInfo3.AllGood());

            CameraInfo[] cameras1 = new CameraInfo[3];
            cameras[0] = cameraInfo1;
            cameras[1] = cameraInfo2;
            cameras[2] = cameraInfo3;

            Console.WriteLine(LegalCities(cameras));
        }

        //ההנחה שיש מצלמות לכל הערים על פי השאלה
        //Question 10 ב-2
        public static int LegalCities(CameraInfo[] cameras)
        {
            int count = 0;
            for (int cityCode = 0; cityCode < 100; cityCode++)
            {
                bool allGood = true;

                for (int j = 0; j < cameras.Length; j++)
                {
                    if (cityCode == cameras[j].GetCity())
                    {
                        if (!cameras[j].AllGood())
                        {
                            allGood = false;
                            break;
                        }
                    }
                }
                if (allGood)
                {
                    count++;
                }

            }
            return count;
        }
    }
    public class CarInfo
    {
        private string id;
        private bool privateCar;
        private int speed;

        public string GetId() { return id; }
        public void SetId(string id) { this.id = id; }

        public bool GetIsPrivate() { return privateCar; }
        public void SetIsPrivate(bool privateCar) { this.privateCar = privateCar; }

        public int GetSpeed() { return speed; }
        public void SetSpeed(int speed) { this.speed = speed; }


        public override string ToString()
        {
            return $"CarInfo:[id = {id}, privateCar= {privateCar}, speed = {speed}]";
        }

        //סעיף א
        public bool Illegal(int maxSpeed)
        {
            return privateCar || speed > maxSpeed;
        }
    }

    public class CameraInfo
    {
        private int city;
        private int maxSpeed;
        private CarInfo[] cars;

        public int GetCity() { return city; }
        public void SetCity(int city) { this.city = city; }

        public int GetMaxSpeed() { return maxSpeed; }
        public void SetMaxSpeed(int maxSpeed) { this.maxSpeed = maxSpeed; }

        public CarInfo[] GetCars() { return cars; }
        public void SetCars(CarInfo[] cars) { this.cars = cars; }

        //ב-1
        public bool AllGood()
        {
            for (int i = 0; i < cars.Length; i++)
            {
                if (cars[i] != null && cars[i].Illegal(maxSpeed))
                {
                    return false;
                }
            }
            return true;
        }

        public override string ToString()
        {
            return $"CameraInfo:[city = {city}, maxSpeed={maxSpeed}, cars = \n{string.Join(",", (object[])cars)}]";

        }

    }
}
